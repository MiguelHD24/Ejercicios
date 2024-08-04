using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Customers
	{
		 public static Customers Insert (Customers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Customers.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Customers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Customers.Find(Entidad.CustomerID);
				 Registro.CompanyName = Entidad.CompanyName;
				 Registro.ContactName = Entidad.ContactName;
				 Registro.ContactTitle = Entidad.ContactTitle;
				 Registro.Address = Entidad.Address;
				 Registro.City = Entidad.City;
				 Registro.Region = Entidad.Region;
				 Registro.PostalCode = Entidad.PostalCode;
				 Registro.Country = Entidad.Country;
				 Registro.Phone = Entidad.Phone;
				 Registro.Fax = Entidad.Fax;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Customers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Customers.Find(Entidad.CustomerID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Customers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Customers.Where(a=>a.CustomerID == Entidad.CustomerID).Count() > 0;
			}
		}
		 public static Customers Registro (Customers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Customers.Where(a=>a.CustomerID == Entidad.CustomerID).SingleOrDefault();
			}
		}
		 
	}
}
