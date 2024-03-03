using Hesabdari.Core.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace Hesabdari.Infrastructure.Data.SQLCommands.ValueConversions
{
    public class BusinessIdConversion : ValueConverter<BusinessId, Guid>
    {
        public BusinessIdConversion() 
            : base(x => x.Value , x => BusinessId.FromGuid(x))
        {
        }
    }
}
