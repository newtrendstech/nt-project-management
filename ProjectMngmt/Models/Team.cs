using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.Models
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string Description { get; set; }
    }
}