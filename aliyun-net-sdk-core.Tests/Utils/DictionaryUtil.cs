using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Utils
{
    public class DictionaryUtilTest
    {
        [Fact]
        public void Add()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            { { "a", "b" }
            };

            DictionaryUtil.Add(dic, "c", "d");
            DictionaryUtil.Add(dic, "c", "d"); // 覆盖“添加相同元素”的情况
            Assert.Equal("d", DictionaryUtil.Get(dic, "c"));

            Dictionary<string, string> nullDic = null;
            DictionaryUtil.Add(nullDic, "nullKey", "nullValue"); // 方法无回调，无静态存储

            // When value is null
            DictionaryUtil.Add(dic, "nullValue", nullDic); // 方法无回调，无静态存储
        }

        [Fact]
        public void Get()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            { { "a", "b" }
            };
            Assert.Equal("b", DictionaryUtil.Get(dic, "a"));
        }

        [Fact]
        public void Pop()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            { { "a", "b" }
            };
            DictionaryUtil.Pop(dic, "a");
            DictionaryUtil.Pop(dic, "c");
            Assert.Null(DictionaryUtil.Get(dic, "a"));
        }
    }
}
