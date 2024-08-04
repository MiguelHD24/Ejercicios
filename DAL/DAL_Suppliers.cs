using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Suppliers
	{
		 public static Suppliers Insert (Suppliers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Suppliers.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Suppliers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Suppliers.Find(Entidad.SupplierID);
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
				 Registro.HomePage = Entidad.HomePage;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Suppliers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Suppliers.Find(Entidad.SupplierID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Suppliers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Suppliers.Where(a=>a.SupplierID == Entidad.SupplierID).Count() > 0;
			}
		}
		 public static Suppliers Registro (Suppliers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Suppliers.Where(a=>a.SupplierID == Entidad.SupplierID).SingleOrDefault();
			}
		}
		 
	}
}
