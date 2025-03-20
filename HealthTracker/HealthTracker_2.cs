using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_112323153.LogIn;

namespace Final_112323153
{
    public partial class HealthTracker_2 : Form
    {
        public HealthTracker_2()
        {
            InitializeComponent();

        }

        private void Capturebtn_Click(object sender, EventArgs e)
        {
            GlobalForm.capturepictureForm.date = this.date;
            GlobalForm.capturepictureForm.time = this.time;
            GlobalForm.capturepictureForm.savefilepath = this.savefilepath;
            GlobalForm.capturepictureForm.Show();

            this.Hide();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            if (healthData.isInputOK(BStextBox.Text, HRtextBox.Text, BPtextBox.Text, CLtextBox.Text, WtextBox.Text) == VaildState.VALID && CapturePictureBox_Show != null)
            {
                healthData.BloodSugar = BStextBox.Text;
                healthData.HeartRate = HRtextBox.Text;
                healthData.BloodPressure = BPtextBox.Text;
                healthData.Cholesterol = CLtextBox.Text;
                healthData.Weight = WtextBox.Text;
                healthDataContent = $"{healthData.BloodSugar}\n{healthData.HeartRate}\n{healthData.BloodPressure}\n{healthData.Cholesterol}\n{healthData.Weight}";
                healthData.SaveHealthData(userID, date, time, healthDataContent);
                healthData.SaveImage((Bitmap)image, userID, date, time);
                this.Hide();
                GlobalForm.healthtracker_1Form.Show();
            }
            else
            {
                MessageBox.Show("Failed to save the file " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void HealthTracker_2_Load(object sender, EventArgs e)
        {

            UserID_Label.Text = login.UserId;
            savefilepath = healthData.isDirectoryExcits(login.UserId, date, time);


        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm.healthtracker_1Form.Show();
            BStextBox.Text = "";
            HRtextBox.Text = "";
            BPtextBox.Text = "";
            CLtextBox.Text = "";
            WtextBox.Text = "";
        }

        private void HealthTracker_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            GlobalForm.healthtracker_1Form.Show();
        }

        private void HealthTracker_2_Activated(object sender, EventArgs e)
        {
            if (image != null)
            {
                int width = CapturePictureBox_Show.Width;
                int height = CapturePictureBox_Show.Height;
                Image resizedImage = healthData.ResizeImage(image, width, height);
                CapturePictureBox_Show.Image = resizedImage;
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            CapturePictureBox_Show.Image = null;
        }

        //限制輸入字元
        private void BStextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = healthData.KeyProcess(sender, e);
        }

        private void HRtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = healthData.KeyProcess(sender, e);
        }

        private void BPtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = healthData.KeyProcess(sender, e);
        }

        private void CLtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = healthData.KeyProcess(sender, e);
        }

        private void WtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = healthData.KeyProcess(sender, e);
        }
    }
}
