using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.EF.Repos
{
    public class StudentRepo : IRepository<Student>, IStudentRepository
    {
        UMSContaxt db;
        public StudentRepo(UMSContaxt db)
        {
            this.db = db;
        }
        public bool Create(Student s)
        {
            db.Students.Add(s);
            return db.SaveChanges() > 0;
        }
        public Student Get(int id)
        {
            return db.Students.Find(id);
        }
        public List<Student> Get()
        {
            return db.Students.ToList();
        }
        public bool Update(Student s)
        {
            var data = Get(s.Id);
            db.Entry(data).CurrentValues.SetValues(s);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var data = Get(id);
            db.Students.Remove(data);
            return db.SaveChanges() > 0;
        }
        public bool GetSearch(int id)
        {
            var data = Get(id);
            if (data != null)
            {
                return true;
            }
            return false;
        }

        object IRepository<Student>.PaymentStatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
