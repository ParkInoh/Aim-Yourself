using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AimYourself {
    public partial class FormOverlay : Form {
        public struct RECT {
            public int Left, Top, Right, Bottom;
        }

        private RECT rect;
        private Point clickedPoint, windowCenterPoint;

        public int length = Properties.Settings.Default.length, 
                    gap = Properties.Settings.Default.gap, 
                    thickness = Properties.Settings.Default.thickness;

        public bool drawPointFlag = Properties.Settings.Default.drawPointFlag, 
                    drawOutlineFlag = Properties.Settings.Default.drawOutlineFlag, 
                    drawGapFlag = Properties.Settings.Default.drawGapFlag;

        public bool[] drawSidelineFlags = new bool[4] {
            Properties.Settings.Default.drawSidelineFlags0,
            Properties.Settings.Default.drawSidelineFlags1,
            Properties.Settings.Default.drawSidelineFlags2,
            Properties.Settings.Default.drawSidelineFlags3
        }; // up, down, Left, Right

        private IntPtr newHandle;

        private Graphics graphics;
        private Pen pen = new Pen(Properties.Settings.Default.color, 1), 
                    outlinePen = new Pen(Color.Black, 2),
                    transparentPen = new Pen(Color.Wheat, 2);
        private Brush brush = new SolidBrush(Properties.Settings.Default.color), 
                      outlineBrush = new SolidBrush(Color.Black);


        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point p);

        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr GetAncestor(IntPtr hwnd, int flags);
        

        public FormOverlay() {
            InitializeComponent();
        }

        private void FormOverlay_Load(object sender, EventArgs e) {
            // if color of something drawn in form is wheat, it will be invisible.
            // so don't try to draw something which color is wheat.
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            // click through window, transparent, invisible in alt + tab
            // -20: GWL_EXSTYLE
            // 0x80000: WS_EX_LAYERED
            // 0x20: WS_EX_TRANSPARENT
            // 0x80: WS_EX_TOOLWINDOW
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20 | 0x80);

            this.Size = new Size(1920, 1080);
            this.Top = 0;
            this.Left = 0;

            // save center of window to windowCenterPoint
            windowCenterPoint = new Point(1920 / 2, 1080 / 2);


        }

        private void FormOverlay_Paint(object sender, PaintEventArgs e) {
            graphics = e.Graphics;

            if (drawOutlineFlag) {
                if (drawSidelineFlags[0])
                    graphics.DrawLine(outlinePen, windowCenterPoint.X, windowCenterPoint.Y - length - gap - 1, windowCenterPoint.X, windowCenterPoint.Y - gap + 1);  // up
                if (drawSidelineFlags[1])
                    graphics.DrawLine(outlinePen, windowCenterPoint.X, windowCenterPoint.Y + gap - 1, windowCenterPoint.X, windowCenterPoint.Y + length + gap + 1);  // down
                if (drawSidelineFlags[2])
                    graphics.DrawLine(outlinePen, windowCenterPoint.X - length - gap - 1, windowCenterPoint.Y, windowCenterPoint.X - gap + 1, windowCenterPoint.Y);  // Left
                if (drawSidelineFlags[3])
                    graphics.DrawLine(outlinePen, windowCenterPoint.X + gap - 1, windowCenterPoint.Y, windowCenterPoint.X + length + gap + 1, windowCenterPoint.Y);  // Right
            }

            if (drawSidelineFlags[0])
                graphics.DrawLine(pen, windowCenterPoint.X, windowCenterPoint.Y - length - gap, windowCenterPoint.X, windowCenterPoint.Y - gap);  // up
            if (drawSidelineFlags[1])
                graphics.DrawLine(pen, windowCenterPoint.X, windowCenterPoint.Y + gap, windowCenterPoint.X, windowCenterPoint.Y + length + gap);  // down
            if (drawSidelineFlags[2])
                graphics.DrawLine(pen, windowCenterPoint.X - length - gap, windowCenterPoint.Y, windowCenterPoint.X - gap, windowCenterPoint.Y);  // Left
            if (drawSidelineFlags[3])
                graphics.DrawLine(pen, windowCenterPoint.X + gap, windowCenterPoint.Y, windowCenterPoint.X + length + gap, windowCenterPoint.Y);  // Right

            if (drawGapFlag) {
                if (drawPointFlag) {
                    if (drawOutlineFlag) {
                        graphics.FillRectangle(outlineBrush, new Rectangle(windowCenterPoint.X - thickness / 2 - 1, windowCenterPoint.Y - thickness / 2 - 1, thickness + 2, thickness + 2));
                    }
                    graphics.FillRectangle(brush, new Rectangle(windowCenterPoint.X - thickness / 2, windowCenterPoint.Y - thickness / 2, thickness, thickness));
                }
            }

        }

        public void SetDoubleBuffered(bool flag) {
            if (flag)
                DoubleBuffered = true;
            else
                DoubleBuffered = false;
        }

        public void GetClickedWindow() {
            if (GetCursorPos(out clickedPoint)) {
                IntPtr hWnd = WindowFromPoint(clickedPoint);
                if (hWnd != IntPtr.Zero) {
                    newHandle = GetAncestor(hWnd, 3);
                    GetWindowRect(newHandle, out rect);
                    windowCenterPoint = new Point(rect.Left + (rect.Right - rect.Left) / 2, rect.Top + (rect.Bottom - rect.Top) / 2);
                    this.Refresh();
                }
            }
        }

        public void SetPointFlag(bool flag) {
            drawPointFlag = flag;
            this.Refresh();
        }

        public void SetSidelineFlag(int target, bool flag) {
            drawSidelineFlags[target] = flag;
            this.Refresh();
        }

        public void SetGapFlag(bool flag) {
            this.drawGapFlag = flag;
            this.Refresh();
        }

        public void SetOutlineFlag(bool flag) {
            this.drawOutlineFlag = flag;
            this.Refresh();
        }

        public void SetColor(Color color) {
            pen.Color = color;
            brush = new SolidBrush(color);
            this.Refresh();
        }

        public void SetThickness(int thickness) {
            this.thickness = thickness;
            pen.Width = thickness;
            transparentPen.Width = thickness + 2;
            outlinePen.Width = thickness + 2;
            this.Refresh();
        }
        
        public void SetLength(int length) {
            this.length = length;
            this.Refresh();
        }

        public void SetGap(int gap) {
            this.gap = gap;
            this.Refresh();
        }
    }
}
