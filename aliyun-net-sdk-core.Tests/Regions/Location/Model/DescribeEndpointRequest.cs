using System.Collections.Generic;

using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Regions.Location.Model
{
    public class DescribeEndpointRequestTest
    {
        [Fact]
        public void Id()
        {
            DescribeEndpointRequest instance = new DescribeEndpointRequest();
            string Id = "Id";
            instance.Id = Id;
            Assert.Equal(Id, instance.Id);
        }

        [Fact]
        public void EndpointType()
        {
            DescribeEndpointRequest instance = new DescribeEndpointRequest();
            string EndpointType = "EndpointType";
            instance.EndpointType = EndpointType;
            Assert.Equal(EndpointType, instance.EndpointType);
        }

        [Fact]
        public void LocationProduct()
        {
            DescribeEndpointRequest instance = new DescribeEndpointRequest();
            string LocationProduct = "LocationProduct";
            instance.LocationProduct = LocationProduct;
            Assert.Equal(LocationProduct, instance.LocationProduct);
        }

        [Fact]
        public void GetResponse()
        {
            DescribeEndpointRequest instance = new DescribeEndpointRequest();
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
                };
            }

            // 此方法仅有一行代码，只回调了null，没有其它逻辑
            var result = instance.GetResponse(unmarshallerContext);
            Assert.Null(result);
        }
    }
}
