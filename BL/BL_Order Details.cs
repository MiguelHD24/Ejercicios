using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Order Details
	{
		 public static Order Details Insert (Order Details Entidad)
		{
			 return DAL_Order Details.Insert(Entidad);
		}
		 public static bool Update (Order Details Entidad)
		{
			 return DAL_Order Details.Update(Entidad);
		}
		 public static bool Anular (Order Details Entidad)
		{
			 return DAL_Order Details.Anular(Entidad);
		}
		 public static bool Existe (Order Details Entidad)
		{
			 return DAL_Order Details.Existe(Entidad);
		}
		 public static Order Details Registro (Order Details Entidad)
		{
			 return DAL_Order Details.Registro(Entidad);
		}
		 public static List<Order Details> Lista (bool Activo = true)
		{
			 return DAL_Order Details.Lista(Activo);
		}
	}
}
