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

        private void CancelSubmission(object s,EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void SubmitForm(object s, EventArgs e)
        {

            Project newProject = new Project()
            {
                ProjectName = projectName.Text,
                OperatorName = operatorName.Text,
                Activity = activity.Text,
                TypeOfActivity = typeOfActivity.Text,
                MacroActivity = macroActivity.Text,
                SpecificObjective = specificObjective.Text,
                PeopleInvolved = peopleInvolved.Text,
                PartnerOrganizations = partnerOrganizations.Text,
                PartnerInstituitions = partnerInstituitions.Text,
                Date = date.Text,
                Time = time.Text,
                Location = location.Text,
                Duration = duration.Text,
                PresentPeople = presentPeople.Text,
                ForecastedPeople = forecastedPeople.Text,
                ParticipationPartners = participationPartners.Text,
                ParticipationBeneficiary = participationBeneficiary.Text,
                ParticipationInstituition = participationInstituition.Text,
                ProductAndOutcome = productsAndOutcome.Text,
                QLIndicator = qlIndicator.Text,
                GoodPraticesLearned  = goodPraticeLearned.Text,
                MistakesToNotBeenRepeated = mistakesToNotBeRepeated.Text,
                FutureForwarding = futureForward.Text,
                SourcesAndImages = imagesAndSources.Text,
                ImpactEvaluation = evaluationImpact.Text,
                LevelOfConseguimento = levelOfConseguimento.Text
        };
            
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

            conn.CreateTable<Project>();
            int rows = conn.Insert(newProject);
            conn.Close();

            if (rows > 0)
            {
                DisplayAlert("Sucesso", "Dados cadastrados com sucesso", "Ok");
            }
            else
            {
                DisplayAlert("Falha", "Falha no cadastro!", "Ok");
            }
            Navigation.PopAsync();
        }
    }
}