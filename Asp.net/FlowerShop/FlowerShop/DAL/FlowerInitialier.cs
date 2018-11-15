using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlowerShop.DAL
{
    public class FlowerInitialier : DropCreateDatabaseIfModelChanges<FlowerContext>
    {
        protected override void Seed(FlowerContext context)
        {

        }
    }
}