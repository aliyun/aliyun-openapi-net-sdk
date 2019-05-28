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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Feature.Test
{
    public class FeatureTestBase
    {
        private static readonly string AccessKeyId = "ACCESS_KEY_ID";
        private static readonly string AccessKeySecret = "ACCESS_KEY_SECRET";
        private static readonly string roleArn = "RAM";

        private static readonly string bearerToken = "BEARERTOKEN";
        public static DefaultAcsClient client;

        public IClientProfile profile;
        public string regionId = "cn-shanghai";

        public FeatureTestBase()
        {
            profile = DefaultProfile.GetProfile(regionId, GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            client = new DefaultAcsClient(profile);
            client.SetConnectTimeoutInMilliSeconds(2 * 60 * 1000);
            client.SetReadTimeoutInMilliSeconds(2 * 60 * 1000);
        }

        public static string GetBasicAccessKeyId()
        {
            return Environment.GetEnvironmentVariable(AccessKeyId) ?? "FakeAccessKeyId";
        }

        public static string GetBasicAccessKeySecret()
        {
            return Environment.GetEnvironmentVariable(AccessKeySecret) ?? "FakeAccessKeySecret";
        }

        public static string GetRoleArn()
        {
            return Environment.GetEnvironmentVariable(roleArn) ?? "FakeRoleArn";
        }

        public static string GetBearerToken()
        {
            return Environment.GetEnvironmentVariable(bearerToken) ?? "FakeBearerToken";
        }

        public string GetToken()
        {
            var profile = DefaultProfile.GetProfile(regionId, GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            IAcsClient client = new DefaultAcsClient(profile);

            var assumeRoleRequest = new AssumeRoleRequest();
            assumeRoleRequest.RoleArn = GetRoleArn();
            assumeRoleRequest.RoleSessionName = "robert_test";

            var assumeRoleResponse = client.GetAcsResponse(assumeRoleRequest);

            return assumeRoleResponse.Credentials.SecurityToken;
        }
    }
}
