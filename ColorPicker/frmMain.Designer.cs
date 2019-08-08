namespace ColorPicker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCapturePixel = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblLight = new System.Windows.Forms.Label();
            this.txtRGBColorCode = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.pnlRainbowColor = new System.Windows.Forms.Panel();
            this.pnlGradient = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.pnlColorDisplay = new System.Windows.Forms.Panel();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.chkRGBA = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.topPanel.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            this.pnlColorDisplay.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::ColorPicker.Properties.Resources.icons8_Paint_Palette_48px;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(31, 32);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(34, 6);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(108, 19);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "ColorPicker";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Miriam", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(441, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCapturePixel
            // 
            this.btnCapturePixel.BackgroundImage = global::ColorPicker.Properties.Resources.icons8_Color_Dropper_64px;
            this.btnCapturePixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturePixel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCapturePixel.FlatAppearance.BorderSize = 0;
            this.btnCapturePixel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturePixel.Font = new System.Drawing.Font("Miriam", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCapturePixel.ForeColor = System.Drawing.Color.White;
            this.btnCapturePixel.Location = new System.Drawing.Point(406, 0);
            this.btnCapturePixel.Name = "btnCapturePixel";
            this.btnCapturePixel.Size = new System.Drawing.Size(35, 32);
            this.btnCapturePixel.TabIndex = 3;
            this.btnCapturePixel.UseVisualStyleBackColor = true;
            this.btnCapturePixel.Click += new System.EventHandler(this.btnCapturePixel_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.topPanel.Controls.Add(this.btnCapturePixel);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Controls.Add(this.lblAppName);
            this.topPanel.Controls.Add(this.pbIcon);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(476, 32);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06667F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.93333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayout.Controls.Add(this.lblLight, 0, 5);
            this.tableLayout.Controls.Add(this.txtRGBColorCode, 1, 6);
            this.tableLayout.Controls.Add(this.txtAlpha, 2, 4);
            this.tableLayout.Controls.Add(this.txtBlue, 2, 3);
            this.tableLayout.Controls.Add(this.txtGreen, 2, 2);
            this.tableLayout.Controls.Add(this.pnlRainbowColor, 2, 0);
            this.tableLayout.Controls.Add(this.pnlGradient, 0, 0);
            this.tableLayout.Controls.Add(this.lblRed, 0, 1);
            this.tableLayout.Controls.Add(this.lblGreen, 0, 2);
            this.tableLayout.Controls.Add(this.lblBlue, 0, 3);
            this.tableLayout.Controls.Add(this.lblAlpha, 0, 4);
            this.tableLayout.Controls.Add(this.trackBarRed, 1, 1);
            this.tableLayout.Controls.Add(this.trackBarGreen, 1, 2);
            this.tableLayout.Controls.Add(this.trackBarBlue, 1, 3);
            this.tableLayout.Controls.Add(this.trackBarAlpha, 1, 4);
            this.tableLayout.Controls.Add(this.txtRed, 2, 1);
            this.tableLayout.Controls.Add(this.pnlColorDisplay, 0, 7);
            this.tableLayout.Controls.Add(this.lblColor, 0, 6);
            this.tableLayout.Controls.Add(this.chkRGBA, 2, 6);
            this.tableLayout.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 32);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 8;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout.Size = new System.Drawing.Size(476, 523);
            this.tableLayout.TabIndex = 1;
            // 
            // lblLight
            // 
            this.lblLight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(2, 392);
            this.lblLight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(54, 19);
            this.lblLight.TabIndex = 20;
            this.lblLight.Text = "Light";
            // 
            // txtRGBColorCode
            // 
            this.txtRGBColorCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRGBColorCode.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGBColorCode.Location = new System.Drawing.Point(63, 421);
            this.txtRGBColorCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtRGBColorCode.Name = "txtRGBColorCode";
            this.txtRGBColorCode.Size = new System.Drawing.Size(295, 32);
            this.txtRGBColorCode.TabIndex = 19;
            // 
            // txtAlpha
            // 
            this.txtAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlpha.Enabled = false;
            this.txtAlpha.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlpha.Location = new System.Drawing.Point(362, 351);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(112, 32);
            this.txtAlpha.TabIndex = 14;
            // 
            // txtBlue
            // 
            this.txtBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlue.Enabled = false;
            this.txtBlue.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.Location = new System.Drawing.Point(362, 316);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(112, 32);
            this.txtBlue.TabIndex = 13;
            // 
            // txtGreen
            // 
            this.txtGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGreen.Enabled = false;
            this.txtGreen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.Location = new System.Drawing.Point(362, 281);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(112, 32);
            this.txtGreen.TabIndex = 12;
            // 
            // pnlRainbowColor
            // 
            this.pnlRainbowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRainbowColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRainbowColor.Location = new System.Drawing.Point(362, 2);
            this.pnlRainbowColor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRainbowColor.Name = "pnlRainbowColor";
            this.pnlRainbowColor.Size = new System.Drawing.Size(112, 240);
            this.pnlRainbowColor.TabIndex = 0;
            this.pnlRainbowColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRainbowColor_Paint);
            this.pnlRainbowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlRainbowColor_MouseClick);
            // 
            // pnlGradient
            // 
            this.tableLayout.SetColumnSpan(this.pnlGradient, 2);
            this.pnlGradient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGradient.Location = new System.Drawing.Point(3, 3);
            this.pnlGradient.Name = "pnlGradient";
            this.pnlGradient.Size = new System.Drawing.Size(354, 238);
            this.pnlGradient.TabIndex = 1;
            this.pnlGradient.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGradient_Paint);
            this.pnlGradient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGradient_MouseClick);
            // 
            // lblRed
            // 
            this.lblRed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(3, 252);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(36, 19);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(37)))));
            this.lblGreen.Location = new System.Drawing.Point(3, 287);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(54, 19);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBlue.Location = new System.Drawing.Point(3, 322);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(45, 19);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Text = "Blue";
            // 
            // lblAlpha
            // 
            this.lblAlpha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha.ForeColor = System.Drawing.Color.DimGray;
            this.lblAlpha.Location = new System.Drawing.Point(3, 357);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(54, 19);
            this.lblAlpha.TabIndex = 5;
            this.lblAlpha.Text = "Alpha";
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.Color.Red;
            this.trackBarRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRed.Location = new System.Drawing.Point(63, 246);
            this.trackBarRed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(295, 31);
            this.trackBarRed.TabIndex = 7;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(37)))));
            this.trackBarGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarGreen.Location = new System.Drawing.Point(63, 281);
            this.trackBarGreen.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(295, 31);
            this.trackBarGreen.TabIndex = 8;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.trackBarBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBlue.Location = new System.Drawing.Point(63, 316);
            this.trackBarBlue.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(295, 31);
            this.trackBarBlue.TabIndex = 9;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.BackColor = System.Drawing.Color.DimGray;
            this.trackBarAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarAlpha.Location = new System.Drawing.Point(63, 351);
            this.trackBarAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(295, 31);
            this.trackBarAlpha.TabIndex = 10;
            this.trackBarAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // txtRed
            // 
            this.txtRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRed.Enabled = false;
            this.txtRed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.Location = new System.Drawing.Point(362, 246);
            this.txtRed.Margin = new System.Windows.Forms.Padding(2);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(112, 32);
            this.txtRed.TabIndex = 11;
            // 
            // pnlColorDisplay
            // 
            this.pnlColorDisplay.BackColor = System.Drawing.Color.White;
            this.tableLayout.SetColumnSpan(this.pnlColorDisplay, 3);
            this.pnlColorDisplay.Controls.Add(this.lblPressEnter);
            this.pnlColorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColorDisplay.Location = new System.Drawing.Point(2, 456);
            this.pnlColorDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColorDisplay.Name = "pnlColorDisplay";
            this.pnlColorDisplay.Size = new System.Drawing.Size(472, 65);
            this.pnlColorDisplay.TabIndex = 17;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.AutoSize = true;
            this.lblPressEnter.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.ForeColor = System.Drawing.Color.White;
            this.lblPressEnter.Location = new System.Drawing.Point(15, 11);
            this.lblPressEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(439, 43);
            this.lblPressEnter.TabIndex = 0;
            this.lblPressEnter.Text = "Press Enter To Choose";
            this.lblPressEnter.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(2, 427);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 19);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // chkRGBA
            // 
            this.chkRGBA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRGBA.AutoSize = true;
            this.chkRGBA.Location = new System.Drawing.Point(362, 428);
            this.chkRGBA.Margin = new System.Windows.Forms.Padding(2);
            this.chkRGBA.Name = "chkRGBA";
            this.chkRGBA.Size = new System.Drawing.Size(56, 17);
            this.chkRGBA.TabIndex = 16;
            this.chkRGBA.Text = "RGBA";
            this.chkRGBA.UseVisualStyleBackColor = true;
            this.chkRGBA.CheckedChanged += new System.EventHandler(this.chkRGBA_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnLight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDark, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 387);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 29);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLight.Location = new System.Drawing.Point(0, 0);
            this.btnLight.Margin = new System.Windows.Forms.Padding(0);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(146, 29);
            this.btnLight.TabIndex = 1;
            this.btnLight.Text = "Light";
            this.btnLight.UseVisualStyleBackColor = false;
            this.btnLight.Click += new System.EventHandler(this.BtnLittleBitBrighter_Click);
            // 
            // btnDark
            // 
            this.btnDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDark.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDark.ForeColor = System.Drawing.Color.White;
            this.btnDark.Location = new System.Drawing.Point(146, 0);
            this.btnDark.Margin = new System.Windows.Forms.Padding(0);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(147, 29);
            this.btnDark.TabIndex = 2;
            this.btnDark.Text = "Dark";
            this.btnDark.UseVisualStyleBackColor = false;
            this.btnDark.Click += new System.EventHandler(this.BtnLittleBitDarker_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(476, 555);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            this.pnlColorDisplay.ResumeLayout(false);
            this.pnlColorDisplay.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCapturePixel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel pnlRainbowColor;
        private System.Windows.Forms.Panel pnlGradient;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.CheckBox chkRGBA;
        private System.Windows.Forms.Panel pnlColorDisplay;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.TextBox txtRGBColorCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnDark;
    }
}

