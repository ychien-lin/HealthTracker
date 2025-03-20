using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Final_112323153.LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Final_112323153
{
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
        }



        private void LogInbutton_Click(object sender, EventArgs e)
        {


            if (!Regex.IsMatch(UserIDtextBox.Text, login.pattern) || !Regex.IsMatch(PasswardtextBox.Text, login.pattern))
            {
                MessageBox.Show("User ID and Password must contain only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserIDtextBox.Text = "";
                PasswardtextBox.Text = "";
                return;
            }
            LogIn result = login.Validation(UserIDtextBox.Text, PasswardtextBox.Text, flag);
            if (result.State == VaildState.VALID)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GlobalForm.createuserForm.flag = flag;
                GlobalForm.healthtracker_1Form.flag = flag;
                GlobalForm.healthtracker_1Form.userID = result.UserId;
                GlobalForm.healthtracker_2Form.userID = result.UserId;
                GlobalForm.capturepictureForm.userID = result.UserId;

                GlobalForm.healthtracker_1Form.Show();
                UserIDtextBox.Text = "";
                PasswardtextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Please Try Again", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserIDtextBox.Text = "";
                PasswardtextBox.Text = "";
            }
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            User_ID_Label.Text = "User ID:";
            flag = false;
            Backbutton.Enabled = false;
            Backbutton.Visible = false;
            tableLayoutPanel2.Enabled = true;
            tableLayoutPanel2.Visible = true;
            NutritionistLogInbutton.Enabled = true;
            NutritionistLogInbutton.Visible = true;
        }
        private void NutritionistLogInbutton_Click(object sender, EventArgs e)
        {
            User_ID_Label.Text = "Nutritionist ID:";
            GlobalForm.createuserForm.UpdateLabel("Nutritionist ID:");
            flag = true;
            tableLayoutPanel2.Visible = false;
            Backbutton.Enabled = true;
            Backbutton.Visible = true;
            NutritionistLogInbutton.Enabled = false;
            NutritionistLogInbutton.Visible = false;
            UserIDtextBox.Text = "";
            PasswardtextBox.Text = "";
        }




        private void UserIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制字元
            e.Handled = login.KeyProcess(sender, e);
        }
        private void PasswardtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //限制密碼不能複製貼上
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
            }
        }
        private void PasswardtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = login.KeyProcess(sender, e);
        }

        private void create_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm.createuserForm.login.pattern = login.pattern;
            GlobalForm.createuserForm.Show();

        }

        private void UserLogIn_Load(object sender, EventArgs e)
        {
            Backbutton.Enabled = false;
            Backbutton.Visible = false;
        }

        private void UserLogIn_Activated(object sender, EventArgs e)
        {
            
            Backbutton.Enabled = false;
            Backbutton.Visible = false;
            tableLayoutPanel2.Visible = true;
            tableLayoutPanel2.Enabled = true;
            NutritionistLogInbutton.Enabled = true;
            NutritionistLogInbutton.Visible = true;

        }

        
    }
}
