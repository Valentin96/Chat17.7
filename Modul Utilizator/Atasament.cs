using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_Utilizator
{
    public partial class Atasament : Form
    {
        public Atasament()
        {
            InitializeComponent();
            
        }

        private void mButtonChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Client.SendFile(fd.FileName);
            }
        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            mLabelTextAfisare.Text = Client.MesajCurrent.Trim();
        }
    }
}
