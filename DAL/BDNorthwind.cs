using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
	 public class BDNorthwind:DbContext
	{
		public BDNorthwind():base(Conexion.ConexionString(true)){}
		 public virtual DbSet<Categories> Categories{get;set;}
		 public virtual DbSet<CustomerCustomerDemo> CustomerCustomerDemo{get;set;}
		 public virtual DbSet<CustomerDemographics> CustomerDemographics{get;set;}
		 public virtual DbSet<Customers> Customers{get;set;}
		 public virtual DbSet<Employees> Employees{get;set;}
		 public virtual DbSet<EmployeeTerritories> EmployeeTerritories{get;set;}
		 public virtual DbSet<Order Details> Order Details{get;set;}
		 public virtual DbSet<Orders> Orders{get;set;}
		 public virtual DbSet<Products> Products{get;set;}
		 public virtual DbSet<Region> Region{get;set;}
		 public virtual DbSet<Shippers> Shippers{get;set;}
		 public virtual DbSet<Suppliers> Suppliers{get;set;}
		 public virtual DbSet<Territories> Territories{get;set;}
		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categories>().Property(e => e.CategoryName).IsUnicode(false);
			modelBuilder.Entity<Categories>().Property(e => e.Description).IsUnicode(false);
			modelBuilder.Entity<CustomerCustomerDemo>().Property(e => e.CustomerID).IsUnicode(false);
			modelBuilder.Entity<CustomerCustomerDemo>().Property(e => e.CustomerTypeID).IsUnicode(false);
			modelBuilder.Entity<CustomerDemographics>().Property(e => e.CustomerTypeID).IsUnicode(false);
			modelBuilder.Entity<CustomerDemographics>().Property(e => e.CustomerDesc).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.CustomerID).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.CompanyName).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.ContactName).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.ContactTitle).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.Address).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.City).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.Region).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.PostalCode).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.Country).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.Phone).IsUnicode(false);
			modelBuilder.Entity<Customers>().Property(e => e.Fax).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.LastName).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.FirstName).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Title).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.TitleOfCourtesy).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Address).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.City).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Region).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.PostalCode).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Country).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.HomePhone).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Extension).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.Notes).IsUnicode(false);
			modelBuilder.Entity<Employees>().Property(e => e.PhotoPath).IsUnicode(false);
			modelBuilder.Entity<EmployeeTerritories>().Property(e => e.TerritoryID).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.CustomerID).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipName).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipAddress).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipCity).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipRegion).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipPostalCode).IsUnicode(false);
			modelBuilder.Entity<Orders>().Property(e => e.ShipCountry).IsUnicode(false);
			modelBuilder.Entity<Products>().Property(e => e.ProductName).IsUnicode(false);
			modelBuilder.Entity<Products>().Property(e => e.QuantityPerUnit).IsUnicode(false);
			modelBuilder.Entity<Region>().Property(e => e.RegionDescription).IsUnicode(false);
			modelBuilder.Entity<Shippers>().Property(e => e.CompanyName).IsUnicode(false);
			modelBuilder.Entity<Shippers>().Property(e => e.Phone).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.CompanyName).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.ContactName).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.ContactTitle).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.Address).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.City).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.Region).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.PostalCode).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.Country).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.Phone).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.Fax).IsUnicode(false);
			modelBuilder.Entity<Suppliers>().Property(e => e.HomePage).IsUnicode(false);
			modelBuilder.Entity<Territories>().Property(e => e.TerritoryID).IsUnicode(false);
			modelBuilder.Entity<Territories>().Property(e => e.TerritoryDescription).IsUnicode(false);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			 base.OnModelCreating(modelBuilder);
		}
		}
	}
