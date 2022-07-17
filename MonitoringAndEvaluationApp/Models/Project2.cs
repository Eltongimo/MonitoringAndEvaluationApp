using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MonitoringAndEvaluationApp.Models
{
    
    public class Project2
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
        public string Duration { get; set; }
        public int presentPeople { get; set; }
        public int ForecastedPeople { get; set; }
        public int ParticipationBeneficiary { get; set; }
        public int ParticipationInstituition { get; set; }
        public int ProductOutcomeActivity { get; set; }
        public int QLIndicator { get; set; }
        public string GoodPraticesLearned { get; set; }

        public string MistakesToNotBeenRepeated { get; set; }   
        public string SourcesAndImages { get; set; }

    }
}
