using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Categories
	{
		 public static Categories Insert (Categories Entidad)
		{
			 return DAL_Categories.Insert(Entidad);
		}
		 public static bool Update (Categories Entidad)
		{
			 return DAL_Categories.Update(Entidad);
		}
		 public static bool Anular (Categories Entidad)
		{
			 return DAL_Categories.Anular(Entidad);
		}
		 public static bool Existe (Categories Entidad)
		{
			 return DAL_Categories.Existe(Entidad);
		}
		 public static Categories Registro (Categories Entidad)
		{
			 return DAL_Categories.Registro(Entidad);
		}
		
	}
}
