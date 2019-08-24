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
    internal class FeatureTest
    {
        internal string accessKeyId = "";
        internal string accessKeySecret = "";
        internal string roleArn = "";
        internal string bearerToken = "";
        internal string regionId = "cn-shanghai";

        FeatureTest()
        {
            accessKeyId = Environment.GetEnvironmentVariable("ACCESS_KEY_ID") ?? "FakeAccessKeyId";
            accessKeySecret = Environment.GetEnvironmentVariable("ACCESS_KEY_SECRET") ?? "FakeAccessKeySecret";
            roleArn = Environment.GetEnvironmentVariable("RAM") ?? "FakeRoleArn";
            bearerToken = Environment.GetEnvironmentVariable("BEARERTOKEN") ?? "FakeBearerToken";
        }

        static FeatureTest featureTest = new FeatureTest();

        static IClientProfile profile = DefaultProfile.GetProfile(
            RegionId,
            BasicAccessKeyId,
            BasicAccessKeySecret
        );

        public static DefaultAcsClient DefaultClient
        {
            get
            {
                DefaultAcsClient client = new DefaultAcsClient(profile);
                client.SetConnectTimeoutInMilliSeconds(2 * 60 * 1000);
                client.SetReadTimeoutInMilliSeconds(2 * 60 * 1000);
                return client;
            }
        }

        public static string BasicAccessKeyId
        {
            get
            {
                return featureTest.accessKeyId;
            }
        }

        public static string BasicAccessKeySecret
        {
            get
            {
                return featureTest.accessKeySecret;
            }
        }

        public static string RoleArn
        {
            get
            {
                return featureTest.roleArn;
            }
        }

        public static string BearerToken
        {
            get
            {
                return featureTest.bearerToken;
            }
        }

        public static string RegionId
        {
            get
            {
                return featureTest.regionId;
            }
        }

        public static string GetToken()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            assumeRoleRequest.RoleArn = RoleArn;
            assumeRoleRequest.RoleSessionName = "robert_test";

            var assumeRoleResponse = DefaultClient.GetAcsResponse(assumeRoleRequest);

            return assumeRoleResponse.Credentials.SecurityToken;
        }
    }
}
