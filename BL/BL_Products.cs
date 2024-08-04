using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Products
	{
		 public static Products Insert (Products Entidad)
		{
			 return DAL_Products.Insert(Entidad);
		}
		 public static bool Update (Products Entidad)
		{
			 return DAL_Products.Update(Entidad);
		}
		 public static bool Anular (Products Entidad)
		{
			 return DAL_Products.Anular(Entidad);
		}
		 public static bool Existe (Products Entidad)
		{
			 return DAL_Products.Existe(Entidad);
		}
		 public static Products Registro (Products Entidad)
		{
			 return DAL_Products.Registro(Entidad);
		}
		 
	}
}
