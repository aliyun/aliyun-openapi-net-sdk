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
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Aliyun.Acs.Core.Utils
{
    public class IniReader
    {
        private ConcurrentDictionary<string, ConcurrentDictionary<string, string>> ini = new ConcurrentDictionary<string, ConcurrentDictionary<string, string>>(StringComparer.InvariantCultureIgnoreCase);
        private static ReaderWriterLockSlim cacheLock = new ReaderWriterLockSlim();

        public IniReader(string file)
        {
            cacheLock.EnterReadLock();
            try
            {
                var txt = File.ReadAllText(file);

                var currentSection = new ConcurrentDictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

                ini[""] = currentSection;

                foreach (var line in txt.Split(new [] { "\n" }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(t => !string.IsNullOrWhiteSpace(t))
                        .Select(t => t.Trim()))
                {
                    if (line.StartsWith(";"))
                        continue;

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentSection = new ConcurrentDictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                        ini[line.Substring(1, line.LastIndexOf("]") - 1)] = currentSection;
                        continue;
                    }

                    var idx = line.IndexOf("=");
                    if (idx == -1)
                        currentSection[line] = "";
                    else
                        currentSection[line.Substring(0, idx)] = line.Substring(idx + 1);
                }
            }
            finally
            {
                cacheLock.ExitReadLock();
            }
        }

        public string GetValue(string key)
        {
            return GetValue(key, "", "");
        }

        public string GetValue(string key, string section)
        {
            return GetValue(key, section, "");
        }

        public string GetValue(string key, string section, string @default)
        {
            if (!ini.ContainsKey(section))
                return @default;

            if (!ini[section].ContainsKey(key))
                return @default;

            return ini[section][key];
        }

        public string[] GetKeys(string section)
        {
            if (!ini.ContainsKey(section))
                return new string[0];

            return ini[section].Keys.ToArray();
        }

        public string[] GetSections()
        {
            return ini.Keys.Where(t => t != "").ToArray();
        }

        public void SaveSettings(string newFilePath, string section, ConcurrentDictionary<string, string> keyValuePairDic)
        {
            string strToSave = "";

            strToSave += ("[" + section + "]\r\n");

            foreach (var keyValuePair in keyValuePairDic)
            {
                strToSave += (keyValuePair.Key + "=" + keyValuePair.Value + "\r\n");
            }

            strToSave += "\r\n";

            cacheLock.EnterWriteLock();
            try
            {
                using(var tw = new StreamWriter(newFilePath))
                {
                    tw.Write(strToSave);
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }
    }
}
