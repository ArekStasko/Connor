using Connor.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Connor.Persistance.Configurations;

public class PromptConfiguration : IEntityTypeConfiguration<Prompt>
{
    public void Configure(EntityTypeBuilder<Prompt> builder)
    {
        builder.ToTable("Prompts");
        
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.Avoid)
            .IsRequired()
            .HasColumnType("varchar(200)");

        builder.Property(p => p.FocusOn)
            .IsRequired()
            .HasColumnType("varchar(200)");
        
        builder.Property(p => p.Text)
            .IsRequired()
            .HasColumnType("varchar(400)");
        
        builder.Property(p => p.From)
            .IsRequired()
            .HasColumnType("time");
        
        builder.Property(p => p.To)
            .IsRequired()
            .HasColumnType("time");

        builder.Property(p => p.Type)
            .IsRequired()
            .HasColumnType("varchar(50)");
    }
}