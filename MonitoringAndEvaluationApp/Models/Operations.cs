using System;
using System.Collections.Generic;
using System.Text;
using  SQLite;

namespace MonitoringAndEvaluationApp.Models
{
    public class Operations
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int projectId { get; set; }
        public List<Activity> Activity { get; set; }
        public int LevelOfConseguimento { get; set; }
        public string necessaryActions { get; set; }
        
    }
}
