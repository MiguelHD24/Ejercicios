using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_CustomerCustomerDemo
	{
		 public static CustomerCustomerDemo Insert (CustomerCustomerDemo Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.CustomerCustomerDemo.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (CustomerCustomerDemo Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.CustomerCustomerDemo.Find(Entidad.CustomerID);
				 Registro.CustomerTypeID = Entidad.CustomerTypeID;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (CustomerCustomerDemo Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.CustomerCustomerDemo.Find(Entidad.CustomerID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (CustomerCustomerDemo Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.CustomerCustomerDemo.Where(a=>a.CustomerID == Entidad.CustomerID).Count() > 0;
			}
		}
		 public static CustomerCustomerDemo Registro (CustomerCustomerDemo Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.CustomerCustomerDemo.Where(a=>a.CustomerID == Entidad.CustomerID).SingleOrDefault();
			}
		}
		 public static List<CustomerCustomerDemo> Lista (bool Activo = true)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
			}
		}
	}
}
