using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class PMSContaxt : DbContext
    {
        public PMSContaxt(DbContextOptions<PMSContaxt> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Depertment> Depertments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
