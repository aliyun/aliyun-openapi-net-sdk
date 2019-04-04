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

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    /// <summary>
    /// STSAssumeRoleSessionCredentialsProvider provides RamRoleArnCredential
    /// </summary>
    public class STSAssumeRoleSessionCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private long roleSessionDurationSeconds = 3600;
        private long assumeRoleRound = 0;

        private IAcsClient stsClient;
        private readonly string roleArn;
        private string roleSessionName;
        private BasicSessionCredentials credentials = null;

        public STSAssumeRoleSessionCredentialsProvider(AlibabaCloudCredentials longLivedCredentials,
            string roleArn, IClientProfile clientProfile)
        {
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider = new StaticCredentialsProvider(longLivedCredentials);
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = new DefaultAcsClient(clientProfile, longLivedCredentialsProvider);
        }

        public STSAssumeRoleSessionCredentialsProvider(AlibabaCloudCredentials longLivedCredentials, string roleArn, IAcsClient client)
        {
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider = new StaticCredentialsProvider(longLivedCredentials);
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = client;
        }

        public STSAssumeRoleSessionCredentialsProvider(AlibabaCloudCredentialsProvider longLivedCredentialsProvider,
            string roleArn, IClientProfile clientProfile)
        {
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = new DefaultAcsClient(clientProfile, longLivedCredentialsProvider);
        }

        public void WithRoleSessionName(string roleSessionName)
        {
            this.roleSessionName = roleSessionName;
        }

        public void WithRoleSessionDurationSeconds(long roleSessionDurationSeconds)
        {
            if (roleSessionDurationSeconds < 180 || roleSessionDurationSeconds > 3600)
            {
                throw new ArgumentOutOfRangeException("Assume Role session duration should be in the range of 3min - 1Hr");
            }
            this.roleSessionDurationSeconds = roleSessionDurationSeconds;
        }

        public void WithSTSClient(IAcsClient client)
        {
            stsClient = client;
        }

        public static string GetNewRoleSessionName()
        {
            return "aliyun-net-sdk-" + DateTimeExtensions.currentTimeMillis(DateTime.Now);
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (credentials == null || credentials.WillSoonExpire())
            {
                credentials = GetNewSessionCredentials();
            }
            return credentials;
        }

        private BasicSessionCredentials GetNewSessionCredentials()
        {
            assumeRoleRound += 1;

            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest
            {
                RoleArn = roleArn,
                RoleSessionName = roleSessionName,
                DurationSeconds = roleSessionDurationSeconds
            };
            AssumeRoleResponse response = stsClient.GetAcsResponse(assumeRoleRequest);
            return new BasicSessionCredentials(
                response.Credentials.AccessKeyId,
                response.Credentials.AccessKeySecret,
                response.Credentials.SecurityToken,
                roleSessionDurationSeconds
            );
        }
    }
}
