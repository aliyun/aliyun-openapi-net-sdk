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

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Transform
{
    public class UnmarshallerContext
    {
        public Dictionary<string, string> ResponseDictionary { get; set; }
        public HttpResponse HttpResponse { get; set; }

        public int? IntegerValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return int.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return null;
        }

        public string StringValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return DictionaryUtil.Get(ResponseDictionary, key);
            }

            return null;
        }

        public long? LongValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return long.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return null;
        }

        public bool? BooleanValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return bool.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return null;
        }

        public float? FloatValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return float.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return null;
        }

        public double? DoubleValue(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return double.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return null;
        }

        public T? EnumValue<T>(string key) where T : struct
        {
            var value = StringValue(key);
            if (null == value)
            {
                return null;
            }

            return (T)Enum.Parse(typeof(T), value);
        }

        public int Length(string key)
        {
            if (null != DictionaryUtil.Get(ResponseDictionary, key))
            {
                return int.Parse(DictionaryUtil.Get(ResponseDictionary, key));
            }

            return 0;
        }
    }
}
