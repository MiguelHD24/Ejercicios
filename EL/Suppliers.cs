using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Suppliers")]
	public class Suppliers
	 {
		[Key]
		public int SupplierID { get; set; }
		[MaxLength(40)]
		[Required]
		public string CompanyName { get; set; }
		[MaxLength(30)]
		public string ContactName { get; set; }
		[MaxLength(30)]
		public string ContactTitle { get; set; }
		[MaxLength(60)]
		public string Address { get; set; }
		[MaxLength(15)]
		public string City { get; set; }
		[MaxLength(15)]
		public string Region { get; set; }
		[MaxLength(10)]
		public string PostalCode { get; set; }
		[MaxLength(15)]
		public string Country { get; set; }
		[MaxLength(24)]
		public string Phone { get; set; }
		[MaxLength(24)]
		public string Fax { get; set; }
		[MaxLength(1073741823)]
		public string HomePage { get; set; }
	 }
}
