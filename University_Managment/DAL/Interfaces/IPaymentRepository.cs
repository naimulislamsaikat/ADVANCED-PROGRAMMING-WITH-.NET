using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IPaymentRepository
    {
        bool PaymentStatus(int id);
    }
}
