namespace VirtualStore.Core.Entities
{
    public class Category
    {
        public Category(int categoryId, string? name)
        {
            CategoryId = categoryId;
            Name = name;
            Products = new List<Product>();
        }

        public int CategoryId { get; private set; }
        public string? Name { get; private set; }
        public List<Product> Products { get;  private set; }
    }
}
