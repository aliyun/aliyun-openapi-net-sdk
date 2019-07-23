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
using System.Collections.Generic;
using System.IO;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class TestHelper
    {
        private static readonly string slash = EnvironmentUtil.GetOSSlash();
        private static readonly string homePath = EnvironmentUtil.GetHomePath();

        public static void RemoveEnvironmentValue()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_ID", null);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_SECRET", null);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
        }

        public static void InitializeEnvironmentValue()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_ID", "ACCESS_KEY_ID");
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_SECRET", "ACCESS_KEY_SECRET");
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "cn-hangzhou");
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "cn-hangzhou");
        }

        private static void CreateAndSetCurrentDirecotry()
        {

            Directory.CreateDirectory(homePath + slash + ".alibabacloud" + slash);
            Directory.SetCurrentDirectory(homePath + slash + ".alibabacloud" + slash);

            var filePath = GetIniFilePath();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (File.Create(filePath)) { }
        }

        public static string GetIniFilePath()
        {
            return Directory.GetCurrentDirectory() + slash + "credentials.ini";
        }

        public static void DeleteIniFile()
        {
            File.Delete(homePath + slash + ".alibabacloud" + slash + "credentials.ini");
        }

        private static void CreateDefaultIniFile(string sectionName, IDictionary<string, string> keyValue)
        {
            CreateAndSetCurrentDirecotry();
            var iniReader = new IniReader(GetIniFilePath());
            iniReader.SaveSettings(GetIniFilePath(), sectionName, keyValue);
        }

        public static void CreateIniFileWithAk()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "access_key_id",
                    "foo"
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkNotDefault()
        {
            var sectionName = "notDefault";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "access_key_id",
                    "foo"
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkType()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "access_key_id",
                    "foo"
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                },
                {
                    "type",
                    "access_key"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkTypeWithEmptyAK()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "access_key_id",
                    ""
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                },
                {
                    "type",
                    "access_key"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithEcs()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "role_name",
                    "fake_role_name"
                },
                {
                    "type",
                    "ecs_ram_role"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithRam()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "access_key_id",
                    "foo"
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "role_arn",
                    "fake_role_arn"
                },
                {
                    "type",
                    "ram_role_arn"
                },
                {
                    "role_session_name",
                    "sessionname"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithBearerToken()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "bearer_token",
                    "fake_bearer_token"
                },
                {
                    "type",
                    "bearer_token"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithRsaKey()
        {
            var sectionName = "default";
            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "public_key_id",
                    "public_key_id"
                },
                {
                    "private_key_file",
                    "private_key_file"
                },
                {
                    "type",
                    "rsa_key_pair"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithDefaultSection()
        {
            var sectionName = "default";

            var keyValueDic = new Dictionary<string, string>
            {
                {
                    "enable",
                    "true"
                },
                {
                    "type",
                    "access_key"
                },
                {
                    "access_key_id",
                    "foo"
                },
                {
                    "access_key_secret",
                    "bar"
                },
                {
                    "region_id",
                    "cn-hangzhou"
                }
            };

            CreateDefaultIniFile(sectionName, keyValueDic);
        }
    }
}
