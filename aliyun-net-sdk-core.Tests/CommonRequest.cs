using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests
{
    public class CommonRequestTest
    {
        [Fact]
        public void Instance()
        {
            CommonRequest instance = new CommonRequest();
        }

        [Fact]
        public void BuildRequest()
        {
            CommonRequest instance = new CommonRequest();
            AcsRequest<CommonResponse> request = instance.BuildRequest();
            request = instance.BuildRequest(); // all parameters is null

            // all parameters  is not null
            instance.UriPattern = "https://www.alibabacloud.com";
            instance.AddPathParameters("foo", "bar");
            instance.Action = "Action";
            instance.RegionId = "RegionId";
            instance.LocationProduct = "LocationProduct";
            instance.LocationEndpointType = "LocationEndpointType";
            instance.TimeoutInMilliSeconds = 100000;
            instance.Method = MethodType.GET;
            instance.Domain = "Domain";
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("somestring");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            instance.AddQueryParameters("foo", "bar");
            instance.AddBodyParameters("foo", "bar");
            request = instance.BuildRequest();
        }

        [Fact]
        public void Add()
        {
            CommonRequest instance = new CommonRequest();
            instance.AddQueryParameters("foo", "bar"); // 私有参数，无get方法
            instance.AddBodyParameters("foo", "bar"); // 私有参数，无get方法
            instance.AddHeadParameters("foo", "bar"); // 私有参数，无get方法
            instance.AddPathParameters("foo", "bar"); // 私有参数，无get方法
        }

        [Fact]
        public void SetContent()
        {
            CommonRequest instance = new CommonRequest();
            byte[] content = Encoding.ASCII.GetBytes("someString");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
        }
    }
}
