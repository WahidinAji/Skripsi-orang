﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentalModeOn
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc0NTcwQDMxMzcyZTMzMmUzME1Ybnd3WitCVlVlYmhrVmRxUnhDamFmZm90Q09UcTZ1R3hlUUFPbTIzS1U9");
            InitializeComponent();

            MainPage = new Views.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
