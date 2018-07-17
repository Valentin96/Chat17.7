namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mLoginButton = new System.Windows.Forms.Button();
            this.mExitButton = new System.Windows.Forms.Button();
            this.mUserNameLabel = new System.Windows.Forms.Label();
            this.mPasswordLabel = new System.Windows.Forms.Label();
            this.mUserNameTextBox = new System.Windows.Forms.TextBox();
            this.mPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.mTextBoxPhoneNumberSignUp = new System.Windows.Forms.TextBox();
            this.mLabelPhoneNumberSignUp = new System.Windows.Forms.Label();
            this.mButtonSignUp = new System.Windows.Forms.Button();
            this.mConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.mConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.mPasswordTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.mUserNameTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.mUserNameLabel_Click = new System.Windows.Forms.Label();
            this.mPasswordLabelLogin_Click = new System.Windows.Forms.Label();
            this.mSignUpLabel = new System.Windows.Forms.Label();
            this.mButtonResetPassword = new System.Windows.Forms.Button();
            this.panelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLoginButton
            // 
            this.mLoginButton.Location = new System.Drawing.Point(233, 307);
            this.mLoginButton.Name = "mLoginButton";
            this.mLoginButton.Size = new System.Drawing.Size(128, 68);
            this.mLoginButton.TabIndex = 0;
            this.mLoginButton.Text = "LOGIN";
            this.mLoginButton.UseVisualStyleBackColor = true;
            this.mLoginButton.Click += new System.EventHandler(this.mLoginButton_Click);
            // 
            // mExitButton
            // 
            this.mExitButton.Location = new System.Drawing.Point(530, 307);
            this.mExitButton.Name = "mExitButton";
            this.mExitButton.Size = new System.Drawing.Size(130, 69);
            this.mExitButton.TabIndex = 1;
            this.mExitButton.Text = "EXIT";
            this.mExitButton.UseVisualStyleBackColor = true;
            this.mExitButton.Click += new System.EventHandler(this.mExitButton_Click);
            // 
            // mUserNameLabel
            // 
            this.mUserNameLabel.AutoSize = true;
            this.mUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserNameLabel.Location = new System.Drawing.Point(218, 79);
            this.mUserNameLabel.Name = "mUserNameLabel";
            this.mUserNameLabel.Size = new System.Drawing.Size(157, 32);
            this.mUserNameLabel.TabIndex = 2;
            this.mUserNameLabel.Text = "UserName";
            this.mUserNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mPasswordLabel
            // 
            this.mPasswordLabel.AutoSize = true;
            this.mPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPasswordLabel.Location = new System.Drawing.Point(218, 190);
            this.mPasswordLabel.Name = "mPasswordLabel";
            this.mPasswordLabel.Size = new System.Drawing.Size(147, 32);
            this.mPasswordLabel.TabIndex = 3;
            this.mPasswordLabel.Text = "Password";
            this.mPasswordLabel.Click += new System.EventHandler(this.mPasswordLabel_Click);
            // 
            // mUserNameTextBox
            // 
            this.mUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserNameTextBox.Location = new System.Drawing.Point(530, 88);
            this.mUserNameTextBox.Name = "mUserNameTextBox";
            this.mUserNameTextBox.Size = new System.Drawing.Size(144, 34);
            this.mUserNameTextBox.TabIndex = 4;
            this.mUserNameTextBox.TextChanged += new System.EventHandler(this.mUserNameTextBox_TextChanged);
            // 
            // mPasswordTextBox
            // 
            this.mPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPasswordTextBox.Location = new System.Drawing.Point(530, 200);
            this.mPasswordTextBox.Name = "mPasswordTextBox";
            this.mPasswordTextBox.PasswordChar = '*';
            this.mPasswordTextBox.Size = new System.Drawing.Size(144, 38);
            this.mPasswordTextBox.TabIndex = 5;
            this.mPasswordTextBox.TextChanged += new System.EventHandler(this.mPasswordTextBox_TextChanged);
            // 
            // panelSignUp
            // 
            this.panelSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelSignUp.Controls.Add(this.mTextBoxPhoneNumberSignUp);
            this.panelSignUp.Controls.Add(this.mLabelPhoneNumberSignUp);
            this.panelSignUp.Controls.Add(this.mButtonSignUp);
            this.panelSignUp.Controls.Add(this.mConfirmPasswordLabel);
            this.panelSignUp.Controls.Add(this.mConfirmPasswordTextBox);
            this.panelSignUp.Controls.Add(this.mPasswordTextBoxSignUp);
            this.panelSignUp.Controls.Add(this.mUserNameTextBoxSignUp);
            this.panelSignUp.Controls.Add(this.mUserNameLabel_Click);
            this.panelSignUp.Controls.Add(this.mPasswordLabelLogin_Click);
            this.panelSignUp.Controls.Add(this.mSignUpLabel);
            this.panelSignUp.Location = new System.Drawing.Point(12, 79);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(200, 324);
            this.panelSignUp.TabIndex = 6;
            this.panelSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignUp_Paint);
            // 
            // mTextBoxPhoneNumberSignUp
            // 
            this.mTextBoxPhoneNumberSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxPhoneNumberSignUp.Location = new System.Drawing.Point(20, 249);
            this.mTextBoxPhoneNumberSignUp.Name = "mTextBoxPhoneNumberSignUp";
            this.mTextBoxPhoneNumberSignUp.Size = new System.Drawing.Size(138, 22);
            this.mTextBoxPhoneNumberSignUp.TabIndex = 9;
            this.mTextBoxPhoneNumberSignUp.TextChanged += new System.EventHandler(this.mTextBoxPhoneNumberSignUp_TextChanged);
            // 
            // mLabelPhoneNumberSignUp
            // 
            this.mLabelPhoneNumberSignUp.AutoSize = true;
            this.mLabelPhoneNumberSignUp.Location = new System.Drawing.Point(17, 228);
            this.mLabelPhoneNumberSignUp.Name = "mLabelPhoneNumberSignUp";
            this.mLabelPhoneNumberSignUp.Size = new System.Drawing.Size(103, 17);
            this.mLabelPhoneNumberSignUp.TabIndex = 8;
            this.mLabelPhoneNumberSignUp.Text = "Phone Number";
            // 
            // mButtonSignUp
            // 
            this.mButtonSignUp.Location = new System.Drawing.Point(36, 289);
            this.mButtonSignUp.Name = "mButtonSignUp";
            this.mButtonSignUp.Size = new System.Drawing.Size(107, 32);
            this.mButtonSignUp.TabIndex = 7;
            this.mButtonSignUp.Text = "SignUp";
            this.mButtonSignUp.UseVisualStyleBackColor = true;
            this.mButtonSignUp.Click += new System.EventHandler(this.mButtonSignUp_Click);
            // 
            // mConfirmPasswordLabel
            // 
            this.mConfirmPasswordLabel.AutoSize = true;
            this.mConfirmPasswordLabel.Location = new System.Drawing.Point(17, 167);
            this.mConfirmPasswordLabel.Name = "mConfirmPasswordLabel";
            this.mConfirmPasswordLabel.Size = new System.Drawing.Size(117, 17);
            this.mConfirmPasswordLabel.TabIndex = 6;
            this.mConfirmPasswordLabel.Text = "ConfirmPassword";
            this.mConfirmPasswordLabel.Click += new System.EventHandler(this.mConfirmPasswordLabel_Click);
            // 
            // mConfirmPasswordTextBox
            // 
            this.mConfirmPasswordTextBox.Location = new System.Drawing.Point(20, 187);
            this.mConfirmPasswordTextBox.Name = "mConfirmPasswordTextBox";
            this.mConfirmPasswordTextBox.PasswordChar = '*';
            this.mConfirmPasswordTextBox.Size = new System.Drawing.Size(138, 22);
            this.mConfirmPasswordTextBox.TabIndex = 5;
            this.mConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.mConfirmPasswordTextBox_TextChanged);
            // 
            // mPasswordTextBoxSignUp
            // 
            this.mPasswordTextBoxSignUp.Location = new System.Drawing.Point(20, 131);
            this.mPasswordTextBoxSignUp.Name = "mPasswordTextBoxSignUp";
            this.mPasswordTextBoxSignUp.PasswordChar = '*';
            this.mPasswordTextBoxSignUp.Size = new System.Drawing.Size(138, 22);
            this.mPasswordTextBoxSignUp.TabIndex = 4;
            this.mPasswordTextBoxSignUp.TextChanged += new System.EventHandler(this.mPasswordTextBoxSignUp_TextChanged);
            // 
            // mUserNameTextBoxSignUp
            // 
            this.mUserNameTextBoxSignUp.Location = new System.Drawing.Point(20, 75);
            this.mUserNameTextBoxSignUp.Name = "mUserNameTextBoxSignUp";
            this.mUserNameTextBoxSignUp.Size = new System.Drawing.Size(138, 22);
            this.mUserNameTextBoxSignUp.TabIndex = 3;
            this.mUserNameTextBoxSignUp.TextChanged += new System.EventHandler(this.mUserNameTextBoxSignUp_TextChanged);
            // 
            // mUserNameLabel_Click
            // 
            this.mUserNameLabel_Click.AutoSize = true;
            this.mUserNameLabel_Click.Location = new System.Drawing.Point(17, 55);
            this.mUserNameLabel_Click.Name = "mUserNameLabel_Click";
            this.mUserNameLabel_Click.Size = new System.Drawing.Size(75, 17);
            this.mUserNameLabel_Click.TabIndex = 2;
            this.mUserNameLabel_Click.Text = "UserName";
            this.mUserNameLabel_Click.Click += new System.EventHandler(this.mUserNameLabel_Click_Click);
            // 
            // mPasswordLabelLogin_Click
            // 
            this.mPasswordLabelLogin_Click.AutoSize = true;
            this.mPasswordLabelLogin_Click.Location = new System.Drawing.Point(17, 111);
            this.mPasswordLabelLogin_Click.Name = "mPasswordLabelLogin_Click";
            this.mPasswordLabelLogin_Click.Size = new System.Drawing.Size(69, 17);
            this.mPasswordLabelLogin_Click.TabIndex = 1;
            this.mPasswordLabelLogin_Click.Text = "Password";
            this.mPasswordLabelLogin_Click.Click += new System.EventHandler(this.mPasswordLabelLogin_Click_Click);
            // 
            // mSignUpLabel
            // 
            this.mSignUpLabel.AutoSize = true;
            this.mSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSignUpLabel.Location = new System.Drawing.Point(3, 0);
            this.mSignUpLabel.Name = "mSignUpLabel";
            this.mSignUpLabel.Size = new System.Drawing.Size(99, 29);
            this.mSignUpLabel.TabIndex = 0;
            this.mSignUpLabel.Text = "SignUp";
            this.mSignUpLabel.Click += new System.EventHandler(this.mSignUpLabel_Click);
            // 
            // mButtonResetPassword
            // 
            this.mButtonResetPassword.Location = new System.Drawing.Point(530, 257);
            this.mButtonResetPassword.Name = "mButtonResetPassword";
            this.mButtonResetPassword.Size = new System.Drawing.Size(130, 31);
            this.mButtonResetPassword.TabIndex = 7;
            this.mButtonResetPassword.Text = "ResetPassword";
            this.mButtonResetPassword.UseVisualStyleBackColor = true;
            this.mButtonResetPassword.Click += new System.EventHandler(this.mButtonResetPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mButtonResetPassword);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.mPasswordTextBox);
            this.Controls.Add(this.mUserNameTextBox);
            this.Controls.Add(this.mPasswordLabel);
            this.Controls.Add(this.mUserNameLabel);
            this.Controls.Add(this.mExitButton);
            this.Controls.Add(this.mLoginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mLoginButton;
        private System.Windows.Forms.Button mExitButton;
        private System.Windows.Forms.Label mUserNameLabel;
        private System.Windows.Forms.Label mPasswordLabel;
        private System.Windows.Forms.TextBox mUserNameTextBox;
        private System.Windows.Forms.TextBox mPasswordTextBox;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.Label mUserNameLabel_Click;
        private System.Windows.Forms.Label mPasswordLabelLogin_Click;
        private System.Windows.Forms.Label mSignUpLabel;
        private System.Windows.Forms.TextBox mPasswordTextBoxSignUp;
        private System.Windows.Forms.TextBox mUserNameTextBoxSignUp;
        private System.Windows.Forms.Label mConfirmPasswordLabel;
        private System.Windows.Forms.TextBox mConfirmPasswordTextBox;
        private System.Windows.Forms.Button mButtonSignUp;
        private System.Windows.Forms.Button mButtonResetPassword;
        private System.Windows.Forms.TextBox mTextBoxPhoneNumberSignUp;
        private System.Windows.Forms.Label mLabelPhoneNumberSignUp;
    }
}

