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

using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class RoaSignatureComposerTest
    {
        [Fact]
        public void ComposeStringToSign()
        {
            RoaSignatureComposer.ClearComposer();
            var tmp = new Dictionary<string, string>
            {
                {"foo", "bar"},
                {"a", "A"},
                {"nullValue", null}
            };
            var method = MethodType.GET;
            Signer signer = new HmacSHA1Signer();
            var instance = RoaSignatureComposer.GetComposer();
            var result = instance.ComposeStringToSign(method, "www.alibabacloud.com?", signer, tmp, tmp, tmp);
            Assert.Equal("GET\n\n\n\n\nwww.alibabacloud.com?&a=A&foo=bar&nullValue", result);
        }

        [Fact]
        public void RefreshSignParameters()
        {
            RoaSignatureComposer.ClearComposer();
            var instance = new RoaSignatureComposer();
            var parameters = new Dictionary<string, string>
            {
                {"foo", "bar"},
                {"a", "A"},
                {"nullValue", null}
            };
            var mock = new Mock<Signer>();
            mock.Setup(foo => foo.GetSignerType()).Returns("MockSigner");
            var signer = mock.Object;
            var context = new UnmarshallerContext();

            context.ResponseDictionary =
                instance.RefreshSignParameters(parameters, signer, "accessKeyId", FormatType.JSON);
            Assert.Equal("MockSigner", context.StringValue("x-acs-signature-type"));

            var hmacSHA1Signer = new HmacSHA1Signer();
            context.ResponseDictionary =
                instance.RefreshSignParameters(parameters, hmacSHA1Signer, "accessKeyId", null);
            Assert.Null(context.StringValue("x-acs-signature-type"));
        }

        [Fact]
        public void ReplaceOccupiedParameters()
        {
            RoaSignatureComposer.ClearComposer();
            var tmp = new Dictionary<string, string>
            {
                {"foo", "bar"},
                {"a", "A"},
                {"b", "B"}
            };
            var result = RoaSignatureComposer.ReplaceOccupiedParameters("url?a=[a]&foo=[foo]&b=[b]", tmp);
            Assert.Equal("url?a=A&foo=bar&b=B", result);
        }
    }
}
