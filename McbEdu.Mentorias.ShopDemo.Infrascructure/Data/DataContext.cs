using McbEdu.Mentorias.ShopDemo.Domain.Contracts.Infrascructure.Mappings;
using McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace McbEdu.Mentorias.ShopDemo.Infrascructure.Data;

public class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; protected set; }

    private IBaseMapping<Customer> CustomerBaseMapping { get; }

    public DataContext(DbContextOptions options, IBaseMapping<Customer> customerBaseMapping) : base(options)
    {
        CustomerBaseMapping = customerBaseMapping;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CustomerBaseMapping.CreateBaseMapping(modelBuilder.Entity<Customer>());

        base.OnModelCreating(modelBuilder);
    }
}
