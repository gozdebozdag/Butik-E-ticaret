namespace BotuqieButik.data.Entitis
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        public string? image { get; set; }

        public int? ProductCategoryId { get; set; }
        public Category? category { get; set; }
    }
}
