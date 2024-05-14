using Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        EDBContext _context;
        public CategoryRepository(EDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
