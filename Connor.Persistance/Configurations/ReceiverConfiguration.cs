using Connor.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connor.Persistance.Configurations;

public class ReceiverConfiguration : IEntityTypeConfiguration<Receiver>
{
    public void Configure(EntityTypeBuilder<Receiver> builder)
    {
        builder.ToTable("Receivers");
        
        builder.HasKey(r => r.Id);
        
        builder.Property(r => r.Age)
            .IsRequired()
            .HasColumnType("tinyint");

        builder.Property(r => r.Name)
            .IsRequired()
            .HasColumnType("varchar(30)");
        
        builder.Property(r => r.Surname)
            .IsRequired()
            .HasColumnType("varchar(50)");
        
        builder.Property(r => r.Characteristics)
            .IsRequired()
            .HasColumnType("varchar(400)");
        
        builder.Property(r => r.Gender)
            .IsRequired()
            .HasColumnType("bit");
        
        builder.Property(r => r.Habits)
            .IsRequired()
            .HasColumnType("varchar(200)");
        
        builder.Property(r => r.Profession)
            .IsRequired()
            .HasColumnType("varchar(50)");
        
    }
}