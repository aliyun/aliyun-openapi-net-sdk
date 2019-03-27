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
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using Aliyun.Acs.Core.Http;

using Serilog;

namespace Aliyun.Acs.Core.Utils
{
    public class SerilogHelper
    {
        private static string logTemplate = "[{start_time}] {channel} {level}: '{method} {uri} HTTP/{version}' {code} {cost}ms {hostname} {pid} {NewLine}";
        private static ILogger logger;
        private const string RegexPattern = @"{(.*?)}";
        private static readonly IDictionary<string, string> LogMessageValueMap = new Dictionary<string, string>();

        public static long ExecuteTime { get; set; }
        public static string StartTime { get; set; }
        public static bool EnableLogger { get; private set; }

        private static void BuildKeyValueMap<T>(AcsRequest<T> request, HttpResponse response, long executeTime, string startTime) where T : AcsResponse
        {
            var requestHeader = request.Headers == null ? "" : DictionaryUtil.TransformDicToString(request.Headers);
            var requestContent = request.Content == null? "": Encoding.Default.GetString(request.Content);

            var responseHeader = response.Headers == null ? "" : DictionaryUtil.TransformDicToString(response.Headers);
            var responseContent = response.Content == null? "": Encoding.Default.GetString(response.Content);

            var requestUri = new Uri(request.Url);
            var host = requestUri.Host;
            var target = requestUri.PathAndQuery + requestUri.Fragment;
            var hostName = Dns.GetHostName();

            LogMessageValueMap.Add("channel", "AlibabaCloud");
            LogMessageValueMap.Add("level", "Info");
            LogMessageValueMap.Add("request", requestHeader + requestContent);
            LogMessageValueMap.Add("req_headers", requestHeader);
            LogMessageValueMap.Add("host", host);
            LogMessageValueMap.Add("method", request.Method.ToString());
            LogMessageValueMap.Add("uri", request.Url);
            LogMessageValueMap.Add("version", response.HttpVersion);
            LogMessageValueMap.Add("target", target);
            LogMessageValueMap.Add("hostname", hostName);

            LogMessageValueMap.Add("code", response.Status.ToString());
            LogMessageValueMap.Add("error", responseContent);

            LogMessageValueMap.Add("response", responseHeader + responseContent + response.Status.ToString());
            LogMessageValueMap.Add("res_headers", responseHeader);

            LogMessageValueMap.Add("pid", Process.GetCurrentProcess().Id.ToString());
            LogMessageValueMap.Add("cost", executeTime.ToString());
            LogMessageValueMap.Add("start_time", startTime);
        }

        public static void SetLogger(string logPath)
        {
            EnableLogger = true;

            CreateLogFile(logPath, out var filePath);

            var loggerConfiguration = new LoggerConfiguration()
                .WriteTo.File(filePath, outputTemplate : logTemplate, rollingInterval : RollingInterval.Day);
            logger = loggerConfiguration.CreateLogger();
        }

        public static void SetLoggerFormat(string format)
        {
            format = format + "{NewLine}";
            logTemplate = format;
        }

        public static void OutputLogInfo<T>(AcsRequest<T> request, HttpResponse httpResponse, long executeTime, string startTime) where T : AcsResponse
        {
            BuildKeyValueMap(request, httpResponse, executeTime, startTime);

            var logKey = new List<string>();
            var logValue = new List<string>();

            Regex re = new Regex(RegexPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            var matchCollection = re.Matches(logTemplate);

            if (0 < matchCollection.Count)
            {
                foreach (Match item in matchCollection)
                {
                    logKey.Add(item.Value.Trim('{', '}'));
                }
            }

            foreach (var item in logKey)
            {
                LogMessageValueMap.TryGetValue(item, out string value);
                logValue.Add(value);
            }

            var logParameters = logValue.Cast<object>().ToArray();
            logger.Information(logTemplate, logParameters);
        }

        private static void CreateLogFile(string path, out string filePath)
        {
            var slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            string directoryPath = path.TrimEnd('/', '\\');

            if (!Directory.Exists(path))
            {
                directoryPath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                    Environment.GetEnvironmentVariable("HOME") :
                    Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            }

            Directory.CreateDirectory(directoryPath + slash + ".alibabacloud" + slash);

            filePath = directoryPath + slash + ".alibabacloud" + slash + "log.txt";
        }
    }
}
