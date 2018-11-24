using System;

namespace FlowerShop2.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
