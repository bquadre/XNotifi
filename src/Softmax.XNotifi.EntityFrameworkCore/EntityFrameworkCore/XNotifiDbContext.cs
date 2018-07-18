using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Softmax.XNotifi.Authorization.Roles;
using Softmax.XNotifi.Authorization.Users;
using Softmax.XNotifi.MultiTenancy;
using Softmax.XNotifi._Clients;
using Softmax.XNotifi._Applications;

namespace Softmax.XNotifi.EntityFrameworkCore
{
    public class XNotifiDbContext : AbpZeroDbContext<Tenant, Role, User, XNotifiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Client> AppClients { get; set; }

        public virtual DbSet<Application> Applications { get; set; }

        public XNotifiDbContext(DbContextOptions<XNotifiDbContext> options)
            : base(options)
        {
        }
    }
}
