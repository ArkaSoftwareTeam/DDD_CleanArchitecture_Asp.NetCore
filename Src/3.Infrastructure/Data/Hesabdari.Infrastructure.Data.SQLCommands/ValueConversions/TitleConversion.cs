using Hesabdari.Core.Toolkits.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hesabdari.Infrastructure.Data.SQLCommands.ValueConversions
{
    public class TitleConversion:ValueConverter<Title , string>
    {
        public TitleConversion() : base(c => c.Value, c => Title.FromString(c))
        {

        }
    }
}
