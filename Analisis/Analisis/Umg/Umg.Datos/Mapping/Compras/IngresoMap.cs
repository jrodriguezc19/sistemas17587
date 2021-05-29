using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Compras;

namespace Umg.Datos.Mapping.Compras
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("Ingreso")
             .HasKey(c => c.Idingreso);


            builder.Property(c => c.TipoComprobante)
             .HasMaxLength(20);

            builder.Property(c => c.SerieComprobante)
                .HasMaxLength(7);

            builder.Property(c => c.NumComprobante)
                .HasMaxLength(10);
                
            builder.Property(c => c.FechaHora);
            builder.Property(c => c.Impuesto);

            builder.Property(c => c.Estado)
                .HasMaxLength(20);

            builder.Property(c => c.Total);
                
            //relacion con Usuario uno uno//
            builder.HasOne(p => p.Usuarios)
                .WithOne();

            builder.HasOne(p => p.personas)
                .WithOne();

        }
    }
}
