using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ProductDTOs
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public int? QuantityInStore { get; set; }
        public bool? IsPromoted { get; set; }
        public int CategoryId { get; set; }
   
    }
}
