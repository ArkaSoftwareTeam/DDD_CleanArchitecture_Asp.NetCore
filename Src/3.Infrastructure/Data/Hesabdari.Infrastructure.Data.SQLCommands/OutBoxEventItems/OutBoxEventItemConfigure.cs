using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hesabdari.Infrastructure.Data.SQLCommands.OutBoxEventItems
{
    public class OutBoxEventItemConfigure : IEntityTypeConfiguration<OutBoxEventItem>
    {
        public void Configure(EntityTypeBuilder<OutBoxEventItem> builder)
        {
            builder.Property(x => x.AccuredByUserId).HasMaxLength(255);
            builder.Property(x => x.EventName).HasMaxLength(255);
            builder.Property(x => x.AggregateName).HasMaxLength(255);
            builder.Property(x => x.EventTypeName).HasMaxLength(500);
            builder.Property(x => x.AggregateTypeName).HasMaxLength(500);
        }
    }
}
