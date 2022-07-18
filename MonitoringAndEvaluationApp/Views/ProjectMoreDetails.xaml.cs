using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonitoringAndEvaluationApp.Models;

namespace MonitoringAndEvaluationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectMoreDetails : ContentPage
    {
        private Project project;
        public ProjectMoreDetails(Project p)
        {
            InitializeComponent();
            project = p;
            AddignProperties(project);
        }


        private void AddignProperties(Project p)
        {
            projectName.Text += p.ProjectName;
            date.Text += p.Date;
            location.Text += p.Location;
            time.Text += p.Time;
            duration.Text += p.Duration;
            presentPeople.Text += p.PresentPeople;
            forecastedPeople.Text += p.ForecastedPeople;
            participationPartners.Text += p.ParticipationPartners;
            participationBeneficiary.Text += p.ParticipationBeneficiary;
            participationInstituition.Text += p.ParticipationInstituition;
            productOutCome.Text += p.ProductAndOutcome;
            qlIndicator.Text += p.QLIndicator;
            goodPraticesLearned.Text += p.GoodPraticesLearned;
            mistakesToNotBeRepeated.Text += p.MistakesToNotBeenRepeated;
            futureForwarding.Text += p.FutureForwarding;
            sourcesAndImages.Text += p.SourcesAndImages;
        }
        
    }
}