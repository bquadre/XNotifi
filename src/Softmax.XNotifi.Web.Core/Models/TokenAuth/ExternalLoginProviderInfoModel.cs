using Abp.AutoMapper;
using Softmax.XNotifi.Authentication.External;

namespace Softmax.XNotifi.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
