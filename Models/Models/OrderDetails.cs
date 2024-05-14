using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECommerceWebAPI;

namespace Models
{
    [Table("Order_Details")]
    public partial class OrderDetail
    {
        [Key]
        [Column("Product_ID")]
        public int ProductId { get; set; }
        [Key]
        [Column("Order_ID")]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; }
    }
}
