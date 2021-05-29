using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class CategoriaMap : IEntityTypeConfiguration<DetalleIngreso>
    {


        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("DetalleIngreso")
                .HasKey(h => h.IdDetalleIngreso);

            builder.Property(h => h.idIngreso);


            builder.Property(h => h.idArticulo);
                

            builder.Property(h => h.Cantidad);


            builder.Property(h => h.PrecioDetalle);


            //relacion con ingreso uno uno//
            builder.HasOne(p => p.Ingresos)
                .WithOne();

            //relacion con Articulo uno uno//
            builder.HasOne(p => p.Articulos)
                .WithOne();
        }

       
    }
}
