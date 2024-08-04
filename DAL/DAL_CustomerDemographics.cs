using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_CustomerDemographics
	{
		 public static CustomerDemographics Insert (CustomerDemographics Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.CustomerDemographics.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (CustomerDemographics Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.CustomerDemographics.Find(Entidad.CustomerTypeID);
				 Registro.CustomerDesc = Entidad.CustomerDesc;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (CustomerDemographics Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.CustomerDemographics.Find(Entidad.CustomerTypeID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (CustomerDemographics Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.CustomerDemographics.Where(a=>a.CustomerTypeID == Entidad.CustomerTypeID).Count() > 0;
			}
		}
		 public static CustomerDemographics Registro (CustomerDemographics Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.CustomerDemographics.Where(a=>a.CustomerTypeID == Entidad.CustomerTypeID).SingleOrDefault();
			}
		}
		 
	}
}
