using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_112323153
{
    public partial class CaptuePicture : Form
    {
        //參考來源:https://stackoverflow.com/questions/50812961/simple-camera-capture-in-winforms

        public CaptuePicture()
        {
            InitializeComponent();
            isCameraRunning = false;
        }

        private void InitializeCamera()
        {
            capture = new VideoCapture(0); // 0表示默认相机
            capture.Open(0);
            if (capture.IsOpened())
            {
                isCameraRunning = true;
                Application.Idle += ProcessFrame;
            }
            else
            {
                MessageBox.Show("Failed to open camera. Please check your device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalForm.healthtracker_2Form.Show();
                this.Close();
            }
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                using (var frame = new Mat())
                {
                    capture.Read(frame);
                    if (!frame.Empty())
                    {
                        CapturePictureBox.Image?.Dispose(); // Dispose the previous image if any
                        image = BitmapConverter.ToBitmap(frame);
                        CapturePictureBox.Image = image;
                    }
                }
            }
        }

        private void Shotbtn_Click(object sender, EventArgs e)
        {
            if (CapturePictureBox.Image != null)
            {
                var tempImage = new Bitmap(CapturePictureBox.Image);
                GlobalForm.healthtracker_2Form.image = tempImage;
                this.Hide();
                GlobalForm.healthtracker_2Form.Show();
                MessageBox.Show("Success to capture the picture ", "Capture success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to capture the picture ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm.healthtracker_2Form.Show();

        }

        

        private void CaptuePicture_Load(object sender, EventArgs e)
        {
            InitializeCamera();

        }

        private void CaptuePicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCameraRunning)
            {
                isCameraRunning = false;
                Application.Idle -= ProcessFrame;
                this.Hide();
                GlobalForm.healthtracker_2Form.Show();
                capture.Release();
            }
            this.Hide();
            GlobalForm.healthtracker_2Form.Show();
        }
    }
}
