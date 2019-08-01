namespace Zeroit.Framework.SnippetEditors
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.baseTheme1 = new Zeroit.Framework.SnippetEditors.BaseTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.overwriteRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.appendRadioBtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveSnippetBtn = new System.Windows.Forms.Button();
            this.copyCode = new System.Windows.Forms.Button();
            this.baseTheme1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme1
            // 
            this.baseTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme1.Colors = new Zeroit.Framework.SnippetEditors.Bloom[0];
            this.baseTheme1.Controls.Add(this.panel1);
            this.baseTheme1.Controls.Add(this.label9);
            this.baseTheme1.Controls.Add(this.button1);
            this.baseTheme1.Controls.Add(this.saveSnippetBtn);
            this.baseTheme1.Controls.Add(this.copyCode);
            this.baseTheme1.Customization = "";
            this.baseTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.baseTheme1.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.mainIcon;
            this.baseTheme1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baseTheme1.ImageSize = new System.Drawing.Size(20, 20);
            this.baseTheme1.Location = new System.Drawing.Point(0, 0);
            this.baseTheme1.Movable = true;
            this.baseTheme1.Name = "baseTheme1";
            this.baseTheme1.NoRounding = false;
            this.baseTheme1.ShowIcon = true;
            this.baseTheme1.ShowText = false;
            this.baseTheme1.Sizable = false;
            this.baseTheme1.Size = new System.Drawing.Size(569, 296);
            this.baseTheme1.SmartBounds = true;
            this.baseTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.baseTheme1.TabIndex = 0;
            this.baseTheme1.Text = "File Already Exists";
            this.baseTheme1.TextAlign = System.Drawing.StringAlignment.Center;
            this.baseTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme1.Transparent = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.overwriteRadioBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.appendRadioBtn);
            this.panel1.Location = new System.Drawing.Point(173, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 37);
            this.panel1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Overwrite";
            // 
            // overwriteRadioBtn
            // 
            this.overwriteRadioBtn.AutoSize = true;
            this.overwriteRadioBtn.Checked = true;
            this.overwriteRadioBtn.Font = new System.Drawing.Font("Verdana", 10F);
            this.overwriteRadioBtn.ForeColor = System.Drawing.Color.White;
            this.overwriteRadioBtn.Location = new System.Drawing.Point(185, 12);
            this.overwriteRadioBtn.Name = "overwriteRadioBtn";
            this.overwriteRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.overwriteRadioBtn.TabIndex = 61;
            this.overwriteRadioBtn.TabStop = true;
            this.overwriteRadioBtn.UseVisualStyleBackColor = true;
            this.overwriteRadioBtn.CheckedChanged += new System.EventHandler(this.overwriteRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Append";
            // 
            // appendRadioBtn
            // 
            this.appendRadioBtn.AutoSize = true;
            this.appendRadioBtn.Font = new System.Drawing.Font("Verdana", 10F);
            this.appendRadioBtn.ForeColor = System.Drawing.Color.White;
            this.appendRadioBtn.Location = new System.Drawing.Point(77, 13);
            this.appendRadioBtn.Name = "appendRadioBtn";
            this.appendRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.appendRadioBtn.TabIndex = 59;
            this.appendRadioBtn.UseVisualStyleBackColor = true;
            this.appendRadioBtn.CheckedChanged += new System.EventHandler(this.appendRadioBtn_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(68, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(436, 68);
            this.label9.TabIndex = 56;
            this.label9.Text = "The File you are trying to create already exist in the location \r\nyou have provid" +
    "ed.\r\n\r\nDo you want to Append or Overwrite file.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(548, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 19);
            this.button1.TabIndex = 55;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveSnippetBtn
            // 
            this.saveSnippetBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.saveSnippetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.saveSnippetBtn.FlatAppearance.BorderSize = 0;
            this.saveSnippetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSnippetBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.saveSnippetBtn.ForeColor = System.Drawing.Color.White;
            this.saveSnippetBtn.Location = new System.Drawing.Point(173, 232);
            this.saveSnippetBtn.Name = "saveSnippetBtn";
            this.saveSnippetBtn.Size = new System.Drawing.Size(102, 34);
            this.saveSnippetBtn.TabIndex = 54;
            this.saveSnippetBtn.Text = "OK";
            this.saveSnippetBtn.UseVisualStyleBackColor = false;
            this.saveSnippetBtn.Click += new System.EventHandler(this.saveSnippetBtn_Click);
            // 
            // copyCode
            // 
            this.copyCode.BackColor = System.Drawing.Color.Red;
            this.copyCode.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.copyCode.FlatAppearance.BorderSize = 0;
            this.copyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.copyCode.ForeColor = System.Drawing.Color.White;
            this.copyCode.Location = new System.Drawing.Point(281, 232);
            this.copyCode.Name = "copyCode";
            this.copyCode.Size = new System.Drawing.Size(102, 34);
            this.copyCode.TabIndex = 53;
            this.copyCode.Text = "Cancel";
            this.copyCode.UseVisualStyleBackColor = false;
            this.copyCode.Click += new System.EventHandler(this.copyCode_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 296);
            this.Controls.Add(this.baseTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageBox";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme1.ResumeLayout(false);
            this.baseTheme1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme1;
        private System.Windows.Forms.Button saveSnippetBtn;
        private System.Windows.Forms.Button copyCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton overwriteRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton appendRadioBtn;
    }
}