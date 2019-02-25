using System;

namespace Aliyun.Acs.Core.Tests.Mock
{
    public class ACKMock
    {
        private static string AKID { get; } = "ACCESS_KEY_ID";
        private static string AKSE { get; } = "ACCESS_KEY_SECRET";

        public static string GetAccessKeyId(bool mock = false, string mockData = "AccessKeyId")
        {
            return mock ? mockData : GetEnv(ACKMock.AKID, mockData);
        }

        public static string GetAccessKeySecret(bool mock = false, string mockData = "AccessKeySecret")
        {
            return mock ? mockData : GetEnv(ACKMock.AKSE, mockData);
        }

        public static string GetRoleName(bool mock = false, string mockData = "RoleName")
        {
            return mock ? mockData : GetEnv("RAM", mockData);
        }

        private static string GetEnv(string envName, string mockData)
        {
            return Environment.GetEnvironmentVariable(envName) == null ? mockData : Environment.GetEnvironmentVariable(envName);
        }
    }
}
