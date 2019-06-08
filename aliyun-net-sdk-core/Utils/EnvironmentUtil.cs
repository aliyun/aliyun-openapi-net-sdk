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

namespace Aliyun.Acs.Core.Utils
{
    public class EnvironmentUtil
    {
        private static readonly string ENV_ACCESS_KEY_ID = "ALIBABA_CLOUD_ACCESS_KEY_ID";
        private static readonly string ENV_ACCESS_KEY_SECRET = "ALIBABA_CLOUD_ACCESS_KEY_SECRET";
        private static readonly string ENV_REGION_ID = "ALIBABA_CLOUD_REGION_ID";
        private static readonly string ENV_CREDENTIAL_FILE = "ALIBABA_CLOUD_CREDENTIALS_FILE";
        private static readonly string ENV_ROLE_NAME = "ALIBABA_CLOUD_ECS_METADATA";

        public static string GetHomePath()
        {
            return Environment.OSVersion.Platform == PlatformID.Unix
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        }

        public static string GetOSSlash()
        {
            return Environment.OSVersion.Platform == PlatformID.Unix
                ? "/"
                : "\\";
        }

        public static string GetEnvironmentAccessKeyId()
        {
            return Environment.GetEnvironmentVariable(ENV_ACCESS_KEY_ID) ?? null;
        }

        public static string GetEnvironmentAccessKeySecret()
        {
            return Environment.GetEnvironmentVariable(ENV_ACCESS_KEY_SECRET) ?? null;
        }

        public static string GetEnvironmentRegionId()
        {
            return Environment.GetEnvironmentVariable(ENV_REGION_ID) ?? null;
        }

        public static string GetEnvironmentCredentialFile()
        {
            return Environment.GetEnvironmentVariable(ENV_CREDENTIAL_FILE) ?? null;
        }

        public static string GetEnvironmentRoleName()
        {
            return Environment.GetEnvironmentVariable(ENV_ROLE_NAME) ?? null;
        }

        public static string GetComposedPath(string homePath, string slash)
        {
            return homePath + slash + ".alibabacloud" + slash + "credentials.ini";
        }
    }
}
