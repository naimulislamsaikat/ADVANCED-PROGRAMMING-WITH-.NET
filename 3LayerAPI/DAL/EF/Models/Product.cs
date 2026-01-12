using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Category")]
        public virtual Category Categories { get; set; }

        //public virtual ICollection<Category> Categories { get; set; } = new List<Category>(); // Navigation properties
        //public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
