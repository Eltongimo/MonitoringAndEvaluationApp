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
        
        public string peopleInvolved { get; set; }
        public string PartnerOrganizations { get; set; }
        public string PartnerInstituitions { get; set; }
                
     }
}

/*
    public string ActivityMacro { get; set; }
    public string Result { get; set; }
    public string specificObjective { get; set; }
    public List<string> personelInvolved {get;set;}
    public List<string> partnerOrganizations {get;set;}
    public List<string> partnerInstituitions  {get;set;} 
 */