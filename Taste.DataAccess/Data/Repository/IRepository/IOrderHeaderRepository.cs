using System;
using System.Collections.Generic;
using System.Text;
using FoodHut.Models;

namespace FoodHut.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
