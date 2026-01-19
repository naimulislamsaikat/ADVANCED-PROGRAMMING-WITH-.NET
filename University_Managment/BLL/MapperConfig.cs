using AutoMapper;
using BLL.DTOs;
using DAL.EF.Model;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration cfg = new MapperConfiguration(c => {
            c.CreateMap<Depertment, DepertmentDTO>().ReverseMap();
            c.CreateMap<Student, StudentDTO>().ReverseMap();
            c.CreateMap<Course, CourseDTO>().ReverseMap();

        });
        public static Mapper GetMapper()
        {
            return new Mapper(cfg);
        }
    }
}
