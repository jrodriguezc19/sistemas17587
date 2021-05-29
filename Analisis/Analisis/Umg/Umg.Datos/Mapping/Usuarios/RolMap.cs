using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
 
        public class RolMap : IEntityTypeConfiguration<Rol>
        {

            public void Configure(EntityTypeBuilder<Rol> builder)
            {
                builder.ToTable("Rol")
                    .HasKey(e => e.idRol);

                builder.Property(e => e.nombre)
                    .HasMaxLength(30);

                builder.Property(e => e.descipcion)
                    .HasMaxLength(100);

                builder.Property(e => e.condicion);


            }

        }
    }
