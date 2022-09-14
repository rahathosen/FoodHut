using System;
using System.Collections.Generic;
using System.Text;
using FoodHut.Models;

namespace FoodHut.DataAccess.Data.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
