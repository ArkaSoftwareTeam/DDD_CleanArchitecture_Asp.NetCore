using Hesabdari.Core.Domain.Exceptions;
using Hesabdari.Core.Domain.ValueObjects;
using Hesabdari.Utilities.Extensions;

namespace Hesabdari.Sample.Core.Domain.Pepole.ValueObjects
{
    public class FirstName:BaseValueObject<FirstName>
    {
        public string Value { get;private set; }

        public FirstName(string value)
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new InvalidValueObjectStateException(Messages.InvalidNullValue , Messages.FirstName);
            if(value.IsLengthBetween(2 , 50)) 
            {
                throw new InvalidValueObjectStateException(Messages.InvalidStringLength, Messages.FirstName ,"2","50");
            }
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
