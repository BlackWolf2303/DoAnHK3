using System;

namespace Flower.Core.Entities
{
    public class Image : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
