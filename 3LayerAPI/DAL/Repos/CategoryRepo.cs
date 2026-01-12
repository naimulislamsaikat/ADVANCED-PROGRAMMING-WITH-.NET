using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        PMSContext db;
        public CategoryRepo(PMSContext db)
        {
            this.db = db;
        }
        public bool Create(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }
        public List<Category> Get()
        {
            return db.Categories.ToList();
        }
        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }
        public bool Update(Category category)
        {
            var exCat = Get(category.Id);
            //var exCat = db.Categories.Find(category.Id);
            db.Entry(exCat).CurrentValues.SetValues(category);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exCat = Get(id);
            db.Categories.Remove(exCat);
            return db.SaveChanges() > 0;
        }
    }
}
