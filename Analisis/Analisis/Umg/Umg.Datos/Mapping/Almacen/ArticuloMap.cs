using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("Articulo")
            .HasKey(b => b.idArticulo);


            builder.Property(b => b.codigo)
             .HasMaxLength(50);

            builder.Property(b => b.nombre)
                .HasMaxLength(100);

            builder.Property(b => b.precioVenta);
            builder.Property(b => b.stock);
            builder.Property(b => b.descripcion)
                 .HasMaxLength(256);
            builder.Property(b => b.condicion);

            //relacion con categoria uno uno//
            builder.HasOne(p => p.Categorias)
                .WithOne();




        }
    }
}
