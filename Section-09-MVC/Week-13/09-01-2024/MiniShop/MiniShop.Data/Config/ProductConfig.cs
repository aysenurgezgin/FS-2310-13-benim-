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
            builder
                 .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Televizyon",
                        Description = "TV kategorisi",
                        Url = "televizyon"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Bilgisayar",
                        Description = "Bilgisayar kategorisi",
                        Url = "bilgisayar"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Elektronik Eşya",
                        Description = "Elektronik Eşya kategorisi",
                        Url = "elektronik-esya"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Beyaz Eşya",
                        Description = "Beyaz Eşya kategorisi",
                        Url = "beyaz-esya"
                    }
                );

        }
    }
}
