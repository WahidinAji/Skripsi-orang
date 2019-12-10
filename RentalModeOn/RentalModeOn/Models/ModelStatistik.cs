using System;
using System.Collections.Generic;
using System.Text;

namespace RentalModeOn.Models
{
    public class ModelStatistik
    {
        public string Name { get; set; }

        public double Height { get; set; }
        public ModelStatistik(string name, double height)
        {
            this.Name = name;
            this.Height = height;
        }
    }
}
