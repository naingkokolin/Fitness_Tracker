using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public class User
    {
        private string username;
        private string password;
        private string connectionString = "server=localhost;database=fitness_tracker;uid=root";

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

        // Check the username and add to the database
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

                //try
                //{
                //    using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                //    {
                //        mySqlConnection.Open();
                //        string insertQuery = "INSERT INTO account (username) VALUES (@username)";
                //        using (MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection))
                //        {
                //            cmd.Parameters.AddWithValue("@username", username);
                //            cmd.ExecuteNonQuery();
                //            isValid = true;
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            else
            {
                MessageBox.Show("Please fill the name field!");
            }

            return isValid;
        }

        // Validate the password and add to the database
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

                    //try
                    //{
                    //    using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                    //    {
                    //        mySqlConnection.Open();
                    //        string insertQuery = "INSERT INTO account (password) VALUES (@password)";
                    //        using (MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection))
                    //        {
                    //            cmd.Parameters.AddWithValue("@password", password);
                    //            cmd.ExecuteNonQuery();
                    //        }
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                }
            }
            else
            {
                MessageBox.Show("The password length must be 12!");
            }

            return isValid;
        }
    }
}
