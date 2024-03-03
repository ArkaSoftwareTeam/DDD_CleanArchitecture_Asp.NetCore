using Hesabdari.Sample.Core.Domain.Pepole.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Hesabdari.Sample.Core.Domain.Pepole.ValueObjects;
namespace Hesabdari.Sample.Infrastructure.Data.SQLCommands.Pepole.Configure
{
    public class PersonConfigure : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.FirstName).HasConversion(x => x.Value, x => new FirstName(x));
            builder.Property(x => x.LastName).HasConversion(x => x.Value, x => new LastName(x));
        }
    }
}
