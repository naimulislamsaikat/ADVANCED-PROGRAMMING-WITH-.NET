using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IStudentRepository 
    {
        bool GetSearch(int id);
        //List<Student> GetSearch(int id);
    }
}
