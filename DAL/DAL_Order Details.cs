using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Order Details
	{
		 public static Order Details Insert (Order Details Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Order Details.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Order Details Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Order Details.Find(Entidad.OrderID);
				 Registro.ProductID = Entidad.ProductID;
				 Registro.UnitPrice = Entidad.UnitPrice;
				 Registro.Quantity = Entidad.Quantity;
				 Registro.Discount = Entidad.Discount;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Order Details Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Order Details.Find(Entidad.OrderID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Order Details Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Order Details.Where(a=>a.OrderID == Entidad.OrderID).Count() > 0;
			}
		}
		 public static Order Details Registro (Order Details Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Order Details.Where(a=>a.OrderID == Entidad.OrderID).SingleOrDefault();
			}
		}
		 public static List<Order Details> Lista (bool Activo = true)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
			}
		}
	}
}
