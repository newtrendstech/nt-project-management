using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ExceptedWorkHours { get; set; }
        public int TimeSpend { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
        public DateTime EntryDate { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
    }
}