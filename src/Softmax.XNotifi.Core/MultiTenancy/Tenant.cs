using Abp.MultiTenancy;
using Softmax.XNotifi.Authorization.Users;

namespace Softmax.XNotifi.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
