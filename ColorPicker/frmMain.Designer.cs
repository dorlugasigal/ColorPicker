﻿namespace ColorPicker
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
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.pnlRainbowColor = new System.Windows.Forms.Panel();
            this.pnlGradient = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.chkRGBA = new System.Windows.Forms.CheckBox();
            this.pnlColorDisplay = new System.Windows.Forms.Panel();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDarker = new System.Windows.Forms.Button();
            this.btnBrighter = new System.Windows.Forms.Button();
            this.btnLittleBitDarker = new System.Windows.Forms.Button();
            this.btnLittleBitBrighter = new System.Windows.Forms.Button();
            this.txtRGBColorCode = new System.Windows.Forms.TextBox();
            this.lblLight = new System.Windows.Forms.Label();
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
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(41, 39);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(44, 7);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(131, 23);
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
            this.btnExit.Location = new System.Drawing.Point(586, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 39);
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
            this.btnCapturePixel.Location = new System.Drawing.Point(539, 0);
            this.btnCapturePixel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapturePixel.Name = "btnCapturePixel";
            this.btnCapturePixel.Size = new System.Drawing.Size(47, 39);
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
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(633, 39);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
<<<<<<< HEAD
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06667F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.93333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayout.Controls.Add(this.lblLight, 0, 5);
            this.tableLayout.Controls.Add(this.txtRGBColorCode, 1, 6);
=======
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.08F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayout.Controls.Add(this.txtRGBColorCode, 1, 5);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
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
            this.tableLayout.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tableLayout.Controls.Add(this.lblColor, 0, 6);
            this.tableLayout.Controls.Add(this.chkRGBA, 2, 6);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 39);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayout.Name = "tableLayout";
<<<<<<< HEAD
            this.tableLayout.RowCount = 8;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(475, 550);
            this.tableLayout.TabIndex = 1;
            // 
=======
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayout.Size = new System.Drawing.Size(633, 624);
            this.tableLayout.TabIndex = 1;
            // 
            // txtRGBColorCode
            // 
            this.txtRGBColorCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRGBColorCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGBColorCode.Location = new System.Drawing.Point(84, 521);
            this.txtRGBColorCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRGBColorCode.Name = "txtRGBColorCode";
            this.txtRGBColorCode.Size = new System.Drawing.Size(415, 31);
            this.txtRGBColorCode.TabIndex = 15;
            this.txtRGBColorCode.TextChanged += new System.EventHandler(this.txtRGBColorCode_TextChanged);
            // 
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            // txtAlpha
            // 
            this.txtAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlpha.Enabled = false;
            this.txtAlpha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtAlpha.Location = new System.Drawing.Point(378, 393);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(94, 26);
=======
            this.txtAlpha.Location = new System.Drawing.Point(507, 484);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(122, 31);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.txtAlpha.TabIndex = 14;
            // 
            // txtBlue
            // 
            this.txtBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlue.Enabled = false;
            this.txtBlue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtBlue.Location = new System.Drawing.Point(378, 363);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(94, 26);
=======
            this.txtBlue.Location = new System.Drawing.Point(507, 447);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(122, 31);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.txtBlue.TabIndex = 13;
            // 
            // txtGreen
            // 
            this.txtGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGreen.Enabled = false;
            this.txtGreen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtGreen.Location = new System.Drawing.Point(378, 333);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(94, 26);
=======
            this.txtGreen.Location = new System.Drawing.Point(507, 410);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(122, 31);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.txtGreen.TabIndex = 12;
            // 
            // pnlRainbowColor
            // 
            this.pnlRainbowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRainbowColor.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.pnlRainbowColor.Location = new System.Drawing.Point(378, 3);
            this.pnlRainbowColor.Name = "pnlRainbowColor";
            this.pnlRainbowColor.Size = new System.Drawing.Size(94, 294);
=======
            this.pnlRainbowColor.Location = new System.Drawing.Point(507, 4);
            this.pnlRainbowColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRainbowColor.Name = "pnlRainbowColor";
            this.pnlRainbowColor.Size = new System.Drawing.Size(122, 361);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.pnlRainbowColor.TabIndex = 0;
            this.pnlRainbowColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRainbowColor_Paint);
            this.pnlRainbowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlRainbowColor_MouseClick);
            // 
            // pnlGradient
            // 
            this.tableLayout.SetColumnSpan(this.pnlGradient, 2);
            this.pnlGradient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGradient.Location = new System.Drawing.Point(4, 4);
            this.pnlGradient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGradient.Name = "pnlGradient";
<<<<<<< HEAD
            this.pnlGradient.Size = new System.Drawing.Size(369, 294);
=======
            this.pnlGradient.Size = new System.Drawing.Size(495, 361);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
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
            this.lblRed.Location = new System.Drawing.Point(4, 376);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(43, 23);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(37)))));
            this.lblGreen.Location = new System.Drawing.Point(4, 413);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(65, 23);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBlue.Location = new System.Drawing.Point(4, 450);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(54, 23);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Text = "Blue";
            // 
            // lblAlpha
            // 
            this.lblAlpha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha.ForeColor = System.Drawing.Color.DimGray;
            this.lblAlpha.Location = new System.Drawing.Point(4, 487);
            this.lblAlpha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(65, 23);
            this.lblAlpha.TabIndex = 5;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblColor.Location = new System.Drawing.Point(3, 475);
=======
            this.lblColor.Location = new System.Drawing.Point(4, 524);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(65, 23);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.Color.Red;
            this.trackBarRed.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.trackBarRed.Location = new System.Drawing.Point(67, 303);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(305, 24);
=======
            this.trackBarRed.Location = new System.Drawing.Point(84, 373);
            this.trackBarRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(415, 29);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.trackBarRed.TabIndex = 7;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(37)))));
            this.trackBarGreen.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.trackBarGreen.Location = new System.Drawing.Point(67, 333);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(305, 24);
=======
            this.trackBarGreen.Location = new System.Drawing.Point(84, 410);
            this.trackBarGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(415, 29);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.trackBarGreen.TabIndex = 8;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.trackBarBlue.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.trackBarBlue.Location = new System.Drawing.Point(67, 363);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(305, 24);
=======
            this.trackBarBlue.Location = new System.Drawing.Point(84, 447);
            this.trackBarBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(415, 29);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.trackBarBlue.TabIndex = 9;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.BackColor = System.Drawing.Color.DimGray;
            this.trackBarAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.trackBarAlpha.Location = new System.Drawing.Point(67, 393);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(305, 24);
=======
            this.trackBarAlpha.Location = new System.Drawing.Point(84, 484);
            this.trackBarAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(415, 29);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.trackBarAlpha.TabIndex = 10;
            this.trackBarAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // txtRed
            // 
            this.txtRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRed.Enabled = false;
            this.txtRed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txtRed.Location = new System.Drawing.Point(378, 303);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(94, 26);
=======
            this.txtRed.Location = new System.Drawing.Point(507, 373);
            this.txtRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(122, 31);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.txtRed.TabIndex = 11;
            // 
            // chkRGBA
            // 
            this.chkRGBA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRGBA.AutoSize = true;
<<<<<<< HEAD
            this.chkRGBA.Location = new System.Drawing.Point(378, 476);
=======
            this.chkRGBA.Location = new System.Drawing.Point(507, 525);
            this.chkRGBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.chkRGBA.Name = "chkRGBA";
            this.chkRGBA.Size = new System.Drawing.Size(69, 21);
            this.chkRGBA.TabIndex = 16;
            this.chkRGBA.Text = "RGBA";
            this.chkRGBA.UseVisualStyleBackColor = true;
            this.chkRGBA.CheckedChanged += new System.EventHandler(this.chkRGBA_CheckedChanged);
            // 
            // pnlColorDisplay
            // 
            this.pnlColorDisplay.BackColor = System.Drawing.Color.White;
            this.tableLayout.SetColumnSpan(this.pnlColorDisplay, 3);
            this.pnlColorDisplay.Controls.Add(this.lblPressEnter);
<<<<<<< HEAD
            this.pnlColorDisplay.Location = new System.Drawing.Point(3, 503);
            this.pnlColorDisplay.Name = "pnlColorDisplay";
            this.pnlColorDisplay.Size = new System.Drawing.Size(469, 44);
=======
            this.pnlColorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColorDisplay.Location = new System.Drawing.Point(4, 558);
            this.pnlColorDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlColorDisplay.Name = "pnlColorDisplay";
            this.pnlColorDisplay.Size = new System.Drawing.Size(625, 62);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.pnlColorDisplay.TabIndex = 17;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.AutoSize = true;
            this.lblPressEnter.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblPressEnter.Location = new System.Drawing.Point(52, 0);
=======
            this.lblPressEnter.Location = new System.Drawing.Point(19, 5);
            this.lblPressEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(570, 55);
            this.lblPressEnter.TabIndex = 0;
            this.lblPressEnter.Text = "Press Enter To Choose";
            this.lblPressEnter.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnLittleBitBrighter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLittleBitDarker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDarker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrighter, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 423);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 43);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnDarker
            // 
            this.btnDarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDarker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarker.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarker.ForeColor = System.Drawing.Color.White;
            this.btnDarker.Location = new System.Drawing.Point(3, 3);
            this.btnDarker.Name = "btnDarker";
            this.btnDarker.Size = new System.Drawing.Size(70, 37);
            this.btnDarker.TabIndex = 2;
            this.btnDarker.Text = "-10";
            this.btnDarker.UseVisualStyleBackColor = false;
            this.btnDarker.Click += new System.EventHandler(this.BtnDarker_Click);
            // 
            // btnBrighter
            // 
            this.btnBrighter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrighter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrighter.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrighter.Location = new System.Drawing.Point(231, 3);
            this.btnBrighter.Name = "btnBrighter";
            this.btnBrighter.Size = new System.Drawing.Size(71, 37);
            this.btnBrighter.TabIndex = 0;
            this.btnBrighter.Text = "+10";
            this.btnBrighter.UseVisualStyleBackColor = false;
            this.btnBrighter.Click += new System.EventHandler(this.BtnBrighter_Click);
            // 
            // btnLittleBitDarker
            // 
            this.btnLittleBitDarker.BackColor = System.Drawing.Color.Gray;
            this.btnLittleBitDarker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLittleBitDarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLittleBitDarker.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLittleBitDarker.ForeColor = System.Drawing.Color.White;
            this.btnLittleBitDarker.Location = new System.Drawing.Point(79, 3);
            this.btnLittleBitDarker.Name = "btnLittleBitDarker";
            this.btnLittleBitDarker.Size = new System.Drawing.Size(70, 37);
            this.btnLittleBitDarker.TabIndex = 3;
            this.btnLittleBitDarker.Text = "-1";
            this.btnLittleBitDarker.UseVisualStyleBackColor = false;
            this.btnLittleBitDarker.Click += new System.EventHandler(this.BtnLittleBitDarker_Click);
            // 
            // btnLittleBitBrighter
            // 
            this.btnLittleBitBrighter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLittleBitBrighter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLittleBitBrighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLittleBitBrighter.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLittleBitBrighter.Location = new System.Drawing.Point(155, 3);
            this.btnLittleBitBrighter.Name = "btnLittleBitBrighter";
            this.btnLittleBitBrighter.Size = new System.Drawing.Size(70, 37);
            this.btnLittleBitBrighter.TabIndex = 4;
            this.btnLittleBitBrighter.Text = "+1";
            this.btnLittleBitBrighter.UseVisualStyleBackColor = false;
            this.btnLittleBitBrighter.Click += new System.EventHandler(this.BtnLittleBitBrighter_Click);
            // 
            // txtRGBColorCode
            // 
            this.txtRGBColorCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGBColorCode.Location = new System.Drawing.Point(67, 472);
            this.txtRGBColorCode.Name = "txtRGBColorCode";
            this.txtRGBColorCode.Size = new System.Drawing.Size(305, 26);
            this.txtRGBColorCode.TabIndex = 19;
            // 
            // lblLight
            // 
            this.lblLight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(3, 435);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(54, 19);
            this.lblLight.TabIndex = 20;
            this.lblLight.Text = "Light";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(475, 582);
=======
            this.ClientSize = new System.Drawing.Size(633, 663);
>>>>>>> 492d12dde527ee0fca4382b3e6c96ee470396a8c
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDarker;
        private System.Windows.Forms.Button btnBrighter;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.TextBox txtRGBColorCode;
        private System.Windows.Forms.Button btnLittleBitBrighter;
        private System.Windows.Forms.Button btnLittleBitDarker;
    }
}

