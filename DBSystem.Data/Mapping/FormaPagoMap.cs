using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DBSystem.Core.Domain;

namespace DBSystem.Data.Mapping
{
    public class FormaPagoMap : EntityTypeConfiguration<FormaPago>
    {
        public FormaPagoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FormaPago");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.nroDias).HasColumnName("nroDias");
        }
    }
}
