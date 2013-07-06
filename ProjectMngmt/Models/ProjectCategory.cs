using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.Models
{
    public class ProjectCategory
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}