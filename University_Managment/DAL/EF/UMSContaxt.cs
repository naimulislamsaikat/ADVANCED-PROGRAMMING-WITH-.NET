using DAL.EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class UMSContaxt : DbContext
    {
        public UMSContaxt(DbContextOptions<UMSContaxt> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Depertment> Depertments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
