using System.ComponentModel.DataAnnotations;

namespace BotuqieButik.Models
{
    public class ProductCategory
    {
        [Required(ErrorMessage = "Ürün Seçimi Yapınız")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Kategori Seçimi Yapınız")]
        public int CategoryId { get; set; }
    }
}
