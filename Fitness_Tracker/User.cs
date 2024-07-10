using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public class User
    {
        private string username = string.Empty;
        private string password = string.Empty;
        private string connectionString = "server=localhost;database=fitness_tracker;uid=root";
        public static int logiAttemptCount = 5;
        public static string user = string.Empty;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Check the username to accept the registration
        public bool ValidateUsername(string username)
        {
            bool isValid = false;

            var characters = username.ToCharArray();
            if (characters.Length > 0)
            {
                foreach (var character in characters)
                {
                    if (!char.IsLetterOrDigit(character))
                    {
                        MessageBox.Show("The username can only contain letters and numbers!");
                        return isValid;
                    }   
                }
                isValid = true;
            }
            else
            {
                MessageBox.Show("Please fill the name field!");
            }

            return isValid;
        }

        // Validate the password to accept the registration
        public bool ValidatePassword(string password)
        {
            bool isValid = false;

            int uppercaseCount = 0;
            int lowercaseCount = 0;

            var passwords = password.ToCharArray();
            if (passwords.Length == 12)
            {
                foreach (var p in passwords)
                {
                    if (char.IsLower(p)) lowercaseCount++;
                    if (char.IsUpper(p)) uppercaseCount++;
                }

                if (lowercaseCount == 0 || uppercaseCount == 0)
                {
                    MessageBox.Show("Password should contain at least one uppercase and one lowercase letter!");
                    return isValid;
                }
                else
                {
                    isValid = true;
                    MessageBox.Show("Account created successfully.");
                }
            }
            else
            {
                MessageBox.Show("The password length must be 12!");
            }

            return isValid;
        }

        public bool checkUsernamePassword(string username, string password)
        {
            bool isValid = false;
            string connectionString = "server=localhost;database=fitness_tracker;uid=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string getQuery = "SELECT username, password FROM account WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(getQuery, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string dbUsername = reader["username"].ToString() as string ?? string.Empty;
                    string dbPassword = reader["password"].ToString() as string ?? string.Empty;

                    if (username != null && password != null)
                    {
                        if (username != dbUsername || password != dbPassword)
                        {
                            MessageBox.Show("Username or password is incorrect!");
                            return isValid;
                        }
                        else
                        {
                            isValid = true;
                            user = username;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                    return isValid;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isValid;
        }
    }
}
