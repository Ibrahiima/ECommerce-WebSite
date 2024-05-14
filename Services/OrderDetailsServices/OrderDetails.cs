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
    public class OrderDetailService : GenericService<OrderDetail, OrderDetailDTOs>, IOrderDetailService
    {
        public OrderDetailService(IGenericRepository<OrderDetail> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
