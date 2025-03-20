using OpenCvSharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_112323153
{
    partial class CaptuePicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        HealthData healthData = new HealthData();
        LogIn login = new LogIn();
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private bool isCameraRunning;
        public string userID;
        public string date;
        public string time;
        public string savefilepath;

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
            CapturePictureBox = new PictureBox();
            Shotbtn = new Button();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CapturePictureBox).BeginInit();
            SuspendLayout();
            // 
            // CapturePictureBox
            // 
            CapturePictureBox.Location = new System.Drawing.Point(25, 29);
            CapturePictureBox.Name = "CapturePictureBox";
            CapturePictureBox.Size = new System.Drawing.Size(640, 480);
            CapturePictureBox.TabIndex = 0;
            CapturePictureBox.TabStop = false;
            // 
            // Shotbtn
            // 
            Shotbtn.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shotbtn.Location = new System.Drawing.Point(671, 227);
            Shotbtn.Name = "Shotbtn";
            Shotbtn.Size = new System.Drawing.Size(97, 80);
            Shotbtn.TabIndex = 1;
            Shotbtn.Text = "Shot";
            Shotbtn.UseVisualStyleBackColor = true;
            Shotbtn.Click += Shotbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new System.Drawing.Point(671, 429);
            backbtn.Name = "backbtn";
            backbtn.Size = new System.Drawing.Size(97, 80);
            backbtn.TabIndex = 1;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += Backbtn_Click;
            // 
            // CaptuePicture
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 553);
            Controls.Add(backbtn);
            Controls.Add(Shotbtn);
            Controls.Add(CapturePictureBox);
            Name = "CaptuePicture";
            Text = "CaptuePicture";
            FormClosing += CaptuePicture_FormClosing;
            Load += CaptuePicture_Load;
            ((System.ComponentModel.ISupportInitialize)CapturePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox CapturePictureBox;
        private System.Windows.Forms.Button Shotbtn;
        private System.Windows.Forms.Button backbtn;
    }
}
