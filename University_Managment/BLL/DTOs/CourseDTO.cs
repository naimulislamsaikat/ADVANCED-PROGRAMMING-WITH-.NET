using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class CourseDTO
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public int DepId { get; set; }
    }
}
