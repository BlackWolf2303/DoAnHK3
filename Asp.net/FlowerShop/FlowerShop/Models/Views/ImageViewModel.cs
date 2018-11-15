using System;

namespace FlowerShop.Models.Views
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
