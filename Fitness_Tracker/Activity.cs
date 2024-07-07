using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    public class Activity
    {
        public string Name;
        public string Metric1;
        public string Metric2;
        public string Metric3;
        public double CaloryBurned;

        public Activity()
        {
        
        }

        public double CalculateCaloryBurned(String activityName, double metric1, double metric2, double metric3)
        {
            if (activityName == null)
            {
                return 0.0;
            }

            if (activityName.Equals("Walking"))
            {
                CaloryBurned = metric1 * metric2 * 0.57;
            } 
            else if (activityName == "Swimming")
            {
                CaloryBurned = metric1 * (3.5 * 7 * metric2) / 200;
            }
            else if (activityName == "Running")
            {
                CaloryBurned = metric1 * metric2 * 1.036;
            }
            else if (activityName == "Cycling")
            {
                CaloryBurned = metric1 * (3.5 * 6 * metric2);
            }
            else if (activityName == "Yoga")
            {
                CaloryBurned = (metric1 * 3 * metric2) / 200;
            }
            else
            {
                CaloryBurned = metric1 * (3.5 * 6 * metric2);
            }

            return CaloryBurned;
        }
    }
}
