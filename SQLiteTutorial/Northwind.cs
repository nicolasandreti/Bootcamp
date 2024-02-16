//DbContext is from EntityFrameworkCore
//It contain a virtual method for communicate or open connection
//to the database
using Microsoft.EntityFrameworkCore;
namespace SQLiteTutorial;

class Northwind : DbContext 
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Products> Products { get; set; }
	public DbSet<Supplier> Suppliers { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
		//optionsBuilder.UseSqlie("Data Source=./Northwind.db")
	}

	//FluentAPI
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Products>(product =>
		{
			product.HasKey(p => p.ProductId); //PrimaryKey
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(40);
			product.Property(p => p.UnitPrice).HasColumnType("money").HasColumnName("UnitPrice");
			product.Property(p => p.Stock).HasColumnType("smallint").HasColumnName("UnitsInStock");
			product.HasOne(p => p.Category).WithMany(c => c.Products);
			product.HasOne(p => p.Supplier).WithMany(c => c.Products);
		});
		modelBuilder.Entity<OrderDetail>(od =>
		{
			od.HasKey(o => new { o.OrderId , o.ProductId } );
		});
	}
}