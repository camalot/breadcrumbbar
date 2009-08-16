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

		}


		protected override void OnPaint ( PaintEventArgs e ) {
			base.OnPaint ( e );
		}

		private void button1_Click ( object sender, EventArgs e ) {
			this.explorerAddressNavigation1.Address.FullPath = textBox1.Text;
		}

	}
}
