using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CategoryService
    {
        CategoryRepo repo;
        public CategoryService(CategoryRepo repo)
        {
            this.repo = repo;
        }
        public List<CategoryDTO> Get()
        {
            var data = repo.Get();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<CategoryDTO>>(data);
            return ret;
        }
        public CategoryDTO Get(int id)
        {
            //var data = repo.Get(id);
            //var mapper = MapperConfig.GetMapper();
            //var ret = mapper.Map<CategoryDTO>(data);
            //return ret;
            return MapperConfig.GetMapper().Map<CategoryDTO>(repo.Get(id));
        }
        public bool Create(CategoryDTO obj)
        {
            var mapper = MapperConfig.GetMapper();
            var cat = mapper.Map<Category>(obj);
            return repo.Create(cat);
        }
        public bool Update(CategoryDTO obj)
        {
            var mapper = MapperConfig.GetMapper();
            var cat = mapper.Map<Category>(obj);
            return repo.Update(cat);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
