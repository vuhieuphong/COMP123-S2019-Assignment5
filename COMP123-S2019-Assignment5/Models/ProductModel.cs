namespace COMP123_S2019_Assignment5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    /// <summary>
    /// APP NAME: Dollar Computer
    /// AUTHOR'S NAME: Vu Hieu Phong
    /// STUDENT ID: 301049781
    /// APP CREATION DATE: August 13th 2018
    /// APP DESCRIPTION: This app helps to develop a hardware buying UI 
    /// this is the product model for the database
    /// </summary>
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModelConnection")
        {
        }

        public virtual DbSet<Product> products { get; set; }
        //represents the table inside the db

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
