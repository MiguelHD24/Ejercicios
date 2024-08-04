using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Categories
	{
		 public static Categories Insert (Categories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 bd.Categories.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Categories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Categories.Find(Entidad.CategoryID);
				 Registro.CategoryName = Entidad.CategoryName;
				 Registro.Description = Entidad.Description;
				 Registro.Picture = Entidad.Picture;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Categories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 var Registro = bd.Categories.Find(Entidad.CategoryID);
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Categories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Categories.Where(a=>a.CategoryID == Entidad.CategoryID).Count() > 0;
			}
		}
		 public static Categories Registro (Categories Entidad)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
				 return bd.Categories.Where(a=>a.CategoryID == Entidad.CategoryID).SingleOrDefault();
			}
		}
		 public static List<Categories> Lista (bool Activo = true)
		{
			 using (BDNorthwind bd = new BDNorthwind ())
			{
			}
		}
	}
}
