using DAL.EF.Model;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Repos
{
    public class DepertmentRepo : IRepository<Depertment>
    {
        UMSContaxt db;
        public DepertmentRepo(UMSContaxt db)
        {
            this.db = db;
        }
        public Depertment Get(int id)
        {
            return db.Depertments.Find(id);
        }
        public bool Create(Depertment s)
        {
            db.Depertments.Add(s);
            return db.SaveChanges() > 0;
        }
        public bool Update(Depertment d)
        {
            var exobj = Get(d.Id); //
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Depertments.Remove(exobj);
            return db.SaveChanges() > 0;
        }
        public List<Depertment> Get()
        {
            return db.Depertments.ToList();
        }
        //public Depertment GetByName(string name)
        //{
        //    var dept = (from d in db.Depertments
        //                where d.DepName.Contains(name)
        //                select d).SingleOrDefault();
        //    return dept;
        //}
    }
}
