using RentalModeOn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RentalModeOn.ViewModels
{
    public class ViewModelLineChart
    {
        public ObservableCollection<ModelLineChart> DataLine1 { get; set; }
        public ObservableCollection<ModelLineChart> DataLine2 { get; set; }

        public ViewModelLineChart()
        {
            DataLine1 = new ObservableCollection<ModelLineChart>()
            {
                new  ModelLineChart("Jan", 35),
                new  ModelLineChart("Feb", 48),
                new  ModelLineChart("Mar", 65),
                new  ModelLineChart("Apr", 79),
                new  ModelLineChart("May", 75),
            };

            DataLine2 = new ObservableCollection<ModelLineChart>()
            {
                new  ModelLineChart("Jan", 20),
                new  ModelLineChart("Feb", 30),
                new  ModelLineChart("Mar", 40),
                new  ModelLineChart("Apr", 70),
                new  ModelLineChart("May", 65),
            };
        }
    }
}
