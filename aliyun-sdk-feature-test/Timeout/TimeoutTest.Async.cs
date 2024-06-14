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

using System;
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Timeout
{
    [Trait("Category", "FeatureTest")]
    public class AsyncTimeoutTest
    {
        [Fact]
        public async Task TestConnectTimeoutWithException()
        {
            var request = new HttpRequest("https://alibaba.great");
            request.Method = MethodType.GET;
            request.SetConnectTimeoutInMilliSeconds(1);

            var exception = await Assert.ThrowsAsync<ClientException>(() => HttpResponse.GetResponseAsync(request));

            Assert.NotNull(exception.Message);

            request = new HttpRequest("https://alibaba.great");
            request.Method = MethodType.GET;

            using (var cts = new CancellationTokenSource(10))
            {
                exception = await Assert.ThrowsAsync<ClientException>(() => HttpResponse.GetResponseAsync(request, cts.Token));

                Assert.NotNull(exception.Message);
            }
        }

        [Fact]
        public async Task TestVPCConnectTimeoutWithException()
        {
            var request = new DescribeAccessPointsRequest();
            request.SetConnectTimeoutInMilliSeconds(1);

            Exception exception = await Assert.ThrowsAsync<ClientException>(() => FeatureTest.DefaultClient.GetAcsResponseAsync(request));

            Assert.NotNull(exception.Message);

            request = new DescribeAccessPointsRequest();

            using (var cts = new CancellationTokenSource(10))
            {
                exception = null;

                try
                {
                    await FeatureTest.DefaultClient.GetAcsResponseAsync(request, cts.Token);
                }
                catch (Exception e)
                {
                    exception = e;
                }

                Assert.NotNull(exception);
                Assert.NotNull(exception.Message);
            }
        }
    }
}
