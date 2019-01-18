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
using System.Collections.Generic;

namespace Aliyun.Acs.Core.Utils
{
    public class DictionaryUtil
    {
        public static void Add<T>(Dictionary<string, string> dic, string key, T value)
        {
            if (null == value)
            {
                return;
            }
            if (dic == null)
            {
                dic = new Dictionary<string, string>();
            }
            else if (dic.ContainsKey(key))
            {
                dic.Remove(key);
            }
            dic.Add(key, value.ToString());
        }

        public static string Get(Dictionary<string, string> dic, string key)
        {
            if (dic.ContainsKey(key))
            {
                return dic[key];
            }
            return null;
        }

        public static string Pop(Dictionary<string, string> dic, string key)
        {
            string value = null;
            if (dic.ContainsKey(key))
            {
                value = dic[key];
                dic.Remove(key);
            }
            return value;
        }
    }
}
