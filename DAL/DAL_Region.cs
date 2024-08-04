using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Region
	{
		 public static Region Insert (Region Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Region.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Region Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Region.Find(Entidad.RegionID);
				 Registro.RegionDescription = Entidad.RegionDescription;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Region Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Region.Find(Entidad.RegionID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Region Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Region.Where(a=>a.RegionID == Entidad.RegionID).Count() > 0;
			}
		}
		 public static Region Registro (Region Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Region.Where(a=>a.RegionID == Entidad.RegionID).SingleOrDefault();
			}
		}
		 public static List<Region> Lista (bool Activo = true)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
			}
		}
	}
}
