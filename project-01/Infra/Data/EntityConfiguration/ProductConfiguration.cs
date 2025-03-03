using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder){
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2).IsRequired();


            builder.HasData(
                new Product {
                    Id = 1,
                    Name = "caderno",
                    Description = "Carderno espiral 100 folhas",
                    Price = 9.45m
                },
                new Product {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha Branca",
                    Price = 1.45m
                },
                new Product {
                    Id = 3,
                    Name = "Caneta",
                    Description = "Caneta azul",
                    Price = 2.45m
                }
            );
        }

    }
}