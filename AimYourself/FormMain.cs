using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AimYourself {
    public partial class FormMain : Form {
        FormOverlay formOverlay = new FormOverlay();

        public Color pickedColor;
        public decimal savedGapValue;

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.notifyIcon.Icon = SystemIcons.Application;
            this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Aim Yourself minimized";
            this.notifyIcon.BalloonTipTitle = "Aim Yourself";
            this.notifyIcon.Text = "Aim Yourself";

            this.lengthUpDown.Value = Properties.Settings.Default.length;
            this.thicknessUpDown.Value = Properties.Settings.Default.thickness;
            this.gapUpDown.Value = Properties.Settings.Default.gap;

            this.gapFlag.Checked = Properties.Settings.Default.drawGapFlag;
            this.outlineFlag.Checked = Properties.Settings.Default.drawOutlineFlag;
            this.pointFlag.Checked = Properties.Settings.Default.drawPointFlag;

            this.upSidelineFlag.Checked = Properties.Settings.Default.drawSidelineFlags0;
            this.downSidelineFlag.Checked = Properties.Settings.Default.drawSidelineFlags1;
            this.leftSidelineFlag.Checked = Properties.Settings.Default.drawSidelineFlags2;
            this.rightSidelineFlag.Checked = Properties.Settings.Default.drawSidelineFlags3;

            this.colorContainer.BackColor = Properties.Settings.Default.color;
            this.setDoubleBufferedCheckBox.Checked = Properties.Settings.Default.doubleBuffered;


            formOverlay.Show();
        }

        private void setDoubleBufferedCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (setDoubleBufferedCheckBox.Checked == true) {
                formOverlay.SetDoubleBuffered(true);
                Properties.Settings.Default.doubleBuffered = true;
            }
            else {
                formOverlay.SetDoubleBuffered(false);
                Properties.Settings.Default.doubleBuffered = false;
            }
            Properties.Settings.Default.Save();
        }

        private void pointFlag_CheckedChanged(object sender, EventArgs e) {
            if (pointFlag.Checked == true) {
                formOverlay.SetPointFlag(true);
                Properties.Settings.Default.drawPointFlag = true;
            }
            else {
                formOverlay.SetPointFlag(false);
                Properties.Settings.Default.drawPointFlag = false;
            }
            Properties.Settings.Default.Save();
        }

        private void upSidelineFlag_CheckedChanged(object sender, EventArgs e) {
            if (upSidelineFlag.Checked == true) {
                formOverlay.SetSidelineFlag(0, true);
                Properties.Settings.Default.drawSidelineFlags0 = true;
            }
            else {
                formOverlay.SetSidelineFlag(0, false);
                Properties.Settings.Default.drawSidelineFlags0 = false;
            }
            Properties.Settings.Default.Save();
        }

        private void downSidelineFlag_CheckedChanged(object sender, EventArgs e) {
            if (downSidelineFlag.Checked == true) {
                formOverlay.SetSidelineFlag(1, true);
                Properties.Settings.Default.drawSidelineFlags1 = true;
            }
            else {
                formOverlay.SetSidelineFlag(1, false);
                Properties.Settings.Default.drawSidelineFlags1 = false;
            }
            Properties.Settings.Default.Save();
        }

        private void leftSidelineFlag_CheckedChanged(object sender, EventArgs e) {
            if (leftSidelineFlag.Checked == true) {
                formOverlay.SetSidelineFlag(2, true);
                Properties.Settings.Default.drawSidelineFlags2 = true;
            }
            else {
                formOverlay.SetSidelineFlag(2, false);
                Properties.Settings.Default.drawSidelineFlags2 = false;
            }
            Properties.Settings.Default.Save();
        }

        private void rightSidelineFlag_CheckedChanged(object sender, EventArgs e) {
            if (rightSidelineFlag.Checked == true) {
                formOverlay.SetSidelineFlag(3, true);
                Properties.Settings.Default.drawSidelineFlags3 = true;
            }
            else {
                formOverlay.SetSidelineFlag(3, false);
                Properties.Settings.Default.drawSidelineFlags3 = false;
            }
            Properties.Settings.Default.Save();
        }

        private void selectColor_Click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                colorContainer.BackColor = dlg.Color;
                Properties.Settings.Default.color = dlg.Color;
                formOverlay.SetColor(dlg.Color);
                Properties.Settings.Default.Save();
            }
        }

        private void gapFlag_CheckedChanged(object sender, EventArgs e) {
            if (gapFlag.Checked == true) {
                gapUpDown.Enabled = true;
                gapUpDown.Value = savedGapValue;
                formOverlay.SetGapFlag(true);
                Properties.Settings.Default.drawGapFlag = true;
            }
            else {
                gapUpDown.Enabled = false;
                savedGapValue = gapUpDown.Value;
                gapUpDown.Value = 0;
                formOverlay.SetGapFlag(false);
                Properties.Settings.Default.drawGapFlag = false;
            }
            Properties.Settings.Default.Save();
        }

        private void outlineFlag_CheckedChanged(object sender, EventArgs e) {
            if (outlineFlag.Checked == true) {
                formOverlay.SetOutlineFlag(true);
                Properties.Settings.Default.drawOutlineFlag = true;
            }
            else {
                formOverlay.SetOutlineFlag(false);
                Properties.Settings.Default.drawOutlineFlag = false;
            }
            Properties.Settings.Default.Save();
        }

        private void FormMain_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;

                int initialStyle = GetWindowLong(this.Handle, -20);
                SetWindowLong(this.Handle, -20, initialStyle | 0x80);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void lengthUpDown_ValueChanged(object sender, EventArgs e) {
            formOverlay.SetLength((int) lengthUpDown.Value);
            Properties.Settings.Default.length = (int) lengthUpDown.Value;
            Properties.Settings.Default.Save();
        }

        private void thicknessUpDown_ValueChanged(object sender, EventArgs e) {
            formOverlay.SetThickness((int)thicknessUpDown.Value);
            Properties.Settings.Default.thickness = (int) thicknessUpDown.Value;
            Properties.Settings.Default.Save();
        }

        private void gapUpDown_ValueChanged(object sender, EventArgs e) {
            formOverlay.SetGap((int)gapUpDown.Value);
            Properties.Settings.Default.gap = (int) gapUpDown.Value;
            Properties.Settings.Default.Save();
        }
    }
}
