﻿using System;
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
    public partial class ShowProjectDetails : ContentPage
    {

        public Project project { get; set; }

        public ShowProjectDetails(Project p)
        {
           InitializeComponent();
           project = p;
           AssignProperties(p);
        }

        private void AssignProperties(Project p)
        {
            projectName.Text += p.ProjectName;
            operatorName.Text += p.OperatorName;
            activity.Text += p.Activity;
        }

        private void RemoveProject(object sender, EventArgs e)
        {

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                if (conn.Delete<Project>(project.Id) > 0)
                    DisplayAlert("Message", "Projecto apagado com sucesso", "Ok");
                else
                    DisplayAlert("Message", "Erro ao apagar projecto", "Ok");
            }
            Navigation.PushAsync(new TaticoAddToProject());

        }
    }
}