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
    public partial class CustomMessageBox : Form
    {
        public enum Operation
        {
            Append,
            Overwrite
        }

        private Operation operation = Operation.Append;

        public Operation WriteMethod
        {
            get { return operation; }
            set
            {
                operation = value;
                Invalidate();
            }
        }

        public CustomMessageBox()
        {
            InitializeComponent();

            if (overwriteRadioBtn.Checked)
            {
                WriteMethod = Operation.Overwrite;
            }
            else
            {
                WriteMethod = Operation.Append;
            }
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

        private void appendRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(appendRadioBtn.Checked)
            {
                WriteMethod = Operation.Append;
            }
        }

        private void overwriteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (overwriteRadioBtn.Checked)
            {
                WriteMethod = Operation.Overwrite;
            }
        }
    }
}
