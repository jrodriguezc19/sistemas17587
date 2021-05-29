using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class VentasMapMap : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Ventas")
                .HasKey(j => j.idVenta);

            builder.Property(j => j.TipoComprobante)
                .HasMaxLength(20);

            builder.Property(j => j.serieComprobante)
                .HasMaxLength(7);

            builder.Property(j => j.NumComprobante)
                .HasMaxLength(10);

            builder.Property(j => j.FechaHora);

            builder.Property(j => j.Impuesto);

            builder.Property(j => j.total);

            builder.Property(j => j.estado)
                .HasMaxLength(20);

            //relacion con persona uno uno//
            builder.HasOne(j => j.Personas)
                .WithOne();

            //relacion con persona uno uno//
            builder.HasOne(j => j.Usuarios)
                .WithOne();
        }

    }
}

