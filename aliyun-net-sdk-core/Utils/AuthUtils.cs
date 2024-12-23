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

        AuthUtils()
        {
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
    }
}
