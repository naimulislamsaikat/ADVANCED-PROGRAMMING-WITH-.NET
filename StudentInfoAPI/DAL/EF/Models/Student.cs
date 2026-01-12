using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? DepertmentTitle { get; set; }
        public string? Semester { get; set; }

        [ForeignKey("Depertment")]
        public virtual Depertment? DepertmentName { get; set; }
    }
}
