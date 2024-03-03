namespace Hesabdari.Core.Domain.ValueObjects
{
    public abstract class BaseValueObject<TValueObject> : IEquatable<TValueObject>
        where TValueObject : BaseValueObject<TValueObject>
    {
        public bool Equals(TValueObject? other) => this == other;

        public override bool Equals(object? obj)
        {
            if(obj is TValueObject otherObject)
            {
                return GetEqualityComponents().SequenceEqual(otherObject.GetEqualityComponents());
            }
            return false;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        protected abstract IEnumerable<object> GetEqualityComponents();
        public static bool operator ==(BaseValueObject<TValueObject> right , BaseValueObject<TValueObject> left)
        {
            if(right is  null && left is null)
                return true;
            if (right is null || left is null)
                return false;
            return right.Equals(left);
        }

        public static bool operator !=(BaseValueObject<TValueObject> right , BaseValueObject<TValueObject> left)
        {
            return !right.Equals(left);
        }
    }
}
