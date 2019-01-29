using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

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
            UnmarshallerContext context = new UnmarshallerContext();
            CommonRequest instance = new CommonRequest();

            instance.AddQueryParameters("AddQueryParameters", "a");
            context.ResponseDictionary = instance.QueryParameters;
            Assert.Equal("a", context.StringValue("AddQueryParameters"));

            instance.AddBodyParameters("AddBodyParameters", "b");
            context.ResponseDictionary = instance.BodyParameters;
            Assert.Equal("b", context.StringValue("AddBodyParameters"));

            instance.AddHeadParameters("AddHeadParameters", "c");
            context.ResponseDictionary = instance.HeadParameters;
            Assert.Equal("c", context.StringValue("AddHeadParameters"));

            instance.AddPathParameters("AddPathParameters", "d");
            context.ResponseDictionary = instance.PathParameters;
            Assert.Equal("d", context.StringValue("AddPathParameters"));
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
