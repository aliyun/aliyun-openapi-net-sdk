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

using Aliyun.Acs.CCC.Model.V20170705;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    [Trait("Category", "FeatureTest")]
    public class BearerTokenTest
    {
        [Fact]
        public void BearerTokenAccessTest()
        {
            var provider = new BearerTokenCredentialProvider(FeatureTest.BearerToken);

            var profile = DefaultProfile.GetProfile("cn-hangzhou");
            var client = new DefaultAcsClient(profile, provider);

            var request = new ListPhoneNumbersRequest();

            var exception = Assert.Throws<ClientException>(() =>
            {
                var response = client.GetAcsResponse(request);
            });

            Assert.Equal("InvalidBearerToken.Inactive", exception.ErrorCode);
        }
    }
}
