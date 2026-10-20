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

using System.Text.RegularExpressions;

namespace Aliyun.Acs.Core.Utils
{
    internal static class LogRedactor
    {
        private const string SensitiveNames = "AccessKeySecret|SessionAccessKeySecret|AccessSecret|SecretAccessKey|SecurityToken|SessionToken|BearerToken|Signature|Authorization|x-acs-security-token|x-acs-bearer-token";
        private const string Mask = "[REDACTED]";
        private static readonly Regex SensitiveHeader = new Regex("^(?:" + SensitiveNames + ")$", RegexOptions.IgnoreCase);
        private static readonly Regex NamedValue = new Regex(
            @"(?<prefix>\b(?:" + SensitiveNames + @")[""']?\s*[=:]\s*)(?:""(?:\\.|[^""\\])*""|'[^']*'|[^&;\r\n<>""']*)",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);
        // Encoded delimiters end in word characters, so a word boundary alone misses the next field.
        private static readonly Regex EncodedValue = new Regex(
            @"(?<prefix>(?:\b|%(?:25)*(?:26|22|27|20|0a|0d|3f))(?:" + SensitiveNames + @")(?:%(?:25)*22|%(?:25)*27)?(?:\s|%(?:25)*20|\+)*%(?:25)*3[da](?:\s|%(?:25)*20|\+)*(?:%(?:25)*22|%(?:25)*27)?)(?:(?!%(?:25)*(?:26|22|27|3c|3e|0a|0d))[^&;\r\n<>""'])*",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Regex XmlValue = new Regex(
            @"(?<prefix><(?<name>" + SensitiveNames + @")\b[^>]*>).*?(?<suffix></\k<name>\s*>)",
            RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

        internal static string Redact(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            value = XmlValue.Replace(value, "${prefix}" + Mask + "${suffix}");
            value = NamedValue.Replace(value, "${prefix}" + Mask);
            return EncodedValue.Replace(value, "${prefix}" + Mask);
        }

        internal static string RedactHeader(string name, string value)
        {
            return SensitiveHeader.IsMatch(name) ? Mask : Redact(value);
        }
    }
}
