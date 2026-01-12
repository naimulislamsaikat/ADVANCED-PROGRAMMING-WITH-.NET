using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //public int CategoryId { get; set; }
        //public virtual ICollection<Product> Products { get; set; } = new List<Product>(); // Navigation properties
    }
}
