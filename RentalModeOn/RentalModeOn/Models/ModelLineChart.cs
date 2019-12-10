using System;
using System.Collections.Generic;
using System.Text;

namespace RentalModeOn.Models
{
    public class ModelLineChart
    {
        public string Month { get; set; }

        public double Target { get; set; }

        public ModelLineChart(string xValue, double yValue)
        {
            Month = xValue;
            Target = yValue;
        }
    }
}
