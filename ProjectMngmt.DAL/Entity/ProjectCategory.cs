using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMngmt.DAL.Entity
{
    public class ProjectCategory
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
