using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data.EntityConfiguration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasRequired(b => b.Basket)
                .WithOptional(o => o.Order);
        }
    }
}
