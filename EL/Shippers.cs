using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Shippers")]
	public class Shippers
	 {
		[Key]
		public int ShipperID { get; set; }
		[MaxLength(40)]
		[Required]
		public string CompanyName { get; set; }
		[MaxLength(24)]
		public string? Phone { get; set; }
	 }
}
