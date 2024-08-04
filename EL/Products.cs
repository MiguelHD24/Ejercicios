using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Products")]
	public class Products
	 {
		[Key]
		public int ProductID { get; set; }
		[MaxLength(40)]
		[Required]
		public string ProductName { get; set; }
		public int? SupplierID { get; set; }
		public int? CategoryID { get; set; }
		[MaxLength(20)]
		public string? QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; }
		public short? UnitsInStock { get; set; }
		public short? UnitsOnOrder { get; set; }
		public short? ReorderLevel { get; set; }
		[Required]
		public bool Discontinued { get; set; }
	 }
}
