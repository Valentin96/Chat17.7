namespace Chat
{
    partial class ResetPassword
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
            this.mTextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.mLabelPhoneNumber = new System.Windows.Forms.Label();
            this.mTextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.mTextBoxNewPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.mButtonConfirmation = new System.Windows.Forms.Button();
            this.mLabelNewPassword = new System.Windows.Forms.Label();
            this.mLabelConfirmNewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mTextBoxPhoneNumber
            // 
            this.mTextBoxPhoneNumber.Location = new System.Drawing.Point(497, 158);
            this.mTextBoxPhoneNumber.Name = "mTextBoxPhoneNumber";
            this.mTextBoxPhoneNumber.Size = new System.Drawing.Size(227, 22);
            this.mTextBoxPhoneNumber.TabIndex = 0;
            this.mTextBoxPhoneNumber.TextChanged += new System.EventHandler(this.mTextBoxPhoneNumber_TextChanged);
            // 
            // mLabelPhoneNumber
            // 
            this.mLabelPhoneNumber.AutoSize = true;
            this.mLabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelPhoneNumber.Location = new System.Drawing.Point(151, 151);
            this.mLabelPhoneNumber.Name = "mLabelPhoneNumber";
            this.mLabelPhoneNumber.Size = new System.Drawing.Size(274, 29);
            this.mLabelPhoneNumber.TabIndex = 1;
            this.mLabelPhoneNumber.Text = "Scrie numarul de telefon";
            // 
            // mTextBoxNewPassword
            // 
            this.mTextBoxNewPassword.Location = new System.Drawing.Point(497, 254);
            this.mTextBoxNewPassword.Name = "mTextBoxNewPassword";
            this.mTextBoxNewPassword.Size = new System.Drawing.Size(227, 22);
            this.mTextBoxNewPassword.TabIndex = 2;
            this.mTextBoxNewPassword.TextChanged += new System.EventHandler(this.mTextBoxNewPassword_TextChanged);
            // 
            // mTextBoxNewPasswordConfirmation
            // 
            this.mTextBoxNewPasswordConfirmation.Location = new System.Drawing.Point(497, 343);
            this.mTextBoxNewPasswordConfirmation.Name = "mTextBoxNewPasswordConfirmation";
            this.mTextBoxNewPasswordConfirmation.Size = new System.Drawing.Size(227, 22);
            this.mTextBoxNewPasswordConfirmation.TabIndex = 3;
            this.mTextBoxNewPasswordConfirmation.TextChanged += new System.EventHandler(this.mTextBoxNewPasswordConfirmation_TextChanged);
            // 
            // mButtonConfirmation
            // 
            this.mButtonConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButtonConfirmation.Location = new System.Drawing.Point(529, 444);
            this.mButtonConfirmation.Name = "mButtonConfirmation";
            this.mButtonConfirmation.Size = new System.Drawing.Size(159, 37);
            this.mButtonConfirmation.TabIndex = 4;
            this.mButtonConfirmation.Text = "Confirma";
            this.mButtonConfirmation.UseVisualStyleBackColor = true;
            this.mButtonConfirmation.Click += new System.EventHandler(this.mButtonConfirmation_Click);
            // 
            // mLabelNewPassword
            // 
            this.mLabelNewPassword.AutoSize = true;
            this.mLabelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelNewPassword.Location = new System.Drawing.Point(151, 254);
            this.mLabelNewPassword.Name = "mLabelNewPassword";
            this.mLabelNewPassword.Size = new System.Drawing.Size(227, 29);
            this.mLabelNewPassword.TabIndex = 5;
            this.mLabelNewPassword.Text = "Scrie noua ta parola";
            // 
            // mLabelConfirmNewPassword
            // 
            this.mLabelConfirmNewPassword.AutoSize = true;
            this.mLabelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelConfirmNewPassword.Location = new System.Drawing.Point(151, 343);
            this.mLabelConfirmNewPassword.Name = "mLabelConfirmNewPassword";
            this.mLabelConfirmNewPassword.Size = new System.Drawing.Size(268, 29);
            this.mLabelConfirmNewPassword.TabIndex = 6;
            this.mLabelConfirmNewPassword.Text = "Confirma noua ta parola";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 731);
            this.Controls.Add(this.mLabelConfirmNewPassword);
            this.Controls.Add(this.mLabelNewPassword);
            this.Controls.Add(this.mButtonConfirmation);
            this.Controls.Add(this.mTextBoxNewPasswordConfirmation);
            this.Controls.Add(this.mTextBoxNewPassword);
            this.Controls.Add(this.mLabelPhoneNumber);
            this.Controls.Add(this.mTextBoxPhoneNumber);
            this.Name = "ResetPassword";
            this.Text = "Confirma noua ta parola";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mTextBoxPhoneNumber;
        private System.Windows.Forms.Label mLabelPhoneNumber;
        private System.Windows.Forms.TextBox mTextBoxNewPassword;
        private System.Windows.Forms.TextBox mTextBoxNewPasswordConfirmation;
        private System.Windows.Forms.Button mButtonConfirmation;
        private System.Windows.Forms.Label mLabelNewPassword;
        private System.Windows.Forms.Label mLabelConfirmNewPassword;
    }
}

