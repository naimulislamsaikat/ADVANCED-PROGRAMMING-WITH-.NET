using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }

        [ForeignKey("Depertment")] 
        public int DepertmentId { get; set; }
        public virtual Depertment Depertment { get; set; }
    }
}
