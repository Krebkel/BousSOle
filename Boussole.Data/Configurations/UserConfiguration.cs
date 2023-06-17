using Boussole.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        const string personColumnName = "PersonInn";
        
        builder.HasOne(s => s.Person).WithMany().HasForeignKey(personColumnName).IsRequired();
        builder.HasKey(personColumnName);
    }
}