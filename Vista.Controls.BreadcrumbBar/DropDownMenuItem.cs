using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista.Controls {
	public class DropDownMenuItem : ToolStripMenuItem {
		public DropDownMenuItem ()
			: base () {

		}

		public DropDownMenuItem ( string text )
			: base ( text ) {

		}
	}

  public class DropDownSeparator : ToolStripSeparator {
    public DropDownSeparator ( ) {

    }
  }

  public class DropDownMenuItemCollection {

    public DropDownMenuItemCollection ( BreadcrumbBarNode owner ) {
      this.Owner = owner;
			this.Items = new List<ToolStripMenuItem> ();
    }

    public BreadcrumbBarNode Owner { get; private set; }
		private List<ToolStripMenuItem> Items { get; set; }

		public void Add ( ToolStripMenuItem value ) {
			if ( value is ToolStripMenuItem ) {
        this.Items.Add ( value );
        this.Owner.DropDownMenu.Items.Add ( value );
        if ( this.Items.Count == 1 ) {
          ( this.Owner.Parent as BreadcrumbBar ).Nodes.ResizeNodes ( );
          this.Owner.Invalidate ( );
        }
      }
    }

		public void AddRange ( ToolStripMenuItem[] items ) {
      foreach ( var item in this.Items ) {
        this.Add ( item );
      }
    }

		public ToolStripMenuItem this[ int index ] {
      get {
        return this.Items[ index ];
      }
    }

    public void Clear ( ) {
      this.Items.Clear();
      this.Owner.DropDownMenu.Items.Clear ( );
      ( this.Owner.Parent as BreadcrumbBar ).Nodes.ResizeNodes ( );
      this.Owner.Invalidate ( );
    }

    public int Count {
      get {
        return this.Items.Count;
      }
    }

    public void Remove ( DropDownMenuItem value ) {
      this.Owner.DropDownMenu.Items.Remove ( value );
      this.Items.Remove ( value );
    }

    public void RemoveAt ( int index ) {
      this.Owner.DropDownMenu.Items.RemoveAt ( index );
      this.Items.RemoveAt ( index );
    }
  }
}
