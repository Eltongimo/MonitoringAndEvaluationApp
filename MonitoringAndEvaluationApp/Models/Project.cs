using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MonitoringAndEvaluationApp.Models
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string ProjectName { get; set; }
        public string OperatorName { get; set; }
        public string Activity { get; set; }
        public string  TypeOfActivity { get; set; }
        public string MacroActivity { get; set; }
        public string SpecificObjective { get; set; }
        //**
        public string ImpactEvaluation { get; set; }
        //**
        public string LevelOfConseguimento { get; set; }
        //**
        public string NecessaryActions { get; set; }
        public string PeopleInvolved { get; set; }
        public string PartnerOrganizations { get; set; }
        public string PartnerInstituitions { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string PresentPeople { get; set; }
        public string ForecastedPeople { get; set; }
        public string ParticipationPartners { get; set; }
        public string ParticipationBeneficiary { get; set; }
        public string ParticipationInstituition { get; set; }
        public string ProductAndOutcome { get; set; }
        public string QLIndicator { get; set; }
        public string GoodPraticesLearned { get; set; }
        public string MistakesToNotBeenRepeated { get; set; }
        public string FutureForwarding { get; set; }
        public string SourcesAndImages { get; set; }

    }
}