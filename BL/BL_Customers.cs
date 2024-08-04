using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Customers
	{
		 public static Customers Insert (Customers Entidad)
		{
			 return DAL_Customers.Insert(Entidad);
		}
		 public static bool Update (Customers Entidad)
		{
			 return DAL_Customers.Update(Entidad);
		}
		 public static bool Anular (Customers Entidad)
		{
			 return DAL_Customers.Anular(Entidad);
		}
		 public static bool Existe (Customers Entidad)
		{
			 return DAL_Customers.Existe(Entidad);
		}
		 public static Customers Registro (Customers Entidad)
		{
			 return DAL_Customers.Registro(Entidad);
		}
		 public static List<Customers> Lista (bool Activo = true)
		{
			 return DAL_Customers.Lista(Activo);
		}
	}
}
