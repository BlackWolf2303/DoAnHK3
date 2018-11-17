using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.Core.Entities
{
    public interface IContactEntity
    {
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
    }
}
