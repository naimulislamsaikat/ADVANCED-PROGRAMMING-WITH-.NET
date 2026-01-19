using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Repos
{
    public class CourseRepo : IRepository<Course>
    {
        UMSContaxt db;
        public CourseRepo(UMSContaxt db)
        {
            this.db = db;
        }
        public Course Get(int id)
        {
            return db.Courses.Find(id);
        }
        public List<Course> Get()
        {
            return db.Courses.ToList();
        }
        public bool Create(Course s)
        {
            db.Courses.Add(s);
            return db.SaveChanges() > 0;
        }
        public bool Update(Course d)
        {
            var obj = Get(d.CId);
            db.Entry(obj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var obj = Get(id);
            db.Courses.Remove(obj);
            return db.SaveChanges() > 0;
        }
        public bool Search(int id)
        {
            var dept = db.Courses.Find(id);
            if (dept != null)
            {
                return true;
            }
            return false;
        }
    }
}
