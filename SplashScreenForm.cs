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
    public partial class SplashScreenForm : ExtensibleForm
    {

        public Form Form
        {
            get;
            set;
        }

        public SplashScreenForm()
        {
            InitializeComponent();

            #region MyRegion
            if (DesignMode)
            {
                timer.Tick += Timer_Tick;
                if (AutoAnimate)
                {
                    timer.Interval = 20;
                    timer.Start();
                }
            }

            if (!DesignMode)
            {
                timer.Tick += Timer_Tick;

                if (AutoAnimate)
                {
                    timer.Interval = 20;
                    timer.Start();
                }
            }



            #endregion
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {

            

        }
        
        #region Include in Private Field


        private bool autoAnimate = true;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                if (value == true)
                {
                    timer.Enabled = true;
                }

                else
                {
                    timer.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Event

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value + 1 >= progressBar.MaxValue)
            {
                progressBar.Value = 0;
                this.Close();
                Form.Opacity = 1;
            }

            else
            {
                progressBar.Value++;
                Invalidate();
            }
        }

        #endregion
        

        private void SplashScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
        }
        

    }
}
