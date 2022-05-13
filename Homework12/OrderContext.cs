using Microsoft.EntityFrameworkCore;

namespace Homework12;

//[DbConfigurationType(typeof(MySqlEFConfiguration))]
public class OrderContext : DbContext
{
    public OrderContext() : base()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseMySQL("server=localhost;database=orderstest;user=root;password=root"
            , (System.Action<MySql.EntityFrameworkCore.Infrastructure.MySQLDbContextOptionsBuilder>?)null);
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Goods> Goods { get; set; }
    public DbSet<Customer> Customers { get; set; }
}