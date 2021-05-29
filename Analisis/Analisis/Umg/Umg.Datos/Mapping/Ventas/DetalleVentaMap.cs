using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class DetalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {

        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta")
             .HasKey(i => i.idDetalleVenta);

            builder.Property(i => i.cantidad);


            builder.Property(i => i.PrecioDetalleVenta);
               

            builder.Property(i => i.Descuento);
            

        }
    }
    }
