using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Territories
	{
		 public static Territories Insert (Territories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Territories.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Territories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Territories.Find(Entidad.TerritoryID);
				 Registro.TerritoryDescription = Entidad.TerritoryDescription;
				 Registro.RegionID = Entidad.RegionID;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Territories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Territories.Find(Entidad.TerritoryID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Territories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Territories.Where(a=>a.TerritoryID == Entidad.TerritoryID).Count() > 0;
			}
		}
		 public static Territories Registro (Territories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Territories.Where(a=>a.TerritoryID == Entidad.TerritoryID).SingleOrDefault();
			}
		}
		 public static List<Territories> Lista (bool Activo = true)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
			}
		}
	}
}
