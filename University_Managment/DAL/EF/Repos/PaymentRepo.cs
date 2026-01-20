using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Repos
{
    public class PaymentRepo : IRepository<Payment>
    {
        private UMSContaxt db;

        public PaymentRepo(UMSContaxt db)
        {
            this.db = db;
        }
        public Payment PaymentStatus(int id)
        {
            var payment = db.Payments.Where(
                c => c.StudentId == id).FirstOrDefault();

            if (payment != null)
            {
                return payment;
            }
            return new Payment();
        }
        public Payment Get(int id)
        {
            return db.Payments.Find(id);
        }
        public List<Payment> Get()
        {
            return db.Payments.ToList();
        }
        public bool Create(Payment s)
        {
            db.Payments.Add(s);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var obj = Get(id);
            db.Payments.Remove(obj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Payment d)
        {
            var obj = Get(d.PId);
            db.Entry(obj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
        public bool Search(int id)
        {
            var dept = db.Payments.Find(id);
            if (dept != null)
            {
                return true;
            }
            return false;
        }
        object IRepository<Payment>.PaymentStatus(int id)
        {
            return PaymentStatus(id);
        }
    }
}
