using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vista.Controls {
	public class ExplorerNavigationHistoryItem : ICloneable {
		public ExplorerNavigationHistoryItem ()
			: this ( string.Empty ) {

		}

		public ExplorerNavigationHistoryItem ( string text )
			: this ( text, null ) {

		}

		public ExplorerNavigationHistoryItem ( string text, EventHandler click )
			: this ( text, null, click, null ) {
		}

		public ExplorerNavigationHistoryItem ( string text, Image image, EventHandler click )
			: this ( text, image, click, null ) {
		}

		public ExplorerNavigationHistoryItem ( string text, Image image, EventHandler click, object tag ) {
			NavigateDelegate = click;
			this.Text = text;
			this.Image = image;
			this.Tag = tag;
		}

		public string Text { get; set; }
		public EventHandler NavigateDelegate { get; set; }
		public Image Image { get; set; }
		public object Tag { get; set; }

		#region ICloneable Members

		public ExplorerNavigationHistoryItem Clone () {
			ExplorerNavigationHistoryItem i = this.MemberwiseClone () as ExplorerNavigationHistoryItem;
			if ( this.Image != null ) {
				i.Image = this.Image.Clone () as Image;
			}
			if ( this.NavigateDelegate != null ) {
				i.NavigateDelegate = this.NavigateDelegate.Clone () as EventHandler;
			}
			return i;
		}

		#endregion

		#region ICloneable Members

		object ICloneable.Clone () {
			return this.Clone ();
		}

		#endregion
	}
}
