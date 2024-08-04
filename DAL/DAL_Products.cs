using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Products
	{
		 public static Products Insert (Products Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Products.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Products Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Products.Find(Entidad.ProductID);
				 Registro.ProductName = Entidad.ProductName;
				 Registro.SupplierID = Entidad.SupplierID;
				 Registro.CategoryID = Entidad.CategoryID;
				 Registro.QuantityPerUnit = Entidad.QuantityPerUnit;
				 Registro.UnitPrice = Entidad.UnitPrice;
				 Registro.UnitsInStock = Entidad.UnitsInStock;
				 Registro.UnitsOnOrder = Entidad.UnitsOnOrder;
				 Registro.ReorderLevel = Entidad.ReorderLevel;
				 Registro.Discontinued = Entidad.Discontinued;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Products Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Products.Find(Entidad.ProductID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Products Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Products.Where(a=>a.ProductID == Entidad.ProductID).Count() > 0;
			}
		}
		 public static Products Registro (Products Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Products.Where(a=>a.ProductID == Entidad.ProductID).SingleOrDefault();
			}
		}
		
	}
}
