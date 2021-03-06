using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DBSystem.Core.Domain;

namespace DBSystem.Data.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.rucDni)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.razonSocial)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.direccion)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.rucDni).HasColumnName("rucDni");
            this.Property(t => t.razonSocial).HasColumnName("razonSocial");
            this.Property(t => t.direccion).HasColumnName("direccion");
        }
    }
}
