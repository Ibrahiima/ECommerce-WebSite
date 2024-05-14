using ECommerceWebAPI;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Cart
    {
        [Key]
        [Column("User_ID")]
        public int UserId { get; set; }
        [Key]
        [Column("Product_ID")]
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Carts")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Carts")]
        public virtual User User { get; set; }
    }
}
