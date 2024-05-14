using AutoMapper;
using DTOs;
using Models;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CartService : GenericService<Cart,CartDTOs>, ICartService
    {
        public CartService(IGenericRepository<Cart> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
