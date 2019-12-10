using RentalModeOn.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalModeOn.ViewModels
{
    public class ViewModelStatistik
    {
        public List<ModelStatistik> Data { get; set; }
        public ViewModelStatistik()
        {
            Data = new List<ModelStatistik>()
            {
                new ModelStatistik("Wahidin",195),
                new ModelStatistik("Aji",175),
                new ModelStatistik("Stepen", 175),
                new ModelStatistik("John", 180)
            };
        }
    }
}
