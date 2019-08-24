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
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    [Trait("Category", "FeatureTest")]
    public class CredentialsTest
    {
        [Fact]
        public void SdkManageTokenTest()
        {
            if (FeatureTest.RoleArn.Equals("FakeRoleArn"))
            {
                return;
            }

            var profile = DefaultProfile.GetProfile("cn-hangzhou", FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var basicCredential = new BasicCredentials(FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, FeatureTest.RoleArn, profile);

            var client = new DefaultAcsClient(profile, provider);

            var request = new DescribeAccessPointsRequest();
            var response = client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }

        [Fact]
        public void STSAssumeRoleCredentialWithPolicyTest()
        {
            if (FeatureTest.RoleArn.Equals("FakeRoleArn"))
            {
                return;
            }

            var profile = DefaultProfile.GetProfile("cn-shanghai", FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var basicCredential = new BasicCredentials(FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var policy =
                "{ \"Version\": \"1\",\"Statement\": [{\"Effect\": \"Deny\",\"Action\": \"vpc:Create*\",\"Resource\": \"acs:vpc:cn-hangzhou:*:*\"}]}";
            var provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, FeatureTest.RoleArn, policy, profile);

            var client = new DefaultAcsClient(profile, provider);
            var request = new CreateVpcRequest();

            var exception = Assert.Throws<ClientException>(() => { var response = client.GetAcsResponse(request); });

            Assert.Contains(
                "Forbidden.RAM : User not authorized to operate on the specified resource, or this API doesn't support RAM.",
                exception.Message);
        }
    }
}
