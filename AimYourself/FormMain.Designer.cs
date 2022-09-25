namespace AimYourself
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.setDoubleBufferedCheckBox = new System.Windows.Forms.CheckBox();
            this.pointFlag = new System.Windows.Forms.CheckBox();
            this.upSidelineFlag = new System.Windows.Forms.CheckBox();
            this.leftSidelineFlag = new System.Windows.Forms.CheckBox();
            this.rightSidelineFlag = new System.Windows.Forms.CheckBox();
            this.downSidelineFlag = new System.Windows.Forms.CheckBox();
            this.arrowGroupBox = new System.Windows.Forms.GroupBox();
            this.outlineFlag = new System.Windows.Forms.CheckBox();
            this.selectColor = new System.Windows.Forms.Button();
            this.colorContainer = new System.Windows.Forms.Label();
            this.gapFlag = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.gapUpDown = new System.Windows.Forms.NumericUpDown();
            this.thicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arrowGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setDoubleBufferedCheckBox
            // 
            this.setDoubleBufferedCheckBox.AutoSize = true;
            this.setDoubleBufferedCheckBox.Location = new System.Drawing.Point(5, 134);
            this.setDoubleBufferedCheckBox.Name = "setDoubleBufferedCheckBox";
            this.setDoubleBufferedCheckBox.Size = new System.Drawing.Size(127, 28);
            this.setDoubleBufferedCheckBox.TabIndex = 1;
            this.setDoubleBufferedCheckBox.Text = "DoubleBuffered\r\n(If screen flickers)";
            this.setDoubleBufferedCheckBox.UseVisualStyleBackColor = true;
            this.setDoubleBufferedCheckBox.CheckedChanged += new System.EventHandler(this.setDoubleBufferedCheckBox_CheckedChanged);
            // 
            // pointFlag
            // 
            this.pointFlag.AutoSize = true;
            this.pointFlag.Checked = true;
            this.pointFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pointFlag.Location = new System.Drawing.Point(30, 35);
            this.pointFlag.Name = "pointFlag";
            this.pointFlag.Size = new System.Drawing.Size(15, 14);
            this.pointFlag.TabIndex = 2;
            this.pointFlag.UseVisualStyleBackColor = true;
            this.pointFlag.CheckedChanged += new System.EventHandler(this.pointFlag_CheckedChanged);
            // 
            // upSidelineFlag
            // 
            this.upSidelineFlag.AutoSize = true;
            this.upSidelineFlag.Checked = true;
            this.upSidelineFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upSidelineFlag.Location = new System.Drawing.Point(30, 15);
            this.upSidelineFlag.Name = "upSidelineFlag";
            this.upSidelineFlag.Size = new System.Drawing.Size(15, 14);
            this.upSidelineFlag.TabIndex = 3;
            this.upSidelineFlag.UseVisualStyleBackColor = true;
            this.upSidelineFlag.CheckedChanged += new System.EventHandler(this.upSidelineFlag_CheckedChanged);
            // 
            // leftSidelineFlag
            // 
            this.leftSidelineFlag.AutoSize = true;
            this.leftSidelineFlag.Checked = true;
            this.leftSidelineFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftSidelineFlag.Location = new System.Drawing.Point(9, 35);
            this.leftSidelineFlag.Name = "leftSidelineFlag";
            this.leftSidelineFlag.Size = new System.Drawing.Size(15, 14);
            this.leftSidelineFlag.TabIndex = 4;
            this.leftSidelineFlag.UseVisualStyleBackColor = true;
            this.leftSidelineFlag.CheckedChanged += new System.EventHandler(this.leftSidelineFlag_CheckedChanged);
            // 
            // rightSidelineFlag
            // 
            this.rightSidelineFlag.AutoSize = true;
            this.rightSidelineFlag.Checked = true;
            this.rightSidelineFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightSidelineFlag.Location = new System.Drawing.Point(51, 35);
            this.rightSidelineFlag.Name = "rightSidelineFlag";
            this.rightSidelineFlag.Size = new System.Drawing.Size(15, 14);
            this.rightSidelineFlag.TabIndex = 5;
            this.rightSidelineFlag.UseVisualStyleBackColor = true;
            this.rightSidelineFlag.CheckedChanged += new System.EventHandler(this.rightSidelineFlag_CheckedChanged);
            // 
            // downSidelineFlag
            // 
            this.downSidelineFlag.AutoSize = true;
            this.downSidelineFlag.Checked = true;
            this.downSidelineFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downSidelineFlag.Location = new System.Drawing.Point(30, 55);
            this.downSidelineFlag.Name = "downSidelineFlag";
            this.downSidelineFlag.Size = new System.Drawing.Size(15, 14);
            this.downSidelineFlag.TabIndex = 6;
            this.downSidelineFlag.UseVisualStyleBackColor = true;
            this.downSidelineFlag.CheckedChanged += new System.EventHandler(this.downSidelineFlag_CheckedChanged);
            // 
            // arrowGroupBox
            // 
            this.arrowGroupBox.Controls.Add(this.upSidelineFlag);
            this.arrowGroupBox.Controls.Add(this.downSidelineFlag);
            this.arrowGroupBox.Controls.Add(this.pointFlag);
            this.arrowGroupBox.Controls.Add(this.rightSidelineFlag);
            this.arrowGroupBox.Controls.Add(this.leftSidelineFlag);
            this.arrowGroupBox.Location = new System.Drawing.Point(138, 9);
            this.arrowGroupBox.Name = "arrowGroupBox";
            this.arrowGroupBox.Size = new System.Drawing.Size(73, 75);
            this.arrowGroupBox.TabIndex = 7;
            this.arrowGroupBox.TabStop = false;
            this.arrowGroupBox.Text = "Show";
            // 
            // outlineFlag
            // 
            this.outlineFlag.AutoSize = true;
            this.outlineFlag.Checked = true;
            this.outlineFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outlineFlag.Location = new System.Drawing.Point(12, 82);
            this.outlineFlag.Name = "outlineFlag";
            this.outlineFlag.Size = new System.Drawing.Size(96, 16);
            this.outlineFlag.TabIndex = 8;
            this.outlineFlag.Text = "Draw Outline";
            this.outlineFlag.UseVisualStyleBackColor = true;
            this.outlineFlag.CheckedChanged += new System.EventHandler(this.outlineFlag_CheckedChanged);
            // 
            // selectColor
            // 
            this.selectColor.Location = new System.Drawing.Point(3, 104);
            this.selectColor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.selectColor.Name = "selectColor";
            this.selectColor.Size = new System.Drawing.Size(73, 23);
            this.selectColor.TabIndex = 10;
            this.selectColor.Text = "Pick Color";
            this.selectColor.UseVisualStyleBackColor = true;
            this.selectColor.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colorContainer
            // 
            this.colorContainer.BackColor = System.Drawing.Color.Red;
            this.colorContainer.Location = new System.Drawing.Point(82, 104);
            this.colorContainer.Name = "colorContainer";
            this.colorContainer.Size = new System.Drawing.Size(50, 23);
            this.colorContainer.TabIndex = 11;
            // 
            // gapFlag
            // 
            this.gapFlag.Checked = true;
            this.gapFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gapFlag.Location = new System.Drawing.Point(12, 55);
            this.gapFlag.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gapFlag.Name = "gapFlag";
            this.gapFlag.Size = new System.Drawing.Size(64, 21);
            this.gapFlag.TabIndex = 17;
            this.gapFlag.Text = "Gap";
            this.gapFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gapFlag.UseVisualStyleBackColor = true;
            this.gapFlag.CheckedChanged += new System.EventHandler(this.gapFlag_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Aim Yourself minimized";
            this.notifyIcon.BalloonTipTitle = "[Balloon Title when Minimized]";
            this.notifyIcon.Text = "Aim Yourself";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(82, 9);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(50, 21);
            this.lengthUpDown.TabIndex = 19;
            this.lengthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lengthUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lengthUpDown.ValueChanged += new System.EventHandler(this.lengthUpDown_ValueChanged);
            // 
            // gapUpDown
            // 
            this.gapUpDown.Location = new System.Drawing.Point(82, 55);
            this.gapUpDown.Name = "gapUpDown";
            this.gapUpDown.Size = new System.Drawing.Size(50, 21);
            this.gapUpDown.TabIndex = 20;
            this.gapUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gapUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gapUpDown.ValueChanged += new System.EventHandler(this.gapUpDown_ValueChanged);
            // 
            // thicknessUpDown
            // 
            this.thicknessUpDown.Location = new System.Drawing.Point(82, 32);
            this.thicknessUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessUpDown.Name = "thicknessUpDown";
            this.thicknessUpDown.Size = new System.Drawing.Size(50, 21);
            this.thicknessUpDown.TabIndex = 21;
            this.thicknessUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.thicknessUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessUpDown.ValueChanged += new System.EventHandler(this.thicknessUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thickness";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thicknessUpDown);
            this.Controls.Add(this.gapUpDown);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.gapFlag);
            this.Controls.Add(this.colorContainer);
            this.Controls.Add(this.selectColor);
            this.Controls.Add(this.outlineFlag);
            this.Controls.Add(this.arrowGroupBox);
            this.Controls.Add(this.setDoubleBufferedCheckBox);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Aim Yourself";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.arrowGroupBox.ResumeLayout(false);
            this.arrowGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox setDoubleBufferedCheckBox;
        private System.Windows.Forms.CheckBox pointFlag;
        private System.Windows.Forms.CheckBox upSidelineFlag;
        private System.Windows.Forms.CheckBox leftSidelineFlag;
        private System.Windows.Forms.CheckBox rightSidelineFlag;
        private System.Windows.Forms.CheckBox downSidelineFlag;
        private System.Windows.Forms.GroupBox arrowGroupBox;
        private System.Windows.Forms.CheckBox outlineFlag;
        private System.Windows.Forms.Button selectColor;
        private System.Windows.Forms.Label colorContainer;
        private System.Windows.Forms.CheckBox gapFlag;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.NumericUpDown gapUpDown;
        private System.Windows.Forms.NumericUpDown thicknessUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

