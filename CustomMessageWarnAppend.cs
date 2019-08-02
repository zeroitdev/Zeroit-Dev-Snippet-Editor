// ***********************************************************************
// Assembly         : Zeroit Dev Snippet Editor
// Author           : ZEROIT
// Created          : 06-23-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="CustomMessageWarnAppend.cs" company="Zeroit Dev Technologies">
//     Copyright © 2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.SnippetEditors
{
    public partial class CustomMessageWarnAppend : Form
    {
        public string Header
        {
            get { return baseTheme1.Text; }
            set
            {
                baseTheme1.Text = value;
                Invalidate();
            }
        }
        public string Message
        {
            get { return messageLabel.Text; }
            set
            {
                messageLabel.Text = value;
                Invalidate();
            }
        }

        public CustomMessageWarnAppend()
        {
            InitializeComponent();

            Rectangle screenArea = Screen.PrimaryScreen.Bounds;
            this.Location = new Point((screenArea.Width / 2) - (this.Width / 2), (screenArea.Height / 2) - (this.Height / 2));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSnippetBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void copyCode_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
