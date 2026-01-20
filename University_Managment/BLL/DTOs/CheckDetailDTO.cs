using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class CheckDetailDTO
    {
        //student info
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        //department info
        public string DepName { get; set; }
        //course info
        public string CName { get; set; }
        //payment info
        public string PType { get; set; }
        public decimal PAmount { get; set; }
        public int PSemester { get; set; }
        public string PStatus { get; set; }
    }
}
