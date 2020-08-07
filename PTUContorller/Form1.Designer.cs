namespace PTUContorller
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_PTU_IP = new System.Windows.Forms.ListBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Connection_Status = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.groupBox_Pos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_TiltPos_Current = new System.Windows.Forms.Label();
            this.button_Go = new System.Windows.Forms.Button();
            this.textBox_TiltPos_Goal = new System.Windows.Forms.TextBox();
            this.textBox_PanPos_Goal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_PanPos_Current = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_Pos_Range = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TiltRange_Now = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_PanRange_Now = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_TiltMax = new System.Windows.Forms.TextBox();
            this.textBox_PanMax = new System.Windows.Forms.TextBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.textBox_TiltMin = new System.Windows.Forms.TextBox();
            this.textBox_PanMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Speed = new System.Windows.Forms.GroupBox();
            this.label_TiltSpeed = new System.Windows.Forms.Label();
            this.label_PanSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Pos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Pos_Range.SuspendLayout();
            this.groupBox_Speed.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_PTU_IP
            // 
            this.listBox_PTU_IP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_PTU_IP.FormattingEnabled = true;
            this.listBox_PTU_IP.ItemHeight = 35;
            this.listBox_PTU_IP.Items.AddRange(new object[] {
            "Press the button."});
            this.listBox_PTU_IP.Location = new System.Drawing.Point(45, 50);
            this.listBox_PTU_IP.Name = "listBox_PTU_IP";
            this.listBox_PTU_IP.Size = new System.Drawing.Size(240, 249);
            this.listBox_PTU_IP.TabIndex = 0;
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.Location = new System.Drawing.Point(76, 411);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(171, 44);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Connection_Status);
            this.groupBox1.Controls.Add(this.button_Find);
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.listBox_PTU_IP);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 518);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label_Connection_Status
            // 
            this.label_Connection_Status.Location = new System.Drawing.Point(45, 310);
            this.label_Connection_Status.Name = "label_Connection_Status";
            this.label_Connection_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Connection_Status.Size = new System.Drawing.Size(240, 40);
            this.label_Connection_Status.TabIndex = 5;
            this.label_Connection_Status.Text = "Not Connected.";
            this.label_Connection_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.Location = new System.Drawing.Point(76, 362);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(171, 44);
            this.button_Find.TabIndex = 4;
            this.button_Find.Text = "Find PTUs";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect.Location = new System.Drawing.Point(76, 460);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(171, 44);
            this.button_Disconnect.TabIndex = 3;
            this.button_Disconnect.Text = "DisConnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // groupBox_Pos
            // 
            this.groupBox_Pos.Controls.Add(this.label9);
            this.groupBox_Pos.Controls.Add(this.label_TiltPos_Current);
            this.groupBox_Pos.Controls.Add(this.button_Go);
            this.groupBox_Pos.Controls.Add(this.textBox_TiltPos_Goal);
            this.groupBox_Pos.Controls.Add(this.textBox_PanPos_Goal);
            this.groupBox_Pos.Controls.Add(this.label11);
            this.groupBox_Pos.Controls.Add(this.label_PanPos_Current);
            this.groupBox_Pos.Controls.Add(this.label4);
            this.groupBox_Pos.Controls.Add(this.label3);
            this.groupBox_Pos.Controls.Add(this.label2);
            this.groupBox_Pos.Enabled = false;
            this.groupBox_Pos.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Pos.Location = new System.Drawing.Point(354, 12);
            this.groupBox_Pos.Name = "groupBox_Pos";
            this.groupBox_Pos.Size = new System.Drawing.Size(326, 258);
            this.groupBox_Pos.TabIndex = 3;
            this.groupBox_Pos.TabStop = false;
            this.groupBox_Pos.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "Unit : deg";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TiltPos_Current
            // 
            this.label_TiltPos_Current.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TiltPos_Current.Location = new System.Drawing.Point(82, 135);
            this.label_TiltPos_Current.Name = "label_TiltPos_Current";
            this.label_TiltPos_Current.Size = new System.Drawing.Size(113, 34);
            this.label_TiltPos_Current.TabIndex = 14;
            this.label_TiltPos_Current.Text = "-159.5";
            this.label_TiltPos_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Go
            // 
            this.button_Go.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Go.Location = new System.Drawing.Point(140, 185);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(91, 44);
            this.button_Go.TabIndex = 6;
            this.button_Go.Text = "Go";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // textBox_TiltPos_Goal
            // 
            this.textBox_TiltPos_Goal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TiltPos_Goal.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textBox_TiltPos_Goal.Location = new System.Drawing.Point(202, 128);
            this.textBox_TiltPos_Goal.Name = "textBox_TiltPos_Goal";
            this.textBox_TiltPos_Goal.Size = new System.Drawing.Size(100, 42);
            this.textBox_TiltPos_Goal.TabIndex = 13;
            this.textBox_TiltPos_Goal.Text = "-159.5";
            this.textBox_TiltPos_Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PanPos_Goal
            // 
            this.textBox_PanPos_Goal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PanPos_Goal.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textBox_PanPos_Goal.Location = new System.Drawing.Point(202, 70);
            this.textBox_PanPos_Goal.Name = "textBox_PanPos_Goal";
            this.textBox_PanPos_Goal.Size = new System.Drawing.Size(100, 42);
            this.textBox_PanPos_Goal.TabIndex = 12;
            this.textBox_PanPos_Goal.Text = "-159.5";
            this.textBox_PanPos_Goal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 35);
            this.label11.TabIndex = 11;
            this.label11.Text = "Goal";
            // 
            // label_PanPos_Current
            // 
            this.label_PanPos_Current.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PanPos_Current.Location = new System.Drawing.Point(82, 74);
            this.label_PanPos_Current.Name = "label_PanPos_Current";
            this.label_PanPos_Current.Size = new System.Drawing.Size(113, 34);
            this.label_PanPos_Current.TabIndex = 9;
            this.label_PanPos_Current.Text = "-159.5";
            this.label_PanPos_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Now";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tilt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(0, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(962, 62);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(956, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Copyright © 2019 by Wei-Ren Xue";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_Pos_Range
            // 
            this.groupBox_Pos_Range.Controls.Add(this.label1);
            this.groupBox_Pos_Range.Controls.Add(this.label_TiltRange_Now);
            this.groupBox_Pos_Range.Controls.Add(this.label21);
            this.groupBox_Pos_Range.Controls.Add(this.label_PanRange_Now);
            this.groupBox_Pos_Range.Controls.Add(this.label20);
            this.groupBox_Pos_Range.Controls.Add(this.textBox_TiltMax);
            this.groupBox_Pos_Range.Controls.Add(this.textBox_PanMax);
            this.groupBox_Pos_Range.Controls.Add(this.button_Set);
            this.groupBox_Pos_Range.Controls.Add(this.textBox_TiltMin);
            this.groupBox_Pos_Range.Controls.Add(this.textBox_PanMin);
            this.groupBox_Pos_Range.Controls.Add(this.label12);
            this.groupBox_Pos_Range.Controls.Add(this.label15);
            this.groupBox_Pos_Range.Controls.Add(this.label16);
            this.groupBox_Pos_Range.Controls.Add(this.label17);
            this.groupBox_Pos_Range.Enabled = false;
            this.groupBox_Pos_Range.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Pos_Range.Location = new System.Drawing.Point(354, 276);
            this.groupBox_Pos_Range.Name = "groupBox_Pos_Range";
            this.groupBox_Pos_Range.Size = new System.Drawing.Size(596, 254);
            this.groupBox_Pos_Range.TabIndex = 14;
            this.groupBox_Pos_Range.TabStop = false;
            this.groupBox_Pos_Range.Text = "Position Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unit : deg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TiltRange_Now
            // 
            this.label_TiltRange_Now.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TiltRange_Now.Location = new System.Drawing.Point(72, 144);
            this.label_TiltRange_Now.Name = "label_TiltRange_Now";
            this.label_TiltRange_Now.Size = new System.Drawing.Size(206, 34);
            this.label_TiltRange_Now.TabIndex = 19;
            this.label_TiltRange_Now.Text = "-159.5 ~ 159.5";
            this.label_TiltRange_Now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(411, 146);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(29, 35);
            this.label21.TabIndex = 18;
            this.label21.Text = "~";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PanRange_Now
            // 
            this.label_PanRange_Now.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PanRange_Now.Location = new System.Drawing.Point(72, 86);
            this.label_PanRange_Now.Name = "label_PanRange_Now";
            this.label_PanRange_Now.Size = new System.Drawing.Size(206, 34);
            this.label_PanRange_Now.TabIndex = 17;
            this.label_PanRange_Now.Text = "-159.5 ~ 159.5";
            this.label_PanRange_Now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(411, 86);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(29, 35);
            this.label20.TabIndex = 17;
            this.label20.Text = "~";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TiltMax
            // 
            this.textBox_TiltMax.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TiltMax.Location = new System.Drawing.Point(442, 136);
            this.textBox_TiltMax.Name = "textBox_TiltMax";
            this.textBox_TiltMax.Size = new System.Drawing.Size(100, 42);
            this.textBox_TiltMax.TabIndex = 16;
            this.textBox_TiltMax.Text = "-159.5";
            this.textBox_TiltMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PanMax
            // 
            this.textBox_PanMax.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PanMax.Location = new System.Drawing.Point(442, 82);
            this.textBox_PanMax.Name = "textBox_PanMax";
            this.textBox_PanMax.Size = new System.Drawing.Size(100, 42);
            this.textBox_PanMax.TabIndex = 15;
            this.textBox_PanMax.Text = "-159.5";
            this.textBox_PanMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Set
            // 
            this.button_Set.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Set.Location = new System.Drawing.Point(234, 196);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(92, 44);
            this.button_Set.TabIndex = 6;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // textBox_TiltMin
            // 
            this.textBox_TiltMin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TiltMin.Location = new System.Drawing.Point(304, 136);
            this.textBox_TiltMin.Name = "textBox_TiltMin";
            this.textBox_TiltMin.Size = new System.Drawing.Size(100, 42);
            this.textBox_TiltMin.TabIndex = 13;
            this.textBox_TiltMin.Text = "-159.5";
            this.textBox_TiltMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PanMin
            // 
            this.textBox_PanMin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PanMin.Location = new System.Drawing.Point(304, 82);
            this.textBox_PanMin.Name = "textBox_PanMin";
            this.textBox_PanMin.Size = new System.Drawing.Size(100, 42);
            this.textBox_PanMin.TabIndex = 12;
            this.textBox_PanMin.Text = "-159.5";
            this.textBox_PanMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(392, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 35);
            this.label12.TabIndex = 11;
            this.label12.Text = "Goal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(152, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 35);
            this.label15.TabIndex = 8;
            this.label15.Text = "Now";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 35);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tilt";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 35);
            this.label17.TabIndex = 6;
            this.label17.Text = "Pan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tilt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Now";
            // 
            // groupBox_Speed
            // 
            this.groupBox_Speed.Controls.Add(this.label_TiltSpeed);
            this.groupBox_Speed.Controls.Add(this.label_PanSpeed);
            this.groupBox_Speed.Controls.Add(this.label5);
            this.groupBox_Speed.Controls.Add(this.label6);
            this.groupBox_Speed.Controls.Add(this.label7);
            this.groupBox_Speed.Controls.Add(this.label10);
            this.groupBox_Speed.Enabled = false;
            this.groupBox_Speed.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Speed.Location = new System.Drawing.Point(686, 12);
            this.groupBox_Speed.Name = "groupBox_Speed";
            this.groupBox_Speed.Size = new System.Drawing.Size(262, 258);
            this.groupBox_Speed.TabIndex = 9;
            this.groupBox_Speed.TabStop = false;
            this.groupBox_Speed.Text = "Speed";
            // 
            // label_TiltSpeed
            // 
            this.label_TiltSpeed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TiltSpeed.Location = new System.Drawing.Point(104, 131);
            this.label_TiltSpeed.Name = "label_TiltSpeed";
            this.label_TiltSpeed.Size = new System.Drawing.Size(113, 34);
            this.label_TiltSpeed.TabIndex = 16;
            this.label_TiltSpeed.Text = "-159.5";
            this.label_TiltSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PanSpeed
            // 
            this.label_PanSpeed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PanSpeed.Location = new System.Drawing.Point(104, 70);
            this.label_PanSpeed.Name = "label_PanSpeed";
            this.label_PanSpeed.Size = new System.Drawing.Size(113, 34);
            this.label_PanSpeed.TabIndex = 15;
            this.label_PanSpeed.Text = "-159.5";
            this.label_PanSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unit : deg/sec";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(962, 586);
            this.Controls.Add(this.groupBox_Pos_Range);
            this.Controls.Add(this.groupBox_Speed);
            this.Controls.Add(this.groupBox_Pos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PTU Controller V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Pos.ResumeLayout(false);
            this.groupBox_Pos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox_Pos_Range.ResumeLayout(false);
            this.groupBox_Pos_Range.PerformLayout();
            this.groupBox_Speed.ResumeLayout(false);
            this.groupBox_Speed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_PTU_IP;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Label label_Connection_Status;
        private System.Windows.Forms.GroupBox groupBox_Pos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_PanPos_Current;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.TextBox textBox_TiltPos_Goal;
        private System.Windows.Forms.TextBox textBox_PanPos_Goal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox_Pos_Range;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.TextBox textBox_TiltMin;
        private System.Windows.Forms.TextBox textBox_PanMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_TiltMax;
        private System.Windows.Forms.TextBox textBox_PanMax;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_TiltRange_Now;
        private System.Windows.Forms.Label label_PanRange_Now;
        private System.Windows.Forms.Label label_TiltPos_Current;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_Speed;
        private System.Windows.Forms.Label label_TiltSpeed;
        private System.Windows.Forms.Label label_PanSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

    }
}

