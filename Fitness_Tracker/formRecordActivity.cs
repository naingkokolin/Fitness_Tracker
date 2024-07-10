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
        String selectedActivity = string.Empty;
        Activity activity;
        public formRecordActivity()
        {
            InitializeComponent();
            activity = new Activity();
            lblUser.Text = User.user;
            comboBoxActivities.SelectedIndex = 0;
            lbMetric1.Text = "Steps";
            lbMetric2.Text = "Distance";
            lbMetric3.Text = "Time Taken";
        }

        private void btnChooseActiviy_Click(object sender, EventArgs e)
        {
            selectedActivity = comboBoxActivities.SelectedItem.ToString();
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
                }
                else if (selectedActivity == "Swimming")
                {
                    lbMetric1.Text = "Number of Laps";
                    lbMetric2.Text = "Time Taken";
                    lbMetric3.Text = "Average Heart Rate";
                }
                else if (selectedActivity == "Running")
                {
                    lbMetric1.Text = "Distance";
                    lbMetric2.Text = "Weight";
                    lbMetric3.Text = "Average Pace";
                }
                else if (selectedActivity == "Cycling")
                {
                    lbMetric1.Text = "Time";
                    lbMetric2.Text = "Weight";
                    lbMetric3.Text = "Average Speed";
                }
                else if (selectedActivity == "Yoga")
                {
                    lbMetric1.Text = "Duration";
                    lbMetric2.Text = "Weight";
                    lbMetric3.Text = "Heart Rate";
                }
                else
                {
                    lbMetric1.Text = "Number of Exercises";
                    lbMetric2.Text = "Time";
                    lbMetric3.Text = "Weight Lifted";
                }
            }
            lblSelectedActivity.Visible = true;
            lblSelectedActivity.Text = selectedActivity;
        }

        private void btnCalculateCalory_Click(object sender, EventArgs e)
        {
            var caloryWantToBurn = Double.Parse(tbCaloryBurn.Text);

            selectedActivity = comboBoxActivities.SelectedItem.ToString();
            double metric1 = Double.Parse(tbMetric1.Text);
            double metric2 = Double.Parse(tbMetric2.Text);
            double metric3 = Double.Parse(tbMetric3.Text);
            double caloryBurned = activity.CalculateCaloryBurned(selectedActivity, metric1, metric2, metric3);
            MessageBox.Show(caloryBurned + " calories are burned");

            if (caloryBurned >= caloryWantToBurn)
            {
                MessageBox.Show("Congratulations! You have achieved your goal");
            }
            else
            {
                MessageBox.Show("You need to do some activity a little bit!");
            }
        }

        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            lblTargetCalory.Visible = true;
            lblTargetCalory.Text = tbCaloryBurn.Text;
        }
    }
}
