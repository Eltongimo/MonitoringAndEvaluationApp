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
    public partial class ShowAndAddOperational : ContentPage
    {

        private Project project;
        
        public ShowAndAddOperational(Project p)
        {
            InitializeComponent();
            project = p;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
               //   conn.CreateTable<Project>();
               // List<Project> projects = conn.Table<Project>().ToList();
               // projectView.ItemsSource = projects;
            }
        }
    }
}