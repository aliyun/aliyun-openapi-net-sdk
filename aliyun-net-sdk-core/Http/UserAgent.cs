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
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using Aliyun.Acs.Core.Utils;
using System.Collections.ObjectModel;

namespace Aliyun.Acs.Core.Http
{
    public class UserAgent
    {
        private static string DEFAULT_MESSAGE;

        private List<string> excludedList = new List<string>();
        private readonly Dictionary<string, string> userAgent = new Dictionary<string, string>();

        private string OSVersion;
        private string ClientVersion;
        private string CoreVersion;

        public UserAgent()
        {
            SetTheValue();

            DEFAULT_MESSAGE += "Alibaba Cloud (" + OSVersion + ") ";
            DEFAULT_MESSAGE += ClientVersion;
            DEFAULT_MESSAGE += " Core/" + CoreVersion;
        }

        public void SetTheValue()
        {
            OSVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            GetRuntimeRegexValue(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory());
            CoreVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            excludedList.Add("core");
            excludedList.Add("microsoft.netcore.app");
        }

        public static string GetDefaultMessage()
        {
            return DEFAULT_MESSAGE;
        }

        public void AppendUserAgent(string key, string value)
        {
            if (StringUtils.isEmpty(key) || StringUtils.isEmpty(value))
                return;
            if (excludedList.Contains(key.ToLowerInvariant()))
                return;
            this.userAgent.Add(key, value);
        }

        public ReadOnlyDictionary<string, string> GetSysUserAgentDict()
        {
            return new ReadOnlyDictionary<string, string>(userAgent);
        }

        public string Resolve(UserAgent requestConfig, UserAgent clientConfig)
        {
            Dictionary<string, string> finalDict = new Dictionary<string, string>();
            if (clientConfig != null && clientConfig.GetSysUserAgentDict().Count > 0)
            {
                finalDict = new Dictionary<string, string>(clientConfig.GetSysUserAgentDict());
            }
            if (requestConfig != null && requestConfig.GetSysUserAgentDict().Count > 0)
            {
                finalDict = new Dictionary<string, string>(requestConfig.GetSysUserAgentDict());
            }

            StringBuilder agent = new StringBuilder(DEFAULT_MESSAGE);

            foreach (var item in finalDict)
            {
                agent.Append(" " + item.Key + "/" + item.Value);
            }

            return agent.ToString();
        }

        public void GetRuntimeRegexValue(string value)
        {
            Regex rx = new Regex(@"(Microsoft).*(\\|/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match matches = rx.Match(value);

            if (matches.Success)
            {
                char[] separator = { '\\', '/' };
                var array = matches.Value.Split(separator);
                ClientVersion = array[0] + "/" + array[1];
            }
        }
    }
}
