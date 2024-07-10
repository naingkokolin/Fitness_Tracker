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
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            tbRegisterName.Clear();
            tbRegisterPassword.Clear();
        }
    }
}
