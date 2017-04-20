using System.Data.Entity.ModelConfiguration;
using Models;

namespace Data.EntityConfiguration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasRequired(b => b.Basket)
                .WithOptional(o => o.Order);

            HasRequired(u => u.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(u => u.UserId);
        }
    }
}
