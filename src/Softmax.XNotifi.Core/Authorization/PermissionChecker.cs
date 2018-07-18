using Abp.Authorization;
using Softmax.XNotifi.Authorization.Roles;
using Softmax.XNotifi.Authorization.Users;

namespace Softmax.XNotifi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
