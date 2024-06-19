using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    public class Activity
    {
        public string Name { get; }
        public string Metric1 { get; }
        public string Metric2 { get; }
        public string Metric3 { get; }
        public double CaloryBurned { get; set; }

        public Activity(string name, string metric1, string metric2, string metric3)
        {
            Name = name;
            Metric1 = metric1;
            Metric2 = metric2;
            Metric3 = metric3;
        }

        public double CalculateCaloryBurned(Activity activity)
        {
            if (activity == null)
            {
                return 0.0;
            }

            if (activity.Name == "Walking")
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * Int32.Parse(activity.Metric2) * 0.57;
            } 
            else if (activity.Name == "Swimming")
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * (3.5 * 7 * Int32.Parse(activity.Metric2)) / 200;
            }
            else if (activity.Name == "Running")
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * Int32.Parse(activity.Metric2) * 1.036;
            }
            else if (activity.Name == "Cycling")
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * (3.5 * 6 * Int32.Parse(activity.Metric2)) / 200;
            }
            else if (activity.Name == "Yoga")
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * (3 * Int32.Parse(activity.Metric2)) / 200;
            }
            else
            {
                CaloryBurned = Int32.Parse(activity.Metric1) * (3.5 * 6 * Int32.Parse(activity.Metric2)) / 200;
            }

            return CaloryBurned;
        }
    }
}
