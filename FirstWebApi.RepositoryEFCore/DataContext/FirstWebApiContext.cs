using Microsoft.EntityFrameworkCore;
using FirstWebApi.Entities.POCOs;


namespace FirstWebApi.RepositoryEFCore.DataContext
{
	public class FirstWebApiContext : DbContext
	{
		public FirstWebApiContext(DbContextOptions<FirstWebApiContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<InputOutput> InputOutputs { get; set; }
		public DbSet<Storage> Storages { get; set; }
		public DbSet<Warehouse> Warehouses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			modelBuilder.Entity<Category>(category =>
			{
				category.ToTable("Category");

				category.HasKey(c => c.CategoryId);
				category.Property(c => c.CategoryName).IsRequired(false);
				//category.Property(c => c.Products);

			});

			modelBuilder.Entity<Product>(product =>
			{
				product.ToTable("Product");

				product.HasKey(c => c.ProductId);
				product.Property(c => c.ProductName).IsRequired(false);
				product.Property(c => c.ProductDescription).IsRequired(false);
				product.Property(c => c.TotalQuantity).IsRequired(false);
				//product.HasOne(p => p.Category);

			});
		}

	}
}
