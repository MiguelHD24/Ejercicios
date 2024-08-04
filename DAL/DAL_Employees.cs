using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Employees
	{
		 public static Employees Insert (Employees Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Employees.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Employees Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Employees.Find(Entidad.EmployeeID);
				 Registro.LastName = Entidad.LastName;
				 Registro.FirstName = Entidad.FirstName;
				 Registro.Title = Entidad.Title;
				 Registro.TitleOfCourtesy = Entidad.TitleOfCourtesy;
				 Registro.BirthDate = Entidad.BirthDate;
				 Registro.HireDate = Entidad.HireDate;
				 Registro.Address = Entidad.Address;
				 Registro.City = Entidad.City;
				 Registro.Region = Entidad.Region;
				 Registro.PostalCode = Entidad.PostalCode;
				 Registro.Country = Entidad.Country;
				 Registro.HomePhone = Entidad.HomePhone;
				 Registro.Extension = Entidad.Extension;
				 Registro.Photo = Entidad.Photo;
				 Registro.Notes = Entidad.Notes;
				 Registro.ReportsTo = Entidad.ReportsTo;
				 Registro.PhotoPath = Entidad.PhotoPath;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Employees Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Employees.Find(Entidad.EmployeeID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Employees Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Employees.Where(a=>a.EmployeeID == Entidad.EmployeeID).Count() > 0;
			}
		}
		 public static Employees Registro (Employees Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Employees.Where(a=>a.EmployeeID == Entidad.EmployeeID).SingleOrDefault();
			}
		}
		 
	}
}
