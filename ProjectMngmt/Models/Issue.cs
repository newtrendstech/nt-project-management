using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.Models
{
    public class Issue
    {
        [Key]
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Priority { get; set; }
        public string Severity { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime EntryDate { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
    }
}