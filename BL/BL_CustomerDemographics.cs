using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_CustomerDemographics
	{
		 public static CustomerDemographics Insert (CustomerDemographics Entidad)
		{
			 return DAL_CustomerDemographics.Insert(Entidad);
		}
		 public static bool Update (CustomerDemographics Entidad)
		{
			 return DAL_CustomerDemographics.Update(Entidad);
		}
		 public static bool Anular (CustomerDemographics Entidad)
		{
			 return DAL_CustomerDemographics.Anular(Entidad);
		}
		 public static bool Existe (CustomerDemographics Entidad)
		{
			 return DAL_CustomerDemographics.Existe(Entidad);
		}
		 public static CustomerDemographics Registro (CustomerDemographics Entidad)
		{
			 return DAL_CustomerDemographics.Registro(Entidad);
		}
		 
	}
}
