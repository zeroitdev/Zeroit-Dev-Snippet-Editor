// ***********************************************************************
// Assembly         : Zeroit.Framework.Component
// Author           : ZEROIT
// Created          : 11-23-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-23-2018
// ***********************************************************************
// <copyright file="SplashScreen.cs" company="Zeroit Dev Technologies">
//    This program is program that contains helping components.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.SnippetEditors.Helpers;

namespace Zeroit.Framework.Components
{
    /// <summary>
    /// Class ZeroitSplashScreen.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitSplashScreen : Component
	{
        /// <summary>
        /// The allow dragging
        /// </summary>
        private bool allowDragging = true;

        /// <summary>
        /// The show progress bar
        /// </summary>
        private bool showProgressBar = true;

        /// <summary>
        /// The is ellipse
        /// </summary>
        private bool isEllipse = false;

        /// <summary>
        /// The ellipse corner radius
        /// </summary>
        private int ellipseCornerRadius = 10;

        /// <summary>
        /// The progress bar style
        /// </summary>
        private ZeroitFlatProgressBar.Style progressBarStyle = ZeroitFlatProgressBar.Style.Material;

        /// <summary>
        /// The loaded color
        /// </summary>
        private Color loadedColor = Color.DodgerBlue;

        /// <summary>
        /// The unloaded color
        /// </summary>
        private Color unloadedColor = Color.FromArgb(30, 30, 30);

        /// <summary>
        /// The seconds displayed
        /// </summary>
        private int secondsDisplayed = 3000;

        /// <summary>
        /// The back color
        /// </summary>
        private Color backColor = Color.FromArgb(30, 30, 30);

        /// <summary>
        /// The splash size
        /// </summary>
        private Size splashSize = new Size(450, 280);

        /// <summary>
        /// The top text color
        /// </summary>
        private Color topTextColor = Color.White;

        /// <summary>
        /// The top text
        /// </summary>
        private string topText = "VisualStudio";

        /// <summary>
        /// The top text size
        /// </summary>
        private int topTextSize = 36;

        /// <summary>
        /// The bottom text color
        /// </summary>
        private Color bottomTextColor = Color.White;

        /// <summary>
        /// The bottom text
        /// </summary>
        private string bottomText = "Community edition";

        /// <summary>
        /// The bottom text size
        /// </summary>
        private int bottomTextSize = 16;

        /// <summary>
        /// The splash form
        /// </summary>
        private Form splashForm = new Form();

        /// <summary>
        /// The progress bar
        /// </summary>
        private ZeroitFlatProgressBar progressBar = new ZeroitFlatProgressBar();

        /// <summary>
        /// The update progress
        /// </summary>
        private Timer updateProgress = new Timer();

        /// <summary>
        /// The background
        /// </summary>
        private Panel background = new Panel();

        /// <summary>
        /// The text1
        /// </summary>
        private Label text1 = new Label();

        /// <summary>
        /// The handle
        /// </summary>
        private ZeroitFormHandle handle = new ZeroitFormHandle();

        /// <summary>
        /// The handle2
        /// </summary>
        private ZeroitFormHandle handle2 = new ZeroitFormHandle();

        /// <summary>
        /// The handle3
        /// </summary>
        private ZeroitFormHandle handle3 = new ZeroitFormHandle();

        /// <summary>
        /// The handle4
        /// </summary>
        private ZeroitFormHandle handle4 = new ZeroitFormHandle();

        /// <summary>
        /// The ellipse
        /// </summary>
        private ZeroitObjectEllipse ellipse = new ZeroitObjectEllipse();

        /// <summary>
        /// The text2
        /// </summary>
        private Label text2 = new Label();

        /// <summary>
        /// The base form
        /// </summary>
        private Control baseForm;

        /// <summary>
        /// Gets or sets a value indicating whether [allow dragging].
        /// </summary>
        /// <value><c>true</c> if [allow dragging]; otherwise, <c>false</c>.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("Allow dragging the splash")]
		public bool AllowDragging
		{
			get
			{
				return this.allowDragging;
			}
			set
			{
				this.allowDragging = value;
			}
		}

        /// <summary>
        /// Gets or sets the color of the back.
        /// </summary>
        /// <value>The color of the back.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The splash BckColor")]
		public Color BackColor
		{
			get
			{
				return this.backColor;
			}
			set
			{
				this.backColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the bottom text.
        /// </summary>
        /// <value>The bottom text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The bottom text")]
		public string BottomText
		{
			get
			{
				return this.bottomText;
			}
			set
			{
				this.bottomText = value;
			}
		}

        /// <summary>
        /// Gets or sets the color of the bottom text.
        /// </summary>
        /// <value>The color of the bottom text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The bottom text color")]
		public Color BottomTextColor
		{
			get
			{
				return this.bottomTextColor;
			}
			set
			{
				this.bottomTextColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the size of the bottom text.
        /// </summary>
        /// <value>The size of the bottom text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The bottom text size")]
		public int BottomTextSize
		{
			get
			{
				return this.bottomTextSize;
			}
			set
			{
				this.bottomTextSize = value;
			}
		}

        /// <summary>
        /// Gets or sets the ellipse corner radius.
        /// </summary>
        /// <value>The ellipse corner radius.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The corner radius if ellipse")]
		public int EllipseCornerRadius
		{
			get
			{
				return this.ellipseCornerRadius;
			}
			set
			{
				this.ellipseCornerRadius = value;
			}
		}

        /// <summary>
        /// Gets or sets a value indicating whether this instance is ellipse.
        /// </summary>
        /// <value><c>true</c> if this instance is ellipse; otherwise, <c>false</c>.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("Is the splash elliptical")]
		public bool IsEllipse
		{
			get
			{
				return this.isEllipse;
			}
			set
			{
				this.isEllipse = value;
			}
		}

        /// <summary>
        /// Gets or sets the color of the loaded.
        /// </summary>
        /// <value>The color of the loaded.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The progressbar loaded color")]
		public Color LoadedColor
		{
			get
			{
				return this.loadedColor;
			}
			set
			{
				this.loadedColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the progress bar style.
        /// </summary>
        /// <value>The progress bar style.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("Progressbar style")]
		public ZeroitFlatProgressBar.Style ProgressBarStyle
		{
			get
			{
				return this.progressBarStyle;
			}
			set
			{
				this.progressBarStyle = value;
			}
		}

        /// <summary>
        /// Gets or sets the seconds displayed.
        /// </summary>
        /// <value>The seconds displayed.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("Amount of seconds splash is displayed for in milliseconds")]
		public int SecondsDisplayed
		{
			get
			{
				return this.secondsDisplayed;
			}
			set
			{
				this.secondsDisplayed = value;
			}
		}

        /// <summary>
        /// Gets or sets a value indicating whether [show progress bar].
        /// </summary>
        /// <value><c>true</c> if [show progress bar]; otherwise, <c>false</c>.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("Show progressbar")]
		public bool ShowProgressBar
		{
			get
			{
				return this.showProgressBar;
			}
			set
			{
				this.showProgressBar = value;
			}
		}

        /// <summary>
        /// Gets or sets the size of the splash.
        /// </summary>
        /// <value>The size of the splash.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The splash size")]
		public Size SplashSize
		{
			get
			{
				return this.splashSize;
			}
			set
			{
				this.splashSize = value;
			}
		}

        /// <summary>
        /// Gets or sets the top text.
        /// </summary>
        /// <value>The top text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The top text")]
		public string TopText
		{
			get
			{
				return this.topText;
			}
			set
			{
				this.topText = value;
			}
		}

        /// <summary>
        /// Gets or sets the color of the top text.
        /// </summary>
        /// <value>The color of the top text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The top text color")]
		public Color TopTextColor
		{
			get
			{
				return this.topTextColor;
			}
			set
			{
				this.topTextColor = value;
			}
		}

        /// <summary>
        /// Gets or sets the size of the top text.
        /// </summary>
        /// <value>The size of the top text.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The top text size")]
		public int TopTextSize
		{
			get
			{
				return this.topTextSize;
			}
			set
			{
				this.topTextSize = value;
			}
		}

        /// <summary>
        /// Gets or sets the color of the unloaded.
        /// </summary>
        /// <value>The color of the unloaded.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The progressbar unloaded color")]
		public Color UnloadedColor
		{
			get
			{
				return this.unloadedColor;
			}
			set
			{
				this.unloadedColor = value;
			}
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitSplashScreen"/> class.
        /// </summary>
        public ZeroitSplashScreen()
		{
		}

        /// <summary>
        /// Starts the specified main form.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public void Start(Control mainForm)
		{
            
			this.baseForm = mainForm;
			((Form)this.baseForm).WindowState = FormWindowState.Minimized;
			((Form)this.baseForm).ShowInTaskbar = false;
			this.splashForm.BackColor = this.backColor;
			this.splashForm.FormBorderStyle = FormBorderStyle.None;
			this.splashForm.StartPosition = FormStartPosition.CenterScreen;
			this.splashForm.Size = this.splashSize;
			this.background.Dock = DockStyle.Fill;
			this.background.BackColor = this.backColor;
			this.splashForm.Controls.Add(this.background);
			this.progressBar.BarStyle = this.progressBarStyle;
			this.progressBar.InocmpletedColor = this.unloadedColor;
			this.progressBar.CompleteColor = this.loadedColor;
			this.progressBar.Value = 0;
			this.progressBar.Size = new Size(this.splashForm.Width, 10);
			this.progressBar.Location = new Point(0, this.splashForm.Height / 5 * 4);
			if (!this.showProgressBar)
			{
				this.progressBar.Visible = false;
			}
			this.background.Controls.Add(this.progressBar);
			this.updateProgress.Interval = this.secondsDisplayed / 100;
			this.updateProgress.Tick += new EventHandler(this.updateLoader);
			this.text1.ForeColor = this.topTextColor;
			this.text1.Font = new Font("Verdana", (float)this.topTextSize);
			this.text1.Text = this.topText;
			this.text1.BackColor = this.backColor;
			this.text1.AutoSize = true;
			this.text1.Location = new Point(0, this.splashForm.Height / 4);
			this.background.Controls.Add(this.text1);
			this.text2.ForeColor = this.bottomTextColor;
			this.text2.Font = new Font("Verdana", (float)this.bottomTextSize);
			this.text2.Text = this.bottomText;
			this.text2.BackColor = this.backColor;
			this.text2.AutoSize = true;
			Label point = this.text2;
			int width = this.text1.Width / 2 - this.text2.Width;
			Point location = this.text1.Location;
			point.Location = new Point(width, location.Y + this.text1.Height);
			this.background.Controls.Add(this.text2);
			this.handle.DockAtTop = false;
			if (this.allowDragging)
			{
				this.handle.HandleControl = this.background;
				this.handle2.HandleControl = this.text1;
				this.handle3.HandleControl = this.text2;
				this.handle4.HandleControl = this.progressBar;
			}
			if (this.isEllipse)
			{
				this.ellipse.CornerRadius = this.ellipseCornerRadius;
				this.ellipse.EffectedForm = this.splashForm;
			}
			this.splashForm.Show();
			this.splashForm.BringToFront();
			this.updateProgress.Enabled = true;
		}

        /// <summary>
        /// Updates the loader.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void updateLoader(object sender, EventArgs e)
		{
			if (this.progressBar.Value >= 100)
			{
				this.progressBar.Dispose();
				this.updateProgress.Dispose();
				this.background.Dispose();
				this.text1.Dispose();
				this.text2.Dispose();
				this.handle.Dispose();
				this.handle2.Dispose();
				this.handle3.Dispose();
				this.handle4.Dispose();
				this.ellipse.Dispose();
				this.splashForm.Dispose();
				((Form)this.baseForm).ShowInTaskbar = true;
				((Form)this.baseForm).WindowState = FormWindowState.Normal;
			}
			else
			{
				ZeroitFlatProgressBar value = this.progressBar;
				value.Value = value.Value + 1;
			}
		}
	}
}