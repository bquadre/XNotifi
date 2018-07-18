using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Softmax.XNotifi.EntityFrameworkCore
{
    public static class XNotifiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<XNotifiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<XNotifiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
