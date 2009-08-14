using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Controls {
  public class BreadcrumbBarRootNode : BreadcrumbBarNode {
    internal BreadcrumbBarRootNode ( BreadcrumbBar parent, Image image )
      : base ( string.Empty ) {
      this.Parent = parent;
      this.Image = image;
    }

    public Image Image { get; set; }

    public Rectangle ImageBounds {
      get {
        return new Rectangle ( 2, 2, this.Image.Width, this.Bounds.Height );
      }
    }

    public override Rectangle DropDownBounds {
      get {
        return new Rectangle ( new Point ( ImageBounds.X + this.Image.Width + 2, 0 ), new Size ( DropDownSize.Width, this.Bounds.Height ) );
      }
    }

    internal bool IsMouseOverImage { get; set; }

    protected override void OnMouseMove ( MouseEventArgs e ) {
      base.OnMouseMove ( e );
      this.IsMouseOverImage = Rectangle.Intersect ( new Rectangle ( this.PointToClient ( MousePosition ), new Size ( 1, 1 ) ),
        this.ImageBounds ) != Rectangle.Empty;
      this.Invalidate ( );
    }

    protected override void OnClick ( EventArgs e ) {
      if ( this.IsMouseOverImage ) {
        BreadcrumbBar bb = this.Parent as BreadcrumbBar;
        bb.ViewMode = BreadcrumbBar.ViewModes.Text;
      } else {
        base.OnClick ( e );
      }
    }


    protected override void OnPaint ( PaintEventArgs e ) {
      base.OnPaint ( e );
      Graphics g = e.Graphics;
      if ( this.Parent != null && this.Parent is BreadcrumbBar ) {
        BreadcrumbBar parent = this.Parent as BreadcrumbBar;
				g.Clear ( parent.IsMouseOver ? Color.FromArgb ( parent.BackgroundAlpha, parent.HoverBackColor ) : Color.FromArgb ( parent.BackgroundAlpha, parent.BackColor ) );
        int imgOffset = 3;
        if ( this.Image != null ) {
          DrawImage ( g );
          imgOffset = this.Image.Width;
        }

        if ( ( this.IsMouseOverDropDown || this.IsDropDownVisible ) && this.HasChildNodes ) {
          FillBackground ( g, DropDownBounds, new Color[ ] {
					Color.FromArgb ( 255, 234, 246, 253 ),
					Color.FromArgb ( 255, 215, 239, 252 ),
					Color.FromArgb ( 255, 189, 230, 253 ),
					Color.FromArgb ( 255, 166, 214, 244 )
					} );
          DrawBorder ( g, DropDownBounds, Color.FromArgb ( 200, 95, 96, 97 ) );
        }
        if ( this.HasChildNodes ) {
          if ( ( ( this.IsMouseDown && this.IsMouseOverDropDown ) ) || this.IsDropDownVisible ) {
            DrawDownArrow ( g, DropDownBounds );
          } else {
            DrawRightArrow ( g, DropDownBounds );
          }
        }
      }
    }

    private void DrawLeftMore ( Graphics g, Rectangle rectangle ) {
      Point startPoint = CalcStartPoint ( DropDownBounds.Size, new Size ( 8, 5 ) );
      startPoint.Offset ( DropDownBounds.X - 1, DropDownBounds.Y );

      Color clr = Color.FromArgb ( 255, 0, 0, 0 );
      using ( Pen pen = new Pen ( clr, 1 ) ) {
        g.DrawLine ( pen, startPoint, new Point ( startPoint.X + 7, startPoint.Y ) );
        startPoint.Offset ( 1, 1 );
      }
    }

    protected void DrawImage ( Graphics g ) {
      using ( Bitmap bmp = new Bitmap ( this.Image, this.Image.Width, this.Image.Height ) ) {
        g.DrawImage ( bmp, 2, 2, bmp.Width, bmp.Height );
      }
    }
  }
}
