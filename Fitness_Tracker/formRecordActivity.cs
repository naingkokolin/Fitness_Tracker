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
    public partial class formRecordActivity : Form
    {
        public formRecordActivity()
        {
            InitializeComponent();
            comboBoxActivities.SelectedIndex = 0;
            lbMetric1.Text = "Steps";
            lbMetric2.Text = "Distance";
            lbMetric3.Text = "Time Taken";
        }

        private void btnChooseActiviy_Click(object sender, EventArgs e)
        {
            string selectedActivity = comboBoxActivities.SelectedItem.ToString();
            if (selectedActivity == null)
            {
                selectedActivity = comboBoxActivities.Items[0].ToString();
            } 
            else
            {
                if (selectedActivity == "Walking")
                {
                    lbMetric1.Text = "Steps";
                    lbMetric2.Text = "Distance";
                    lbMetric3.Text = "Time Taken";
                    MessageBox.Show("You chose walking");
                }
                else if (selectedActivity == "Swimming")
                {
                    lbMetric1.Text = "Number of Laps";
                    lbMetric2.Text = "Time Taken";
                    lbMetric3.Text = "Average Heart Rate";
                    MessageBox.Show("You chose swimming");
                }
                else if (selectedActivity == "Running")
                {
                    lbMetric1.Text = "Distance";
                    lbMetric2.Text = "Time Taken";
                    lbMetric3.Text = "Average Pace";
                    MessageBox.Show("You chose running");
                } 
                else if (selectedActivity == "Cycling")
                {
                    lbMetric1.Text = "Distance";
                    lbMetric2.Text = "Time Taken";
                    lbMetric3.Text = "Average Speed";
                    MessageBox.Show("You chose Cycling");
                }
                else if (selectedActivity == "Yoga")
                {
                    lbMetric1.Text = "Duration";
                    lbMetric2.Text = "Difficulty Level";
                    lbMetric3.Text = "Heart Rate";
                    MessageBox.Show("You chose yoga");
                } else
                {
                    lbMetric1.Text = "Number of Exercises";
                    lbMetric2.Text = "Repetition";
                    lbMetric3.Text = "Weight Lifted";
                    MessageBox.Show("You chose strength training");
                }
            }
        }
    }
}
