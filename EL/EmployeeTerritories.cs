using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("EmployeeTerritories")]
	public class EmployeeTerritories
	 {
		[Key]
		public int EmployeeID { get; set; }
		[MaxLength(20)]
		[Required]
		public string TerritoryID { get; set; }
	 }
}
