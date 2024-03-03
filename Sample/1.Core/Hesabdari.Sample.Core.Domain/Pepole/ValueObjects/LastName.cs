using Hesabdari.Core.Domain.Exceptions;
using Hesabdari.Core.Domain.ValueObjects;

namespace Hesabdari.Sample.Core.Domain.Pepole.ValueObjects
{
    public class LastName : BaseValueObject<LastName>
    {
        public string Value { get; private set; }

        public LastName(string value)
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
                throw new InvalidValueObjectStateException(Messages.InvalidNullValue, Messages.FirstName);
            if (value.Length < 2 || value.Length > 50)
            {
                throw new InvalidValueObjectStateException(Messages.InvalidStringLength, Messages.FirstName, "2", "50");
            }
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
