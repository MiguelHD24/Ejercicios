using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_OrderDetails
	{
		 public static OrderDetails Insert (OrderDetails Entidad)
		{
			 return DAL_OrderDetails.Insert(Entidad);
		}
		 public static bool Update (OrderDetails Entidad)
		{
			 return DAL_OrderDetails.Update(Entidad);
		}
		 public static bool Anular (OrderDetails Entidad)
		{
			 return DAL_OrderDetails.Anular(Entidad);
		}
		 public static bool Existe (OrderDetails Entidad)
		{
			 return DAL_OrderDetails.Existe(Entidad);
		}
		 public static OrderDetails Registro (OrderDetails Entidad)
		{
			 return DAL_OrderDetails.Registro(Entidad);
		}
		 
	}
}
