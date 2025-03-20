namespace Final_112323153
{
    partial class HealthTracker_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        LogIn login = new LogIn();
        HealthData  healthData = new HealthData();
        public string userID;
        public string date;
        public string time;
        public string savefilepath;
        public Image image;
        
        private string healthDataContent;
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
            UserID_Label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            HRtextBox = new TextBox();
            Unit_HR = new Label();
            Unit_BP = new Label();
            label4 = new Label();
            Unit_BS = new Label();
            Unit_CL = new Label();
            Blood_pressure = new Label();
            Weight = new Label();
            Cholesterol_level = new Label();
            Blood_sugar = new Label();
            Heart_rate = new Label();
            BStextBox = new TextBox();
            BPtextBox = new TextBox();
            CLtextBox = new TextBox();
            WtextBox = new TextBox();
            Savebtn = new Button();
            CapturePictureBox_Show = new PictureBox();
            groupBox1 = new GroupBox();
            Resetbtn = new Button();
            Capturebtn = new Button();
            Backbtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CapturePictureBox_Show).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UserID_Label
            // 
            UserID_Label.AutoSize = true;
            UserID_Label.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserID_Label.Location = new Point(20, 9);
            UserID_Label.Name = "UserID_Label";
            UserID_Label.Size = new Size(92, 35);
            UserID_Label.TabIndex = 0;
            UserID_Label.Text = "UserID";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(HRtextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(Unit_HR, 2, 1);
            tableLayoutPanel1.Controls.Add(Unit_BP, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 4);
            tableLayoutPanel1.Controls.Add(Unit_BS, 2, 0);
            tableLayoutPanel1.Controls.Add(Unit_CL, 2, 3);
            tableLayoutPanel1.Controls.Add(Blood_pressure, 0, 2);
            tableLayoutPanel1.Controls.Add(Weight, 0, 4);
            tableLayoutPanel1.Controls.Add(Cholesterol_level, 0, 3);
            tableLayoutPanel1.Controls.Add(Blood_sugar, 0, 0);
            tableLayoutPanel1.Controls.Add(Heart_rate, 0, 1);
            tableLayoutPanel1.Controls.Add(BStextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(BPtextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(CLtextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(WtextBox, 1, 4);
            tableLayoutPanel1.Location = new Point(65, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(621, 344);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // HRtextBox
            // 
            HRtextBox.Anchor = AnchorStyles.None;
            HRtextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            HRtextBox.Location = new Point(324, 81);
            HRtextBox.Multiline = true;
            HRtextBox.Name = "HRtextBox";
            HRtextBox.Size = new Size(127, 42);
            HRtextBox.TabIndex = 6;
            HRtextBox.KeyPress += HRtextBox_KeyPress;
            // 
            // Unit_HR
            // 
            Unit_HR.Anchor = AnchorStyles.None;
            Unit_HR.AutoSize = true;
            Unit_HR.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Unit_HR.Location = new Point(505, 85);
            Unit_HR.Name = "Unit_HR";
            Unit_HR.Size = new Size(75, 33);
            Unit_HR.TabIndex = 4;
            Unit_HR.Text = "bpm";
            // 
            // Unit_BP
            // 
            Unit_BP.Anchor = AnchorStyles.None;
            Unit_BP.AutoSize = true;
            Unit_BP.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Unit_BP.Location = new Point(491, 153);
            Unit_BP.Name = "Unit_BP";
            Unit_BP.Size = new Size(104, 33);
            Unit_BP.TabIndex = 5;
            Unit_BP.Text = "mmHg";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(519, 291);
            label4.Name = "label4";
            label4.Size = new Size(48, 33);
            label4.TabIndex = 6;
            label4.Text = "kg";
            // 
            // Unit_BS
            // 
            Unit_BS.Anchor = AnchorStyles.None;
            Unit_BS.AutoSize = true;
            Unit_BS.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Unit_BS.Location = new Point(493, 17);
            Unit_BS.Name = "Unit_BS";
            Unit_BS.Size = new Size(100, 33);
            Unit_BS.TabIndex = 2;
            Unit_BS.Text = "mg/dL";
            // 
            // Unit_CL
            // 
            Unit_CL.Anchor = AnchorStyles.None;
            Unit_CL.AutoSize = true;
            Unit_CL.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Unit_CL.Location = new Point(493, 221);
            Unit_CL.Name = "Unit_CL";
            Unit_CL.Size = new Size(100, 33);
            Unit_CL.TabIndex = 3;
            Unit_CL.Text = "mg/dL";
            // 
            // Blood_pressure
            // 
            Blood_pressure.Anchor = AnchorStyles.None;
            Blood_pressure.AutoSize = true;
            Blood_pressure.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Blood_pressure.Location = new Point(16, 150);
            Blood_pressure.Name = "Blood_pressure";
            Blood_pressure.Size = new Size(278, 40);
            Blood_pressure.TabIndex = 0;
            Blood_pressure.Text = "Blood pressure:";
            // 
            // Weight
            // 
            Weight.Anchor = AnchorStyles.None;
            Weight.AutoSize = true;
            Weight.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Weight.Location = new Point(86, 288);
            Weight.Name = "Weight";
            Weight.Size = new Size(138, 40);
            Weight.TabIndex = 0;
            Weight.Text = "Weight:";
            // 
            // Cholesterol_level
            // 
            Cholesterol_level.Anchor = AnchorStyles.None;
            Cholesterol_level.AutoSize = true;
            Cholesterol_level.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cholesterol_level.Location = new Point(5, 218);
            Cholesterol_level.Name = "Cholesterol_level";
            Cholesterol_level.Size = new Size(299, 40);
            Cholesterol_level.TabIndex = 0;
            Cholesterol_level.Text = "Cholesterol level:";
            // 
            // Blood_sugar
            // 
            Blood_sugar.Anchor = AnchorStyles.None;
            Blood_sugar.AutoSize = true;
            Blood_sugar.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Blood_sugar.Location = new Point(42, 14);
            Blood_sugar.Name = "Blood_sugar";
            Blood_sugar.Size = new Size(226, 40);
            Blood_sugar.TabIndex = 0;
            Blood_sugar.Text = "Blood sugar:";
            // 
            // Heart_rate
            // 
            Heart_rate.Anchor = AnchorStyles.None;
            Heart_rate.AutoSize = true;
            Heart_rate.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heart_rate.Location = new Point(61, 82);
            Heart_rate.Name = "Heart_rate";
            Heart_rate.Size = new Size(188, 40);
            Heart_rate.TabIndex = 0;
            Heart_rate.Text = "Heart rate:";
            // 
            // BStextBox
            // 
            BStextBox.Anchor = AnchorStyles.None;
            BStextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BStextBox.Location = new Point(324, 13);
            BStextBox.Multiline = true;
            BStextBox.Name = "BStextBox";
            BStextBox.Size = new Size(127, 42);
            BStextBox.TabIndex = 1;
            BStextBox.KeyPress += BStextBox_KeyPress;
            // 
            // BPtextBox
            // 
            BPtextBox.Anchor = AnchorStyles.None;
            BPtextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            BPtextBox.Location = new Point(324, 149);
            BPtextBox.Multiline = true;
            BPtextBox.Name = "BPtextBox";
            BPtextBox.Size = new Size(127, 42);
            BPtextBox.TabIndex = 6;
            BPtextBox.KeyPress += BPtextBox_KeyPress;
            // 
            // CLtextBox
            // 
            CLtextBox.Anchor = AnchorStyles.None;
            CLtextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            CLtextBox.Location = new Point(324, 217);
            CLtextBox.Multiline = true;
            CLtextBox.Name = "CLtextBox";
            CLtextBox.Size = new Size(127, 42);
            CLtextBox.TabIndex = 6;
            CLtextBox.KeyPress += CLtextBox_KeyPress;
            // 
            // WtextBox
            // 
            WtextBox.Anchor = AnchorStyles.None;
            WtextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            WtextBox.Location = new Point(324, 287);
            WtextBox.Multiline = true;
            WtextBox.Name = "WtextBox";
            WtextBox.Size = new Size(127, 42);
            WtextBox.TabIndex = 6;
            WtextBox.KeyPress += WtextBox_KeyPress;
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = SystemColors.ControlText;
            Savebtn.Location = new Point(0, 703);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(393, 50);
            Savebtn.TabIndex = 6;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // CapturePictureBox_Show
            // 
            CapturePictureBox_Show.Location = new Point(95, 26);
            CapturePictureBox_Show.Name = "CapturePictureBox_Show";
            CapturePictureBox_Show.Size = new Size(320, 240);
            CapturePictureBox_Show.TabIndex = 7;
            CapturePictureBox_Show.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Resetbtn);
            groupBox1.Controls.Add(Capturebtn);
            groupBox1.Controls.Add(CapturePictureBox_Show);
            groupBox1.Location = new Point(42, 413);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 269);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Resetbtn
            // 
            Resetbtn.Anchor = AnchorStyles.None;
            Resetbtn.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resetbtn.Location = new Point(493, 162);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(151, 50);
            Resetbtn.TabIndex = 9;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = true;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Capturebtn
            // 
            Capturebtn.Anchor = AnchorStyles.None;
            Capturebtn.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Capturebtn.Location = new Point(493, 48);
            Capturebtn.Name = "Capturebtn";
            Capturebtn.Size = new Size(151, 50);
            Capturebtn.TabIndex = 9;
            Capturebtn.Text = "Capture";
            Capturebtn.UseVisualStyleBackColor = true;
            Capturebtn.Click += Capturebtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = SystemColors.ControlText;
            Backbtn.Location = new Point(389, 703);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(393, 50);
            Backbtn.TabIndex = 6;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // HealthTracker_2
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(groupBox1);
            Controls.Add(Backbtn);
            Controls.Add(Savebtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(UserID_Label);
            Name = "HealthTracker_2";
            Text = "HealthTracker";
            Activated += HealthTracker_2_Activated;
            FormClosing += HealthTracker_2_FormClosing;
            Load += HealthTracker_2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CapturePictureBox_Show).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserID_Label;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox HRtextBox;
        private Label Unit_HR;
        private Label Unit_BP;
        private Label label4;
        private Label Unit_BS;
        private Label Unit_CL;
        private Label Blood_pressure;
        private Label Weight;
        private Label Cholesterol_level;
        private Label Blood_sugar;
        private Label Heart_rate;
        private TextBox BStextBox;
        private TextBox BPtextBox;
        private TextBox CLtextBox;
        private TextBox WtextBox;
        private Button Savebtn;
        private PictureBox CapturePictureBox_Show;
        private GroupBox groupBox1;
        private Button Capturebtn;
        private Button Backbtn;
        private Button Resetbtn;
    }
}