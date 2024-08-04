using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Orders
	{
		 public static Orders Insert (Orders Entidad)
		{
			 return DAL_Orders.Insert(Entidad);
		}
		 public static bool Update (Orders Entidad)
		{
			 return DAL_Orders.Update(Entidad);
		}
		 public static bool Anular (Orders Entidad)
		{
			 return DAL_Orders.Anular(Entidad);
		}
		 public static bool Existe (Orders Entidad)
		{
			 return DAL_Orders.Existe(Entidad);
		}
		 public static Orders Registro (Orders Entidad)
		{
			 return DAL_Orders.Registro(Entidad);
		}
		 public static List<Orders> Lista (bool Activo = true)
		{
			 return DAL_Orders.Lista(Activo);
		}
	}
}
