using Boussole.Docs.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations.Docs;

internal class PersonMerchConfiguration : IEntityTypeConfiguration<PersonMerch>
{
    public void Configure(EntityTypeBuilder<PersonMerch> builder)
    {
        builder.HasKey(entity => entity.Person);
    }
}