using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class StudentService
    {
        DataAccessFactory factory;
        public StudentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<StudentDTO> All()
        {
            var data = factory.StudentData().Get();
            var ret = MapperConfig.GetMapper().Map<List<StudentDTO>>(data);
            return ret;

        }
        public StudentDTO Get(int id)
        {
            Student data = factory.StudentData().Get(id);
            StudentDTO ret = MapperConfig.GetMapper().Map<StudentDTO>(data);
            return ret;
        }
        public bool Create(StudentDTO dto)
        {
            Student data = MapperConfig.GetMapper().Map<Student>(dto);
            return factory.StudentData().Create(data);
        }
        public bool Update(StudentDTO dto)
        {
            Student data = MapperConfig.GetMapper().Map<Student>(dto);
            return factory.StudentData().Update(data);
        }
        public bool Delete(int id)
        {
            return factory.StudentData().Delete(id);
        }

        public StudentDTO GetSearch(int id)
        {
            Student data = factory.StudentData().Get(id);
            StudentDTO ret = MapperConfig.GetMapper().Map<StudentDTO>(data);
            return ret;
        }
    }
}
