using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Flower.Core.Entities
{
    interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        IdentityUser CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        IdentityUser ModifiedBy { get; set; }
    }
}
