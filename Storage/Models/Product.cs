using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [Range(1, 10000)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
