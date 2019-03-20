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
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using Aliyun.Acs.Core.Utils;

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

            DEFAULT_MESSAGE = "Alibaba Cloud (" + this.OSVersion + ") ";
            DEFAULT_MESSAGE += this.ClientVersion;
            DEFAULT_MESSAGE += " Core/" + this.CoreVersion;
        }

        public void SetTheValue()
        {
            this.OSVersion = GetOsVersion();
            this.ClientVersion = GetRuntimeRegexValue(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory());
            this.CoreVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.excludedList.Add("core");
            this.excludedList.Add("microsoft.netcore.app");
        }

        private string GetOsVersion()
        {
            try
            {
                return System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            }
            catch (System.Exception)
            {
                return System.Environment.OSVersion.ToString();
            }
        }

        public string GetRuntimeRegexValue(string value)
        {
            Regex rx = new Regex(@"(\.NET).*(\\|\/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match matches = rx.Match(value);
            char[] separator = { '\\', '/' };

            if (matches.Success)
            {
                var clientValueArray = matches.Value.Split(separator);
                return BuildClientVersion(clientValueArray);
            }
            return "RuntimeNotFound";
        }

        private string BuildClientVersion(string[] value)
        {
            string finalValue = "";
            for (int i = 0; i < value.Length - 1; ++i)
            {
                finalValue += value[i].Replace(".", "").ToLower();
            }

            finalValue += "/" + value[value.Length - 1];

            return finalValue;
        }

        public static string GetDefaultMessage()
        {
            return DEFAULT_MESSAGE;
        }

        public void AppendUserAgent(string key, string value)
        {
            if (String.IsNullOrEmpty(key) || String.IsNullOrEmpty(value))
                return;
            if (this.excludedList.Contains(key.ToLowerInvariant()))
                return;
            DictionaryUtil.Add(this.userAgent, key, value);
        }

        public ReadOnlyDictionary<string, string> GetSysUserAgentDict()
        {
            return new ReadOnlyDictionary<string, string>(this.userAgent);
        }

        public static string Resolve(UserAgent requestConfig, UserAgent clientConfig)
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
    }
}
