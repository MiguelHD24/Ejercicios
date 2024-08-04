using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Shippers
	{
		 public static Shippers Insert (Shippers Entidad)
		{
			 return DAL_Shippers.Insert(Entidad);
		}
		 public static bool Update (Shippers Entidad)
		{
			 return DAL_Shippers.Update(Entidad);
		}
		 public static bool Anular (Shippers Entidad)
		{
			 return DAL_Shippers.Anular(Entidad);
		}
		 public static bool Existe (Shippers Entidad)
		{
			 return DAL_Shippers.Existe(Entidad);
		}
		 public static Shippers Registro (Shippers Entidad)
		{
			 return DAL_Shippers.Registro(Entidad);
		}
		 public static List<Shippers> Lista (bool Activo = true)
		{
			 return DAL_Shippers.Lista(Activo);
		}
	}
}
