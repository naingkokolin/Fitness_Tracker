using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class formLogin : Form
    {
        User user = new User();
        public formLogin()
        {
            InitializeComponent();
        }

        private void lblLoginRegister_Click(object sender, EventArgs e)
        {
            formRegistration formRegistration = new formRegistration();
            formRegistration.Show();
            this.Hide();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            bool isValidAccount = false;
            String loginName = tbLoginName.Text;
            String loginPassword = tbLoginPassword.Text;
            isValidAccount = user.checkUsernamePassword(loginName, loginPassword);
            if (isValidAccount)
            {
                User.logiAttemptCount = 0;
                formRecordActivity recordActivityForm = new formRecordActivity();
                recordActivityForm.Show();
                this.Hide();
            }
            else
            {
                User.logiAttemptCount--;
                if (User.logiAttemptCount <= 0)
                {
                    MessageBox.Show("You have reached the limit of login attempts. Please try again later or register another account.");
                    this.Close();
                }
                else if (User.logiAttemptCount <= 3)
                {
                    lbLoginAttemptCount.Text = "Remaining Login Attempts: " + User.logiAttemptCount;
                    lbLoginAttemptCount.Visible = true;
                }
            }
        }
    }
}
