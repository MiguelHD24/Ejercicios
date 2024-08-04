using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Suppliers
	{
		 public static Suppliers Insert (Suppliers Entidad)
		{
			 return DAL_Suppliers.Insert(Entidad);
		}
		 public static bool Update (Suppliers Entidad)
		{
			 return DAL_Suppliers.Update(Entidad);
		}
		 public static bool Anular (Suppliers Entidad)
		{
			 return DAL_Suppliers.Anular(Entidad);
		}
		 public static bool Existe (Suppliers Entidad)
		{
			 return DAL_Suppliers.Existe(Entidad);
		}
		 public static Suppliers Registro (Suppliers Entidad)
		{
			 return DAL_Suppliers.Registro(Entidad);
		}
		 public static List<Suppliers> Lista (bool Activo = true)
		{
			 return DAL_Suppliers.Lista(Activo);
		}
	}
}
