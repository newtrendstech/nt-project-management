using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.DAL.Entity
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string Description { get; set; }
    }
}
