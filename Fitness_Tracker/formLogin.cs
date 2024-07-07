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
            this.Hide();
            formRegistration.ShowDialog();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            bool isValidAccount = false;
            String loginName = tbLoginName.Text;
            String loginPassword = tbLoginPassword.Text;
            isValidAccount = user.checkUsernamePassword(loginName, loginPassword);
            if (isValidAccount)
            {
                formRecordActivity recordActivityForm = new formRecordActivity();
                recordActivityForm.Show();
                this.Hide();
            }
        }
    }
}
