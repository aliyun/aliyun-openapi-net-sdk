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

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class RpcSignatureComposerTest
    {
        [Fact]
        public void ComposeStringToSign()
        {
            RpcSignatureComposer.ClearComposer();
            var tmp = new Dictionary<string, string>
            {
                {"foo", "bar"},
                {"a", "A"},
                {"b", "B"}
            };
            var method = MethodType.GET;
            Signer signer = new HmacSHA1Signer();
            var instance = RoaSignatureComposer.GetComposer();
            var result = instance.ComposeStringToSign(method, "uriPattern", signer, tmp, tmp, tmp);
            Assert.Equal("GET\n\n\n\n\nuriPattern?a=A&b=B&foo=bar", result);
        }

        [Fact]
        public void RefreshSignParameters()
        {
            RpcSignatureComposer.ClearComposer();
            var formatType = FormatType.JSON;
            ;
            ISignatureComposer signatureComposer;
            UnmarshallerContext context;

            var parameters = new Dictionary<string, string>
            {
                {"foo", "bar"},
                {"a", "A"},
                {"b", "B"}
            };

            // Override FormatType is not null, GetSignerType callback is null
            var hmacSHA1Signer = new HmacSHA1Signer();
            signatureComposer = RoaSignatureComposer.GetComposer();
            context = new UnmarshallerContext();
            context.ResponseDictionary =
                signatureComposer.RefreshSignParameters(parameters, hmacSHA1Signer, "accessKeyId", formatType);
            Assert.Equal("HMAC-SHA1", context.StringValue("x-acs-signature-method"));

            // Override FormatType is not null, GetSignerType callback is not null
            var SHA256withRSASigner = new SHA256withRSASigner();
            Assert.NotNull(SHA256withRSASigner.GetSignerType());
            signatureComposer = new RpcSignatureComposer();
            context.ResponseDictionary =
                signatureComposer.RefreshSignParameters(parameters, SHA256withRSASigner, "accessKeyId", null);
            Assert.Null(context.StringValue("x-acs-signature-method"));
        }
    }
}
