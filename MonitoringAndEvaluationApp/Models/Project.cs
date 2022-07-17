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
        
        public string PeopleInvolved { get; set; }
        public string PartnerOrganizations { get; set; }
        public string PartnerInstituitions { get; set; }
                
     }
}