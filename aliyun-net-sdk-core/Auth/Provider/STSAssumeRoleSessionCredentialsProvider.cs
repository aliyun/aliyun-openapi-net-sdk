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
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    /// <summary>
    ///     STSAssumeRoleSessionCredentialsProvider provides RamRoleArnCredential
    /// </summary>
    public class STSAssumeRoleSessionCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private readonly string policy;

        /// <summary>
        /// The arn of the role to be assumed.
        /// </summary>
        private readonly string roleArn;

        private BasicSessionCredentials credentials;

        /// <summary>
        /// Default duration for started sessions. Unit of Second
        /// </summary>
        private long roleSessionDurationSeconds = 3600;

        private string roleSessionName;
        private string externalId;

        /// <summary>
        /// Unit of millisecond
        /// </summary>
        private int connectTimeout = 5000;

        private int readTimeout = 10000;

        /// <summary>
        /// Endpoint of RAM OpenAPI
        /// </summary>
        private readonly string stsEndpoint;

        private IAcsClient stsClient;

        public STSAssumeRoleSessionCredentialsProvider(
            AlibabaCloudCredentials longLivedCredentials,
            string roleArn,
            IClientProfile clientProfile)
        {
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider =
                new StaticCredentialsProvider(longLivedCredentials);
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = new DefaultAcsClient(clientProfile, longLivedCredentialsProvider);
        }

        public STSAssumeRoleSessionCredentialsProvider(
            AlibabaCloudCredentials longLivedCredentials,
            string roleArn,
            IAcsClient client)
        {
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider =
                new StaticCredentialsProvider(longLivedCredentials);
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = client;
        }

        public STSAssumeRoleSessionCredentialsProvider(
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider,
            string roleArn,
            IClientProfile clientProfile)
        {
            this.roleArn = roleArn;
            roleSessionName = GetNewRoleSessionName();
            stsClient = new DefaultAcsClient(clientProfile, longLivedCredentialsProvider);
        }

        public STSAssumeRoleSessionCredentialsProvider(
            AlibabaCloudCredentials longLivedCredentials,
            string roleArn,
            string policy,
            IClientProfile profile
        )
        {
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider =
                new StaticCredentialsProvider(longLivedCredentials);
            this.roleArn = roleArn;
            this.policy = policy;
            roleSessionName = GetNewRoleSessionName();
            stsClient = new DefaultAcsClient(profile, longLivedCredentialsProvider);
        }

        public STSAssumeRoleSessionCredentialsProvider(
            string roleArn,
            string policy,
            IAcsClient client
        )
        {
            this.roleArn = roleArn;
            this.policy = policy;
            roleSessionName = GetNewRoleSessionName();
            stsClient = client;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (credentials == null || credentials.WillSoonExpire())
            {
                credentials = GetNewSessionCredentials();
            }

            return credentials;
        }

        public void WithRoleSessionName(string roleSessionName)
        {
            this.roleSessionName = roleSessionName;
        }

        public void WithRoleSessionDurationSeconds(long roleSessionDurationSeconds)
        {
            if (roleSessionDurationSeconds < 180 || roleSessionDurationSeconds > 3600)
            {
                throw new ArgumentOutOfRangeException(
                    "Assume Role session duration should be in the range of 3min - 1Hr");
            }

            this.roleSessionDurationSeconds = roleSessionDurationSeconds;
        }

        public void WithSTSClient(IAcsClient client)
        {
            stsClient = client;
        }

        /// <summary>
        /// An identifier for the assumed role session.
        /// </summary>
        public static string GetNewRoleSessionName()
        {
            return "aliyun-net-sdk-" + DateTime.UtcNow.currentTimeMillis();
        }

        private BasicSessionCredentials GetNewSessionCredentials()
        {
            var assumeRoleRequest = new AssumeRoleRequest
            {
                RoleArn = roleArn, RoleSessionName = roleSessionName, DurationSeconds = roleSessionDurationSeconds
            };

            if (!string.IsNullOrEmpty(this.stsEndpoint))
            {
                assumeRoleRequest.SetEndpoint(this.stsEndpoint);
            }
            if (!string.IsNullOrEmpty(policy))
            {
                assumeRoleRequest.Policy = policy;
            }

            if (null != this.externalId)
            {
                assumeRoleRequest.ExternalId = this.externalId;
            }

            var response = stsClient.GetAcsResponse(assumeRoleRequest);
            return new BasicSessionCredentials(
                response.Credentials.AccessKeyId,
                response.Credentials.AccessKeySecret,
                response.Credentials.SecurityToken,
                roleSessionDurationSeconds
            );
        }

        private STSAssumeRoleSessionCredentialsProvider(Builder builder)
        {
            this.roleSessionName = builder.roleSessionName ??
                                   (!string.IsNullOrEmpty(AuthUtils.EnvironmentRoleSessionName)
                                       ? AuthUtils.EnvironmentRoleSessionName
                                       : GetNewRoleSessionName());
            this.roleSessionDurationSeconds = (builder.durationSeconds == null || builder.durationSeconds == 0)
                ? 3600
                : builder.durationSeconds.Value;
            if (this.roleSessionDurationSeconds < 900)
            {
                throw new ClientException("Session duration should be in the range of 900s - max session duration");
            }

            this.roleArn = string.IsNullOrEmpty(builder.roleArn) ? AuthUtils.EnvironmentRoleArn : builder.roleArn;
            if (string.IsNullOrEmpty(this.roleArn))
            {
                throw new ArgumentException("RoleArn or environment variable ALIBABA_CLOUD_ROLE_ARN cannot be empty.");
            }

            this.policy = builder.policy;
            this.externalId = builder.externalId;
            this.connectTimeout = (builder.connectTimeout == null || builder.connectTimeout <= 0)
                ? 5000
                : builder.connectTimeout.Value;
            this.readTimeout = (builder.readTimeout == null || builder.readTimeout <= 0)
                ? 10000
                : builder.readTimeout.Value;

            var prefix = builder.enableVpc == null
                ? (AuthUtils.EnableVpcEndpoint ? "sts-vpc" : "sts")
                : (builder.enableVpc == true ? "sts-vpc" : "sts");
            if (!string.IsNullOrEmpty(builder.stsRegionId))
            {
                this.stsEndpoint =  string.Format("{0}.{1}.aliyuncs.com", prefix, builder.stsRegionId);
            }
            if (!string.IsNullOrEmpty(AuthUtils.EnvironmentSTSRegion))
            {
                this.stsEndpoint =  string.Format("{0}.{1}.aliyuncs.com", prefix, AuthUtils.EnvironmentSTSRegion);
            }
            this.stsEndpoint =  "sts.aliyuncs.com";

            var profile = DefaultProfile.GetProfile(builder.stsRegionId);
            if (null != builder.credentialsProvider)
            {
                this.stsClient = new DefaultAcsClient(profile, builder.credentialsProvider);
            } else if (!string.IsNullOrEmpty(builder.securityToken))
            {
                var credentialsProvider = new StaticCredentialsProvider(
                    new BasicSessionCredentials(builder.accessKeyId, builder.accessKeySecret, builder.securityToken));
                this.stsClient = new DefaultAcsClient(profile, credentialsProvider);
            }
            else
            {
                var credentialsProvider = new StaticCredentialsProvider(
                    new BasicCredentials(builder.accessKeyId, builder.accessKeySecret));
                this.stsClient = new DefaultAcsClient(profile, credentialsProvider);
            }
        }

        public class Builder
        {
            internal int? durationSeconds;
            internal string roleSessionName;
            internal string roleArn;
            internal string policy;
            internal int? connectTimeout;
            internal int? readTimeout;
            internal AlibabaCloudCredentialsProvider credentialsProvider;
            internal string externalId;
            internal string stsRegionId;
            internal bool? enableVpc;
            internal string accessKeyId;
            internal string accessKeySecret;
            internal string securityToken;

            public Builder DurationSeconds(int? durationSeconds)
            {
                this.durationSeconds = durationSeconds;
                return this;
            }

            public Builder RoleSessionName(string roleSessionName)
            {
                this.roleSessionName = roleSessionName;
                return this;
            }

            public Builder RoleArn(string roleArn)
            {
                this.roleArn = roleArn;
                return this;
            }

            public Builder Policy(string policy)
            {
                this.policy = policy;
                return this;
            }

            public Builder ConnectTimeout(int? connectTimeout)
            {
                this.connectTimeout = connectTimeout;
                return this;
            }

            public Builder ReadTimeout(int? readTimeout)
            {
                this.readTimeout = readTimeout;
                return this;
            }

            public Builder CredentialsProvider(AlibabaCloudCredentialsProvider credentialsProvider)
            {
                this.credentialsProvider = credentialsProvider;
                return this;
            }

            public Builder ExternalId(string externalId)
            {
                this.externalId = externalId;
                return this;
            }

            public Builder StsRegionId(string stsRegionId)
            {
                this.stsRegionId = stsRegionId;
                return this;
            }

            public Builder EnableVpc(bool? enableVpc)
            {
                this.enableVpc = enableVpc;
                return this;
            }

            public Builder AccessKeyId(string accessKeyId)
            {
                this.accessKeyId = accessKeyId;
                return this;
            }

            public Builder AccessKeySecret(string accessKeySecret)
            {
                this.accessKeySecret = accessKeySecret;
                return this;
            }

            public Builder SecurityToken(string securityToken)
            {
                this.securityToken = securityToken;
                return this;
            }

            public STSAssumeRoleSessionCredentialsProvider Build()
            {
                return new STSAssumeRoleSessionCredentialsProvider(this);
            }
        }
    }
}
