namespace DemoApp {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.glassArea = new System.Windows.Forms.Panel ();
			this.grad1 = new System.Windows.Forms.Panel ();
			this.panelBottom = new System.Windows.Forms.Panel ();
			this.breadcrumbBar2 = new Vista.Controls.BreadcrumbBar ();
			this.explorerNavigation2 = new Vista.Controls.ExplorerNavigation ();
			this.breadcrumbBar3 = new Vista.Controls.BreadcrumbBar ();
			this.explorerNavigation3 = new Vista.Controls.ExplorerNavigation ();
			this.breadcrumbBar1 = new Vista.Controls.BreadcrumbBar ();
			this.explorerNavigation1 = new Vista.Controls.ExplorerNavigation ();
			this.glassArea.SuspendLayout ();
			this.grad1.SuspendLayout ();
			this.panelBottom.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// glassArea
			// 
			this.glassArea.BackColor = System.Drawing.Color.Green;
			this.glassArea.Controls.Add ( this.breadcrumbBar1 );
			this.glassArea.Controls.Add ( this.explorerNavigation1 );
			this.glassArea.Location = new System.Drawing.Point ( 1, 160 );
			this.glassArea.Name = "glassArea";
			this.glassArea.Size = new System.Drawing.Size ( 836, 42 );
			this.glassArea.TabIndex = 0;
			// 
			// grad1
			// 
			this.grad1.Controls.Add ( this.breadcrumbBar3 );
			this.grad1.Controls.Add ( this.explorerNavigation3 );
			this.grad1.Dock = System.Windows.Forms.DockStyle.Top;
			this.grad1.Location = new System.Drawing.Point ( 0, 0 );
			this.grad1.Name = "grad1";
			this.grad1.Size = new System.Drawing.Size ( 836, 37 );
			this.grad1.TabIndex = 3;
			this.grad1.Paint += new System.Windows.Forms.PaintEventHandler ( this.grad1_Paint );
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.Add ( this.breadcrumbBar2 );
			this.panelBottom.Controls.Add ( this.explorerNavigation2 );
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBottom.Location = new System.Drawing.Point ( 0, 37 );
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size ( 836, 39 );
			this.panelBottom.TabIndex = 5;
			// 
			// breadcrumbBar2
			// 
			this.breadcrumbBar2.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
									| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.breadcrumbBar2.BackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar2.BackgroundAlpha = ( (byte)( 255 ) );
			this.breadcrumbBar2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.breadcrumbBar2.HoverBackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar2.Location = new System.Drawing.Point ( 76, 10 );
			this.breadcrumbBar2.Name = "breadcrumbBar2";
			this.breadcrumbBar2.PathSeparator = "/";
			this.breadcrumbBar2.Size = new System.Drawing.Size ( 757, 22 );
			this.breadcrumbBar2.TabIndex = 2;
			this.breadcrumbBar2.Text = "breadcrumbBar2";
			// 
			// explorerNavigation2
			// 
			this.explorerNavigation2.BackColor = System.Drawing.Color.Transparent;
			this.explorerNavigation2.Location = new System.Drawing.Point ( 1, 7 );
			this.explorerNavigation2.Name = "explorerNavigation2";
			this.explorerNavigation2.Size = new System.Drawing.Size ( 74, 29 );
			this.explorerNavigation2.TabIndex = 1;
			this.explorerNavigation2.Text = "explorerNavigation2";
			// 
			// breadcrumbBar3
			// 
			this.breadcrumbBar3.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
									| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.breadcrumbBar3.BackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar3.BackgroundAlpha = ( (byte)( 255 ) );
			this.breadcrumbBar3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.breadcrumbBar3.HoverBackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar3.Location = new System.Drawing.Point ( 76, 7 );
			this.breadcrumbBar3.Name = "breadcrumbBar3";
			this.breadcrumbBar3.PathSeparator = "/";
			this.breadcrumbBar3.Size = new System.Drawing.Size ( 759, 22 );
			this.breadcrumbBar3.TabIndex = 4;
			this.breadcrumbBar3.Text = "breadcrumbBar3";
			// 
			// explorerNavigation3
			// 
			this.explorerNavigation3.BackColor = System.Drawing.Color.Transparent;
			this.explorerNavigation3.Location = new System.Drawing.Point ( 1, 4 );
			this.explorerNavigation3.Name = "explorerNavigation3";
			this.explorerNavigation3.Size = new System.Drawing.Size ( 74, 29 );
			this.explorerNavigation3.TabIndex = 3;
			this.explorerNavigation3.Text = "explorerNavigation3";
			// 
			// breadcrumbBar1
			// 
			this.breadcrumbBar1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
									| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.breadcrumbBar1.BackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar1.BackgroundAlpha = ( (byte)( 255 ) );
			this.breadcrumbBar1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.breadcrumbBar1.HoverBackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar1.Location = new System.Drawing.Point ( 75, 12 );
			this.breadcrumbBar1.Name = "breadcrumbBar1";
			this.breadcrumbBar1.PathSeparator = "/";
			this.breadcrumbBar1.Size = new System.Drawing.Size ( 759, 22 );
			this.breadcrumbBar1.TabIndex = 1;
			this.breadcrumbBar1.Text = "breadcrumbBar1";
			// 
			// explorerNavigation1
			// 
			this.explorerNavigation1.BackColor = System.Drawing.Color.Transparent;
			this.explorerNavigation1.Location = new System.Drawing.Point ( 0, 8 );
			this.explorerNavigation1.Name = "explorerNavigation1";
			this.explorerNavigation1.PaintForGlass = true;
			this.explorerNavigation1.Size = new System.Drawing.Size ( 74, 29 );
			this.explorerNavigation1.TabIndex = 0;
			this.explorerNavigation1.Text = "explorerNavigation1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 836, 322 );
			this.Controls.Add ( this.panelBottom );
			this.Controls.Add ( this.grad1 );
			this.Controls.Add ( this.glassArea );
			this.Name = "Form1";
			this.glassArea.ResumeLayout ( false );
			this.grad1.ResumeLayout ( false );
			this.panelBottom.ResumeLayout ( false );
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.Panel glassArea;
		private Vista.Controls.BreadcrumbBar breadcrumbBar1;
		private Vista.Controls.ExplorerNavigation explorerNavigation1;
		private Vista.Controls.ExplorerNavigation explorerNavigation2;
		private Vista.Controls.BreadcrumbBar breadcrumbBar2;
		private System.Windows.Forms.Panel grad1;
		private Vista.Controls.BreadcrumbBar breadcrumbBar3;
		private Vista.Controls.ExplorerNavigation explorerNavigation3;
		private System.Windows.Forms.Panel panelBottom;
	}
}

