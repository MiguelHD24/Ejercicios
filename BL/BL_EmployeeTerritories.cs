using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_EmployeeTerritories
	{
		 public static EmployeeTerritories Insert (EmployeeTerritories Entidad)
		{
			 return DAL_EmployeeTerritories.Insert(Entidad);
		}
		 public static bool Update (EmployeeTerritories Entidad)
		{
			 return DAL_EmployeeTerritories.Update(Entidad);
		}
		 public static bool Anular (EmployeeTerritories Entidad)
		{
			 return DAL_EmployeeTerritories.Anular(Entidad);
		}
		 public static bool Existe (EmployeeTerritories Entidad)
		{
			 return DAL_EmployeeTerritories.Existe(Entidad);
		}
		 public static EmployeeTerritories Registro (EmployeeTerritories Entidad)
		{
			 return DAL_EmployeeTerritories.Registro(Entidad);
		}
		 
	}
}
