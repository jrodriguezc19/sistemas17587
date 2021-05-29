using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    
        public class PersonaMap : IEntityTypeConfiguration<Persona>
        {

            public void Configure(EntityTypeBuilder<Persona> builder)
            {
                builder.ToTable("Persona")
                    .HasKey(d => d.IdPersona);

                builder.Property(d => d.TipoPersona)
                    .HasMaxLength(20);

                builder.Property(d => d.Nombre)
                    .HasMaxLength(100);

                builder.Property(d => d.TipoDocumento)
                    .HasMaxLength(20);

                builder.Property(d => d.NumDocumento)
                    .HasMaxLength(20);

                builder.Property(d => d.Direccion)
                    .HasMaxLength(20);

                builder.Property(d => d.Telefono)
                    .HasMaxLength(20);

                builder.Property(d => d.Email)
                    .HasMaxLength(50);


            }

    
        }
    }



