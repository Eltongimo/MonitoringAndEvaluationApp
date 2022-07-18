using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonitoringAndEvaluationApp.Models;
using SQLite;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowTaticoMore : ContentPage
    {
        public ShowTaticoMore()
        {
            InitializeComponent();
        }


        public void HandleSelectedItem(object sender, SelectedItemChangedEventArgs item)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Project2>();
                List<Project2> projects = conn.Table<Project2>().ToList();
                projectView.ItemsSource = projects;
            }
        }

        private void AddProjectMoreDetails(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewProjectMoreDetails());
        }

        private void ShowMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(null);
        }

    }
}