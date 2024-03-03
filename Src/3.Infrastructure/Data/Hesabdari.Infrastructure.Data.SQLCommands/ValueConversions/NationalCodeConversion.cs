using Hesabdari.Core.Toolkits.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hesabdari.Infrastructure.Data.SQLCommands.ValueConversions
{
    public class NationalCodeConversion:ValueConverter<NationalCode , string>
    {
        public NationalCodeConversion() : base(c => c.Value, c => NationalCode.FromString(c))
        {

        }
    }
}
