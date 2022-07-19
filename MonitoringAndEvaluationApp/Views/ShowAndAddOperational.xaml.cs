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
            AssignProperties(project);
        }

        private void AssignProperties(Project p)
        {

            projectName.Text += p.ProjectName;
            specificObjective.Text += p.SpecificObjective;
            activity.Text += p.Activity;
            levelOfConseguimento.Text += p.LevelOfConseguimento;
            partenersInstituition.Text += p.ParticipationInstituition;
            partners.Text += p.PartnerOrganizations;
            partnersBeneficiaries.Text += p.ParticipationBeneficiary;
            impactEvaluation.Text += p.ImpactEvaluation;
            necessaryActions.Text += p.NecessaryActions;

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