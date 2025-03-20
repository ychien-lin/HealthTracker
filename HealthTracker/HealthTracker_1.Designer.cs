namespace Final_112323153
{
    partial class HealthTracker_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        LogIn login = new LogIn();
        HealthData healthData = new HealthData();
        public bool flag;
        public string userID;
        public string date;
        public string time;
        public string filepath;
        public List<string> HealthValues;

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
            AddNewDataButton = new Button();
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
            UserID_Label = new Label();
            pictureBox = new PictureBox();
            NAdviceTextBox = new TextBox();
            label1 = new Label();
            NutritionistAdviceLabel = new Label();
            Readbutton = new Button();
            Timelabel = new Label();
            openFileDialog = new OpenFileDialog();
            backbtn = new Button();
            Savebtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // AddNewDataButton
            // 
            AddNewDataButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewDataButton.Location = new Point(725, 142);
            AddNewDataButton.Name = "AddNewDataButton";
            AddNewDataButton.Size = new Size(170, 69);
            AddNewDataButton.TabIndex = 5;
            AddNewDataButton.Text = "Add New Data";
            AddNewDataButton.UseVisualStyleBackColor = true;
            AddNewDataButton.Click += AddNewDataButton_Click;
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
            tableLayoutPanel1.Location = new Point(12, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(639, 344);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // HRtextBox
            // 
            HRtextBox.Anchor = AnchorStyles.None;
            HRtextBox.Enabled = false;
            HRtextBox.Font = new Font("Arial Narrow", 16.2F);
            HRtextBox.Location = new Point(335, 81);
            HRtextBox.Multiline = true;
            HRtextBox.Name = "HRtextBox";
            HRtextBox.Size = new Size(127, 42);
            HRtextBox.TabIndex = 6;
            // 
            // Unit_HR
            // 
            Unit_HR.Anchor = AnchorStyles.None;
            Unit_HR.AutoSize = true;
            Unit_HR.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Unit_HR.Location = new Point(521, 85);
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
            Unit_BP.Location = new Point(506, 153);
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
            label4.Location = new Point(534, 291);
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
            Unit_BS.Location = new Point(508, 17);
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
            Unit_CL.Location = new Point(508, 221);
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
            Blood_pressure.Location = new Point(20, 150);
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
            Weight.Location = new Point(90, 288);
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
            Cholesterol_level.Location = new Point(10, 218);
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
            Blood_sugar.Location = new Point(46, 14);
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
            Heart_rate.Location = new Point(65, 82);
            Heart_rate.Name = "Heart_rate";
            Heart_rate.Size = new Size(188, 40);
            Heart_rate.TabIndex = 0;
            Heart_rate.Text = "Heart rate:";
            // 
            // BStextBox
            // 
            BStextBox.Anchor = AnchorStyles.None;
            BStextBox.Enabled = false;
            BStextBox.Font = new Font("Arial Narrow", 16.2F);
            BStextBox.Location = new Point(335, 13);
            BStextBox.Multiline = true;
            BStextBox.Name = "BStextBox";
            BStextBox.Size = new Size(127, 42);
            BStextBox.TabIndex = 1;
            // 
            // BPtextBox
            // 
            BPtextBox.Anchor = AnchorStyles.None;
            BPtextBox.Enabled = false;
            BPtextBox.Font = new Font("Arial Narrow", 16.2F);
            BPtextBox.Location = new Point(335, 149);
            BPtextBox.Multiline = true;
            BPtextBox.Name = "BPtextBox";
            BPtextBox.Size = new Size(127, 42);
            BPtextBox.TabIndex = 6;
            // 
            // CLtextBox
            // 
            CLtextBox.Anchor = AnchorStyles.None;
            CLtextBox.Enabled = false;
            CLtextBox.Font = new Font("Arial Narrow", 16.2F);
            CLtextBox.Location = new Point(335, 217);
            CLtextBox.Multiline = true;
            CLtextBox.Name = "CLtextBox";
            CLtextBox.Size = new Size(127, 42);
            CLtextBox.TabIndex = 6;
            // 
            // WtextBox
            // 
            WtextBox.Anchor = AnchorStyles.None;
            WtextBox.Enabled = false;
            WtextBox.Font = new Font("Arial Narrow", 16.2F);
            WtextBox.Location = new Point(335, 287);
            WtextBox.Multiline = true;
            WtextBox.Name = "WtextBox";
            WtextBox.Size = new Size(127, 42);
            WtextBox.TabIndex = 6;
            // 
            // UserID_Label
            // 
            UserID_Label.AutoSize = true;
            UserID_Label.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserID_Label.Location = new Point(12, 6);
            UserID_Label.Name = "UserID_Label";
            UserID_Label.Size = new Size(92, 35);
            UserID_Label.TabIndex = 3;
            UserID_Label.Text = "UserID";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(11, 400);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(640, 480);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // NAdviceTextBox
            // 
            NAdviceTextBox.Enabled = false;
            NAdviceTextBox.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NAdviceTextBox.Location = new Point(670, 274);
            NAdviceTextBox.Multiline = true;
            NAdviceTextBox.Name = "NAdviceTextBox";
            NAdviceTextBox.Size = new Size(300, 373);
            NAdviceTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(682, 205);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 8;
            // 
            // NutritionistAdviceLabel
            // 
            NutritionistAdviceLabel.Anchor = AnchorStyles.None;
            NutritionistAdviceLabel.AutoSize = true;
            NutritionistAdviceLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutritionistAdviceLabel.Location = new Point(655, 224);
            NutritionistAdviceLabel.Name = "NutritionistAdviceLabel";
            NutritionistAdviceLabel.Size = new Size(325, 40);
            NutritionistAdviceLabel.TabIndex = 9;
            NutritionistAdviceLabel.Text = "Nutritionist Advice:";
            // 
            // Readbutton
            // 
            Readbutton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Readbutton.Location = new Point(725, 60);
            Readbutton.Name = "Readbutton";
            Readbutton.Size = new Size(170, 69);
            Readbutton.TabIndex = 5;
            Readbutton.Text = "Open Data";
            Readbutton.UseVisualStyleBackColor = true;
            Readbutton.Click += Readbutton_Click;
            // 
            // Timelabel
            // 
            Timelabel.AutoSize = true;
            Timelabel.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timelabel.Location = new Point(256, 6);
            Timelabel.Name = "Timelabel";
            Timelabel.Size = new Size(76, 35);
            Timelabel.TabIndex = 3;
            Timelabel.Text = "Time:";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(779, 830);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 50);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.Enabled = false;
            Savebtn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(779, 662);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(94, 50);
            Savebtn.TabIndex = 5;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Visible = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // HealthTracker_1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 903);
            Controls.Add(NutritionistAdviceLabel);
            Controls.Add(label1);
            Controls.Add(NAdviceTextBox);
            Controls.Add(pictureBox);
            Controls.Add(Readbutton);
            Controls.Add(Savebtn);
            Controls.Add(backbtn);
            Controls.Add(AddNewDataButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Timelabel);
            Controls.Add(UserID_Label);
            Name = "HealthTracker_1";
            Text = "HealthTracker_1";
            Activated += HealthTracker_1_Activated;
            FormClosing += HealthTracker_1_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNewDataButton;
        private TableLayoutPanel tableLayoutPanel1;
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
        private Label UserID_Label;
        private TextBox HRtextBox;
        private TextBox BPtextBox;
        private TextBox CLtextBox;
        private TextBox WtextBox;
        private PictureBox pictureBox;
        private TextBox NAdviceTextBox;
        private Label label1;
        private Label NutritionistAdviceLabel;
        private Button Readbutton;
        private Label Timelabel;
        private OpenFileDialog openFileDialog;
        private Button backbtn;
        private Button Savebtn;
    }
}