using Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CartRepository : GenericRepository<Cart>, IcartRepository
    {
        EDBContext _context;
        public CartRepository(EDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
