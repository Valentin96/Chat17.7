namespace Modul_Utilizator
{
    partial class Atasament
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
            this.components = new System.ComponentModel.Container();
            this.mButtonChooseFile = new System.Windows.Forms.Button();
            this.mTimer = new System.Windows.Forms.Timer(this.components);
            this.mLabelTextAfisare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mButtonChooseFile
            // 
            this.mButtonChooseFile.Location = new System.Drawing.Point(312, 141);
            this.mButtonChooseFile.Name = "mButtonChooseFile";
            this.mButtonChooseFile.Size = new System.Drawing.Size(110, 23);
            this.mButtonChooseFile.TabIndex = 0;
            this.mButtonChooseFile.Text = "Choose Fille";
            this.mButtonChooseFile.UseVisualStyleBackColor = true;
            this.mButtonChooseFile.Click += new System.EventHandler(this.mButtonChooseFile_Click);
            // 
            // mTimer
            // 
            this.mTimer.Enabled = true;
            this.mTimer.Tick += new System.EventHandler(this.mTimer_Tick);
            // 
            // mLabelTextAfisare
            // 
            this.mLabelTextAfisare.AutoSize = true;
            this.mLabelTextAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelTextAfisare.Location = new System.Drawing.Point(332, 202);
            this.mLabelTextAfisare.Name = "mLabelTextAfisare";
            this.mLabelTextAfisare.Size = new System.Drawing.Size(0, 24);
            this.mLabelTextAfisare.TabIndex = 1;
            // 
            // Atasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mLabelTextAfisare);
            this.Controls.Add(this.mButtonChooseFile);
            this.Name = "Atasament";
            this.Text = "Atasament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mButtonChooseFile;
        private System.Windows.Forms.Timer mTimer;
        private System.Windows.Forms.Label mLabelTextAfisare;
    }
}