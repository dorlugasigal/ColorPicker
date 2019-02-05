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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class frmMain : Form
    {
        #region Properties
        static Timer MouseMoveTimer = new Timer();
        Rectangle m_screen;
        Bitmap m_bmpRainbow;
        Bitmap m_bmpGradient;
        Color m_rainbowCurrentColor;
        Color m_chosenColor;
        Point m_chosenColorPosition;
        Point m_initPosition;
        Pen m_pen;
        LinearGradientBrush m_linearGradientBrush;
        ColorBlend m_colorBlend;
        int m_rainbowCurrentColorHeight;

        BackgroundWorker c;

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
            clsManageComunication.OnSendMessage += ClsManageComunication_OnSendMessage1;

            MouseMoveTimer.Interval = 10;
            MouseMoveTimer.Tick += MouseMoveTimer_Tick;
            m_screen = Screen.PrimaryScreen.WorkingArea;
        }
        private void InitiatePaintProperties()
        {
            m_pen = new Pen(Color.Black, 1);
            m_linearGradientBrush = new LinearGradientBrush(pnlRainbowColor.ClientRectangle, Color.Black, Color.Black, 90);
            m_colorBlend = new ColorBlend(7);
            m_colorBlend.Colors = new Color[7] { Color.Red, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Magenta, Color.Red };
            m_colorBlend.Positions = new float[7] { 0f, 0.16f, 0.334f, 0.5f, 0.668f, 0.835f, 1f };
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Location = new Point(m_screen.Size.Width - Size.Width, m_screen.Size.Height / 2 - Size.Height / 2);
            m_initPosition = Location;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnCapturePixel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pnlGradient.BackgroundImage = Gradient2D(pnlGradient.ClientRectangle, Color.White, Color.Black, Color.Red, Color.Black);
            InitiatePaintProperties();
            m_bmpRainbow = new Bitmap(pnlRainbowColor.ClientRectangle.Width, pnlRainbowColor.ClientRectangle.Height);
            m_bmpGradient = new Bitmap(pnlGradient.ClientRectangle.Width, pnlGradient.ClientRectangle.Height);
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

        #region Paint Events
        private void pnlRainbowColor_Paint(object sender, PaintEventArgs e)
        {
            m_linearGradientBrush.InterpolationColors = m_colorBlend;
            e.Graphics.FillRectangle(m_linearGradientBrush, pnlRainbowColor.ClientRectangle);
            //paint a line on the rainbow where the color is picked
            e.Graphics.DrawLine(m_pen, 0, m_rainbowCurrentColorHeight, pnlRainbowColor.Width, m_rainbowCurrentColorHeight);
        }
        private void pnlGradient_Paint(object sender, PaintEventArgs e)
        {
            if (m_chosenColorPosition != null)
            {
                e.Graphics.DrawEllipse(m_pen, m_chosenColorPosition.X - 5, m_chosenColorPosition.Y - 5, 10, 10);
            }
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
            trackBarAlpha.Enabled = chkRGBA.Checked;
            if (chkRGBA.Checked && trackBarAlpha.Value != 255)
            {
                m_chosenColor = Color.FromArgb(trackBarAlpha.Value, m_chosenColor);
            }
            UpdateRGBCode(m_chosenColor);
            pnlColorDisplay.BackColor = m_chosenColor;
        }
        private void txtRGBColorCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Color color = ColorTranslator.FromHtml(txtRGBColorCode.Text);
                pnlColorDisplay.BackColor = color;
                return;
            }
            catch (Exception)
            {
            }
            try
            {
                Match numbers = Regex.Match(txtRGBColorCode.Text, @"([\d]+[\.]?[\d]*)");
                List<float> lst = new List<float>();
                while (numbers.Length != 0)
                {
                    lst.Add(float.Parse(numbers.Value));
                    numbers = numbers.NextMatch();
                }
                if (lst.Count != 3 && lst.Count != 4) { return; }
                pnlColorDisplay.BackColor = Color.FromArgb((numbers.Length == 4 ? (int)(255 * lst[3]) : 255),
                                                            (int)lst[0], (int)lst[1], (int)lst[2]);
            }
            catch (Exception)
            {
            }
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                this.Location = m_initPosition;
            }
        }
        private void pnlRainbowColor_MouseClick(object sender, MouseEventArgs e)
        {
            m_rainbowCurrentColorHeight = e.Y;
            m_rainbowCurrentColor = m_bmpRainbow.GetPixel(e.X, e.Y);
            pnlGradient.BackgroundImage = Gradient2D(pnlGradient.ClientRectangle, Color.White, Color.Black, m_rainbowCurrentColor, Color.Black);
            RefreshBitmaps();
            m_chosenColor = m_bmpGradient.GetPixel(m_chosenColorPosition.X, m_chosenColorPosition.Y);
            UpdateChosenColor();
            RefreshAllPanels();
        }
        private void pnlGradient_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshBitmaps();
            m_chosenColorPosition = new Point(e.X, e.Y);
            m_chosenColor = m_bmpGradient.GetPixel(m_chosenColorPosition.X, m_chosenColorPosition.Y);
            UpdateChosenColor();
            RefreshAllPanels();
        }
        private void trackBars_Scroll(object sender, EventArgs e)
        {
            txtRed.Text = trackBarRed.Value.ToString();
            txtGreen.Text = trackBarGreen.Value.ToString();
            txtBlue.Text = trackBarBlue.Value.ToString();
            txtAlpha.Text = trackBarAlpha.Value.ToString();
            m_chosenColor = Color.FromArgb((!chkRGBA.Checked ? 255 : trackBarAlpha.Value),
                                            trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            pnlColorDisplay.BackColor = m_chosenColor;
            UpdateRGBCode(m_chosenColor);
        }
        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnCapturePixel_Click(object sender, EventArgs e)
        {
            bool isButtonClicked = btnCapturePixel.BackColor != Color.ForestGreen;
            lblPressEnter.Visible = isButtonClicked;
            if (isButtonClicked)
            {
                btnCapturePixel.BackColor = Color.ForestGreen;
                MouseMoveTimer.Start();
            }
            else
            {
                btnCapturePixel.BackColor = Color.FromArgb(49, 49, 49);
                MouseMoveTimer.Stop();
            }
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

        private void ClsManageComunication_OnSendMessage1(string Message)
        {
            this.Invoke((System.Action)(() =>
            {
                this.TopMost = true;
                this.Show();
                var original = this.Location;
                var rnd = new Random(1337);
                const int shake_amplitude = 10;
                for (int i = 0; i < 10; i++)
                {
                    this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                    System.Threading.Thread.Sleep(20);
                }
                this.Location = original;
                this.TopMost = false;

            }));
        }

    }
}
