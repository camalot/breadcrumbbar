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

			if ( Areo.IsGlassSupported ) {
				glassArea.BackColor = Color.Transparent;
				// getting "control does not support transparent background" exception for now
				glassArea.Resize += delegate ( object s, EventArgs e ) {
					this.Invalidate ( glassArea.Region, true );
				};
				this.ExtendFrameIntoClientArea ( glassArea );

			}
			BreadcrumbBarButton reload = new BreadcrumbBarButton();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar1.Buttons.Add ( reload );

			reload = new BreadcrumbBarButton ();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar2.Buttons.Add ( reload );

			reload = new BreadcrumbBarButton ();
			reload.Image = Vista.Controls.Properties.Resources.refresh;
			this.breadcrumbBar3.Buttons.Add ( reload );

			glassArea.SetGlassWindowDragable ();
		}



		/*protected override void WndProc ( ref Message m ) {
			base.WndProc ( ref m );

			if ( m.Msg == 0x84 // if this is a click
					&& m.Result.ToInt32 () == 1 // ...and it is on the client
					// ...and specifically in the glass area
					&& this.IsOnGlass ( glassArea,m.LParam.ToInt32 () ) ) {
				m.Result = new IntPtr ( 2 ); // lie and say they clicked on the title bar
			}
		}*/

		protected override void OnPaint ( PaintEventArgs e ) {
			base.OnPaint ( e );
			if ( Areo.IsGlassSupported ) {
				using ( SolidBrush blackBrush = new SolidBrush ( Color.Black ) ) {
					e.Graphics.FillRectangle ( blackBrush, glassArea.ClientRectangle );
				}
			}
		}

		private void grad1_Paint ( object sender, PaintEventArgs e ) {
			using ( LinearGradientBrush brush = new LinearGradientBrush ( grad1.ClientRectangle, Color.Crimson, Color.Azure, LinearGradientMode.Vertical ) ) {
				e.Graphics.FillRectangle ( brush, grad1.ClientRectangle );
			}
		}
	}
}
