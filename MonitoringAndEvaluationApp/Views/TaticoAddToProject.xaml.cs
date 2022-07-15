using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonitoringAndEvaluationApp.Views;
using SQLite;
using MonitoringAndEvaluationApp.Models;

namespace MonitoringAndEvaluationApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaticoAddToProject : ContentPage
    {
        public TaticoAddToProject()
        {
            InitializeComponent();
        }


        public void AddProject(object ob, EventArgs e)
        {
            Navigation.PushAsync(new AddProjectPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Project>();
                List<Project> projects = conn.Table<Project>().ToList();
                projectView.ItemsSource = projects;
            }
        }

        public void HandleSelectedItem(object sender, SelectedItemChangedEventArgs item)
        {
           Project selectedProject =  ((ListView)sender).SelectedItem as Project;

           Navigation.PushAsync(new ShowProjectDetails(selectedProject));

        }

    }
}