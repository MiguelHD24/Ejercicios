using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Region
	{
		 public static Region Insert (Region Entidad)
		{
			 return DAL_Region.Insert(Entidad);
		}
		 public static bool Update (Region Entidad)
		{
			 return DAL_Region.Update(Entidad);
		}
		 public static bool Anular (Region Entidad)
		{
			 return DAL_Region.Anular(Entidad);
		}
		 public static bool Existe (Region Entidad)
		{
			 return DAL_Region.Existe(Entidad);
		}
		 public static Region Registro (Region Entidad)
		{
			 return DAL_Region.Registro(Entidad);
		}
		 public static List<Region> Lista (bool Activo = true)
		{
			 return DAL_Region.Lista(Activo);
		}
	}
}
