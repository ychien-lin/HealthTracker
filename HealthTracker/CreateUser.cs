using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Final_112323153;



namespace Final_112323153
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();

        }
        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateIDtextBox.Text = "";
            CreatePasswordtextBox.Text = "";
            this.Hide();
            GlobalForm.userloginForm.Show();
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            CreateIDtextBox.Text = "";
            CreatePasswordtextBox.Text = "";
            this.Hide();

            GlobalForm.userloginForm.Show();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {


            if (!Regex.IsMatch(CreateIDtextBox.Text, login.pattern) || !Regex.IsMatch(CreatePasswordtextBox.Text, login.pattern))
            {
                MessageBox.Show("User ID and Password must contain only letters and numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CreateIDtextBox.Text = "";
                CreatePasswordtextBox.Text = "";
                return;
            }
            login.Save(CreateIDtextBox.Text, CreatePasswordtextBox.Text, flag);
            CreateIDtextBox.Text = "";
            CreatePasswordtextBox.Text = "";
            this.Hide();
            GlobalForm.userloginForm.Show();
        }



        private void CreateIDtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
            }
        }



        public void UpdateLabel(string text)
        {
            //用於更新ID
            CreateUserIDLabel.Text = text;
        }

        private void CreateIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能輸入指定字元
            e.Handled = login.KeyProcess(sender, e);
        }

        private void CreatePasswordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = login.KeyProcess(sender, e);
        }
        private void CreatePasswordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //限制密碼不能複製貼上
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
            }
        }

        
    }
}
