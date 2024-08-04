using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Territories
	{
		 public static Territories Insert (Territories Entidad)
		{
			 return DAL_Territories.Insert(Entidad);
		}
		 public static bool Update (Territories Entidad)
		{
			 return DAL_Territories.Update(Entidad);
		}
		 public static bool Anular (Territories Entidad)
		{
			 return DAL_Territories.Anular(Entidad);
		}
		 public static bool Existe (Territories Entidad)
		{
			 return DAL_Territories.Existe(Entidad);
		}
		 public static Territories Registro (Territories Entidad)
		{
			 return DAL_Territories.Registro(Entidad);
		}
		
	}
}
