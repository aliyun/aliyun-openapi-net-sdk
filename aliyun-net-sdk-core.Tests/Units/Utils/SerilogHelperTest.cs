using System;
using System.Linq;
using System.Reflection;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class SerilogHelperTest
    {
        [Fact]
        public void OutputLogInfoTestValid()
        {

            string format = "{start_time}|{code}|{pid}|{cost}";

            var logger = new Logger(loggerPath: EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt", template: format);

            SerilogHelper.SetLogger(logger);

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();
            long executeTime = 100;
            string startTime = DateTime.Now.ToString();

            SerilogHelper.LogInfo(request, response, executeTime, startTime);
            Assert.True(SerilogHelper.EnableLogger);

            SerilogHelper.CloseLogger();
        }

        [Fact]
        public void OutputLogInfoTestInValid()
        {
            string format = "{code}|{pid}|{start_time}";
            var logger = new Logger(loggerPath: EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt", template: format);

            SerilogHelper.SetLogger(logger);

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();
            long executeTime = 100;
            string startTime = DateTime.Now.ToString();

            Assert.Throws<ClientException>(() =>
            {
                SerilogHelper.LogInfo(request, null, executeTime, startTime);
            });

            SerilogHelper.CloseLogger();
            Assert.False(SerilogHelper.EnableLogger);

            SerilogHelper.LogInfo(request, null, 100, "100");
        }

        [Fact]
        public void OutputLogException()
        {
            string format = "{Exception}";
            var logger = new Logger(loggerPath: EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt", template: format);

            SerilogHelper.SetLogger(logger);

            var exception = new Exception();

            SerilogHelper.LogException(exception, "errorcode", "errormessage");

            SerilogHelper.CloseLogger();
            Assert.False(SerilogHelper.EnableLogger);

            //Should return directly
            SerilogHelper.LogException(exception, "error", "error");
        }
    }
}
