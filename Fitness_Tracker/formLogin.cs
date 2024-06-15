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
            String loginName = tbLoginName.Text;
            String loginPassword = tbLoginPassword.Text;


        }
    }
}
