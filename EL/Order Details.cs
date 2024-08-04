using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Order Details")]
	public class Order Details
	 {
		[Key]
		public int OrderID { get; set; }
		[Required]
		public int ProductID { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public short Quantity { get; set; }
		[Required]
		public float Discount { get; set; }
	 }
}
