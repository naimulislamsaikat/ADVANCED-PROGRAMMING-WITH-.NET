using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Depertment
    {
        public int DepertmentId { get; set; }
        public string? DepertmentName { get; set; }
        public string? DepertmentType { get; set; }
        public string? DepertmentFacultyList { get; set; }

        [ForeignKey("Student")]
        public virtual Student? DepertmentTitle { get; set; }
        //public virtual ICollection<Student>? Students { get; set; }

    }
}
