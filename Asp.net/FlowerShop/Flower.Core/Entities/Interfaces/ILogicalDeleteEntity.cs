using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.Core.Entities
{
    public interface ILogicalDeleteEntity
    {
        bool Deleted { get; set; }
    }
}
