using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class frmMain : Form
    {


        #region Properties
        static System.Windows.Forms.Timer MouseMoveTimer = new System.Windows.Forms.Timer();
        Rectangle m_screen;
        Bitmap m_bmpRainbow;
        Bitmap m_bmpGradient;
        Color m_rainbowCurrentColor;
        Color m_chosenColor;
        Point m_chosenColorPosition;
        Point m_initPosition;
        int m_rainbowCurrentColorHeight;
        #endregion

        #region Properties for dragging the form with mouse

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        #endregion

        #region Get Pixel Color from screen

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();

            MouseMoveTimer.Interval = 10;
            MouseMoveTimer.Tick += MouseMoveTimer_Tick;
            m_screen = Screen.PrimaryScreen.WorkingArea;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Location = new Point(m_screen.Size.Width - Size.Width, m_screen.Size.Height / 2 - Size.Height / 2);
            m_initPosition = Location;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnCapturePixel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pnlGradient.BackgroundImage = Gradient2D(pnlGradient.ClientRectangle, Color.White, Color.Black, Color.Red, Color.Black);

            RefreshBitmaps();
            RefreshAllPanels();

        }

        #region Main Gradient Generator

        public List<PointF> getCorners(RectangleF r)
        {
            return new List<PointF>() { r.Location, new PointF(r.Right, r.Top), new PointF(r.Right, r.Bottom), new PointF(r.Left, r.Bottom) };
        }
        public static Color medianColor(List<Color> cols)
        {
            int c = cols.Count;
            return Color.FromArgb(cols.Sum(x => x.A) / c, cols.Sum(x => x.R) / c, cols.Sum(x => x.G) / c, cols.Sum(x => x.B) / c);
        }
        Bitmap Gradient2D(Rectangle r, Color c1, Color c2, Color c3, Color c4)
        {
            List<Color> colors = new List<Color> { c1, c3, c4, c2 };
            Bitmap bmp = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(bmp))
                for (int y = 0; y < r.Height; y++)
                {

                    using (PathGradientBrush pgb = new PathGradientBrush(getCorners(r).ToArray()))
                    {
                        pgb.CenterColor = medianColor(colors);
                        pgb.SurroundColors = colors.ToArray();
                        g.FillRectangle(pgb, 0, y, r.Width, 1);
                    }
                }
            return bmp;
        }

        #endregion

        #region Refresh Data functions, bitmaps and panels
        private void RefreshBitmaps()
        {
            pnlRainbowColor.DrawToBitmap(m_bmpRainbow, pnlRainbowColor.ClientRectangle);
            pnlGradient.DrawToBitmap(m_bmpGradient, pnlGradient.ClientRectangle);
        }

        private void RefreshAllPanels()
        {
            pnlColorDisplay.Refresh();
            pnlRainbowColor.Refresh();
            pnlGradient.Refresh();
        }
        #endregion

        #region Data assigners to sliders, output RGB and display panel

        private void AssignColorToSliders()
        {
            txtBlue.Text = m_chosenColor.B.ToString();
            txtRed.Text = m_chosenColor.R.ToString();
            txtGreen.Text = m_chosenColor.G.ToString();
            txtAlpha.Text = m_chosenColor.A.ToString();

            trackBarAlpha.Value = m_chosenColor.A;
            trackBarBlue.Value = m_chosenColor.B;
            trackBarGreen.Value = m_chosenColor.G;
            trackBarRed.Value = m_chosenColor.R;
        }
        private void UpdateRGBCode(Color clr)
        {
            txtRGBColorCode.TextChanged -= txtRGBColorCode_TextChanged;
            txtRGBColorCode.Text = "rgb" + (chkRGBA.Checked ? "a" : "")
                + "(" + clr.R
                + "," + clr.G
                + "," + clr.B
                + (chkRGBA.Checked ? "," + string.Format("{0:0.0}", (trackBarAlpha.Value / 255.0)) : "")
                + ")";
            txtRGBColorCode.TextChanged += txtRGBColorCode_TextChanged;
        }
        private void UpdateChosenColor()
        {
            pnlColorDisplay.BackColor = m_chosenColor;
            AssignColorToSliders();
            UpdateRGBCode(m_chosenColor);
        }

        #endregion


        #region Text changed, CheckBox change and click events

        private void chkRGBA_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtRGBColorCode_TextChanged(object sender, EventArgs e)
        {

        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pnlRainbowColor_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void pnlGradient_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void trackBars_Scroll(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnCapturePixel_Click(object sender, EventArgs e)
        {

        }

        #endregion


        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            m_chosenColor = GetColorAt(cursor);
            AssignColorToSliders();
            pnlColorDisplay.BackColor = m_chosenColor;
            UpdateRGBCode(m_chosenColor);
        }

    }
}
