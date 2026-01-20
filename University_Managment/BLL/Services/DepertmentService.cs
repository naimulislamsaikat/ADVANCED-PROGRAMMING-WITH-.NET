using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using DAL.EF.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepertmentService
    {
        DataAccessFactory factory;
        public DepertmentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<DepertmentDTO> All()
        {
            var data = factory.GetDepRepo().Get();
            var ret = MapperConfig.GetMapper().Map<List<DepertmentDTO>>(data);
            return ret;

        }
        public DepertmentDTO Get(int id)
        {
            Depertment data = factory.GetDepRepo().Get(id);
            DepertmentDTO ret = MapperConfig.GetMapper().Map<DepertmentDTO>(data);
            return ret;
        }
        public bool Create(DepertmentDTO dto)
        {
            Depertment data = MapperConfig.GetMapper().Map<Depertment>(dto);
            factory.GetDepRepo().Create(data);
            return true;
        }
        public bool Delete(int id)
        {
            factory.GetDepRepo().Delete(id);
            return true;
        }
        public bool Update(DepertmentDTO dto)
        {
            Depertment data = MapperConfig.GetMapper().Map<Depertment>(dto);
            factory.GetDepRepo().Update(data);
            return true;
        }
    }
}
