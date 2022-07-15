using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using MonitoringAndEvaluationApp.Models;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void SubmitForm(object s, EventArgs e)
        {

            Project newProject = new Project()
            {
                ProjectName = projectName.Text,
                OperatorName = operatorName.Text,
                Activity = activity.Text

            };
            
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

            conn.CreateTable<Project>();
            int rows = conn.Insert(newProject);
            conn.Close();

            if (rows > 0)
            {
                DisplayAlert("Sucess", "Succesfully!", "Ok");
            }
            else
            {
                DisplayAlert("Failure", "Failded!", "Ok");
            }

            Navigation.PushAsync(new TaticoAddToProject());
        }
    }
}