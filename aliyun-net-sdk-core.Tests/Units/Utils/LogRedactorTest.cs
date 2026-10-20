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
using System.IO;
using System.Reflection;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    [CollectionDefinition("SDK diagnostic state", DisableParallelization = true)]
    public class DiagnosticStateCollection
    {
    }

    [Collection("SDK diagnostic state")]
    public class LogRedactorTest
    {
        [Theory]
        [InlineData("https://example.invalid/?Signature=synthetic%2Bsignature%3D&SecurityToken=synthetic%26token&Action=DescribeRegions")]
        [InlineData("Authorization: acs test-id:synthetic-signature\r\nx-acs-security-token: synthetic-token")]
        [InlineData("AccessKeySecret=synthetic-secret&SecurityToken=synthetic-token")]
        [InlineData("{\"Credentials\":{\"AccessKeySecret\":\"synthetic-secret\",\"SecurityToken\":\"synthetic-token\"}}")]
        [InlineData("<Credentials><AccessKeySecret>synthetic-secret</AccessKeySecret><SecurityToken>synthetic-token</SecurityToken></Credentials>")]
        [InlineData("MessageTokenDTO={\"AccessKeySecret\":\"synthetic-secret\",\"SecurityToken\":\"synthetic-token\"}")]
        [InlineData("string to sign is: SecurityToken%3Dsynthetic%252Btoken%26Signature%3Dsynthetic-signature%26Action%3DDescribeRegions")]
        [InlineData("SecurityToken%253Dsynthetic-token%2526Signature%253Dsynthetic-signature%2526Action%253DDescribeRegions")]
        [InlineData("%7B%22AccessKeySecret%22%3A%22synthetic-secret%22%7D")]
        [InlineData("https%3A%2F%2Fexample.invalid%2F%3FSignature%3Dsynthetic-signature%26SecurityToken%3Dsynthetic-token")]
        [InlineData("{\"SessionAccessKey\":{\"SessionAccessKeySecret\":\"synthetic-secret\"}}")]
        [InlineData("<SessionAccessKeySecret>synthetic-secret</SessionAccessKeySecret>")]
        [InlineData("SessionAccessKeySecret%3Dsynthetic-secret%26Action%3DGetSessionAccessKey")]
        [InlineData("{\"AccessKeySecret\":\"synthetic\\\"-secret\"}")]
        public void SensitiveValuesAreRemoved(string original)
        {
            var redacted = LogRedactor.Redact(original);
            Assert.DoesNotContain("synthetic", redacted);
            Assert.Contains("[REDACTED]", redacted);
        }

        [Fact]
        public void SafeDiagnosticsAndAlgorithmFieldsArePreserved()
        {
            const string text = "https://example.invalid/?SignatureMethod=HMAC-SHA256&SignatureVersion=1.0&SignatureNonce=nonce&Action=DescribeRegions";
            Assert.Equal(text, LogRedactor.Redact(text));
            Assert.Null(LogRedactor.Redact(null));
            Assert.Equal("", LogRedactor.Redact(""));
        }

        [Fact]
        public void ExceptionMessagesAreRedacted()
        {
            const string message = "https://example.invalid/?Signature=synthetic-signature&SecurityToken=synthetic-token";
            var exceptions = new ClientException[]
            {
                new ClientException(message),
                new ClientException("TestError", message),
                new ClientException("TestError", message, "request-id"),
                new ServerException("TestError", message, "request-id")
            };
            foreach (var exception in exceptions)
            {
                Assert.DoesNotContain("synthetic", exception.ErrorMessage);
                Assert.DoesNotContain("synthetic", exception.ToString());
            }
        }

        [Fact]
        public void DebugOutputDoesNotMutateTheRequestOrResponse()
        {
            var originalConsole = Console.Out;
            var originalDebug = Environment.GetEnvironmentVariable("DEBUG");
            var output = new StringWriter();
            var request = new HttpRequest("https://example.invalid/?Signature=synthetic-signature&SecurityToken=synthetic-token")
            {
                Method = MethodType.GET
            };
            request.Headers.Add("Authorization", "acs test-id:synthetic-signature&synthetic-suffix");
            var response = new HttpResponse
            {
                Headers = new Dictionary<string, string> { { "SecurityToken", "synthetic-response-token;synthetic-suffix" } }
            };
            try
            {
                Environment.SetEnvironmentVariable("DEBUG", "sdk");
                Console.SetOut(output);
                typeof(DefaultAcsClient).GetMethod("PrintHttpDebugMsg", BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(new DefaultAcsClient(), new object[] { request, response });
            }
            finally
            {
                Console.SetOut(originalConsole);
                Environment.SetEnvironmentVariable("DEBUG", originalDebug);
            }
            Assert.DoesNotContain("synthetic", output.ToString());
            Assert.Contains("[REDACTED]", output.ToString());
            Assert.Contains("synthetic-signature", request.Url);
            Assert.Equal("acs test-id:synthetic-signature&synthetic-suffix", request.Headers["Authorization"]);
            Assert.Equal("synthetic-response-token;synthetic-suffix", response.Headers["SecurityToken"]);
        }
    }
}
