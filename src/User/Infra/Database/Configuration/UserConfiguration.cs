using Microsoft.EntityFrameworkCore;
using PayFlow.User.Domain.AggregateModel;

namespace PayFlow.User.Infra.Database.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<UserEntiy>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserEntiy> builder)
    {
        builder.Property(user => user.Name)
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(user => user.Email)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(user => user.Password)
            .HasMaxLength(150)
            .IsRequired();
    }
}
