using DAL.EF;
using DAL.EF.Model;
using DAL.EF.Repos;
using DAL.Interfaces;

namespace DAL
{
    public class DataAccessFactory
    {
        UMSContaxt db;
        public DataAccessFactory(UMSContaxt db)
        {
            this.db = db;
        }
        public IRepository<Depertment> GetDepRepo()
        {
            return new DepertmentRepo(db);
        }
        public IRepository<Student> StudentData()
        {
            return new StudentRepo(db);
        }
        public IStudentRepository StudentSearchData()
        {
            return new StudentRepo(db);
        }
        public IRepository<Course> CourseData()
        {
            return new CourseRepo(db);
        }

    }
}
