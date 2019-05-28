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

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class DictionaryUtilTest
    {
        [Fact]
        public void Add()
        {
            var dic = new Dictionary<string, string> {{"a", "b"}};

            DictionaryUtil.Add(dic, "c", "d");
            DictionaryUtil.Add(dic, "c", "d");
            Assert.Equal("d", DictionaryUtil.Get(dic, "c"));

            DictionaryUtil.Add(dic, "c", "e");
            Assert.Equal("e", DictionaryUtil.Get(dic, "c"));

            DictionaryUtil.Add(null, "nullKey", "nullValue");

            Assert.Throws<NullReferenceException>(() => { DictionaryUtil.Get(null, "nullKey"); });

            // When value is null
            DictionaryUtil.Add(dic, "nullValue", null);
        }

        [Fact]
        public void GenericAddTest()
        {
            var dic = new Dictionary<string, string>();

            // Should be return cause of null value
            DictionaryUtil.Add(dic, "key", null); 

            Dictionary<string, int> dic2 = null;
            DictionaryUtil.Add(dic2, "key", 1);
            Assert.Null(dic2);

            var dic3 = new Dictionary<string, Dictionary<string, string>>();
            var innerDic1 = new Dictionary<string, string> {{"innerKey1", "innerValue1"}};
            var innerDic2 = new Dictionary<string, string> {{"innerKey2", "innerValue2"}};

            DictionaryUtil.Add(dic3, "testKey", innerDic1);
            DictionaryUtil.Add(dic3, "testKey", innerDic2);

            Assert.Equal(innerDic2, DictionaryUtil.Get(dic3, "testKey"));
        }

        [Fact]
        public void GenericGetTest()
        {
            var dic = new Dictionary<int, int>();

            DictionaryUtil.Add(dic, 1, 2);

            Assert.Equal(2, DictionaryUtil.Get(dic, 1));

            // Get default t value int -> 0
            Assert.Equal(0, DictionaryUtil.Get(dic, 2));
        }

        [Fact]
        public void GenericPopTest()
        {
            var dic = new Dictionary<string, int>();
            DictionaryUtil.Add(dic, "testKey", 1);

            var value = DictionaryUtil.Pop(dic, "fakeKey");

            Assert.Equal(0, value);

            value = DictionaryUtil.Pop(dic, "testKey");
            Assert.Equal(1, value);
            Assert.Equal(0, DictionaryUtil.Get(dic, "testKey"));
        }

        [Fact]
        public void GenericPrintTest()
        {
            var dic = new Dictionary<int, int> {{1, 3}, {2, 4}};
            DictionaryUtil.Print(dic, '|');
        }

        [Fact]
        public void GenericTransformDicToStringTest()
        {
            var dic = new Dictionary<int, string>();

            DictionaryUtil.TransformDicToString(dic);
        }

        [Fact]
        public void Get()
        {
            var dic = new Dictionary<string, string> {{"a", "b"}};
            Assert.Equal("b", DictionaryUtil.Get(dic, "a"));
        }

        [Fact]
        public void Pop()
        {
            var dic = new Dictionary<string, string> {{"a", "b"}};
            DictionaryUtil.Pop(dic, "a");
            DictionaryUtil.Pop(dic, "c");
            Assert.Null(DictionaryUtil.Get(dic, "a"));
        }
    }
}
