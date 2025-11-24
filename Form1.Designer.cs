namespace OpenTK_winforms_z02
{
    partial class Form1
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
            this.GlControl1 = new OpenTK.GLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMouseControl2D = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericXeye = new System.Windows.Forms.NumericUpDown();
            this.numericYeye = new System.Windows.Forms.NumericUpDown();
            this.numericZeye = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericCameraDepth = new System.Windows.Forms.NumericUpDown();
            this.btnMouseControl3D = new System.Windows.Forms.Button();
            this.btnShowAxes = new System.Windows.Forms.Button();
            this.btnCubeQ = new System.Windows.Forms.Button();
            this.btnCubeT = new System.Windows.Forms.Button();
            this.btnResetObjects = new System.Windows.Forms.Button();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnLight0 = new System.Windows.Forms.Button();
            this.btnLight0Reset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trackLight0PositionX = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionY = new System.Windows.Forms.TrackBar();
            this.trackLight0PositionZ = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericLight0Ambient_Red = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Ambient_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Ambient_Blue = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Blue = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Red = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericLight0Specular_Blue = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Specular_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Specular_Red = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnLightsNo = new System.Windows.Forms.Button();
            this.btnLight1 = new System.Windows.Forms.Button();
            this.btnLight1Reset = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.trackLight1PositionX = new System.Windows.Forms.TrackBar();
            this.trackLight1PositionY = new System.Windows.Forms.TrackBar();
            this.trackLight1PositionZ = new System.Windows.Forms.TrackBar();
            this.btnMouseControlLight1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericXeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionZ)).BeginInit();
            this.SuspendLayout();
            // 
            // GlControl1
            // 
            this.GlControl1.BackColor = System.Drawing.Color.Black;
            this.GlControl1.Location = new System.Drawing.Point(13, 13);
            this.GlControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GlControl1.Name = "GlControl1";
            this.GlControl1.Size = new System.Drawing.Size(881, 776);
            this.GlControl1.TabIndex = 0;
            this.GlControl1.VSync = false;
            this.GlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1_Paint);
            this.GlControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseDown);
            this.GlControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseMove);
            this.GlControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlControl1_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ViewDepthX";
            // 
            // btnMouseControl2D
            // 
            this.btnMouseControl2D.Location = new System.Drawing.Point(917, 150);
            this.btnMouseControl2D.Name = "btnMouseControl2D";
            this.btnMouseControl2D.Size = new System.Drawing.Size(388, 28);
            this.btnMouseControl2D.TabIndex = 10;
            this.btnMouseControl2D.UseVisualStyleBackColor = true;
            this.btnMouseControl2D.Click += new System.EventHandler(this.btnMouseControl2D_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1035, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1156, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Oz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1047, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ViewDepthY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1171, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ViewDepthZ";
            // 
            // numericXeye
            // 
            this.numericXeye.Location = new System.Drawing.Point(917, 67);
            this.numericXeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericXeye.Name = "numericXeye";
            this.numericXeye.Size = new System.Drawing.Size(112, 22);
            this.numericXeye.TabIndex = 15;
            this.numericXeye.ValueChanged += new System.EventHandler(this.numericXeye_ValueChanged);
            // 
            // numericYeye
            // 
            this.numericYeye.Location = new System.Drawing.Point(1038, 67);
            this.numericYeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericYeye.Name = "numericYeye";
            this.numericYeye.Size = new System.Drawing.Size(112, 22);
            this.numericYeye.TabIndex = 16;
            this.numericYeye.ValueChanged += new System.EventHandler(this.numericYeye_ValueChanged);
            // 
            // numericZeye
            // 
            this.numericZeye.Location = new System.Drawing.Point(1159, 67);
            this.numericZeye.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericZeye.Name = "numericZeye";
            this.numericZeye.Size = new System.Drawing.Size(112, 22);
            this.numericZeye.TabIndex = 17;
            this.numericZeye.ValueChanged += new System.EventHandler(this.numericZeye_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(914, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Camera depth:";
            // 
            // numericCameraDepth
            // 
            this.numericCameraDepth.Location = new System.Drawing.Point(1021, 109);
            this.numericCameraDepth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericCameraDepth.Name = "numericCameraDepth";
            this.numericCameraDepth.Size = new System.Drawing.Size(284, 22);
            this.numericCameraDepth.TabIndex = 19;
            this.numericCameraDepth.ValueChanged += new System.EventHandler(this.numericCameraDepth_ValueChanged);
            // 
            // btnMouseControl3D
            // 
            this.btnMouseControl3D.Location = new System.Drawing.Point(917, 184);
            this.btnMouseControl3D.Name = "btnMouseControl3D";
            this.btnMouseControl3D.Size = new System.Drawing.Size(388, 28);
            this.btnMouseControl3D.TabIndex = 20;
            this.btnMouseControl3D.UseVisualStyleBackColor = true;
            this.btnMouseControl3D.Click += new System.EventHandler(this.btnMouseControl3D_Click);
            // 
            // btnShowAxes
            // 
            this.btnShowAxes.Location = new System.Drawing.Point(917, 218);
            this.btnShowAxes.Name = "btnShowAxes";
            this.btnShowAxes.Size = new System.Drawing.Size(388, 28);
            this.btnShowAxes.TabIndex = 21;
            this.btnShowAxes.UseVisualStyleBackColor = true;
            this.btnShowAxes.Click += new System.EventHandler(this.btnShowAxes_Click);
            // 
            // btnCubeQ
            // 
            this.btnCubeQ.Location = new System.Drawing.Point(917, 252);
            this.btnCubeQ.Name = "btnCubeQ";
            this.btnCubeQ.Size = new System.Drawing.Size(142, 34);
            this.btnCubeQ.TabIndex = 22;
            this.btnCubeQ.Text = "Load cube (quads)";
            this.btnCubeQ.UseVisualStyleBackColor = true;
            this.btnCubeQ.Click += new System.EventHandler(this.btnCubeQ_Click);
            // 
            // btnCubeT
            // 
            this.btnCubeT.Location = new System.Drawing.Point(1149, 252);
            this.btnCubeT.Name = "btnCubeT";
            this.btnCubeT.Size = new System.Drawing.Size(156, 34);
            this.btnCubeT.TabIndex = 23;
            this.btnCubeT.Text = "Load cube (triangles)";
            this.btnCubeT.UseVisualStyleBackColor = true;
            this.btnCubeT.Click += new System.EventHandler(this.btnCubeT_Click);
            // 
            // btnResetObjects
            // 
            this.btnResetObjects.Location = new System.Drawing.Point(912, 292);
            this.btnResetObjects.Name = "btnResetObjects";
            this.btnResetObjects.Size = new System.Drawing.Size(393, 28);
            this.btnResetObjects.TabIndex = 24;
            this.btnResetObjects.Text = "Reset 3D objects";
            this.btnResetObjects.UseVisualStyleBackColor = true;
            this.btnResetObjects.Click += new System.EventHandler(this.btnResetObjects_Click);
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(912, 341);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(393, 28);
            this.btnLights.TabIndex = 25;
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnLight0
            // 
            this.btnLight0.Location = new System.Drawing.Point(1027, 375);
            this.btnLight0.Name = "btnLight0";
            this.btnLight0.Size = new System.Drawing.Size(135, 34);
            this.btnLight0.TabIndex = 26;
            this.btnLight0.UseVisualStyleBackColor = true;
            this.btnLight0.Click += new System.EventHandler(this.btnLight0_Click);
            // 
            // btnLight0Reset
            // 
            this.btnLight0Reset.Location = new System.Drawing.Point(1168, 375);
            this.btnLight0Reset.Name = "btnLight0Reset";
            this.btnLight0Reset.Size = new System.Drawing.Size(137, 34);
            this.btnLight0Reset.TabIndex = 27;
            this.btnLight0Reset.Text = "Reset";
            this.btnLight0Reset.UseVisualStyleBackColor = true;
            this.btnLight0Reset.Click += new System.EventHandler(this.btnLight0Reset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(914, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Manipulare pozitie sursă 0:";
            // 
            // trackLight0PositionX
            // 
            this.trackLight0PositionX.BackColor = System.Drawing.Color.Red;
            this.trackLight0PositionX.LargeChange = 10;
            this.trackLight0PositionX.Location = new System.Drawing.Point(912, 432);
            this.trackLight0PositionX.Maximum = 50;
            this.trackLight0PositionX.Minimum = -50;
            this.trackLight0PositionX.Name = "trackLight0PositionX";
            this.trackLight0PositionX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionX.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionX.TabIndex = 29;
            this.trackLight0PositionX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionX.Scroll += new System.EventHandler(this.trackLight0PositionX_Scroll);
            // 
            // trackLight0PositionY
            // 
            this.trackLight0PositionY.BackColor = System.Drawing.Color.Gold;
            this.trackLight0PositionY.LargeChange = 10;
            this.trackLight0PositionY.Location = new System.Drawing.Point(979, 432);
            this.trackLight0PositionY.Maximum = 50;
            this.trackLight0PositionY.Minimum = -50;
            this.trackLight0PositionY.Name = "trackLight0PositionY";
            this.trackLight0PositionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionY.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionY.TabIndex = 30;
            this.trackLight0PositionY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionY.Scroll += new System.EventHandler(this.trackLight0PositionY_Scroll);
            // 
            // trackLight0PositionZ
            // 
            this.trackLight0PositionZ.BackColor = System.Drawing.Color.LimeGreen;
            this.trackLight0PositionZ.LargeChange = 10;
            this.trackLight0PositionZ.Location = new System.Drawing.Point(1041, 432);
            this.trackLight0PositionZ.Maximum = 50;
            this.trackLight0PositionZ.Minimum = -50;
            this.trackLight0PositionZ.Name = "trackLight0PositionZ";
            this.trackLight0PositionZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight0PositionZ.Size = new System.Drawing.Size(56, 357);
            this.trackLight0PositionZ.TabIndex = 31;
            this.trackLight0PositionZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight0PositionZ.Scroll += new System.EventHandler(this.trackLight0PositionZ_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1121, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Manipulare culoare sursă 0:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1121, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "RED";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1121, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "GREEN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1121, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "BLUE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1121, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "(iluminare ambientală)";
            // 
            // numericLight0Ambient_Red
            // 
            this.numericLight0Ambient_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Location = new System.Drawing.Point(1188, 460);
            this.numericLight0Ambient_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Red.Name = "numericLight0Ambient_Red";
            this.numericLight0Ambient_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Red.TabIndex = 37;
            this.numericLight0Ambient_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Red.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Red_ValueChanged);
            // 
            // numericLight0Ambient_Green
            // 
            this.numericLight0Ambient_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Location = new System.Drawing.Point(1188, 488);
            this.numericLight0Ambient_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Green.Name = "numericLight0Ambient_Green";
            this.numericLight0Ambient_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Green.TabIndex = 38;
            this.numericLight0Ambient_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Green.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Green_ValueChanged);
            // 
            // numericLight0Ambient_Blue
            // 
            this.numericLight0Ambient_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Location = new System.Drawing.Point(1188, 516);
            this.numericLight0Ambient_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Ambient_Blue.Name = "numericLight0Ambient_Blue";
            this.numericLight0Ambient_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Ambient_Blue.TabIndex = 39;
            this.numericLight0Ambient_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Ambient_Blue.ValueChanged += new System.EventHandler(this.numericLight0Ambient_Blue_ValueChanged);
            // 
            // numericLight0Difuse_Blue
            // 
            this.numericLight0Difuse_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Location = new System.Drawing.Point(1188, 645);
            this.numericLight0Difuse_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Blue.Name = "numericLight0Difuse_Blue";
            this.numericLight0Difuse_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Blue.TabIndex = 47;
            this.numericLight0Difuse_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Blue.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Blue_ValueChanged);
            // 
            // numericLight0Difuse_Green
            // 
            this.numericLight0Difuse_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Location = new System.Drawing.Point(1188, 617);
            this.numericLight0Difuse_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Green.Name = "numericLight0Difuse_Green";
            this.numericLight0Difuse_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Green.TabIndex = 46;
            this.numericLight0Difuse_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Green.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Green_ValueChanged);
            // 
            // numericLight0Difuse_Red
            // 
            this.numericLight0Difuse_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Location = new System.Drawing.Point(1188, 589);
            this.numericLight0Difuse_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Difuse_Red.Name = "numericLight0Difuse_Red";
            this.numericLight0Difuse_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Difuse_Red.TabIndex = 45;
            this.numericLight0Difuse_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Difuse_Red.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Red_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1121, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "(iluminare difuză)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1121, 647);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "BLUE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1121, 619);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "GREEN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1121, 591);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "RED";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1121, 541);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Manipulare culoare sursă 0:";
            // 
            // numericLight0Specular_Blue
            // 
            this.numericLight0Specular_Blue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Location = new System.Drawing.Point(1188, 774);
            this.numericLight0Specular_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Blue.Name = "numericLight0Specular_Blue";
            this.numericLight0Specular_Blue.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Blue.TabIndex = 55;
            this.numericLight0Specular_Blue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Blue.ValueChanged += new System.EventHandler(this.numericLight0Specular_Blue_ValueChanged);
            // 
            // numericLight0Specular_Green
            // 
            this.numericLight0Specular_Green.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Location = new System.Drawing.Point(1188, 746);
            this.numericLight0Specular_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Green.Name = "numericLight0Specular_Green";
            this.numericLight0Specular_Green.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Green.TabIndex = 54;
            this.numericLight0Specular_Green.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Green.ValueChanged += new System.EventHandler(this.numericLight0Specular_Green_ValueChanged);
            // 
            // numericLight0Specular_Red
            // 
            this.numericLight0Specular_Red.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Location = new System.Drawing.Point(1188, 718);
            this.numericLight0Specular_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericLight0Specular_Red.Name = "numericLight0Specular_Red";
            this.numericLight0Specular_Red.Size = new System.Drawing.Size(112, 22);
            this.numericLight0Specular_Red.TabIndex = 53;
            this.numericLight0Specular_Red.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericLight0Specular_Red.ValueChanged += new System.EventHandler(this.numericLight0Specular_Red_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1121, 691);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 17);
            this.label19.TabIndex = 52;
            this.label19.Text = "(iluminare speculară)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1121, 776);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 51;
            this.label20.Text = "BLUE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1121, 748);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 17);
            this.label21.TabIndex = 50;
            this.label21.Text = "GREEN";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1121, 720);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 17);
            this.label22.TabIndex = 49;
            this.label22.Text = "RED";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1121, 670);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 17);
            this.label23.TabIndex = 48;
            this.label23.Text = "Manipulare culoare sursă 0:";
            // 
            // btnLightsNo
            // 
            this.btnLightsNo.Location = new System.Drawing.Point(917, 375);
            this.btnLightsNo.Name = "btnLightsNo";
            this.btnLightsNo.Size = new System.Drawing.Size(94, 34);
            this.btnLightsNo.TabIndex = 56;
            this.btnLightsNo.Text = "Lights #";
            this.btnLightsNo.UseVisualStyleBackColor = true;
            this.btnLightsNo.Click += new System.EventHandler(this.btnLightsNo_Click);
            // 
            // btnLight1
            // 
            this.btnLight1.Location = new System.Drawing.Point(1027, 415);
            this.btnLight1.Name = "btnLight1";
            this.btnLight1.Size = new System.Drawing.Size(135, 34);
            this.btnLight1.TabIndex = 57;
            this.btnLight1.Text = "Sursa 1 OFF";
            this.btnLight1.UseVisualStyleBackColor = true;
            this.btnLight1.Click += new System.EventHandler(this.btnLight1_Click);
            // 
            // btnLight1Reset
            // 
            this.btnLight1Reset.Location = new System.Drawing.Point(1168, 415);
            this.btnLight1Reset.Name = "btnLight1Reset";
            this.btnLight1Reset.Size = new System.Drawing.Size(137, 34);
            this.btnLight1Reset.TabIndex = 58;
            this.btnLight1Reset.Text = "Reset Sursa 1";
            this.btnLight1Reset.UseVisualStyleBackColor = true;
            this.btnLight1Reset.Click += new System.EventHandler(this.btnLight1Reset_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(914, 455);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(178, 17);
            this.label24.TabIndex = 59;
            this.label24.Text = "Manipulare pozitie sursă 1:";
            // 
            // trackLight1PositionX
            // 
            this.trackLight1PositionX.BackColor = System.Drawing.Color.Red;
            this.trackLight1PositionX.LargeChange = 10;
            this.trackLight1PositionX.Location = new System.Drawing.Point(912, 475);
            this.trackLight1PositionX.Maximum = 50;
            this.trackLight1PositionX.Minimum = -50;
            this.trackLight1PositionX.Name = "trackLight1PositionX";
            this.trackLight1PositionX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight1PositionX.Size = new System.Drawing.Size(56, 314);
            this.trackLight1PositionX.TabIndex = 60;
            this.trackLight1PositionX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight1PositionX.Scroll += new System.EventHandler(this.trackLight1PositionX_Scroll);
            // 
            // trackLight1PositionY
            // 
            this.trackLight1PositionY.BackColor = System.Drawing.Color.Gold;
            this.trackLight1PositionY.LargeChange = 10;
            this.trackLight1PositionY.Location = new System.Drawing.Point(979, 475);
            this.trackLight1PositionY.Maximum = 50;
            this.trackLight1PositionY.Minimum = -50;
            this.trackLight1PositionY.Name = "trackLight1PositionY";
            this.trackLight1PositionY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight1PositionY.Size = new System.Drawing.Size(56, 314);
            this.trackLight1PositionY.TabIndex = 61;
            this.trackLight1PositionY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight1PositionY.Scroll += new System.EventHandler(this.trackLight1PositionY_Scroll);
            // 
            // trackLight1PositionZ
            // 
            this.trackLight1PositionZ.BackColor = System.Drawing.Color.LimeGreen;
            this.trackLight1PositionZ.LargeChange = 10;
            this.trackLight1PositionZ.Location = new System.Drawing.Point(1041, 475);
            this.trackLight1PositionZ.Maximum = 50;
            this.trackLight1PositionZ.Minimum = -50;
            this.trackLight1PositionZ.Name = "trackLight1PositionZ";
            this.trackLight1PositionZ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLight1PositionZ.Size = new System.Drawing.Size(56, 314);
            this.trackLight1PositionZ.TabIndex = 62;
            this.trackLight1PositionZ.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLight1PositionZ.Scroll += new System.EventHandler(this.trackLight1PositionZ_Scroll);
            // 
            // btnMouseControlLight1
            // 
            this.btnMouseControlLight1.Location = new System.Drawing.Point(917, 415);
            this.btnMouseControlLight1.Name = "btnMouseControlLight1";
            this.btnMouseControlLight1.Size = new System.Drawing.Size(94, 34);
            this.btnMouseControlLight1.TabIndex = 63;
            this.btnMouseControlLight1.Text = "Mouse OFF";
            this.btnMouseControlLight1.UseVisualStyleBackColor = true;
            this.btnMouseControlLight1.Click += new System.EventHandler(this.btnMouseControlLight1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 802);
            this.Controls.Add(this.btnMouseControlLight1);
            this.Controls.Add(this.trackLight1PositionZ);
            this.Controls.Add(this.trackLight1PositionY);
            this.Controls.Add(this.trackLight1PositionX);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnLight1Reset);
            this.Controls.Add(this.btnLight1);
            this.Controls.Add(this.btnLightsNo);
            this.Controls.Add(this.numericLight0Specular_Blue);
            this.Controls.Add(this.numericLight0Specular_Green);
            this.Controls.Add(this.numericLight0Specular_Red);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.numericLight0Difuse_Blue);
            this.Controls.Add(this.numericLight0Difuse_Green);
            this.Controls.Add(this.numericLight0Difuse_Red);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericLight0Ambient_Blue);
            this.Controls.Add(this.numericLight0Ambient_Green);
            this.Controls.Add(this.numericLight0Ambient_Red);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackLight0PositionZ);
            this.Controls.Add(this.trackLight0PositionY);
            this.Controls.Add(this.trackLight0PositionX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLight0Reset);
            this.Controls.Add(this.btnLight0);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.btnResetObjects);
            this.Controls.Add(this.btnCubeT);
            this.Controls.Add(this.btnCubeQ);
            this.Controls.Add(this.btnShowAxes);
            this.Controls.Add(this.btnMouseControl3D);
            this.Controls.Add(this.numericCameraDepth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericZeye);
            this.Controls.Add(this.numericYeye);
            this.Controls.Add(this.numericXeye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMouseControl2D);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GlControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Illumination";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericXeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCameraDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight0PositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Ambient_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Specular_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLight1PositionZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl GlControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMouseControl2D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericXeye;
        private System.Windows.Forms.NumericUpDown numericYeye;
        private System.Windows.Forms.NumericUpDown numericZeye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericCameraDepth;
        private System.Windows.Forms.Button btnMouseControl3D;
        private System.Windows.Forms.Button btnShowAxes;
        private System.Windows.Forms.Button btnCubeQ;
        private System.Windows.Forms.Button btnCubeT;
        private System.Windows.Forms.Button btnResetObjects;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnLight0;
        private System.Windows.Forms.Button btnLight0Reset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackLight0PositionX;
        private System.Windows.Forms.TrackBar trackLight0PositionY;
        private System.Windows.Forms.TrackBar trackLight0PositionZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Red;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Ambient_Blue;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Blue;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Red;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Blue;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Specular_Red;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnLightsNo;
        private System.Windows.Forms.Button btnLight1;
        private System.Windows.Forms.Button btnLight1Reset;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar trackLight1PositionX;
        private System.Windows.Forms.TrackBar trackLight1PositionY;
        private System.Windows.Forms.TrackBar trackLight1PositionZ;
        private System.Windows.Forms.Button btnMouseControlLight1;
    }
}