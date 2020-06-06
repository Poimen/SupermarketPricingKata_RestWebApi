namespace SupermarketApi.Products.Models
{
    public class ProductViewModel
    {
        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public decimal Price { get; }

        public ProductViewModel(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
