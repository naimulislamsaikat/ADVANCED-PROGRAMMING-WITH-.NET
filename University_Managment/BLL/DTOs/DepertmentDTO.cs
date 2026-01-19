using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs
{
    public class DepertmentDTO
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public string DepHead { get; set; }
    }
}
