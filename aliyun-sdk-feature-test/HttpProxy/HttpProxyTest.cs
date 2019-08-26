/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.HttpProxy
{
    [Trait("Category", "FeatureTest")]
    public class HttpProxyTest
    {
        [Fact]
        public void HttpProxy()
        {
            var client = FeatureTest.DefaultClient;

            var request = new DescribeAccessPointsRequest();
            client.SetHttpProxy("http://localhost:8989");

            var response = client.GetAcsResponse(request);
            Assert.NotNull(response.HttpResponse.Content);

            var expectValue = "HTTP/1.1 o_o";
            string actualValue;
            response.HttpResponse.Headers.TryGetValue("Via", out actualValue);
            Assert.Equal(expectValue, actualValue);

            client.SetHttpProxy(null);
        }

        [Fact]
        public void HttpProxyWithCredential()
        {
            var client = FeatureTest.DefaultClient;

            var request = new DescribeAccessPointsRequest();
            client.SetHttpProxy("http://username:password@localhost:8989");
            var response = client.GetAcsResponse(request);

            var expectValue = "HTTP/1.1 o_o";
            string actualValue;
            response.HttpResponse.Headers.TryGetValue("Via", out actualValue);

            Assert.Equal(expectValue, actualValue);
            Assert.NotNull(response.HttpResponse.Content);

            client.SetHttpProxy(null);
        }
    }
}
