using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Employees
	{
		 public static Employees Insert (Employees Entidad)
		{
			 return DAL_Employees.Insert(Entidad);
		}
		 public static bool Update (Employees Entidad)
		{
			 return DAL_Employees.Update(Entidad);
		}
		 public static bool Anular (Employees Entidad)
		{
			 return DAL_Employees.Anular(Entidad);
		}
		 public static bool Existe (Employees Entidad)
		{
			 return DAL_Employees.Existe(Entidad);
		}
		 public static Employees Registro (Employees Entidad)
		{
			 return DAL_Employees.Registro(Entidad);
		}
		 public static List<Employees> Lista (bool Activo = true)
		{
			 return DAL_Employees.Lista(Activo);
		}
	}
}
