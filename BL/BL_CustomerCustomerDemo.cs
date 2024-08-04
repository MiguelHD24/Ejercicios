using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_CustomerCustomerDemo
	{
		 public static CustomerCustomerDemo Insert (CustomerCustomerDemo Entidad)
		{
			 return DAL_CustomerCustomerDemo.Insert(Entidad);
		}
		 public static bool Update (CustomerCustomerDemo Entidad)
		{
			 return DAL_CustomerCustomerDemo.Update(Entidad);
		}
		 public static bool Anular (CustomerCustomerDemo Entidad)
		{
			 return DAL_CustomerCustomerDemo.Anular(Entidad);
		}
		 public static bool Existe (CustomerCustomerDemo Entidad)
		{
			 return DAL_CustomerCustomerDemo.Existe(Entidad);
		}
		 public static CustomerCustomerDemo Registro (CustomerCustomerDemo Entidad)
		{
			 return DAL_CustomerCustomerDemo.Registro(Entidad);
		}
		
	}
}
