using MonitoringAndEvaluationApp.ViewModels;
using MonitoringAndEvaluationApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MonitoringAndEvaluationApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(TaticoAddToProject), typeof(TaticoAddToProject));
        
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
