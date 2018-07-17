namespace Modul_Utilizator
{
    partial class ServerAtasament
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
            this.mLabelInfo = new System.Windows.Forms.Label();
            this.mButtonReceiveFille = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // mLabelInfo
            // 
            this.mLabelInfo.AutoSize = true;
            this.mLabelInfo.Location = new System.Drawing.Point(333, 212);
            this.mLabelInfo.Name = "mLabelInfo";
            this.mLabelInfo.Size = new System.Drawing.Size(0, 17);
            this.mLabelInfo.TabIndex = 0;
            // 
            // mButtonReceiveFille
            // 
            this.mButtonReceiveFille.Location = new System.Drawing.Point(336, 118);
            this.mButtonReceiveFille.Name = "mButtonReceiveFille";
            this.mButtonReceiveFille.Size = new System.Drawing.Size(178, 23);
            this.mButtonReceiveFille.TabIndex = 1;
            this.mButtonReceiveFille.Text = "ReceiveFille";
            this.mButtonReceiveFille.UseVisualStyleBackColor = true;
            this.mButtonReceiveFille.Click += new System.EventHandler(this.mButtonReceiveFille_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ServerAtasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mButtonReceiveFille);
            this.Controls.Add(this.mLabelInfo);
            this.Name = "ServerAtasament";
            this.Text = "ServerAtasament";
            this.Load += new System.EventHandler(this.ServerAtasament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLabelInfo;
        private System.Windows.Forms.Button mButtonReceiveFille;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}