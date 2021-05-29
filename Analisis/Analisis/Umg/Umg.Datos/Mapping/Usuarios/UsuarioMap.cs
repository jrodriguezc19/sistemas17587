using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario")
                    .HasKey(g => g.idusuario);

            builder.Property(g => g.nombre)
                .HasMaxLength(100);

            builder.Property(g => g.tipodocumento)
                .HasMaxLength(20);

            builder.Property(g => g.numdocumentos)
                .HasMaxLength(20);

            builder.Property(g => g.direccion)
                .HasMaxLength(70);

            builder.Property(g => g.telefono)
                .HasMaxLength(20);

            builder.Property(g => g.Email)
                .HasMaxLength(50);

            builder.Property(g => g.password_hash);


            builder.Property(g => g.Password_sal);

            builder.Property(g => g.condicion);

            //relacion con roles uno uno//
            builder.HasOne(e => e.Roles)
                .WithOne();


        }

    }
}





  