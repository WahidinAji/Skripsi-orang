using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentalModeOn.Views.Perencanaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProsesPage : ContentPage
    {
        public ProsesPage()
        {
            InitializeComponent();
            //slider.Value = 0.8;
        }

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = string.Format("the value is {0:F3}", e.NewValue);
        //}
    }
}