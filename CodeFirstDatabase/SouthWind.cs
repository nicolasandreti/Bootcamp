using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CodeFirstDatabase;

public class SouthWind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		//optionsBuilder.UseSqlite("FileName=./Southwind.db");
		optionsBuilder.UseNpgsql("Host=localhost:5432;Database=mydatabase;Username=postgres;Password=postgres");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(20);
			category.Property(c => c.Description).IsRequired(false).HasMaxLength(50);
			category.HasMany(c => c.Prodcts).WithOne(p => p.Category);
		});	
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(20);
			product.Property(p => p.Description).IsRequired(false).HasMaxLength(50);
		});
		modelBuilder.Entity<Category>().HasData(
			new Category()
			{
				CategoryId = 1,
				CategoryName = "Electronic",
				Description = "Anything"
			},
			new Category()
			{
				CategoryId = 2,
				CategoryName = "Seafood",
				Description = "Bla bla bla"
			}
		);
		modelBuilder.Entity<Product>().HasData(
			new Product() 
			{
				ProductId = 1,
				ProductName = "Laptop",
				CategoryId = 1,
				Description = "Anything"
			},
			new Product() 
			{
				ProductId = 2,
				ProductName = "Shrimp",
				CategoryId = 2,
				Description = "Bla bla bla"
			}
		);
	}
}
