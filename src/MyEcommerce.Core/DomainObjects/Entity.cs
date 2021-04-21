using System;

namespace MyEcommerce.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity() => Id = Guid.NewGuid();

        public static implicit operator bool(Entity entity) => entity != null;

        public override bool Equals(object obj) => obj is Entity entity && entity.Id.Equals(Id);

        public override int GetHashCode() => HashCode.Combine(Id);

        public override string ToString() => $"{GetType().Name} - Id = {Id}";
    }
}