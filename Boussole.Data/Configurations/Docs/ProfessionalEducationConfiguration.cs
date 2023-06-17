using Boussole.Docs.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boussole.Data.Configurations.Docs;

internal class ProfessionalEducationConfiguration : IEntityTypeConfiguration<ProfessionalEducation>
{
    public void Configure(EntityTypeBuilder<ProfessionalEducation> builder)
    {
        builder.HasKey(entity => entity.Person);
    }
}