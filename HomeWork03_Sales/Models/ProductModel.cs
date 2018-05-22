namespace HomeWork03_Sales.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
            AppDomain.CurrentDomain.SetData("Directory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductTotal> ProductTotal { get; set; }
        public virtual DbSet<SalesSaleProduct> SalesSaleProduct { get; set; }
        public virtual DbSet<SaleTotal> SaleTotal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
