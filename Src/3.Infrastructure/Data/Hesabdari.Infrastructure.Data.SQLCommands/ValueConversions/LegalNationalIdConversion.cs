using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Hesabdari.Core.Toolkits.ValueObjects;
namespace Hesabdari.Infrastructure.Data.SQLCommands.ValueConversions
{
    public class LegalNationalIdConversion : ValueConverter<LegalNationalId, string>
    {
        public LegalNationalIdConversion() : base(c => c.Value, c => LegalNationalId.FromString(c))
        {

        }
    }
}
