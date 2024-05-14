using AutoMapper;
using DTOs;
using Models;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : GenericService<Order, OrderDTOs>, IOrderService
    {
        public OrderService(IGenericRepository<Order> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
