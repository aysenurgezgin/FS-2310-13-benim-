using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Properties)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.ToTable("Products");
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone14",
                    Price = 59000,
                    Properties = "Harika bir telefon",
                    Url="iphone-14",
                    ImageUrl="1.png",
                    IsHome=true
                },
                
                ) ;


        }
    }
}
