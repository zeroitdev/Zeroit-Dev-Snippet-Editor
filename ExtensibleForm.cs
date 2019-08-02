// ***********************************************************************
// Assembly         : Zeroit Dev Snippet Editor
// Author           : ZEROIT
// Created          : 06-21-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="ExtensibleForm.cs" company="Zeroit Dev Technologies">
//     Copyright © 2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.SnippetEditors
{
    public class ExtensibleForm : Form
    {
        Color border = Color.Blue;
        public Color Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawRectangle(new Pen(Border), new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1));
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensibleForm));
            this.SuspendLayout();
            // 
            // ExtensibleForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtensibleForm";
            this.ResumeLayout(false);

        }
    }
}
