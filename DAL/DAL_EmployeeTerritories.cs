using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_EmployeeTerritories
	{
		 public static EmployeeTerritories Insert (EmployeeTerritories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.EmployeeTerritories.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (EmployeeTerritories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.EmployeeTerritories.Find(Entidad.EmployeeID);
				 Registro.TerritoryID = Entidad.TerritoryID;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (EmployeeTerritories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.EmployeeTerritories.Find(Entidad.EmployeeID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (EmployeeTerritories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.EmployeeTerritories.Where(a=>a.EmployeeID == Entidad.EmployeeID).Count() > 0;
			}
		}
		 public static EmployeeTerritories Registro (EmployeeTerritories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.EmployeeTerritories.Where(a=>a.EmployeeID == Entidad.EmployeeID).SingleOrDefault();
			}
		}
		 
	}
}
