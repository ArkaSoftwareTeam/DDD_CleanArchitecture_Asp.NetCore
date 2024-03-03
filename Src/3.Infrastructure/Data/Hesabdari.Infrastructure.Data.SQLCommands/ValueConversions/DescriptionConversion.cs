using Hesabdari.Core.Toolkits.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hesabdari.Infrastructure.Data.SQLCommands.ValueConversions
{
    public class DescriptionConversion:ValueConverter<Description, string>
    {
        public DescriptionConversion() : base(c => c.Value, c => Description.FromString(c))
        {

        }
    }
}
