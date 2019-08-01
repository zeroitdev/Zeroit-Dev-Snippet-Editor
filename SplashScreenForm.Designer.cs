namespace Zeroit.Framework.SnippetEditors
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.zeroitFormHandle1 = new Zeroit.Framework.SnippetEditors.Helpers.ZeroitFormHandle();
            this.progressBar = new Zeroit.Framework.SnippetEditors.Helpers.ZeroitFlatProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zeroitFormHandle1
            // 
            this.zeroitFormHandle1.DockAtTop = true;
            this.zeroitFormHandle1.HandleControl = this;
            // 
            // progressBar
            // 
            this.progressBar.BarStyle = Zeroit.Framework.SnippetEditors.Helpers.ZeroitFlatProgressBar.Style.Material;
            this.progressBar.BarThickness = 5;
            this.progressBar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.progressBar.InocmpletedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.progressBar.Location = new System.Drawing.Point(12, 203);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(363, 10);
            this.progressBar.TabIndex = 0;
            this.progressBar.Text = "zeroitFlatProgressBar1";
            this.progressBar.Value = 0F;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZEROIT DEV SNIPPET EDITOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Just Save It...";
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Border = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(384, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SplashScreenForm_FormClosed);
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Helpers.ZeroitFormHandle zeroitFormHandle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Helpers.ZeroitFlatProgressBar progressBar;
    }
}