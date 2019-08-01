// ***********************************************************************
// Assembly         : Zeroit.Framework.Component
// Author           : ZEROIT
// Created          : 11-23-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-23-2018
// ***********************************************************************
// <copyright file="ObjectEllipse.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Zeroit.Framework.SnippetEditors.Helpers
{
    /// <summary>
    /// Class ZeroitObjectEllipse.
    /// </summary>
    /// <seealso cref="System.ComponentModel.Component" />
    public class ZeroitObjectEllipse : Component
	{
        /// <summary>
        /// The refresh UI
        /// </summary>
        private Timer RefreshUI = new Timer();

        /// <summary>
        /// The corner radius
        /// </summary>
        private int cornerRadius = 10;

        /// <summary>
        /// The effected control
        /// </summary>
        private Control effectedControl = null;

        /// <summary>
        /// Gets or sets the corner radius.
        /// </summary>
        /// <value>The corner radius.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The corner radius")]
		public int CornerRadius
		{
			get
			{
				return this.cornerRadius;
			}
			set
			{
				this.cornerRadius = value;
				this.SetCustomRegion();
			}
		}

        /// <summary>
        /// Gets or sets the effected control.
        /// </summary>
        /// <value>The effected control.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The effected object")]
		public Control EffectedControl
		{
			get
			{
				return this.effectedControl;
			}
			set
			{
				if (this.effectedControl != null)
				{
					this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, 0, 0));
				}
				this.effectedControl = value;
				this.SetCustomRegion();
			}
		}

        /// <summary>
        /// Gets or sets the effected form.
        /// </summary>
        /// <value>The effected form.</value>
        [Browsable(true)]
		[Category("Zeroit.Framework.DaggerControls")]
		[Description("The effected form(will remove ellipse from effected control)")]
		public Form EffectedForm
		{
			get
			{
				return this.effectedControl as Form;
			}
			set
			{
				if (this.effectedControl != null)
				{
					this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, 0, 0));
				}
				this.effectedControl = value;
				this.SetCustomRegion();
			}
		}

        /// <summary>
        /// Gets or sets the <see cref="T:System.ComponentModel.ISite" /> of the <see cref="T:System.ComponentModel.Component" />.
        /// </summary>
        /// <value>The site.</value>
        public override ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				base.Site = value;
				if (value != null)
				{
					IDesignerHost service = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
					if (service != null)
					{
						IComponent rootComponent = service.RootComponent;
						if (rootComponent is ContainerControl)
						{
							this.effectedControl = rootComponent as ContainerControl;
						}
					}
				}
			}
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitObjectEllipse"/> class.
        /// </summary>
        public ZeroitObjectEllipse()
		{
			this.RefreshUI.Interval = 50;
			this.RefreshUI.Tick += new EventHandler(this.RefreshUI_Tick);
			this.RefreshUI.Enabled = true;
		}

        /// <summary>
        /// Handles the SizeChanged event of the Container control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Container_SizeChanged(object sender, EventArgs e)
		{
			this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, this.cornerRadius, this.cornerRadius));
		}

        /// <summary>
        /// Creates the round rect RGN.
        /// </summary>
        /// <param name="nLeftRect">The n left rect.</param>
        /// <param name="nTopRect">The n top rect.</param>
        /// <param name="nRightRect">The n right rect.</param>
        /// <param name="nBottomRect">The n bottom rect.</param>
        /// <param name="nWidthEllipse">The n width ellipse.</param>
        /// <param name="nHeightEllipse">The n height ellipse.</param>
        /// <returns>IntPtr.</returns>
        [DllImport("Gdi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Component" /> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (this.effectedControl != null)
			{
				this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, 0, 0));
			}
		}

        /// <summary>
        /// Handles the Tick event of the RefreshUI control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RefreshUI_Tick(object sender, EventArgs e)
		{
			this.SetCustomRegion();
			this.RefreshUI.Dispose();
			try
			{
				((Form)this.effectedControl).FormBorderStyle = FormBorderStyle.None;
			}
			catch
			{
			}
		}

        /// <summary>
        /// Sets the custom region.
        /// </summary>
        private void SetCustomRegion()
		{
			if (this.effectedControl != null)
			{
				this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, 0, 0));
				this.effectedControl.Region = Region.FromHrgn(ZeroitObjectEllipse.CreateRoundRectRgn(0, 0, this.effectedControl.Width, this.effectedControl.Height, this.cornerRadius, this.cornerRadius));
				this.effectedControl.SizeChanged += new EventHandler(this.Container_SizeChanged);
			}
		}
	    
	}
}