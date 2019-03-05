using System;
using System.IO;

using SharpConfig;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class TestHelper
    {
        private static Configuration iniConfiguration;

        private static readonly string slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
        public static void RemoveEnvironmentValue()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_ID", null);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_SECRET", null);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
        }

        public static void InitializeEnvironmentValue()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_ID", Environment.GetEnvironmentVariable("ACCESS_KEY_ID"));
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ACCESS_KEY_SECRET", Environment.GetEnvironmentVariable("ACCESS_KEY_SECRET"));
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "cn-hangzhou");
        }

        private static void CreateAndSetCurrentDirecotry(string homePath)
        {
            Directory.CreateDirectory(homePath + slash + ".alibabacloud" + slash);
            Directory.SetCurrentDirectory(homePath + slash + ".alibabacloud" + slash);
        }

        public static void DeleteIniFile(string homePath)
        {
            System.IO.File.Delete(homePath + slash + ".alibabacloud" + slash + "credentials.ini");
        }

        private static void CreateDefaultIniFile(string homePath, out Configuration config)
        {
            CreateAndSetCurrentDirecotry(homePath);
            var cfgStr =
                "[default]" + Environment.NewLine +
                "Setting = Value";

            config = Configuration.LoadFromString(cfgStr);
        }

        public static void CreateIniFileWithAk(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["access_key_id"].RawValue = "foo";
            iniConfiguration["default"]["access_key_secret"].RawValue = "bar";
            iniConfiguration["default"]["region_id"].RawValue = "cn-hangzhou";

            iniConfiguration.SaveToFile("credentials.ini");
        }

        public static void CreateIniFileWithAkType(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["access_key_id"].RawValue = "foo";
            iniConfiguration["default"]["access_key_secret"].RawValue = "bar";
            iniConfiguration["default"]["region_id"].RawValue = "cn-hangzhou";
            iniConfiguration["default"]["type"].RawValue = "access_key";

            iniConfiguration.SaveToFile("credentials.ini");
        }

        public static void CreateIniFileWithEcs(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["role_name"].RawValue = "fake_role_name";
            iniConfiguration["default"]["type"].RawValue = "ecs_ram_role";

            iniConfiguration.SaveToFile("credentials.ini");
        }

        public static void CreateIniFileWithRam(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["access_key_id"].RawValue = "foo";
            iniConfiguration["default"]["access_key_secret"].RawValue = "bar";
            iniConfiguration["default"]["role_arn"].RawValue = "fake_role_arn";
            iniConfiguration["default"]["type"].RawValue = "ram_role_arn";
            iniConfiguration["default"]["role_session_name"].RawValue = "sessionname";

            iniConfiguration.SaveToFile("credentials.ini");
        }

        public static void CreateIniFileWithBearerToken(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["bearer_token"].RawValue = "fake_bearer_token";
            iniConfiguration["default"]["type"].RawValue = "bearer_token";

            iniConfiguration.SaveToFile("credentials.ini");
        }

        public static void CreateIniFileWithRsaKey(string homePath)
        {
            CreateDefaultIniFile(homePath, out iniConfiguration);

            iniConfiguration["default"]["public_key_id"].RawValue = "public_key_id";
            iniConfiguration["default"]["private_key_file"].RawValue = "private_key_file";
            iniConfiguration["default"]["type"].RawValue = "rsa_key_pair";

            iniConfiguration.SaveToFile("credentials.ini");
        }
    }
}
