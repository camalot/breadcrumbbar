using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista.Controls;
using System.Drawing.Drawing2D;

namespace DemoApp {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent ();

			this.ExtendFrameIntoClientArea ( glassArea );

			BreadcrumbBarButton reload = new BreadcrumbBarButton();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar1.Buttons.Add ( reload );

			reload = new BreadcrumbBarButton ();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar2.Buttons.Add ( reload );

			reload = new BreadcrumbBarButton ();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar3.Buttons.Add ( reload );
		}


		protected override void OnPaint ( PaintEventArgs e ) {
			base.OnPaint ( e );
		}

		private void grad1_Paint ( object sender, PaintEventArgs e ) {
			using ( LinearGradientBrush brush = new LinearGradientBrush ( grad1.ClientRectangle, Color.Crimson, Color.Azure, LinearGradientMode.Vertical ) ) {
				e.Graphics.FillRectangle ( brush, grad1.ClientRectangle );
			}
		}
	}
}
