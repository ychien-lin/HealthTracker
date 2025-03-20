namespace Final_112323153
{
    partial class UserLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        HealthData healthData = new HealthData();
        LogIn login = new LogIn();
        public string userID;

        public bool flag;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            User_ID_Label = new Label();
            PasswardtextBox = new TextBox();
            Passward_Label = new Label();
            UserIDtextBox = new TextBox();
            LogInbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            create = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            NutritionistLogInbutton = new Button();
            Backbutton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // User_ID_Label
            // 
            User_ID_Label.Anchor = AnchorStyles.None;
            User_ID_Label.AutoSize = true;
            User_ID_Label.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_ID_Label.Location = new Point(56, 29);
            User_ID_Label.Name = "User_ID_Label";
            User_ID_Label.Size = new Size(148, 40);
            User_ID_Label.TabIndex = 0;
            User_ID_Label.Text = "User ID:";
            // 
            // PasswardtextBox
            // 
            PasswardtextBox.Anchor = AnchorStyles.None;
            PasswardtextBox.Font = new Font("Arial", 18F, FontStyle.Bold);
            PasswardtextBox.Location = new Point(266, 129);
            PasswardtextBox.Multiline = true;
            PasswardtextBox.Name = "PasswardtextBox";
            PasswardtextBox.PasswordChar = '*';
            PasswardtextBox.Size = new Size(248, 39);
            PasswardtextBox.TabIndex = 1;
            PasswardtextBox.KeyDown += PasswardtextBox_KeyDown;
            PasswardtextBox.KeyPress += PasswardtextBox_KeyPress;
            // 
            // Passward_Label
            // 
            Passward_Label.Anchor = AnchorStyles.None;
            Passward_Label.AutoSize = true;
            Passward_Label.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passward_Label.Location = new Point(36, 129);
            Passward_Label.Name = "Passward_Label";
            Passward_Label.Size = new Size(187, 40);
            Passward_Label.TabIndex = 0;
            Passward_Label.Text = "Passward:";
            // 
            // UserIDtextBox
            // 
            UserIDtextBox.Anchor = AnchorStyles.None;
            UserIDtextBox.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDtextBox.Location = new Point(266, 29);
            UserIDtextBox.Multiline = true;
            UserIDtextBox.Name = "UserIDtextBox";
            UserIDtextBox.Size = new Size(248, 39);
            UserIDtextBox.TabIndex = 1;
            UserIDtextBox.KeyPress += UserIDtextBox_KeyPress;
            // 
            // LogInbutton
            // 
            LogInbutton.Anchor = AnchorStyles.None;
            LogInbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbutton.Location = new Point(526, 126);
            LogInbutton.Name = "LogInbutton";
            LogInbutton.Size = new Size(118, 46);
            LogInbutton.TabIndex = 2;
            LogInbutton.Text = "Log In";
            LogInbutton.UseVisualStyleBackColor = true;
            LogInbutton.Click += LogInbutton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 80);
            label1.Name = "label1";
            label1.Size = new Size(343, 69);
            label1.TabIndex = 3;
            label1.Text = "Health Traker";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 5);
            label2.Name = "label2";
            label2.Size = new Size(172, 40);
            label2.TabIndex = 0;
            label2.Text = "New User";
            // 
            // create
            // 
            create.Anchor = AnchorStyles.None;
            create.BackColor = SystemColors.Highlight;
            create.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create.Location = new Point(256, 3);
            create.Name = "create";
            create.Size = new Size(118, 44);
            create.TabIndex = 2;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(LogInbutton, 2, 1);
            tableLayoutPanel1.Controls.Add(User_ID_Label, 0, 0);
            tableLayoutPanel1.Controls.Add(PasswardtextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(UserIDtextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(Passward_Label, 0, 1);
            tableLayoutPanel1.Location = new Point(75, 200);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0797539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9202461F));
            tableLayoutPanel1.Size = new Size(650, 200);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(create, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(190, 475);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(420, 50);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // NutritionistLogInbutton
            // 
            NutritionistLogInbutton.Anchor = AnchorStyles.None;
            NutritionistLogInbutton.BackColor = SystemColors.GradientActiveCaption;
            NutritionistLogInbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutritionistLogInbutton.Location = new Point(250, 412);
            NutritionistLogInbutton.Name = "NutritionistLogInbutton";
            NutritionistLogInbutton.Size = new Size(300, 50);
            NutritionistLogInbutton.TabIndex = 7;
            NutritionistLogInbutton.Text = "Nutritionist Log In";
            NutritionistLogInbutton.UseVisualStyleBackColor = false;
            NutritionistLogInbutton.Click += NutritionistLogInbutton_Click;
            // 
            // Backbutton
            // 
            Backbutton.Anchor = AnchorStyles.None;
            Backbutton.Enabled = false;
            Backbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbutton.Location = new Point(616, 476);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(104, 46);
            Backbutton.TabIndex = 2;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = true;
            Backbutton.Click += Backbutton_Click;
            // 
            // UserLogIn
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(Backbutton);
            Controls.Add(NutritionistLogInbutton);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "UserLogIn";
            Text = "Health Traker Log In";
            Activated += UserLogIn_Activated;
            Load += UserLogIn_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User_ID_Label;
        private TextBox PasswardtextBox;
        private Label Passward_Label;
        private TextBox UserIDtextBox;
        private Button LogInbutton;
        private Label label1;
        private Label label2;
        private Button create;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button NutritionistLogInbutton;
        private Button Backbutton;
    }
}
