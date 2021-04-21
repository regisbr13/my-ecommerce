using MyEcommerce.Core.DomainObjects;

namespace MyEcommerce.Catalog.Domain
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        public override string ToString() => $"{Name} - {Code}";
    }
}