using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class TelefonoMap : IEntityTypeConfiguration<Telefono>
    {
        public void Configure(EntityTypeBuilder<Telefono> builder)
        {
            builder.ToTable("Telefono")
            .HasKey(f => f.idTelefono);


            builder.Property(f => f.idPersona);
             

            builder.Property(f => f.telefonoPersonal)
                .HasMaxLength(8);

            builder.Property(f => f.telefonoResidencial)
                .HasMaxLength(8);

            builder.Property(f => f.telefonoLaboral)
                 .HasMaxLength(8);



            //relacion con usuario uno uno//
            builder.HasOne(f => f.Usuarios)
                .WithOne();




        }

      
    }
}