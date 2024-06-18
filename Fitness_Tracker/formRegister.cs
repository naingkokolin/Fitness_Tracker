namespace Fitness_Tracker
{
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }

        private void lblRegisterLogin_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            String registerName = tbRegisterName.Text;
            String registerPassword = tbRegisterPassword.Text;
            int uppercaseCount = 0;
            int lowercaseCount = 0;

            var characters = registerName.ToCharArray();
            if (characters.Length > 0)
            {
                foreach (var character in characters)
                {
                    if (!(Char.IsLetterOrDigit(character)))
                    {
                        MessageBox.Show("The username can only contain letters and numbers!");
                        return;
                    }
                }
            } else
            {
                MessageBox.Show("Please fill the name field!");
                return;
            }

            var passwords = registerPassword.ToCharArray();
            if (passwords.Length == 12 && passwords.Length > 0)
            {
                foreach (var password in passwords)
                {
                    if (Char.IsLower(password)) lowercaseCount++;

                    if (Char.IsUpper(password)) uppercaseCount++;
                }
                if (lowercaseCount == 0 || uppercaseCount == 0)
                {
                    MessageBox.Show("Password should contain at least one upper case or lower case!");
                    return;
                }
                else
                {
                    MessageBox.Show("Account created successfully.");
                }
            }
            else
            {
                MessageBox.Show("The password length must be 12!");
                return;
            }
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            tbRegisterName.Clear();
            tbRegisterPassword.Clear();
        }
    }
}
