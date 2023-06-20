namespace VirtualStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product(string? name, decimal prince, string? description, long stock, string? imageURL, DateTime createdAt, Category? category, int categoryId)
        {
            Name = name;
            Prince = prince;
            Description = description;
            Stock = stock;
            ImageURL = imageURL;

            CreatedAt = DateTime.Now;
            Category = category;
            CategoryId = categoryId;
        }

        public string? Name { get; private set; }
        public decimal Prince { get; private set; }
        public string? Description { get; private set; }
        public long Stock { get; private set; }
        public string? ImageURL { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Category Category { get; private set; }
        public int CategoryId { get; private set; }
    }
}
