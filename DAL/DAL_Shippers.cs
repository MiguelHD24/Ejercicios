using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Shippers
	{
		 public static Shippers Insert (Shippers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Shippers.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Shippers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Shippers.Find(Entidad.ShipperID);
				 Registro.CompanyName = Entidad.CompanyName;
				 Registro.Phone = Entidad.Phone;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Shippers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Shippers.Find(Entidad.ShipperID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Shippers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Shippers.Where(a=>a.ShipperID == Entidad.ShipperID).Count() > 0;
			}
		}
		 public static Shippers Registro (Shippers Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Shippers.Where(a=>a.ShipperID == Entidad.ShipperID).SingleOrDefault();
			}
		}
		 
	}
}
