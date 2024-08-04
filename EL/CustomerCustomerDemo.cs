using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("CustomerCustomerDemo")]
	public class CustomerCustomerDemo
	 {
		[Key]
		[MaxLength(5)]
		public string CustomerID { get; set; }
		[MaxLength(10)]
		[Required]
		public string CustomerTypeID { get; set; }
	 }
}
