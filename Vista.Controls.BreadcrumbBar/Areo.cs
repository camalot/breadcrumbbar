using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Vista.Controls {
	public static class Areo {

		public enum BP_BUFFERFORMAT {
			BPBF_COMPATIBLEBITMAP,
			BPBF_DIB,
			BPBF_TOPDOWNDIB,
			BPBF_TOPDOWNMONODIB
		}



		public struct MARGINS {
			public int Left;
			public int Right;
			public int Top;
			public int Bottom;
		}

		public struct POINTAPI {
			public int x;
			public int y;
		}


		public struct DTTOPTS {
			public uint dwSize;
			public uint dwFlags;
			public uint crText;
			public uint crBorder;
			public uint crShadow;
			public int iTextShadowType;
			public POINTAPI ptShadowOffset;
			public int iBorderSize;
			public int iFontPropId;
			public int iColorPropId;
			public int iStateId;
			public int fApplyOverlay;
			public int iGlowSize;
			public IntPtr pfnDrawTextCallback;
			public int lParam;
		}

		public struct BITMAPINFOHEADER {
			public int biSize;
			public int biWidth;
			public int biHeight;
			public short biPlanes;
			public short biBitCount;
			public int biCompression;
			public int biSizeImage;
			public int biXPelsPerMeter;
			public int biYPelsPerMeter;
			public int biClrUsed;
			public int biClrImportant;
		}

		public struct RGBQUAD {
			public byte rgbBlue;
			public byte rgbGreen;
			public byte rgbRed;
			public byte rgbReserved;
		}

		public struct BITMAPINFO {
			public BITMAPINFOHEADER bmiHeader;
			public RGBQUAD bmiColors;
		}

		[StructLayout ( LayoutKind.Sequential )]
		public struct RECT {
			public int left;
			public int top;
			public int right;
			public int bottom;

			public RECT ( System.Drawing.Rectangle rect ) {
				left = rect.Left;
				top = rect.Top;
				right = rect.Right;
				bottom = rect.Bottom;
			}

			//for ease with casting from a rectangle
			public static implicit operator RECT ( System.Drawing.Rectangle rc ) {
				return new RECT ( rc );
			}
		}


		// consts for wndproc
		public const int WM_NCHITTEST = 0x84;
		public const int HTCLIENT = 1;
		public const int HTCAPTION = 2;

		public const int DTT_COMPOSITED = (int)( 1UL << 13 );
		public const int DTT_GLOWSIZE = (int)( 1UL << 11 );

		//Text format consts
		public const int DT_SINGLELINE = 0x00000020;
		public const int DT_CENTER = 0x00000001;
		public const int DT_VCENTER = 0x00000004;
		public const int DT_NOPREFIX = 0x00000800;

		//Const for BitBlt
		public const int SRCCOPY = 0x00CC0020;

		//Consts for CreateDIBSection
		public const int BI_RGB = 0;

		//color table in RGBs
		public const int DIB_RGB_COLORS = 0;

		//consts for the textbox
		public const int WM_PRINTCLIENT = 0x0318;
		public const int PRF_CLIENT = 4;
		public const int WM_PAINT = 0xf;

		//required p/invokes

		//UXTHEME
		[DllImport ( "uxtheme.dll" )]
		public static extern IntPtr BeginBufferedPaint ( IntPtr hdc, ref RECT prcTarget, BP_BUFFERFORMAT dwFormat, IntPtr pPaintParams, out IntPtr phdc );

		[DllImport ( "uxtheme.dll" )]
		public static extern IntPtr EndBufferedPaint ( IntPtr hBufferedPaint, bool fUpdateTarget );

		[DllImport ( "uxtheme.dll" )]
		public static extern IntPtr BufferedPaintSetAlpha ( IntPtr targetDC, IntPtr prcTarget, byte Alpha );

		[DllImport ( "uxtheme.dll" )]
		public static extern void BufferedPaintInit ();

		[DllImport ( "uxtheme.dll" )]
		public static extern void BufferedPaintUnInit ();

		[DllImport ( "uxtheme.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Unicode )]
		public static extern int DrawThemeTextEx ( IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int iCharCount, int dwFlags, ref RECT pRect, ref DTTOPTS pOptions );

		[DllImport ( "uxtheme.dll", ExactSpelling = true, SetLastError = true )]
		public static extern int DrawThemeText ( IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int iCharCount, int dwFlags1, int dwFlags2, ref RECT pRect );

		//USER32
		[DllImport ( "user32.dll" )]
		public static extern bool InvalidateRect ( IntPtr hWnd, RECT lpRect, bool bErase );

		[DllImport ( "user32.dll", CharSet = CharSet.Auto )]
		public static extern IntPtr SendMessage ( IntPtr hWnd, int msg, IntPtr wParam, int lParam );

		[DllImport ( "user32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern IntPtr GetDC ( IntPtr hdc );

		[DllImport ( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern int SaveDC ( IntPtr hdc );

		[DllImport ( "user32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern int ReleaseDC ( IntPtr hdc, int state );

		//GDI
		[DllImport ( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern IntPtr CreateCompatibleDC ( IntPtr hDC );

		[DllImport ( "gdi32.dll", ExactSpelling = true )]
		public static extern IntPtr SelectObject ( IntPtr hDC, IntPtr hObject );

		[DllImport ( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern bool DeleteObject ( IntPtr hObject );

		[DllImport ( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern bool DeleteDC ( IntPtr hdc );

		[DllImport ( "gdi32.dll" )]
		public static extern bool BitBlt ( IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop );

		[DllImport ( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
		public static extern IntPtr CreateDIBSection ( IntPtr hdc, ref BITMAPINFO pbmi, uint iUsage, int ppvBits, IntPtr hSection, uint dwOffset );


		//API declares
		[DllImport ( "dwmapi.dll" )]
		public static extern void DwmIsCompositionEnabled ( ref bool isEnabled );
		[DllImport ( "dwmapi.dll" )]
		public static extern void DwmExtendFrameIntoClientArea ( System.IntPtr hWnd, ref MARGINS pMargins );

		public static void ExtendFrameIntoClientArea ( this Form form, Panel glassArea ) {
			MARGINS marg;
			marg.Top = glassArea.Height; // extend 20 pixels from the top
			marg.Left = 0;
			marg.Right = 0;
			marg.Bottom = 0;
			DwmExtendFrameIntoClientArea ( form.Handle, ref marg );
		}

		public static bool IsOnGlass ( this Form form, Panel glassArea, int lParam ) {
			// get screen coordinates
			int x = ( lParam << 16 ) >> 16; // lo order word
			int y =  lParam >> 16; // hi order word

			// translate screen coordinates to client area
			Point p = form.PointToClient ( new Point ( x, y ) );

			// work out if point clicked is on glass
			if ( y < glassArea.Top )
				return true;

			return false;
		}

		public static bool IsGlassSupported {
			get {
				if ( Environment.OSVersion.Version.Major < 6 )
					return false;

				bool isGlassSupported = false;
				DwmIsCompositionEnabled ( ref isGlassSupported );
				return isGlassSupported;
			}
		}


	}
}
