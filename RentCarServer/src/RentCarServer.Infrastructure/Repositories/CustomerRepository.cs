using RentCarServer.Domain.Customers;
using RentCarServer.Infrastructure.Context;
using RentCarServer.Infrastructure.Repositories;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class CustomerRepository : AuditableRepository<Customer, ApplicationDbContext>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
}