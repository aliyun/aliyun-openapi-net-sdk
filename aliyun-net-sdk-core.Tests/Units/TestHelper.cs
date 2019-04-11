using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class TestHelper
    {
        private static readonly string slash = EnvironmentUtil.GetOSSlash();
        private static readonly string homePath = EnvironmentUtil.GetHomePath();
        private static ReaderWriterLockSlim cacheLock = new ReaderWriterLockSlim();

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

            File.Delete(filePath);
            using(FileStream fs = File.Create(filePath)) { }
        }

        public static string GetIniFilePath()
        {
            return Directory.GetCurrentDirectory() + slash + "credentials.ini";
        }

        public static void DeleteIniFile()
        {
            cacheLock.EnterWriteLock();
            try
            {
                var path = homePath + slash + ".alibabacloud" + slash + "credentials.ini";
                File.Delete(path);
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }

        private static void CreateDefaultIniFile(string sectionName, ConcurrentDictionary<string, string> keyValue)
        {
            cacheLock.EnterWriteLock();
            try
            {
                CreateAndSetCurrentDirecotry();
                IniReader iniReader = new IniReader(GetIniFilePath());
                iniReader.SaveSettings(GetIniFilePath(), sectionName, keyValue);
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }

        private static ConcurrentDictionary<TKey, TValue> TransferDicToConcurrentDic<TKey, TValue>(Dictionary<TKey, TValue> dic)
        {
            return new ConcurrentDictionary<TKey, TValue>(dic);
        }

        public static void CreateIniFileWithAk()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            var concurrentDic = new ConcurrentDictionary<string, string>(keyValueDic);

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkNotDefault()
        {
            var sectionName = "notDefault";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkType()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithAkTypeWithEmptyAK()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithEcs()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithRam()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithRsaKey()
        {
            var sectionName = "default";
            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }

        public static void CreateIniFileWithDefaultSection()
        {
            var sectionName = "default";

            var keyValueDic = TransferDicToConcurrentDic(new Dictionary<string, string>
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
            });

            CreateDefaultIniFile(sectionName, keyValueDic);
        }
    }
}
