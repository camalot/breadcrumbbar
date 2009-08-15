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
			this.breadcrumbBar2 = new Vista.Controls.BreadcrumbBar ();
			this.explorerNavigation2 = new Vista.Controls.ExplorerNavigation ();
			this.breadcrumbBar1 = new Vista.Controls.BreadcrumbBar ();
			this.explorerNavigation1 = new Vista.Controls.ExplorerNavigation ();
			this.glassArea.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// glassArea
			// 
			this.glassArea.BackColor = System.Drawing.Color.Transparent;
			this.glassArea.Controls.Add ( this.breadcrumbBar1 );
			this.glassArea.Controls.Add ( this.explorerNavigation1 );
			this.glassArea.Dock = System.Windows.Forms.DockStyle.Top;
			this.glassArea.Location = new System.Drawing.Point ( 0, 0 );
			this.glassArea.Name = "glassArea";
			this.glassArea.Size = new System.Drawing.Size ( 836, 42 );
			this.glassArea.TabIndex = 0;
			// 
			// breadcrumbBar2
			// 
			this.breadcrumbBar2.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
									| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.breadcrumbBar2.BackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar2.BackgroundAlpha = ( (byte)( 255 ) );
			this.breadcrumbBar2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.breadcrumbBar2.HoverBackColor = System.Drawing.SystemColors.Window;
			this.breadcrumbBar2.Location = new System.Drawing.Point ( 75, 50 );
			this.breadcrumbBar2.Name = "breadcrumbBar2";
			this.breadcrumbBar2.PathSeparator = "/";
			this.breadcrumbBar2.Size = new System.Drawing.Size ( 759, 22 );
			this.breadcrumbBar2.TabIndex = 2;
			this.breadcrumbBar2.Text = "breadcrumbBar2";
			// 
			// explorerNavigation2
			// 
			this.explorerNavigation2.BackColor = System.Drawing.Color.Transparent;
			this.explorerNavigation2.Location = new System.Drawing.Point ( 0, 47 );
			this.explorerNavigation2.MaximumHistory = 10;
			this.explorerNavigation2.Name = "explorerNavigation2";
			this.explorerNavigation2.ShowClearHistory = true;
			this.explorerNavigation2.Size = new System.Drawing.Size ( 74, 29 );
			this.explorerNavigation2.TabIndex = 1;
			this.explorerNavigation2.Text = "explorerNavigation2";
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
			this.explorerNavigation1.MaximumHistory = 10;
			this.explorerNavigation1.Name = "explorerNavigation1";
			this.explorerNavigation1.PaintForGlass = true;
			this.explorerNavigation1.ShowClearHistory = true;
			this.explorerNavigation1.Size = new System.Drawing.Size ( 74, 29 );
			this.explorerNavigation1.TabIndex = 0;
			this.explorerNavigation1.Text = "explorerNavigation1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 836, 264 );
			this.Controls.Add ( this.breadcrumbBar2 );
			this.Controls.Add ( this.explorerNavigation2 );
			this.Controls.Add ( this.glassArea );
			this.Name = "Form1";
			this.glassArea.ResumeLayout ( false );
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.Panel glassArea;
		private Vista.Controls.BreadcrumbBar breadcrumbBar1;
		private Vista.Controls.ExplorerNavigation explorerNavigation1;
		private Vista.Controls.ExplorerNavigation explorerNavigation2;
		private Vista.Controls.BreadcrumbBar breadcrumbBar2;
	}
}

