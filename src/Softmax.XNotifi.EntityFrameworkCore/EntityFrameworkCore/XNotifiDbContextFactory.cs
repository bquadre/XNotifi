using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Softmax.XNotifi.Configuration;
using Softmax.XNotifi.Web;

namespace Softmax.XNotifi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class XNotifiDbContextFactory : IDesignTimeDbContextFactory<XNotifiDbContext>
    {
        public XNotifiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<XNotifiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            XNotifiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(XNotifiConsts.ConnectionStringName));

            return new XNotifiDbContext(builder.Options);
        }
    }
}
