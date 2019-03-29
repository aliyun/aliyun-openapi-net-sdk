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

namespace Aliyun.Acs.Core.Utils
{
    public class Logger
    {
        private const string defaultTemplate = "{start_time} {channel} [{level}] {method} {uri} {version} {code} {cost} {hostname} {pid} {NewLine}";
        public Logger(
            string loggerPath,
            string level = "Info",
            string channel = "AlibabaCloud",
            string template = defaultTemplate)
        {
            LoggerPath = loggerPath;
            Level = level;
            Channel = channel;
            LoggerTemplate = template + "{NewLine}";
        }

        public string LoggerPath { get; }
        public string Level { get; } = "Info";
        public string Channel { get; } = "AlibabaCloud";
        public string LoggerTemplate { get; }

    }
}
