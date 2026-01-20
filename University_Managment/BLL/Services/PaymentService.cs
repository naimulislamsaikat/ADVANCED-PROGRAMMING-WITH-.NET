using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class PaymentService
    {
        DataAccessFactory factory;
        public PaymentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<PaymentDTO> All()
        {
            List<Payment> data = factory.PaymentData().Get();
            List<PaymentDTO> ret = MapperConfig.GetMapper().Map<List<PaymentDTO>>(data);
            return ret;
        }
        public PaymentDTO Get(int id)
        {
            Payment data = factory.PaymentData().Get(id);
            PaymentDTO ret = MapperConfig.GetMapper().Map<PaymentDTO>(data);
            return ret;
        }
        public PaymentDTO Get()
        {
            PaymentDTO data = MapperConfig.GetMapper().Map<PaymentDTO>(factory.PaymentData().Get());
            return data;
        }
        public bool Create(PaymentDTO dto)
        {
            Payment data = MapperConfig.GetMapper().Map<Payment>(dto);
            factory.PaymentData().Create(data);
            return true;
        }
        public bool Update(PaymentDTO dto)
        {
            Payment data = MapperConfig.GetMapper().Map<Payment>(dto);
            factory.PaymentData().Update(data);
            return true;
        }
    }
}
