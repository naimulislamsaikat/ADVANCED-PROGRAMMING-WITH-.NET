using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Model
{
    public class Payment
    {
        [Key]public int PId { get; set; }
        public string PType { get; set; }
        public decimal PAmount { get; set; }
        public int PSemester { get; set; }
        public string PStatus { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
