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
			this.explorerAddressNavigation1 = new Vista.Controls.ExplorerAddressNavigation ();
			this.textBox1 = new System.Windows.Forms.TextBox ();
			this.button1 = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// explorerAddressNavigation1
			// 
			this.explorerAddressNavigation1.BackColor = System.Drawing.Color.Transparent;
			this.explorerAddressNavigation1.Dock = System.Windows.Forms.DockStyle.Top;
			this.explorerAddressNavigation1.DockOnGlass = true;
			this.explorerAddressNavigation1.Location = new System.Drawing.Point ( 0, 0 );
			this.explorerAddressNavigation1.Name = "explorerAddressNavigation1";
			this.explorerAddressNavigation1.Padding = new System.Windows.Forms.Padding ( 1, 3, 1, 3 );
			this.explorerAddressNavigation1.ShowRefresh = true;
			this.explorerAddressNavigation1.Size = new System.Drawing.Size ( 836, 34 );
			this.explorerAddressNavigation1.TabIndex = 0;
			this.explorerAddressNavigation1.Text = "explorerAddressNavigation1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point ( 43, 60 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size ( 259, 20 );
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "/sdcard/system/audio/ringtons/mp3/";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point ( 308, 57 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 75, 23 );
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 836, 322 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.textBox1 );
			this.Controls.Add ( this.explorerAddressNavigation1 );
			this.Name = "Form1";
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private Vista.Controls.ExplorerAddressNavigation explorerAddressNavigation1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;



	}
}

