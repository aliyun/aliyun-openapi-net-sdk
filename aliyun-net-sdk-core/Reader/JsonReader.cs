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
using System.Text;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Reader
{
    public class JsonReader : IReader
    {
        private const int FIRST_POSITION = 0;
        private const int CURRENT_POSITION = 1;
        private const int NEXT_POSITION = 2;

        private static readonly object ARRAY_END_TOKEN = new object();
        private static readonly object OBJECT_END_TOKEN = new object();
        private static readonly object COMMA_TOKEN = new object();
        private static readonly object COLON_TOKEN = new object();

        private static readonly Dictionary<char, char> escapes = new Dictionary<char, char>
        {
            {'\\', '\\'},
            {'/', '/'},
            {'"', '"'},
            {'t', '\t'},
            {'n', '\n'},
            {'r', '\r'},
            {'b', '\b'},
            {'f', '\f'}
        };

        private readonly Dictionary<string, string> map = new Dictionary<string, string>();
        private readonly StringBuilder sb = new StringBuilder();

        private char c;

        private CharEnumerator ct;

        private object token;

        public Dictionary<string, string> Read(string response, string endpoint)
        {
            return Read(response.GetEnumerator(), endpoint);
        }

        public Dictionary<string, string> ReadForHideArrayItem(string response, string endpoint)
        {
            return ReadForHideArrayItem(response.GetEnumerator(), endpoint);
        }

        public Dictionary<string, string> Read(CharEnumerator ci, string endpoint)
        {
            ct = ci;
            NextChar();
            ReadJson(endpoint);
            return map;
        }

        public Dictionary<string, string> ReadForHideArrayItem(CharEnumerator ci, string endpoint)
        {
            ct = ci;
            NextChar();
            ReadJsonForHideArrayItem(endpoint);
            return map;
        }

        private object ReadJson(string baseKey)
        {
            SkipWhiteSpace();
            var ch = c;
            NextChar();
            switch (ch)
            {
                case '{':
                    ProcessObject(baseKey);
                    break;
                case '}':
                    token = OBJECT_END_TOKEN;
                    break;
                case '[':
                    if (c == '"')
                    {
                        ProcessList(baseKey);
                        break;
                    }
                    else
                    {
                        ProcessArray(baseKey);
                        break;
                    }
                case ']':
                    token = ARRAY_END_TOKEN;
                    break;
                case '"':
                    token = ProcessString();
                    break;
                case ',':
                    token = COMMA_TOKEN;
                    break;
                case ':':
                    token = COLON_TOKEN;
                    break;
                case 't':
                    NextChar();
                    NextChar();
                    NextChar();
                    token = true;
                    break;
                case 'n':
                    NextChar();
                    NextChar();
                    NextChar();
                    token = null;
                    break;
                case 'f':
                    NextChar();
                    NextChar();
                    NextChar();
                    NextChar();
                    token = false;
                    break;
                default:
                    // c = ct.previous();
                    if (char.IsDigit(ch) || ch == '-')
                    {
                        token = ProcessNumber(ch);
                    }

                    break;
            }

            return token;
        }

        private object ReadJsonForHideArrayItem(string baseKey)
        {
            SkipWhiteSpace();
            var ch = c;
            NextChar();
            switch (ch)
            {
                case '{':
                    ProcessObjectForHideArrayItem(baseKey);
                    break;
                case '}':
                    token = OBJECT_END_TOKEN;
                    break;
                case '[':
                    if (c == '"')
                    {
                        ProcessList(baseKey);
                        break;
                    }
                    else
                    {
                        ProcessArrayForHideArrayItem(baseKey);
                        break;
                    }
                case ']':
                    token = ARRAY_END_TOKEN;
                    break;
                case '"':
                    token = ProcessString();
                    break;
                case ',':
                    token = COMMA_TOKEN;
                    break;
                case ':':
                    token = COLON_TOKEN;
                    break;
                case 't':
                    NextChar();
                    NextChar();
                    NextChar();
                    token = true;
                    break;
                case 'n':
                    NextChar();
                    NextChar();
                    NextChar();
                    token = null;
                    break;
                case 'f':
                    NextChar();
                    NextChar();
                    NextChar();
                    NextChar();
                    token = false;
                    break;
                default:
                    // c = ct.previous();
                    if (char.IsDigit(ch) || ch == '-')
                    {
                        token = ProcessNumber(ch);
                    }

                    break;
            }

            return token;
        }

        private void ProcessObject(string baseKey)
        {
            var key = baseKey + "." + ReadJson(baseKey);
            while (token != OBJECT_END_TOKEN)
            {
                ReadJson(key);
                if (token != OBJECT_END_TOKEN)
                {
                    var obj = ReadJson(key);

                    if (obj is string || obj is bool || obj is double)
                    {
                        DictionaryUtil.Add(map, key, obj.ToString());
                    }

                    if (ReadJson(key) == COMMA_TOKEN)
                    {
                        key = ReadJson(key).ToString();
                        key = baseKey + "." + key;
                    }
                }
            }
        }

        private void ProcessObjectForHideArrayItem(string baseKey)
        {
            var key = baseKey + "." + ReadJsonForHideArrayItem(baseKey);
            while (token != OBJECT_END_TOKEN)
            {
                ReadJsonForHideArrayItem(key);
                if (token != OBJECT_END_TOKEN)
                {
                    var obj = ReadJsonForHideArrayItem(key);

                    if (obj is string || obj is bool || obj is double)
                    {
                        DictionaryUtil.Add(map, key, obj.ToString());
                    }

                    if (ReadJsonForHideArrayItem(key) == COMMA_TOKEN)
                    {
                        key = ReadJsonForHideArrayItem(key).ToString();
                        key = baseKey + "." + key;
                    }
                }
            }
        }

        private void ProcessList(string baseKey)
        {
            var value = ReadJson(baseKey);
            var index = 0;
            while (token != ARRAY_END_TOKEN)
            {
                var key = TrimFromLast(baseKey, ".") + "[" + index++ + "]";
                DictionaryUtil.Add(map, key, value.ToString());
                if (ReadJson(baseKey) == COMMA_TOKEN)
                {
                    value = ReadJson(baseKey);
                }
            }

            DictionaryUtil.Add(map, TrimFromLast(baseKey, ".") + ".Length", index.ToString());
        }

        private void ProcessArray(string baseKey)
        {
            var index = 0;
            var preKey = baseKey.Substring(0, baseKey.LastIndexOf("."));
            var key = preKey + "[" + index + "]";
            var value = ReadJson(key);

            while (token != ARRAY_END_TOKEN)
            {
                DictionaryUtil.Add(map, preKey + ".Length", (index + 1).ToString());
                if (value is string)
                {
                    DictionaryUtil.Add(map, key, value.ToString());
                }

                if (ReadJson(baseKey) == COMMA_TOKEN)
                {
                    key = preKey + "[" + ++index + "]";
                    value = ReadJson(key);
                }
            }
        }

        private void ProcessArrayForHideArrayItem(string baseKey)
        {
            var index = 0;
            var preKey = baseKey;
            var key = preKey + "[" + index + "]";
            var value = ReadJsonForHideArrayItem(key);

            while (token != ARRAY_END_TOKEN)
            {
                DictionaryUtil.Add(map, preKey + ".Length", (index + 1).ToString());
                if (value is string)
                {
                    DictionaryUtil.Add(map, key, value.ToString());
                }

                if (ReadJsonForHideArrayItem(baseKey) == COMMA_TOKEN)
                {
                    key = preKey + "[" + ++index + "]";
                    value = ReadJsonForHideArrayItem(key);
                }
            }
        }

        private object ProcessNumber(char preChar)
        {
            sb.Clear();
            sb.Append(preChar);
            if ('-' == c)
            {
                AddChar();
            }

            AddDigits();
            if ('.' == c)
            {
                AddChar();
                AddDigits();
            }

            if ('e' == c || 'E' == c)
            {
                AddChar();
                if ('+' == c || '-' == c)
                {
                    AddChar();
                }

                AddDigits();
            }

            return sb.ToString();
        }

        private void AddDigits()
        {
            while (char.IsDigit(c))
            {
                AddChar();
            }
        }

        private void SkipWhiteSpace()
        {
            while (char.IsWhiteSpace(c))
            {
                NextChar();
            }
        }

        private char? NextChar()
        {
            if (ct.MoveNext())
            {
                c = ct.Current;
                return c;
            }

            return null;
        }

        private object ProcessString()
        {
            sb.Clear();
            while (c != '"')
            {
                if (c == '\\')
                {
                    NextChar();
                    char value;
                    if (escapes.TryGetValue(c, out value))
                    {
                        AddChar(value);
                    }
                }
                else
                {
                    AddChar();
                }
            }

            NextChar();
            return sb.ToString();
        }

        private void AddChar(char ch)
        {
            sb.Append(ch);
            NextChar();
        }

        private void AddChar()
        {
            AddChar(c);
        }

        public static string TrimFromLast(string str, string stripString)
        {
            var pos = str.LastIndexOf(stripString);
            if (pos > -1)
            {
                return str.Substring(0, pos);
            }

            return str;
        }
    }
}
