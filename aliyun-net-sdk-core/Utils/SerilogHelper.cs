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
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;

using Serilog;
using Serilog.Exceptions;

namespace Aliyun.Acs.Core.Utils
{
    public class SerilogHelper
    {
        private const string RegexPattern = @"{(.*?)}";
        private static ILogger defaultLogger;
        private static ILogger exceptionLogger;
        private static IDictionary<string, string> LoggerMessageMap;

        private static Logger Logger;
        public static long ExecuteTime { get; set; }
        public static string StartTime { get; set; }
        public static bool EnableLogger { get; private set; }

        private static void BuildKeyValueMap<T>(AcsRequest<T> request, HttpResponse response, long executeTime,
            string startTime) where T : AcsResponse
        {
            try
            {
                LoggerMessageMap = new Dictionary<string, string>();
                var requestHeader =
                    request.Headers == null ? "" : DictionaryUtil.TransformDicToString(request.Headers);
                var requestContent = request.Content == null ? "" : Encoding.Default.GetString(request.Content);

                var responseHeader = response.Headers == null
                    ? ""
                    : DictionaryUtil.TransformDicToString(response.Headers);
                var responseContent = response.Content == null ? "" : Encoding.Default.GetString(response.Content);

                var hostName = Dns.GetHostName();

                if (null != request.Url)
                {
                    var requestUri = new Uri(request.Url);
                    var host = requestUri.Host;
                    var target = requestUri.PathAndQuery + requestUri.Fragment;

                    LoggerMessageMap.Add("host", host);
                    LoggerMessageMap.Add("target", target);
                }

                LoggerMessageMap.Add("level", Logger.Level);
                LoggerMessageMap.Add("channel", Logger.Channel);
                LoggerMessageMap.Add("request", requestHeader + requestContent);
                LoggerMessageMap.Add("req_headers", requestHeader);

                LoggerMessageMap.Add("method", request.Method.ToString());
                LoggerMessageMap.Add("uri", request.Url);
                LoggerMessageMap.Add("version", "HTTP/" + response.HttpVersion);
                LoggerMessageMap.Add("hostname", hostName);

                LoggerMessageMap.Add("code", response.Status.ToString());
                LoggerMessageMap.Add("error", responseContent);
                LoggerMessageMap.Add("response", responseHeader + responseContent + response.Status);
                LoggerMessageMap.Add("res_headers", responseHeader);

                LoggerMessageMap.Add("pid", Process.GetCurrentProcess().Id.ToString());
                LoggerMessageMap.Add("cost", executeTime + "ms");
                LoggerMessageMap.Add("start_time", "[" + startTime + "]");
            }
            catch (Exception ex)
            {
                LogException(ex, "ErrorCode", ex.ToString());
                throw new ClientException(ex.ToString());
            }
        }

        public static void SetLogger(Logger logger)
        {
            Logger = logger;
            EnableLogger = true;

            var loggerConfiguration = new LoggerConfiguration()
                .WriteTo.File(Logger.LoggerPath, outputTemplate: Logger.LoggerTemplate, shared: true);
            defaultLogger = loggerConfiguration.CreateLogger();
        }

        public static void LogInfo<T>(AcsRequest<T> request, HttpResponse httpResponse, long executeTime,
            string startTime) where T : AcsResponse
        {
            if (!EnableLogger)
            {
                return;
            }

            BuildKeyValueMap(request, httpResponse, executeTime, startTime);

            var logKey = new List<string>();
            var logValue = new List<string>();

            var re = new Regex(RegexPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            var matchCollection = re.Matches(Logger.LoggerTemplate);

            if (0 < matchCollection.Count)
            {
                foreach (Match item in matchCollection)
                {
                    logKey.Add(item.Value.Trim('{', '}'));
                }
            }

            foreach (var item in logKey)
            {
                string value;
                LoggerMessageMap.TryGetValue(item, out value);
                logValue.Add(value);
            }

            var logParameters = logValue.Cast<object>().ToArray();
            defaultLogger.Information(Logger.LoggerTemplate, logParameters);
        }

        public static void LogException(Exception ex, string errorCode, string errorMessage)
        {
            if (!EnableLogger)
            {
                return;
            }

            var loggerConfiguration = new LoggerConfiguration()
                .Enrich.WithExceptionDetails()
                .WriteTo.File(Logger.LoggerPath, shared: true);

            exceptionLogger = loggerConfiguration.CreateLogger();
            exceptionLogger.Error(ex, "ExceptionMessage: ");
        }

        public static void CloseLogger()
        {
            EnableLogger = false;
            LoggerMessageMap = null;
            Logger = null;
        }
    }
}
