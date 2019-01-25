using System;
using System.Collections.Generic;
using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests
{
    public class AcsRequestTest
    {
        [Fact]
        public void Instance()
        {
            var mockAcsRequest = new MockAcsRequest();
            Assert.IsType<MockAcsRequest>(mockAcsRequest);

            Assert.Equal(FormatType.XML, mockAcsRequest.AcceptFormat);
            Assert.Equal(ProtocolType.HTTP, mockAcsRequest.Protocol);
        }

        [Fact]
        public void Parameters()
        {
            var mockAcsRequest = new MockAcsRequest();

            Dictionary<String, String> tmpDic = new Dictionary<String, String> { { "foo", "bar" } };
            mockAcsRequest.QueryParameters = tmpDic;

            mockAcsRequest.DomainParameters = tmpDic;
            Assert.Equal(tmpDic, mockAcsRequest.DomainParameters);

            mockAcsRequest.BodyParameters = tmpDic;
            Assert.Equal(tmpDic, mockAcsRequest.BodyParameters);
        }

        [Fact]
        public void ConcatQueryString()
        {
            var mockAcsRequest = new MockAcsRequest();

            Dictionary<String, String> tmpDic = null;

            // When parameters is null
            var result = MockAcsRequest.ConcatQueryString(tmpDic);
            Assert.Null(result);

            // when parameters is empty
            tmpDic = new Dictionary<String, String> { };
            result = MockAcsRequest.ConcatQueryString(tmpDic);
            Assert.NotNull(result); // 非null 但是为空
            Assert.Empty(result);

            // When parammters is not null
            tmpDic = new Dictionary<String, String> { { "foo", "bar" }, { "a", "A" }, { "n", null } };
            result = MockAcsRequest.ConcatQueryString(tmpDic);
            Assert.Equal("foo=bar&a=A&n", result);
        }

        [Fact]
        public void SignRequest()
        {
            Dictionary<String, String> tmpDic = new Dictionary<String, String> { { "foo", "bar" }, { "a", "A" }, { "n", null } };

            var mockAcsRequest = new MockAcsRequest("https://www.alibabacloud.com/");
            HmacSHA1Signer signer = new HmacSHA1Signer();
            Credential credential = new Credential("accessKeyId", "accessKeySecret", "securityToken");
            ProductDomain domain = new ProductDomain();
            MockAcsRequest.ConcatQueryString(tmpDic);

            HttpRequest request = mockAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            Assert.Equal("Instance by MockAcsRequest", request.Url);
        }

        [Fact]
        public void CheckShowJsonItemName()
        {
            var mockAcsRequest = new MockAcsRequest();
            // CheckShowJsonItemName 方法会回调true，且无其它逻辑
            Assert.True(mockAcsRequest.CheckShowJsonItemName());
        }
    }

    public sealed class MockAcsRequest : AcsRequest<CommonRequest>
    {
        public MockAcsRequest(string urlStr = null) : base(urlStr)
        {

        }
        public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain)
        {
            HttpRequest httpRequest = new HttpRequest();
            httpRequest.Url = "Instance by MockAcsRequest";
            return httpRequest;
        }

        public override String ComposeUrl(String endpoint, Dictionary<String, String> queries)
        {
            return "";
        }

        public override CommonRequest GetResponse(UnmarshallerContext unmarshallerContext)
        {
            CommonRequest t = new CommonRequest();
            return t;
        }
    }
}
