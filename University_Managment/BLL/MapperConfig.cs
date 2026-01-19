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
            //c.CreateMap<Depertment, DepertmentStudentDTO>().ReverseMap();
            //c.CreateMap<Depertment, DepertmentCountDTO>().ForMember(
            //        dto => dto.Count,
            //        src => src.MapFrom(d => d.Students.Count)
            //);
            //c.CreateMap<Department, DepartmentDTO>().ReverseMap();
            //c.CreateMap<Department, DepartmentDTO>().ReverseMap();

        });
        public static Mapper GetMapper()
        {
            return new Mapper(cfg);
        }
    }
}
