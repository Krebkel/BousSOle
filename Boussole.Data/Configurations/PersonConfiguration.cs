using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Boussole.LSO.Contracts.Structure;
using Boussole.Persons;

namespace Boussole.Data.Configurations;

internal class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(entity => entity.PersonInn);
    }
}