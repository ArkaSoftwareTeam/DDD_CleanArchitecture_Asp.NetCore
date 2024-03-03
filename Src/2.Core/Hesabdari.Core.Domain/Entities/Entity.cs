using Hesabdari.Core.Domain.ValueObjects;

namespace Hesabdari.Core.Domain.Entities
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public BusinessId BusinessId { get; protected set; } = BusinessId.FromGuid(Guid.NewGuid());
        protected Entity() { }


        public bool Equals(Entity? other) => this == other;
        public override bool Equals(object? obj) => obj is Entity otherObject && Id == otherObject.Id;
        public override int GetHashCode() => Id.GetHashCode();
        public static bool operator ==(Entity? left, Entity? right)
        {
            if (left is null && right is null)
                return true;
            if(left is null || right is null)
                return false;
            return left.Equals(right);

        }
        public static bool operator !=(Entity? left, Entity? right)
        {
            return !(left == right);
        }

    }
}
