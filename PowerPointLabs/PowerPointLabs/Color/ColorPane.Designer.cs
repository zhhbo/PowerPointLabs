﻿namespace PowerPointLabs
{
    partial class ColorPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AnalogousColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.AnalogousLighter = new System.Windows.Forms.Panel();
            this.AnalogousSelected = new System.Windows.Forms.Panel();
            this.AnalogousDarker = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComplementaryLighter = new System.Windows.Forms.Panel();
            this.ComplementarySelected = new System.Windows.Forms.Panel();
            this.ComplementaryDarker = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.TriadicLower = new System.Windows.Forms.Panel();
            this.TriadicSelected = new System.Windows.Forms.Panel();
            this.TriadicHigher = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.Tetradic1 = new System.Windows.Forms.Panel();
            this.TetradicSelected = new System.Windows.Forms.Panel();
            this.Tetradic2 = new System.Windows.Forms.Panel();
            this.Tetradic3 = new System.Windows.Forms.Panel();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.brightnessPanel = new System.Windows.Forms.Panel();
            this.saturationPanel = new System.Windows.Forms.Panel();
            this.saturationBar = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.MonoPanel1 = new System.Windows.Forms.Panel();
            this.MonoPanel2 = new System.Windows.Forms.Panel();
            this.MonoPanel3 = new System.Windows.Forms.Panel();
            this.MonoPanel4 = new System.Windows.Forms.Panel();
            this.MonoPanel5 = new System.Windows.Forms.Panel();
            this.MonoPanel6 = new System.Windows.Forms.Panel();
            this.MonoPanel7 = new System.Windows.Forms.Panel();
            this.themeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.ThemePanel1 = new System.Windows.Forms.Panel();
            this.ThemePanel2 = new System.Windows.Forms.Panel();
            this.ThemePanel3 = new System.Windows.Forms.Panel();
            this.ThemePanel4 = new System.Windows.Forms.Panel();
            this.ThemePanel5 = new System.Windows.Forms.Panel();
            this.ThemePanel6 = new System.Windows.Forms.Panel();
            this.ThemePanel7 = new System.Windows.Forms.Panel();
            this.ThemePanel8 = new System.Windows.Forms.Panel();
            this.ThemePanel9 = new System.Windows.Forms.Panel();
            this.SaveThemeButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ResetThemeButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EditColorButton = new System.Windows.Forms.Button();
            this.FillEyeDropperButton = new System.Windows.Forms.Button();
            this.LineEyeDropperButton = new System.Windows.Forms.Button();
            this.FontEyeDropperButton = new System.Windows.Forms.Button();
            this.AnalogousColorPanel.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.themeLayoutPanel.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 47);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // AnalogousColorPanel
            // 
            this.AnalogousColorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AnalogousColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousColorPanel.Controls.Add(this.label1);
            this.AnalogousColorPanel.Controls.Add(this.flowLayoutPanel6);
            this.AnalogousColorPanel.Location = new System.Drawing.Point(20, 309);
            this.AnalogousColorPanel.Name = "AnalogousColorPanel";
            this.AnalogousColorPanel.Size = new System.Drawing.Size(124, 76);
            this.AnalogousColorPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Analogous Colors";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.AnalogousLighter);
            this.flowLayoutPanel6.Controls.Add(this.AnalogousSelected);
            this.flowLayoutPanel6.Controls.Add(this.AnalogousDarker);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(85, 26);
            this.flowLayoutPanel6.TabIndex = 12;
            // 
            // AnalogousLighter
            // 
            this.AnalogousLighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousLighter.Location = new System.Drawing.Point(3, 3);
            this.AnalogousLighter.Name = "AnalogousLighter";
            this.AnalogousLighter.Size = new System.Drawing.Size(20, 20);
            this.AnalogousLighter.TabIndex = 2;
            this.AnalogousLighter.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.AnalogousLighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.AnalogousLighter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // AnalogousSelected
            // 
            this.AnalogousSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousSelected.Location = new System.Drawing.Point(29, 3);
            this.AnalogousSelected.Name = "AnalogousSelected";
            this.AnalogousSelected.Size = new System.Drawing.Size(20, 20);
            this.AnalogousSelected.TabIndex = 3;
            this.AnalogousSelected.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.AnalogousSelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.AnalogousSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // AnalogousDarker
            // 
            this.AnalogousDarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogousDarker.Location = new System.Drawing.Point(55, 3);
            this.AnalogousDarker.Name = "AnalogousDarker";
            this.AnalogousDarker.Size = new System.Drawing.Size(20, 20);
            this.AnalogousDarker.TabIndex = 4;
            this.AnalogousDarker.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.AnalogousDarker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.AnalogousDarker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(150, 309);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(143, 76);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Complementary Colors";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.ComplementaryLighter);
            this.flowLayoutPanel7.Controls.Add(this.ComplementarySelected);
            this.flowLayoutPanel7.Controls.Add(this.ComplementaryDarker);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(120, 26);
            this.flowLayoutPanel7.TabIndex = 13;
            // 
            // ComplementaryLighter
            // 
            this.ComplementaryLighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementaryLighter.Location = new System.Drawing.Point(3, 3);
            this.ComplementaryLighter.Name = "ComplementaryLighter";
            this.ComplementaryLighter.Size = new System.Drawing.Size(20, 20);
            this.ComplementaryLighter.TabIndex = 2;
            this.ComplementaryLighter.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.ComplementaryLighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.ComplementaryLighter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // ComplementarySelected
            // 
            this.ComplementarySelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementarySelected.Location = new System.Drawing.Point(29, 3);
            this.ComplementarySelected.Name = "ComplementarySelected";
            this.ComplementarySelected.Size = new System.Drawing.Size(20, 20);
            this.ComplementarySelected.TabIndex = 3;
            this.ComplementarySelected.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.ComplementarySelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.ComplementarySelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // ComplementaryDarker
            // 
            this.ComplementaryDarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComplementaryDarker.Location = new System.Drawing.Point(55, 3);
            this.ComplementaryDarker.Name = "ComplementaryDarker";
            this.ComplementaryDarker.Size = new System.Drawing.Size(20, 20);
            this.ComplementaryDarker.TabIndex = 4;
            this.ComplementaryDarker.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.ComplementaryDarker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.ComplementaryDarker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(20, 391);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(124, 64);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triadic Colors";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.TriadicLower);
            this.flowLayoutPanel8.Controls.Add(this.TriadicSelected);
            this.flowLayoutPanel8.Controls.Add(this.TriadicHigher);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(85, 26);
            this.flowLayoutPanel8.TabIndex = 14;
            // 
            // TriadicLower
            // 
            this.TriadicLower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicLower.Location = new System.Drawing.Point(3, 3);
            this.TriadicLower.Name = "TriadicLower";
            this.TriadicLower.Size = new System.Drawing.Size(20, 20);
            this.TriadicLower.TabIndex = 2;
            this.TriadicLower.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.TriadicLower.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.TriadicLower.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // TriadicSelected
            // 
            this.TriadicSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicSelected.Location = new System.Drawing.Point(29, 3);
            this.TriadicSelected.Name = "TriadicSelected";
            this.TriadicSelected.Size = new System.Drawing.Size(20, 20);
            this.TriadicSelected.TabIndex = 3;
            this.TriadicSelected.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.TriadicSelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.TriadicSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // TriadicHigher
            // 
            this.TriadicHigher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadicHigher.Location = new System.Drawing.Point(55, 3);
            this.TriadicHigher.Name = "TriadicHigher";
            this.TriadicHigher.Size = new System.Drawing.Size(20, 20);
            this.TriadicHigher.TabIndex = 4;
            this.TriadicHigher.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.TriadicHigher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.TriadicHigher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(150, 391);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(143, 64);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tetradic Colors";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.Tetradic1);
            this.flowLayoutPanel9.Controls.Add(this.TetradicSelected);
            this.flowLayoutPanel9.Controls.Add(this.Tetradic2);
            this.flowLayoutPanel9.Controls.Add(this.Tetradic3);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(104, 26);
            this.flowLayoutPanel9.TabIndex = 15;
            // 
            // Tetradic1
            // 
            this.Tetradic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic1.Location = new System.Drawing.Point(3, 3);
            this.Tetradic1.Name = "Tetradic1";
            this.Tetradic1.Size = new System.Drawing.Size(20, 20);
            this.Tetradic1.TabIndex = 3;
            this.Tetradic1.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.Tetradic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.Tetradic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // TetradicSelected
            // 
            this.TetradicSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TetradicSelected.Location = new System.Drawing.Point(29, 3);
            this.TetradicSelected.Name = "TetradicSelected";
            this.TetradicSelected.Size = new System.Drawing.Size(20, 20);
            this.TetradicSelected.TabIndex = 4;
            this.TetradicSelected.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.TetradicSelected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.TetradicSelected.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // Tetradic2
            // 
            this.Tetradic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic2.Location = new System.Drawing.Point(55, 3);
            this.Tetradic2.Name = "Tetradic2";
            this.Tetradic2.Size = new System.Drawing.Size(20, 20);
            this.Tetradic2.TabIndex = 5;
            this.Tetradic2.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.Tetradic2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.Tetradic2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // Tetradic3
            // 
            this.Tetradic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tetradic3.Location = new System.Drawing.Point(81, 3);
            this.Tetradic3.Name = "Tetradic3";
            this.Tetradic3.Size = new System.Drawing.Size(20, 20);
            this.Tetradic3.TabIndex = 6;
            this.Tetradic3.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.Tetradic3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.Tetradic3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(26, 116);
            this.brightnessBar.Maximum = 240;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(256, 45);
            this.brightnessBar.TabIndex = 6;
            this.brightnessBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.brightnessBar.ValueChanged += new System.EventHandler(this.brightnessBar_ValueChanged);
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brightnessPanel.Location = new System.Drawing.Point(34, 99);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.Size = new System.Drawing.Size(240, 25);
            this.brightnessPanel.TabIndex = 7;
            // 
            // saturationPanel
            // 
            this.saturationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saturationPanel.Location = new System.Drawing.Point(34, 178);
            this.saturationPanel.Name = "saturationPanel";
            this.saturationPanel.Size = new System.Drawing.Size(240, 25);
            this.saturationPanel.TabIndex = 9;
            // 
            // saturationBar
            // 
            this.saturationBar.Location = new System.Drawing.Point(26, 194);
            this.saturationBar.Maximum = 240;
            this.saturationBar.Name = "saturationBar";
            this.saturationBar.Size = new System.Drawing.Size(256, 45);
            this.saturationBar.TabIndex = 8;
            this.saturationBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.saturationBar.ValueChanged += new System.EventHandler(this.saturationBar_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 245);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 58);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monochromatic Colors";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel1);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel2);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel3);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel4);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel5);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel6);
            this.flowLayoutPanel5.Controls.Add(this.MonoPanel7);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(255, 26);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // MonoPanel1
            // 
            this.MonoPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel1.Location = new System.Drawing.Point(3, 3);
            this.MonoPanel1.Name = "MonoPanel1";
            this.MonoPanel1.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel1.TabIndex = 0;
            this.MonoPanel1.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel2
            // 
            this.MonoPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel2.Location = new System.Drawing.Point(29, 3);
            this.MonoPanel2.Name = "MonoPanel2";
            this.MonoPanel2.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel2.TabIndex = 1;
            this.MonoPanel2.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel3
            // 
            this.MonoPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel3.Location = new System.Drawing.Point(55, 3);
            this.MonoPanel3.Name = "MonoPanel3";
            this.MonoPanel3.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel3.TabIndex = 1;
            this.MonoPanel3.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel4
            // 
            this.MonoPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel4.Location = new System.Drawing.Point(81, 3);
            this.MonoPanel4.Name = "MonoPanel4";
            this.MonoPanel4.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel4.TabIndex = 2;
            this.MonoPanel4.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel5
            // 
            this.MonoPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel5.Location = new System.Drawing.Point(107, 3);
            this.MonoPanel5.Name = "MonoPanel5";
            this.MonoPanel5.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel5.TabIndex = 3;
            this.MonoPanel5.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel6
            // 
            this.MonoPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel6.Location = new System.Drawing.Point(133, 3);
            this.MonoPanel6.Name = "MonoPanel6";
            this.MonoPanel6.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel6.TabIndex = 4;
            this.MonoPanel6.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // MonoPanel7
            // 
            this.MonoPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonoPanel7.Location = new System.Drawing.Point(159, 3);
            this.MonoPanel7.Name = "MonoPanel7";
            this.MonoPanel7.Size = new System.Drawing.Size(20, 20);
            this.MonoPanel7.TabIndex = 5;
            this.MonoPanel7.Click += new System.EventHandler(this.MatchingPanel_Click);
            this.MonoPanel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseDown);
            this.MonoPanel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MatchingPanel_MouseMove);
            // 
            // themeLayoutPanel
            // 
            this.themeLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.themeLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeLayoutPanel.Controls.Add(this.label6);
            this.themeLayoutPanel.Controls.Add(this.flowLayoutPanel11);
            this.themeLayoutPanel.Controls.Add(this.SaveThemeButton);
            this.themeLayoutPanel.Controls.Add(this.LoadButton);
            this.themeLayoutPanel.Controls.Add(this.ResetThemeButton);
            this.themeLayoutPanel.Location = new System.Drawing.Point(20, 461);
            this.themeLayoutPanel.Name = "themeLayoutPanel";
            this.themeLayoutPanel.Size = new System.Drawing.Size(273, 111);
            this.themeLayoutPanel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Theme Colors";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel1);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel2);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel3);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel4);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel5);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel6);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel7);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel8);
            this.flowLayoutPanel11.Controls.Add(this.ThemePanel9);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(255, 26);
            this.flowLayoutPanel11.TabIndex = 15;
            // 
            // ThemePanel1
            // 
            this.ThemePanel1.AllowDrop = true;
            this.ThemePanel1.BackColor = System.Drawing.Color.White;
            this.ThemePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel1.Location = new System.Drawing.Point(3, 3);
            this.ThemePanel1.Name = "ThemePanel1";
            this.ThemePanel1.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel1.TabIndex = 3;
            this.ThemePanel1.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel2
            // 
            this.ThemePanel2.AllowDrop = true;
            this.ThemePanel2.BackColor = System.Drawing.Color.White;
            this.ThemePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel2.Location = new System.Drawing.Point(29, 3);
            this.ThemePanel2.Name = "ThemePanel2";
            this.ThemePanel2.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel2.TabIndex = 4;
            this.ThemePanel2.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel3
            // 
            this.ThemePanel3.AllowDrop = true;
            this.ThemePanel3.BackColor = System.Drawing.Color.White;
            this.ThemePanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel3.Location = new System.Drawing.Point(55, 3);
            this.ThemePanel3.Name = "ThemePanel3";
            this.ThemePanel3.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel3.TabIndex = 5;
            this.ThemePanel3.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel4
            // 
            this.ThemePanel4.AllowDrop = true;
            this.ThemePanel4.BackColor = System.Drawing.Color.White;
            this.ThemePanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel4.Location = new System.Drawing.Point(81, 3);
            this.ThemePanel4.Name = "ThemePanel4";
            this.ThemePanel4.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel4.TabIndex = 6;
            this.ThemePanel4.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel4.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel4.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel5
            // 
            this.ThemePanel5.AllowDrop = true;
            this.ThemePanel5.BackColor = System.Drawing.Color.White;
            this.ThemePanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel5.Location = new System.Drawing.Point(107, 3);
            this.ThemePanel5.Name = "ThemePanel5";
            this.ThemePanel5.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel5.TabIndex = 7;
            this.ThemePanel5.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel5.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel5.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel6
            // 
            this.ThemePanel6.AllowDrop = true;
            this.ThemePanel6.BackColor = System.Drawing.Color.White;
            this.ThemePanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel6.Location = new System.Drawing.Point(133, 3);
            this.ThemePanel6.Name = "ThemePanel6";
            this.ThemePanel6.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel6.TabIndex = 8;
            this.ThemePanel6.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel6.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel6.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel7
            // 
            this.ThemePanel7.AllowDrop = true;
            this.ThemePanel7.BackColor = System.Drawing.Color.White;
            this.ThemePanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel7.Location = new System.Drawing.Point(159, 3);
            this.ThemePanel7.Name = "ThemePanel7";
            this.ThemePanel7.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel7.TabIndex = 9;
            this.ThemePanel7.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel7.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel7.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel8
            // 
            this.ThemePanel8.AllowDrop = true;
            this.ThemePanel8.BackColor = System.Drawing.Color.White;
            this.ThemePanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel8.Location = new System.Drawing.Point(185, 3);
            this.ThemePanel8.Name = "ThemePanel8";
            this.ThemePanel8.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel8.TabIndex = 10;
            this.ThemePanel8.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel8.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel8.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // ThemePanel9
            // 
            this.ThemePanel9.AllowDrop = true;
            this.ThemePanel9.BackColor = System.Drawing.Color.White;
            this.ThemePanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemePanel9.Location = new System.Drawing.Point(211, 3);
            this.ThemePanel9.Name = "ThemePanel9";
            this.ThemePanel9.Size = new System.Drawing.Size(20, 20);
            this.ThemePanel9.TabIndex = 11;
            this.ThemePanel9.Click += new System.EventHandler(this.ThemePanel_Click);
            this.ThemePanel9.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.ThemePanel9.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // SaveThemeButton
            // 
            this.SaveThemeButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.save_icon;
            this.SaveThemeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveThemeButton.Location = new System.Drawing.Point(3, 51);
            this.SaveThemeButton.Name = "SaveThemeButton";
            this.SaveThemeButton.Size = new System.Drawing.Size(49, 47);
            this.SaveThemeButton.TabIndex = 16;
            this.SaveThemeButton.UseVisualStyleBackColor = true;
            this.SaveThemeButton.Click += new System.EventHandler(this.SaveThemeButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.down_icon;
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadButton.Location = new System.Drawing.Point(58, 51);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(49, 47);
            this.LoadButton.TabIndex = 17;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ResetThemeButton
            // 
            this.ResetThemeButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.delete_icon;
            this.ResetThemeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ResetThemeButton.Location = new System.Drawing.Point(113, 51);
            this.ResetThemeButton.Name = "ResetThemeButton";
            this.ResetThemeButton.Size = new System.Drawing.Size(49, 47);
            this.ResetThemeButton.TabIndex = 18;
            this.ResetThemeButton.UseVisualStyleBackColor = true;
            this.ResetThemeButton.Click += new System.EventHandler(this.ResetThemeButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "thm";
            this.saveFileDialog1.Filter = "PPTLabsThemes|*.thm";
            this.saveFileDialog1.Title = "Save Theme";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "thm";
            this.openFileDialog1.Filter = "PPTLabsTheme|*.thm";
            this.openFileDialog1.Title = "Load Theme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(1, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Brightness";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Saturation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(20, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 20);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(20, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 20);
            this.panel3.TabIndex = 17;
            // 
            // EditColorButton
            // 
            this.EditColorButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.Palette_icon;
            this.EditColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditColorButton.Location = new System.Drawing.Point(243, 16);
            this.EditColorButton.Name = "EditColorButton";
            this.EditColorButton.Size = new System.Drawing.Size(46, 47);
            this.EditColorButton.TabIndex = 2;
            this.EditColorButton.UseVisualStyleBackColor = true;
            this.EditColorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FillEyeDropperButton
            // 
            this.FillEyeDropperButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.Paint_icon;
            this.FillEyeDropperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FillEyeDropperButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.FillEyeDropperButton.Location = new System.Drawing.Point(191, 16);
            this.FillEyeDropperButton.Name = "FillEyeDropperButton";
            this.FillEyeDropperButton.Size = new System.Drawing.Size(46, 47);
            this.FillEyeDropperButton.TabIndex = 14;
            this.FillEyeDropperButton.UseVisualStyleBackColor = true;
            this.FillEyeDropperButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FillEyeDropperButton_MouseDown);
            // 
            // LineEyeDropperButton
            // 
            this.LineEyeDropperButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.Technical_Pen_icon;
            this.LineEyeDropperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LineEyeDropperButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.LineEyeDropperButton.Location = new System.Drawing.Point(139, 16);
            this.LineEyeDropperButton.Name = "LineEyeDropperButton";
            this.LineEyeDropperButton.Size = new System.Drawing.Size(46, 47);
            this.LineEyeDropperButton.TabIndex = 13;
            this.LineEyeDropperButton.UseVisualStyleBackColor = true;
            this.LineEyeDropperButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineEyeDropperButton_MouseDown);
            // 
            // FontEyeDropperButton
            // 
            this.FontEyeDropperButton.BackgroundImage = global::PowerPointLabs.Properties.Resources.Type_icon;
            this.FontEyeDropperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FontEyeDropperButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.FontEyeDropperButton.Location = new System.Drawing.Point(87, 16);
            this.FontEyeDropperButton.Name = "FontEyeDropperButton";
            this.FontEyeDropperButton.Size = new System.Drawing.Size(46, 47);
            this.FontEyeDropperButton.TabIndex = 12;
            this.FontEyeDropperButton.UseVisualStyleBackColor = true;
            this.FontEyeDropperButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FontEyeDropperButton_MouseDown);
            // 
            // ColorPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditColorButton);
            this.Controls.Add(this.FillEyeDropperButton);
            this.Controls.Add(this.LineEyeDropperButton);
            this.Controls.Add(this.FontEyeDropperButton);
            this.Controls.Add(this.themeLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AnalogousColorPanel);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saturationPanel);
            this.Controls.Add(this.brightnessPanel);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.saturationBar);
            this.Name = "ColorPane";
            this.Size = new System.Drawing.Size(304, 575);
            this.Load += new System.EventHandler(this.ColorPane_Load);
            this.AnalogousColorPanel.ResumeLayout(false);
            this.AnalogousColorPanel.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.themeLayoutPanel.ResumeLayout(false);
            this.themeLayoutPanel.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button EditColorButton;
        private System.Windows.Forms.FlowLayoutPanel AnalogousColorPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.Panel brightnessPanel;
        private System.Windows.Forms.Panel saturationPanel;
        private System.Windows.Forms.TrackBar saturationBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel MonoPanel1;
        private System.Windows.Forms.Panel MonoPanel2;
        private System.Windows.Forms.Panel MonoPanel3;
        private System.Windows.Forms.Panel MonoPanel4;
        private System.Windows.Forms.Panel MonoPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Panel AnalogousLighter;
        private System.Windows.Forms.Panel AnalogousSelected;
        private System.Windows.Forms.Panel AnalogousDarker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Panel ComplementaryLighter;
        private System.Windows.Forms.Panel ComplementarySelected;
        private System.Windows.Forms.Panel ComplementaryDarker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Panel TriadicLower;
        private System.Windows.Forms.Panel TriadicSelected;
        private System.Windows.Forms.Panel TriadicHigher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Panel Tetradic1;
        private System.Windows.Forms.Panel TetradicSelected;
        private System.Windows.Forms.Panel Tetradic2;
        private System.Windows.Forms.Panel Tetradic3;
        private System.Windows.Forms.Panel MonoPanel6;
        private System.Windows.Forms.Panel MonoPanel7;
        private System.Windows.Forms.FlowLayoutPanel themeLayoutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Panel ThemePanel1;
        private System.Windows.Forms.Panel ThemePanel2;
        private System.Windows.Forms.Panel ThemePanel3;
        private System.Windows.Forms.Panel ThemePanel4;
        private System.Windows.Forms.Panel ThemePanel5;
        private System.Windows.Forms.Panel ThemePanel6;
        private System.Windows.Forms.Panel ThemePanel7;
        private System.Windows.Forms.Panel ThemePanel8;
        private System.Windows.Forms.Panel ThemePanel9;
        private System.Windows.Forms.Button SaveThemeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FontEyeDropperButton;
        private System.Windows.Forms.Button LineEyeDropperButton;
        private System.Windows.Forms.Button FillEyeDropperButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ResetThemeButton;
    }
}