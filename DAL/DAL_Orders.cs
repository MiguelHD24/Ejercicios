using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Orders
	{
		 public static Orders Insert (Orders Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Orders.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Orders Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Orders.Find(Entidad.OrderID);
				 Registro.CustomerID = Entidad.CustomerID;
				 Registro.EmployeeID = Entidad.EmployeeID;
				 Registro.OrderDate = Entidad.OrderDate;
				 Registro.RequiredDate = Entidad.RequiredDate;
				 Registro.ShippedDate = Entidad.ShippedDate;
				 Registro.ShipVia = Entidad.ShipVia;
				 Registro.Freight = Entidad.Freight;
				 Registro.ShipName = Entidad.ShipName;
				 Registro.ShipAddress = Entidad.ShipAddress;
				 Registro.ShipCity = Entidad.ShipCity;
				 Registro.ShipRegion = Entidad.ShipRegion;
				 Registro.ShipPostalCode = Entidad.ShipPostalCode;
				 Registro.ShipCountry = Entidad.ShipCountry;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Orders Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Orders.Find(Entidad.OrderID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Orders Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Orders.Where(a=>a.OrderID == Entidad.OrderID).Count() > 0;
			}
		}
		 public static Orders Registro (Orders Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Orders.Where(a=>a.OrderID == Entidad.OrderID).SingleOrDefault();
			}
		}
		 
	}
}
