using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

class Person1
{
    public static byte[] Person1PublicKey;

    static void Main(string[] args)
    {
        Write("Enter some text you want to encrypt and send somebody: ");
        string message = ReadLine();

        using (ECDiffieHellmanCng ecd = new ECDiffieHellmanCng())
        {
            ecd.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
            ecd.HashAlgorithm = CngAlgorithm.Sha256;
            Person1PublicKey = ecd.PublicKey.ToByteArray();

            Person2 person2 = new Person2();

            CngKey k = CngKey.Import(person2.Person2PublicKey, CngKeyBlobFormat.EccPublicBlob);
            byte[] senderKey = ecd.DeriveKeyMaterial(CngKey.Import(person2.Person2PublicKey, CngKeyBlobFormat.EccPublicBlob));
            Send(senderKey, message, out byte[] encryptedMessage, out byte[] IV);
            person2.Receive(encryptedMessage, IV);

        }
    }

    public static void Send(byte[] key, string secretMessage, out byte[] encryptedMessage, out byte[] IV)
    {
        WriteLine(Environment.NewLine + Environment.NewLine + "Sending the message...");

        using (Aes aes = new AesCryptoServiceProvider())
        {
            aes.Key = key;
            IV = aes.IV;

            // Encrypt the message
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                byte[] plainTextMessage = Encoding.UTF8.GetBytes(secretMessage);
                cs.Write(plainTextMessage, 0, plainTextMessage.Length);
                cs.Close();
                encryptedMessage = ms.ToArray();

            }
        }
    }
}

public class Person2
{
    public byte[] Person2PublicKey;
    private byte[] Key;

    public Person2()
    {
        using (ECDiffieHellmanCng ecd = new ECDiffieHellmanCng())
        {
            ecd.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
            ecd.HashAlgorithm = CngAlgorithm.Sha256;
            Person2PublicKey = ecd.PublicKey.ToByteArray();
            Key = ecd.DeriveKeyMaterial(CngKey.Import(Person1.Person1PublicKey, CngKeyBlobFormat.EccPublicBlob));

        }

        WriteLine(Environment.NewLine + "Encrypted the message: " + Environment.NewLine);

        foreach (byte b in Key)
        {
            Write($"{b}, ");

        }

    }

    public void Receive(byte[] encryptedMessage, byte[] IV)
    {
        WriteLine("Receiving the message...");

        using (Aes aes = new AesCryptoServiceProvider())
        {
            aes.Key = Key;
            aes.IV = IV;

            // Decrypt and show the message
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptedMessage, 0, encryptedMessage.Length);
                    cs.Close();

                    string message = Encoding.UTF8.GetString(ms.ToArray());
                    WriteLine(Environment.NewLine);
                    WriteLine("Decrypted the message: ");
                    WriteLine(Environment.NewLine + message + Environment.NewLine);

                }
            }

            WriteLine(Environment.NewLine + "Press any key to continue...");
            ReadKey();

        }
    }
}