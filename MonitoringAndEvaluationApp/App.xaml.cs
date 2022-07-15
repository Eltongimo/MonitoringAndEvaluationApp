﻿using MonitoringAndEvaluationApp.Services;
using MonitoringAndEvaluationApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;

namespace MonitoringAndEvaluationApp
{
    public partial class App : Application
    {

      public static String DatabaseLocation = string.Empty;
      public App()
      {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        
      }

        public App(string databaseLocation)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            DatabaseLocation = databaseLocation;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
