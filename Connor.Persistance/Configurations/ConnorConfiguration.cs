using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connor.Persistance.Configurations;

public class ConnorConfiguration : IEntityTypeConfiguration<Models.Connor>
{
    public void Configure(EntityTypeBuilder<Models.Connor> builder)
    {
        builder.ToTable("Connors");
        
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Character)
            .IsRequired()
            .HasMaxLength(400);

        builder.Property(c => c.CharacterReference)
            .IsRequired()
            .HasMaxLength(200);
    }
}