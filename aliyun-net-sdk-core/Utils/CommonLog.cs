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
using Aliyun.Acs.Core.Logging;

namespace Aliyun.Acs.Core.Utils
{
    public class CommonLog
    {
        private const string RegexPattern = @"{(.*?)}";

        private static readonly ILog Logger = LogProvider.For<CommonLog>();

        private static volatile bool s_enableLogger;

        private static volatile IDictionary<string, string> LoggerMessageMap = new Dictionary<string, string>();

        internal const string DefaultTemplate = "{channel} {method} {uri} {version} {code} {cost} {hostname} {pid} {NewLine}";

        internal static long ExecuteTime { get; set; }
        private static volatile string template;

        private static void BuildKeyValueMap<T>(AcsRequest<T> request, HttpResponse response, long executeTime)
            where T : AcsResponse
        {
            try
            {
                var requestHeader = request.Headers == null
                    ? ""
                    : DictionaryUtil.TransformDicToString(request.Headers);
                var requestContent = request.Content == null
                    ? ""
                    : Encoding.Default.GetString(request.Content);

                var responseHeader = response.Headers == null
                    ? ""
                    : DictionaryUtil.TransformDicToString(response.Headers);
                var responseContent = response.Content == null
                    ? ""
                    : Encoding.Default.GetString(response.Content);

                var hostName = Dns.GetHostName();

                if (null != request.Url)
                {
                    var requestUri = new Uri(request.Url);
                    LoggerMessageMap.Add("host", requestUri.Host);
                    LoggerMessageMap.Add("target", requestUri.PathAndQuery + requestUri.Fragment);
                }

                LoggerMessageMap.Add("channel", "AlibabaCloud.");
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
            }
            catch (Exception ex)
            {
                LogException(ex, "ErrorCode", ex.ToString());
                throw new ClientException(ex.ToString());
            }
        }

        internal static void EnableLogger(string loggerTemplate = DefaultTemplate)
        {
            template = loggerTemplate;
            s_enableLogger = true;
        }

        internal static void DisableLogger()
        {
            s_enableLogger = false;
        }

        internal static bool GetEnableLoggerStatus()
        {
            return s_enableLogger;
        }

        internal static void LogInfo<T>(AcsRequest<T> request, HttpResponse httpResponse, long executeTime)
            where T : AcsResponse
        {
            if (!s_enableLogger)
            {
                return;
            }

            BuildKeyValueMap(request, httpResponse, executeTime);

            var logKey = new List<string>();
            var logValue = new List<string>();

            var re = new Regex(RegexPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            var matchCollection = re.Matches(template);

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
            Logger.Info(template, logParameters);

            LoggerMessageMap = new Dictionary<string, string>();
        }

        internal static void LogException(Exception ex, string errorCode, string errorMessage)
        {
            if (!s_enableLogger)
            {
                return;
            }

            Logger.Error(ex,
                string.Format("AlibabaCloud. ExceptionMessage: ErrorCode:{0}, ErrorMessage:{1},", errorCode,
                    errorMessage));
        }
    }
}
