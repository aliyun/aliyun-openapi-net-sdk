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

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Sts
{
    public class GetSessionAccessKeyResponseUnmarshallerTest
    {
        [Fact]
        public void GetSessionAccessKeyResponseUnmarshallTest()
        {
            var unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                {
                    {"GetSessionAccessKey.RequestId", "RequestId"},
                    {"GetSessionAccessKey.SessionAccessKey.SessionAccessKeyId", "SessionAccessKeyId"},
                    {"GetSessionAccessKey.SessionAccessKey.SessionAccessKeySecret", "SessionAccessKeySecret"},
                    {"GetSessionAccessKey.SessionAccessKey.Expiration", "100"}
                };
            }

            var response = GetSessionAccessKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
            Assert.Equal("RequestId", response.RequestId);
            Assert.Equal("SessionAccessKeyId", response.SessionAccesskey.SessionAccessKeyId);
            Assert.Equal("SessionAccessKeySecret", response.SessionAccesskey.SessionAccessKeySecert);
            Assert.Equal("100", response.SessionAccesskey.Expiration);
        }
    }
}
