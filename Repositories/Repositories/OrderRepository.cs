using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        EDBContext _context;
        public OrderRepository(EDBContext context) : base(context)
        {
            _context = context;
        }

        //public async Task UpdateAsync(string status)
        //{
        //    var order = await _cont.Orders.FindAsync(orderId);
        //    if (order != null)
        //    {
        //        order.Status = status;
        //        await _cont.SaveChangesAsync();
        //    }
        //}


    }
}
