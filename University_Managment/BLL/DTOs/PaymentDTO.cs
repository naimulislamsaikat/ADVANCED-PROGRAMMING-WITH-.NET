using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class PaymentDTO
    {
        public int PId { get; set; }
        public string PType { get; set; }
        public decimal PAmount { get; set; }
        public int PSemester { get; set; }
        public string PStatus { get; set; }
        public int StudentId { get; set; }
    }
}
