using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext:DbContext
    {
        public OrderContext():base("name=database_order")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> Goods { get; set; }
    }
}
