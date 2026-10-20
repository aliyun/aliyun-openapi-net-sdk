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
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Profile;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class SignatureV2Test
    {
        [Fact]
        public void Sha256SignerAndDefaultCredentials()
        {
            var signer = new HmacSHA256Signer();
            Assert.Equal("HMAC-SHA256", signer.GetSignerName());
            Assert.Equal("1.0", signer.GetSignerVersion());
            Assert.Null(signer.GetSignerType());
            var credentials = new BasicCredentials("test-id", "test-secret");
            Assert.True(Hash("测试 +/~", "test-secret", false) == signer.SignString("测试 +/~", credentials));
            Assert.True(Hash("测试 +/~", "test-secret", false) == signer.SignString("测试 +/~", "test-secret"));
            Assert.IsType<HmacSHA256Signer>(Signer.GetSigner(credentials));
            Assert.IsType<HmacSHA256Signer>(Signer.GetSigner(new BasicSessionCredentials("test-id", "test-secret", "test-token")));
            Assert.IsType<HmacSHA256Signer>(Signer.GetSigner(new LegacyCredentials(new Credential("test-id", "test-secret"))));
        }

        [Theory]
        [InlineData(false, false, MethodType.GET)]
        [InlineData(false, false, MethodType.POST)]
        [InlineData(true, false, MethodType.GET)]
        [InlineData(true, false, MethodType.POST)]
        [InlineData(false, true, MethodType.GET)]
        [InlineData(false, true, MethodType.POST)]
        [InlineData(true, true, MethodType.GET)]
        [InlineData(true, true, MethodType.POST)]
        public void RpcFinalRequestUsesSelectedAlgorithm(bool session, bool sha1, MethodType method)
        {
            var credentials = Credentials(session);
            var signer = sha1 ? (Signer)new HmacSHA1Signer() : Signer.GetSigner(credentials);
            var request = new MockRpcAcsRequest("Ecs", "2014-05-26", "DescribeRegions")
            {
                Method = method,
                RegionId = "cn-hangzhou"
            };
            request.QueryParameters.Add("Special", "中文 +/~&=");
            if (method == MethodType.POST)
            {
                request.BodyParameters.Add("FormValue", "表单 +&/");
            }

            var signed = request.SignRequest(signer, credentials, FormatType.JSON, new ProductDomain("Ecs", "example.invalid"));
            var parameters = Parse(new Uri(signed.Url).Query.TrimStart('?'));
            var signature = parameters["Signature"];
            parameters.Remove("Signature");
            Assert.Equal(sha1 ? "HMAC-SHA1" : "HMAC-SHA256", parameters["SignatureMethod"]);
            Assert.Equal("1.0", parameters["SignatureVersion"]);
            Assert.Equal("test-id", parameters["AccessKeyId"]);
            Assert.Equal(session, parameters.ContainsKey("SecurityToken"));
            if (session)
            {
                Assert.Equal("test-token +/=&", parameters["SecurityToken"]);
            }
            Assert.True(parameters.ContainsKey("SignatureNonce"));
            Assert.True(parameters.ContainsKey("Timestamp"));
            if (signed.Content != null)
            {
                foreach (var parameter in Parse(Encoding.UTF8.GetString(signed.Content)))
                {
                    parameters.Add(parameter.Key, parameter.Value);
                }
            }
            var canonical = string.Join("&", parameters.OrderBy(p => p.Key, StringComparer.Ordinal)
                .Select(p => Uri.EscapeDataString(p.Key) + "=" + Uri.EscapeDataString(p.Value)));
            var stringToSign = method + "&%2F&" + Uri.EscapeDataString(canonical);
            Assert.Equal(stringToSign, request.StringToSign);
            Assert.True(Hash(stringToSign, "test-secret&", sha1) == signature);
        }

        [Theory]
        [InlineData(false, false, MethodType.GET)]
        [InlineData(false, false, MethodType.POST)]
        [InlineData(true, false, MethodType.GET)]
        [InlineData(true, false, MethodType.POST)]
        [InlineData(false, true, MethodType.GET)]
        [InlineData(false, true, MethodType.POST)]
        [InlineData(true, true, MethodType.GET)]
        [InlineData(true, true, MethodType.POST)]
        public void RoaFinalRequestUsesSelectedAlgorithm(bool session, bool sha1, MethodType method)
        {
            var credentials = Credentials(session);
            var signer = sha1 ? (Signer)new HmacSHA1Signer() : Signer.GetSigner(credentials);
            var request = new MockRoaAcsRequest("Cs", "2015-12-15", "DescribeClusters")
            {
                Method = method,
                UriPattern = "/clusters/[id]"
            };
            request.AddPathParameters("id", "test-cluster");
            request.QueryParameters.Add("b", "two");
            request.QueryParameters.Add("a", "one");
            if (method == MethodType.POST)
            {
                request.SetContent(Encoding.UTF8.GetBytes("{\"name\":\"测试\"}"), "UTF-8", FormatType.JSON);
            }
            var signed = request.SignRequest(signer, credentials, FormatType.JSON, new ProductDomain("Cs", "example.invalid"));
            var headers = signed.Headers;
            Assert.Equal(sha1 ? "HMAC-SHA1" : "HMAC-SHA256", headers["x-acs-signature-method"]);
            Assert.Equal("1.0", headers["x-acs-signature-version"]);
            Assert.Equal(session, headers.ContainsKey("x-acs-security-token"));
            if (session)
            {
                Assert.Equal("test-token +/=&", headers["x-acs-security-token"]);
            }
            var md5 = "";
            var contentType = "";
            if (method == MethodType.POST)
            {
                using (var hash = MD5.Create())
                {
                    md5 = Convert.ToBase64String(hash.ComputeHash(signed.Content));
                }
                Assert.Equal(md5, headers["Content-MD5"]);
                contentType = headers["Content-Type"];
            }
            var canonicalHeaders = string.Concat(headers.Where(h => h.Key.StartsWith("x-acs-", StringComparison.OrdinalIgnoreCase))
                .OrderBy(h => h.Key.ToLowerInvariant(), StringComparer.Ordinal)
                .Select(h => h.Key.ToLowerInvariant() + ":" + h.Value + "\n"));
            var stringToSign = method + "\napplication/json\n" + md5 + "\n" + contentType + "\n" + headers["Date"] + "\n" +
                canonicalHeaders + "/clusters/test-cluster?a=one&b=two";
            Assert.True("acs test-id:" + Hash(stringToSign, "test-secret", sha1) == headers["Authorization"]);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClientDefaultAndExplicitSha1ReachTheTransport(bool session)
        {
            var credentials = Credentials(session);
            var profile = DefaultProfile.GetProfile("cn-hangzhou", "test-id", "test-secret");
            var client = new CapturingClient(profile, credentials);
            var request = new MockRpcAcsRequest("Ecs", "2014-05-26", "DescribeRegions")
            {
                ProductDomain = new ProductDomain("Ecs", "example.invalid")
            };
            client.DoAction(request);
            Assert.Equal("HMAC-SHA256", Parse(new Uri(client.Sent.Url).Query.TrimStart('?'))["SignatureMethod"]);
            var legacy = new MockRpcAcsRequest("Ecs", "2014-05-26", "DescribeRegions")
            {
                ProductDomain = request.ProductDomain
            };
            client.DoAction(legacy, false, 0, "cn-hangzhou", credentials, new HmacSHA1Signer(), FormatType.JSON, null);
            Assert.Equal("HMAC-SHA1", Parse(new Uri(client.Sent.Url).Query.TrimStart('?'))["SignatureMethod"]);
            var roa = new MockRoaAcsRequest("Cs", "2015-12-15", "DescribeClusters")
            {
                ProductDomain = new ProductDomain("Cs", "example.invalid"),
                UriPattern = "/clusters"
            };
            client.DoAction(roa);
            Assert.Equal("HMAC-SHA256", client.Sent.Headers["x-acs-signature-method"]);
        }

        private class CapturingClient : DefaultAcsClient
        {
            internal HttpRequest Sent;

            internal CapturingClient(IClientProfile profile, AlibabaCloudCredentials credentials) : base(profile, credentials)
            {
            }

            public override HttpResponse GetResponse(HttpRequest request)
            {
                Sent = request;
                return new HttpResponse { Status = 200, Headers = new Dictionary<string, string>() };
            }
        }

        private static AlibabaCloudCredentials Credentials(bool session)
        {
            return session
                ? (AlibabaCloudCredentials)new BasicSessionCredentials("test-id", "test-secret", "test-token +/=&")
                : new BasicCredentials("test-id", "test-secret");
        }

        private static Dictionary<string, string> Parse(string query)
        {
            return query.Split('&').Select(p => p.Split(new[] { '=' }, 2)).ToDictionary(
                p => Uri.UnescapeDataString(p[0].Replace("+", " ")),
                p => Uri.UnescapeDataString(p[1].Replace("+", " ")));
        }

        private static string Hash(string text, string secret, bool sha1)
        {
            using (var hmac = sha1 ? (HMAC)new HMACSHA1(Encoding.UTF8.GetBytes(secret)) : new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                return Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(text)));
            }
        }
    }
}
