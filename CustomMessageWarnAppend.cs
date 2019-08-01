using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
