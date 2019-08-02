// ***********************************************************************
// Assembly         : Zeroit Dev Snippet Editor
// Author           : ZEROIT
// Created          : 06-23-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-01-2019
// ***********************************************************************
// <copyright file="CustomMessageWarnAppend.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © 2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace Zeroit.Framework.SnippetEditors
{
    partial class CustomMessageWarnAppend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageWarnAppend));
            this.baseTheme1 = new Zeroit.Framework.SnippetEditors.BaseTheme();
            this.messageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveSnippetBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.baseTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme1
            // 
            this.baseTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme1.Colors = new Zeroit.Framework.SnippetEditors.Bloom[0];
            this.baseTheme1.Controls.Add(this.messageLabel);
            this.baseTheme1.Controls.Add(this.button1);
            this.baseTheme1.Controls.Add(this.saveSnippetBtn);
            this.baseTheme1.Controls.Add(this.cancelBtn);
            this.baseTheme1.Customization = "";
            this.baseTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTheme1.Font = new System.Drawing.Font("Verdana", 10F);
            this.baseTheme1.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.mainIcon;
            this.baseTheme1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baseTheme1.ImageSize = new System.Drawing.Size(20, 20);
            this.baseTheme1.Location = new System.Drawing.Point(0, 0);
            this.baseTheme1.Movable = true;
            this.baseTheme1.Name = "baseTheme1";
            this.baseTheme1.NoRounding = false;
            this.baseTheme1.ShowIcon = false;
            this.baseTheme1.ShowText = false;
            this.baseTheme1.Sizable = false;
            this.baseTheme1.Size = new System.Drawing.Size(533, 145);
            this.baseTheme1.SmartBounds = true;
            this.baseTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.baseTheme1.TabIndex = 0;
            this.baseTheme1.Text = "Warning !!!";
            this.baseTheme1.TextAlign = System.Drawing.StringAlignment.Center;
            this.baseTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme1.Transparent = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(49, 38);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(417, 17);
            this.messageLabel.TabIndex = 56;
            this.messageLabel.Text = "Do you want to append the text to the main snippet file ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(511, 1);
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
            this.saveSnippetBtn.Location = new System.Drawing.Point(155, 87);
            this.saveSnippetBtn.Name = "saveSnippetBtn";
            this.saveSnippetBtn.Size = new System.Drawing.Size(102, 34);
            this.saveSnippetBtn.TabIndex = 54;
            this.saveSnippetBtn.Text = "Yes";
            this.saveSnippetBtn.UseVisualStyleBackColor = false;
            this.saveSnippetBtn.Click += new System.EventHandler(this.saveSnippetBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(263, 87);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 34);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.Text = "No";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.copyCode_Click);
            // 
            // CustomMessageWarnAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 145);
            this.Controls.Add(this.baseTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageWarnAppend";
            this.Text = "CustomMessageBox";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme1.ResumeLayout(false);
            this.baseTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label messageLabel;
        public System.Windows.Forms.Button saveSnippetBtn;
        public System.Windows.Forms.Button cancelBtn;
    }
}