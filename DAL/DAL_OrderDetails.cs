using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_OrderDetails
	{
		 public static OrderDetails Insert (OrderDetails Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.OrderDetails.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (OrderDetails Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.OrderDetails.Find(Entidad.OrderID);
				 Registro.ProductID = Entidad.ProductID;
				 Registro.UnitPrice = Entidad.UnitPrice;
				 Registro.Quantity = Entidad.Quantity;
				 Registro.Discount = Entidad.Discount;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (OrderDetails Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.OrderDetails.Find(Entidad.OrderID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (OrderDetails Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.OrderDetails.Where(a=>a.OrderID == Entidad.OrderID).Count() > 0;
			}
		}
		 public static OrderDetails Registro (OrderDetails Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.OrderDetails.Where(a=>a.OrderID == Entidad.OrderID).SingleOrDefault();
			}
		}
		 
	}
}
