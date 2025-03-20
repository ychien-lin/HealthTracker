namespace Final_112323153
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public LogIn login = new LogIn();
        public bool flag;
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
            Create = new Label();
            CreateUserIDLabel = new Label();
            Createbutton = new Button();
            Input_Password_Label = new Label();
            CreateIDtextBox = new TextBox();
            CreatePasswordtextBox = new TextBox();
            groupBox1 = new GroupBox();
            Backbutton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Create.AutoSize = true;
            Create.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create.Location = new Point(83, 30);
            Create.Name = "Create";
            Create.Size = new Size(434, 70);
            Create.TabIndex = 0;
            Create.Text = "Create New ID";
            // 
            // CreateUserIDLabel
            // 
            CreateUserIDLabel.AutoSize = true;
            CreateUserIDLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateUserIDLabel.Location = new Point(23, 36);
            CreateUserIDLabel.Name = "CreateUserIDLabel";
            CreateUserIDLabel.Size = new Size(131, 35);
            CreateUserIDLabel.TabIndex = 1;
            CreateUserIDLabel.Text = "User ID:";
            // 
            // Createbutton
            // 
            Createbutton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Createbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Createbutton.Location = new Point(185, 148);
            Createbutton.Name = "Createbutton";
            Createbutton.Size = new Size(126, 46);
            Createbutton.TabIndex = 3;
            Createbutton.Text = "Create";
            Createbutton.UseVisualStyleBackColor = true;
            Createbutton.Click += Createbutton_Click;
            // 
            // Input_Password_Label
            // 
            Input_Password_Label.AutoSize = true;
            Input_Password_Label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Input_Password_Label.Location = new Point(23, 97);
            Input_Password_Label.Name = "Input_Password_Label";
            Input_Password_Label.Size = new Size(169, 35);
            Input_Password_Label.TabIndex = 1;
            Input_Password_Label.Text = "Password:";
            // 
            // CreateIDtextBox
            // 
            CreateIDtextBox.Font = new Font("Arial", 18F, FontStyle.Bold);
            CreateIDtextBox.Location = new Point(248, 37);
            CreateIDtextBox.Multiline = true;
            CreateIDtextBox.Name = "CreateIDtextBox";
            CreateIDtextBox.Size = new Size(240, 34);
            CreateIDtextBox.TabIndex = 4;
            CreateIDtextBox.KeyDown += CreateIDtextBox_KeyDown;
            CreateIDtextBox.KeyPress += CreateIDtextBox_KeyPress;
            // 
            // CreatePasswordtextBox
            // 
            CreatePasswordtextBox.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePasswordtextBox.Location = new Point(248, 97);
            CreatePasswordtextBox.Multiline = true;
            CreatePasswordtextBox.Name = "CreatePasswordtextBox";
            CreatePasswordtextBox.Size = new Size(240, 34);
            CreatePasswordtextBox.TabIndex = 4;
            CreatePasswordtextBox.KeyDown += CreatePasswordtextBox_KeyDown;
            CreatePasswordtextBox.KeyPress += CreatePasswordtextBox_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreatePasswordtextBox);
            groupBox1.Controls.Add(CreateIDtextBox);
            groupBox1.Controls.Add(Createbutton);
            groupBox1.Controls.Add(Input_Password_Label);
            groupBox1.Controls.Add(CreateUserIDLabel);
            groupBox1.Location = new Point(50, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 200);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Backbutton
            // 
            Backbutton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Backbutton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbutton.Location = new Point(424, 356);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(126, 46);
            Backbutton.TabIndex = 3;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = true;
            Backbutton.Click += Backbutton_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(groupBox1);
            Controls.Add(Create);
            Controls.Add(Backbutton);
            Name = "CreateUser";
            Text = "CreateUser";
            FormClosing += CreateUser_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Create;
        private Label CreateUserIDLabel;
        private Button Createbutton;
        private Label Input_Password_Label;
        private TextBox CreateIDtextBox;
        private TextBox CreatePasswordtextBox;
        private GroupBox groupBox1;
        private Button Backbutton;
    }
}