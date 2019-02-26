using System;

namespace Aliyun.Acs.Core.Tests.Mock
{
    public class ACKMock
    {
        public static string GetAccessKeyId(bool mock = false, string mockData = "AccessKeyId")
        {
            return mock ? mockData : GetEnv("ACCESS_KEY_ID", mockData);
        }

        public static string GetAccessKeySecret(bool mock = false, string mockData = "AccessKeySecret")
        {
            return mock ? mockData : GetEnv("ACCESS_KEY_SECRET", mockData);
        }

        public static string GetRoleName(bool mock = false, string mockData = "RoleName")
        {
            return mock ? mockData : GetEnv("RAM", mockData);
        }

        private static string GetEnv(string envName, string mockData)
        {
            Console.WriteLine("EnvironmentValue>>>>>>>>>" + Environment.GetEnvironmentVariable(envName));
            return Environment.GetEnvironmentVariable(envName) == null ? mockData : Environment.GetEnvironmentVariable(envName);
        }
    }
}
