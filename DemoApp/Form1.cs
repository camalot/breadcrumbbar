using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista.Controls;

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
		}

		protected override void WndProc ( ref Message m ) {
			base.WndProc ( ref m );

			if ( m.Msg == 0x84 // if this is a click
					&& m.Result.ToInt32 () == 1 // ...and it is on the client
					&& this.IsOnGlass ( glassArea,m.LParam.ToInt32 () ) ) // ...and specifically in the glass area
    {
				m.Result = new IntPtr ( 2 ); // lie and say they clicked on the title bar
			}
		}

		protected override void OnPaint ( PaintEventArgs e ) {
			base.OnPaint ( e );
			if ( Areo.IsGlassSupported ) {
				using ( SolidBrush blackBrush = new SolidBrush ( Color.Black ) ) {
					e.Graphics.FillRectangle ( blackBrush, glassArea.ClientRectangle );
				}
			}
		}
	}
}
