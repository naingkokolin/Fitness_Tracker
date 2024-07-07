using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Fitness_Tracker
{
    public partial class formRegistration : Form
    {
        User user = new User();
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
            bool isUsernameValid = false, isPasswordValid = false;
            String registerName = tbRegisterName.Text;
            String registerPassword = tbRegisterPassword.Text;
            isUsernameValid = user.ValidateUsername(registerName);
            isPasswordValid = user.ValidatePassword(registerPassword);
            if (isUsernameValid && isPasswordValid )
            {
                string connectionString = "server=localhost;database=fitness_tracker;uid=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                    {
                        mySqlConnection.Open();
                        string insertQuery = "INSERT INTO account (username, password) VALUES (@username, @password)";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@username", registerName);
                            cmd.Parameters.AddWithValue("@password", registerPassword);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                formLogin loginForm = new formLogin();
                loginForm.Show();
                this.Hide();
            }
            

            //int uppercaseCount = 0;
            //int lowercaseCount = 0;

            //var characters = registerName.ToCharArray();
            //if (characters.Length > 0)
            //{
            //    foreach (var character in characters)
            //    {
            //        if (!(Char.IsLetterOrDigit(character)))
            //        {
            //            MessageBox.Show("The username can only contain letters and numbers!");
            //            return;
            //        }
            //    }
            //} else
            //{
            //    MessageBox.Show("Please fill the name field!");
            //    return;
            //}

            //var passwords = registerPassword.ToCharArray();
            //if (passwords.Length == 12 && passwords.Length > 0)
            //{
            //    foreach (var password in passwords)
            //    {
            //        if (Char.IsLower(password)) lowercaseCount++;

            //        if (Char.IsUpper(password)) uppercaseCount++;
            //    }
            //    if (lowercaseCount == 0 || uppercaseCount == 0)
            //    {
            //        MessageBox.Show("Password should contain at least one upper case or lower case!");
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Account created successfully.");
            //        formRecordActivity recordActivityForm = new formRecordActivity();
            //        recordActivityForm.Show();
            //        this.Hide();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("The password length must be 12!");
            //    return;
            //}
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            tbRegisterName.Clear();
            tbRegisterPassword.Clear();
        }
    }
}
