using Microsoft.AspNetCore.Antiforgery;
using Softmax.XNotifi.Controllers;

namespace Softmax.XNotifi.Web.Host.Controllers
{
    public class AntiForgeryController : XNotifiControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
