

namespace WebAPI.Models
{
    public class Product                                      //доступность из любой части программы.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string color { get; set; }
        public decimal Price { get; set; }
        public List<int> Sizes { get; set; }

    }
}
