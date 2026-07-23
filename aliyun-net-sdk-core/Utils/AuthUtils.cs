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
using System.Text;
using System.IO;
using System.Security;
using Aliyun.Acs.Core.Exceptions;

namespace Aliyun.Acs.Core.Utils
{
    public class AuthUtils
    {
        private static volatile string oidcToken;
        private static volatile string clientType = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_PROFILE");
        private static volatile string disableECSIMDSv1;
        private static volatile string disableECSMetaData;
        private static volatile string environmentEcsMetaDataDisabled;
        private static volatile string environmentCLIProfileDisabled;
        private static volatile string environmentRoleSessionName;
        private static volatile string environmentRoleArn;
        private static volatile string enableVpcEndpoint;
        private static volatile string environmentSTSRegion;
        private static volatile string environmentOIDCProviderArn;
        private static volatile string environmentOIDCTokenFilePath;
        private static volatile string environmentCredentialsURI;

        AuthUtils()
        {
        }
        
        public static string EnvironmentCredentialsURI
        {
            get
            {
                return AuthUtils.environmentCredentialsURI ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_URI");
            }
            
            set { AuthUtils.environmentCredentialsURI = value; }
        }

        
        public static string EnvironmentOIDCTokenFilePath
        {
            get
            {
                return AuthUtils.environmentOIDCTokenFilePath ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_OIDC_TOKEN_FILE");
            }
            
            set { AuthUtils.environmentOIDCTokenFilePath = value; }
        }

        
        public static string EnvironmentOIDCProviderArn
        {
            get
            {
                return AuthUtils.environmentOIDCProviderArn ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_OIDC_PROVIDER_ARN");
            }
            
            set { AuthUtils.environmentOIDCProviderArn = value; }
        }
        
        public static string EnvironmentSTSRegion
        {
            get
            {
                return AuthUtils.environmentSTSRegion ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_STS_REGION");
            }
            
            set { AuthUtils.environmentSTSRegion = value; }
        }
        
        public static bool EnableVpcEndpoint
        {
            get
            {
                if (!string.IsNullOrEmpty(AuthUtils.enableVpcEndpoint))
                {
                    return bool.Parse(AuthUtils.enableVpcEndpoint);
                }

                var env = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_VPC_ENDPOINT_ENABLED");
                return !string.IsNullOrEmpty(env) && bool.Parse(env);
            }

            set { AuthUtils.environmentCLIProfileDisabled = value.ToString(); }
        }

        public static string EnvironmentRoleArn
        {
            get
            {
                return AuthUtils.environmentRoleArn ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_ROLE_ARN");
            }
            
            set { AuthUtils.environmentRoleArn = value; }
        }
        
        public static string EnvironmentRoleSessionName
        {
            get
            {
                return AuthUtils.environmentRoleSessionName ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_ROLE_SESSION_NAME");
            }
            
            set { AuthUtils.environmentRoleSessionName = value; }
        }
        
        public static bool EnvironmentDisableCLIProfile
        {
            get
            {
                if (!string.IsNullOrEmpty(AuthUtils.environmentCLIProfileDisabled))
                {
                    return bool.Parse(AuthUtils.environmentCLIProfileDisabled);
                }

                var env = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_IMDSV1_DISABLED");
                return !string.IsNullOrEmpty(env) && bool.Parse(env);
            }

            set { AuthUtils.environmentCLIProfileDisabled = value.ToString(); }
        }

        public static string EnvironmentEcsMetaDataDisabled
        {
            get
            {
                return AuthUtils.environmentEcsMetaDataDisabled ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_ECS_METADATA");
            }

            set { AuthUtils.environmentEcsMetaDataDisabled = value; }
        }

        public static bool DisableECSMetaData
        {
            get
            {
                if (!string.IsNullOrEmpty(AuthUtils.disableECSMetaData))
                {
                    return bool.Parse(AuthUtils.disableECSMetaData);
                }
                var env = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_ECS_METADATA_DISABLED");
                return !string.IsNullOrEmpty(env) && bool.Parse(env);
            }

            set { AuthUtils.disableECSMetaData = value.ToString(); }
        }

        public static bool DisableECSIMDSv1
        {
            get
            {
                if (!string.IsNullOrEmpty(AuthUtils.disableECSIMDSv1))
                {
                    return bool.Parse(AuthUtils.disableECSIMDSv1);
                }

                var env = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_IMDSV1_DISABLED");
                return !string.IsNullOrEmpty(env) && bool.Parse(env);
            }

            set { AuthUtils.disableECSIMDSv1 = value.ToString(); }
        }

        public static string GetClientType()
        {
            if (clientType == null)
            {
                AuthUtils.clientType = "default";
            }

            return AuthUtils.clientType;
        }


        public static string GetOIDCToken(string OIDCTokenFilePath)
        {
            byte[] buffer;
            if (!File.Exists(OIDCTokenFilePath))
            {
                throw new ClientException("OIDCTokenFilePath " + OIDCTokenFilePath + " does not exist.");
            }

            try
            {
                using (var inStream = new FileStream(OIDCTokenFilePath, FileMode.Open, FileAccess.Read))
                {
                    buffer = new byte[inStream.Length];
                    inStream.Read(buffer, 0, buffer.Length);
                }

                oidcToken = Encoding.UTF8.GetString(buffer);
            }
            catch (UnauthorizedAccessException)
            {
                throw new ClientException("OIDCTokenFilePath " + OIDCTokenFilePath + " cannot be read.");
            }
            catch (SecurityException)
            {
                throw new ClientException("Security Exception: Do not have the required permission. " +
                                          "OIDCTokenFilePath " + OIDCTokenFilePath);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return oidcToken;
        }
        
        public static string GetStsRegionWithVpc(string stsRegionId, bool? enableVpc)
        {
            var prefix = enableVpc == null
                ? (AuthUtils.EnableVpcEndpoint ? "sts-vpc" : "sts")
                : (enableVpc == true ? "sts-vpc" : "sts");
            if (!string.IsNullOrEmpty(stsRegionId))
            {
                return string.Format("https://{0}.{1}.aliyuncs.com", prefix, stsRegionId);
            }
            if (!string.IsNullOrEmpty(AuthUtils.EnvironmentSTSRegion))
            {
                return string.Format("https://{0}.{1}.aliyuncs.com", prefix, AuthUtils.EnvironmentSTSRegion);
            }
            return "https://sts.aliyuncs.com";
        }
    }
}
