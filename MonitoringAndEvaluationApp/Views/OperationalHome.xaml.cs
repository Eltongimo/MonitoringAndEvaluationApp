using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using MonitoringAndEvaluationApp.Models;
using Xamarin.Forms.Xaml;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OperationalHome : ContentPage
    {
        public OperationalHome()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Project>();
                List<Project> projects = conn.Table<Project>().ToList();
                projectViewContent.ItemsSource = projects;
            }
        }

        public void HandleItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = ((ListView)sender).SelectedItem as Project;

           Navigation.PushAsync(new ShowAndAddOperational());
        }
    }
}