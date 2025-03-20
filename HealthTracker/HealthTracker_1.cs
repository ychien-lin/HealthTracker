using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_112323153.LogIn;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Final_112323153
{
    public partial class HealthTracker_1 : Form
    {
        public HealthTracker_1()
        {
            InitializeComponent();
        }

        private void Readbutton_Click(object sender, EventArgs e)
        {
            HealthData healthresult = healthData.Load(userID, flag);
            IAdviceService adviceService = new HealthData();
            if (flag)
            {
                filepath = healthresult.HealthDataUserfilePath;
            }
            if (healthresult.State == VaildState.VALID)
            {
                if (healthresult.HealthDataUserfilePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    if (adviceService.isAdvice(healthresult.HealthDataUserfilePath))
                    {
                        NAdviceTextBox.Text = adviceService.ReadAdvice(healthresult.HealthDataUserfilePath);
                    }
                    else
                    {
                        var HealthValues = healthData.ReadHealthdata(healthresult.HealthDataUserfilePath);
                        if (HealthValues.Count > 0)
                        {
                            try
                            {
                                HealthData firstHealthData = HealthValues[0];
                                BStextBox.Text = firstHealthData.BloodSugar;
                                HRtextBox.Text = firstHealthData.HeartRate;
                                BPtextBox.Text = firstHealthData.BloodPressure;
                                CLtextBox.Text = firstHealthData.Cholesterol;
                                WtextBox.Text = firstHealthData.Weight;
                            }
                            catch 
                            {
                                MessageBox.Show("Health data have some error.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No health data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else if (healthresult.HealthDataUserfilePath.EndsWith(".jpg") || healthresult.HealthDataUserfilePath.EndsWith(".jpeg") || healthresult.HealthDataUserfilePath.EndsWith(".png"))
                {
                    pictureBox.Image = healthData.DisplayImage(healthresult.HealthDataUserfilePath);

                }

                else
                {
                    MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        private void AddNewDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm.healthtracker_2Form.date = date;
            GlobalForm.healthtracker_2Form.time = time;
            GlobalForm.healthtracker_2Form.Show();
        }



        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BStextBox.Text = HRtextBox.Text = BPtextBox.Text = CLtextBox.Text = WtextBox.Text = NAdviceTextBox.Text="";
            pictureBox.Image = null;
            this.flag = false;
            GlobalForm.userloginForm.flag = this.flag;
            GlobalForm.userloginForm.Show();
        }

        private void HealthTracker_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if(flag) { healthData.SaveAdvice(filepath, date, time, NAdviceTextBox.Text); }
            
        }

        

        private void HealthTracker_1_Activated(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("MMdd");
            time = DateTime.Now.ToString("HHmm");
            Timelabel.Text = date;
            
            if (flag)
            {
                UserID_Label.Text = userID;
                NAdviceTextBox.Enabled = true;
                AddNewDataButton.Enabled = false;
                AddNewDataButton.Visible = false;
                Savebtn.Enabled = true;
                Savebtn.Visible = true;
                
            }
            else
            {
                UserID_Label.Text = userID;
                NAdviceTextBox.Enabled = false;
                AddNewDataButton.Enabled = true;
                AddNewDataButton.Visible = true;
                Savebtn.Enabled = false;
                Savebtn.Visible = false;
                
            }
        }
    }
}
