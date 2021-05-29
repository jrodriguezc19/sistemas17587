using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(c => c.idCategoria);
            
            builder.Property(c => c.Nombre)
                .HasMaxLength(50);
            
            builder.Property(c => c.Descripcion)
                .HasMaxLength(250);

            builder.Property(b => b.Condicion);



        }
    }
}
