using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CheckDetailService
    {
        DataAccessFactory factory;
        public CheckDetailService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public CheckDetailDTO GetDetail(int id)
        {
            var data = factory.StudentData().Get(id);
            var data1 = factory.GetDepRepo().Get(data.DepertmentId);
            var data3 = (Payment)factory.PaymentData().PaymentStatus(data.Id);

            //var data3 = factory.PaymentData().PaymentStatus(data.Id);

            var detail = new CheckDetailDTO
            {
                Name = data.Name,
                Number = data.Number,
                Email = data.Email,
                DepName = data1.DepName,
                PType = data3.PType,
                PAmount = data3.PAmount,
                PSemester = data3.PSemester,
                PStatus = data3.PStatus
            };
            return detail;
        }
    }
}
