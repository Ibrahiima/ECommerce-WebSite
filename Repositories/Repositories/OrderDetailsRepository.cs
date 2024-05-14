using Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    
    {
        EDBContext _context;
        public OrderDetailsRepository(EDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
