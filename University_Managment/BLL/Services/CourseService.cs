using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CourseService
    {
        DataAccessFactory factory;
        public CourseService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<CourseDTO> All()
        {
            List<Course> data = factory.CourseData().Get();
            List<CourseDTO> ret = MapperConfig.GetMapper().Map<List<CourseDTO>>(data);
            return ret;
        }
        public CourseDTO Get(int id)
        {
            Course data = factory.CourseData().Get(id);
            CourseDTO ret = MapperConfig.GetMapper().Map<CourseDTO>(data);
            return ret;
        }
        public bool Create(CourseDTO dto)
        {
            Course data = MapperConfig.GetMapper().Map<Course>(dto);
            factory.CourseData().Create(data);
            return true;
        }
        public bool Delete(int id)
        {
            factory.CourseData().Delete(id);
            return true;
        }
        public bool Update(CourseDTO dto)
        {
            Course data = MapperConfig.GetMapper().Map<Course>(dto);
            factory.CourseData().Update(data);
            return true;
        }
    }
}
