using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Model
{
    public class Depertment
    {
        [Key] public int Id { get; set; }
        public string DepName { get; set; }
        public string DepHead { get; set; }
    }
}
