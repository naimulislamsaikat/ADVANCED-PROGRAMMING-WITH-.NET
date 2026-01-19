using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Model
{
    public class Course
    {
        [Key] public int CId { get; set; }
        public string CName { get; set; }

        [ForeignKey("Depertment")]
        public int DepId { get; set; }
        public virtual Depertment Depertment { get; set; }
    }
}
