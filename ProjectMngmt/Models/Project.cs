using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.Models
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("ProjectCategory")]
        public int ProjectCategoryID { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}