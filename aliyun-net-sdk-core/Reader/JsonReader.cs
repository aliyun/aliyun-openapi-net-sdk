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
using Aliyun.Acs.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliyun.Acs.Core.Reader
{
    public class JsonReader : IReader
    {

        private static Object ARRAY_END_TOKEN = new Object();
        private static Object OBJECT_END_TOKEN = new Object();
        private static Object COMMA_TOKEN = new Object();
        private static Object COLON_TOKEN = new Object();

        private const int FIRST_POSITION = 0;
        private const int CURRENT_POSITION = 1;
        private const int NEXT_POSITION = 2;

        private CharEnumerator ct;
        private char c;

        private Object token;
        private StringBuilder sb = new StringBuilder();
        private Dictionary<String, String> map = new Dictionary<String, String>();

        private static Dictionary<char, char> escapes = new Dictionary<char, char> {
            {'\\','\\'},
            {'/', '/'},
            {'"', '"'},
            {'t','\t'},
            {'n','\n'},
            {'r','\r'},
            {'b','\b'},
            {'f','\f'}
        };

        public Dictionary<String, String> Read(String response, String endpoint)
        {
            return Read(response.GetEnumerator(), endpoint);
        }

        public Dictionary<String, String> Read(CharEnumerator ci, String endpoint)
        {
            ct = ci;
            NextChar();
            ReadJson(endpoint);
            return map;
        }

        private Object ReadJson(String baseKey)
        {
            SkipWhiteSpace();
            char ch = c;
            NextChar();
            switch (ch)
            {
                case '{': ProcessObject(baseKey); break;
                case '}': token = OBJECT_END_TOKEN; break;
                case '[':
                    if (c == '"')
                    {
                        ProcessList(baseKey); break;
                    }
                    else
                    {
                        ProcessArray(baseKey); break;
                    }
                case ']': token = ARRAY_END_TOKEN; break;
                case '"': token = ProcessString(); break;
                case ',': token = COMMA_TOKEN; break;
                case ':': token = COLON_TOKEN; break;
                case 't':
                    NextChar(); NextChar(); NextChar();
                    token = true;
                    break;
                case 'n':
                    NextChar(); NextChar(); NextChar();
                    token = null;
                    break;
                case 'f':
                    NextChar(); NextChar(); NextChar(); NextChar();
                    token = false;
                    break;
                default:
                    //c = ct.previous();
                    if (Char.IsDigit(ch) || ch == '-')
                    {
                        token = ProcessNumber(ch);
                    }
                    break;
            }
            return token;
        }

        private void ProcessObject(String baseKey)
        {
            String key = baseKey + "." + ReadJson(baseKey);
            while (token != OBJECT_END_TOKEN)
            {
                ReadJson(key);
                if (token != OBJECT_END_TOKEN)
                {
                    object obj = ReadJson(key);

                    if (obj is String || obj is Boolean || obj is Double)
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

        private void ProcessList(String baseKey)
        {
            Object value = ReadJson(baseKey);
            int index = 0;
            while (token != ARRAY_END_TOKEN)
            {
                String key = TrimFromLast(baseKey, ".") + "[" + (index++) + "]";
                DictionaryUtil.Add(map, key, value.ToString());
                if (ReadJson(baseKey) == COMMA_TOKEN)
                {
                    value = ReadJson(baseKey);
                }
            }
            DictionaryUtil.Add(map, TrimFromLast(baseKey, ".") + ".Length", index.ToString());
        }

        private void ProcessArray(String baseKey)
        {
            int index = 0;
            String preKey = baseKey.Substring(0, baseKey.LastIndexOf("."));
            String key = preKey + "[" + index + "]";
            Object value = ReadJson(key);

            while (token != ARRAY_END_TOKEN)
            {
                DictionaryUtil.Add(map, preKey + ".Length", (index + 1).ToString());
                if (value is String)
                {
                    DictionaryUtil.Add(map, key, value.ToString());
                }
                if (ReadJson(baseKey) == COMMA_TOKEN)
                {
                    key = preKey + "[" + (++index) + "]";
                    value = ReadJson(key);
                }
            }
        }

        private Object ProcessNumber(char preChar)
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
            while (Char.IsDigit(c))
            {
                AddChar();
            }
        }

        private void SkipWhiteSpace()
        {
            while (Char.IsWhiteSpace(c))
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

        private Object ProcessString()
        {
            sb.Clear();
            while (c != '"')
            {
                if (c == '\\')
                {
                    NextChar();
                    Object value = escapes[c];
                    if (value != null)
                    {
                        AddChar((Char)value);
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

        public static String TrimFromLast(String str, String stripString)
        {
            int pos = str.LastIndexOf(stripString);
            if (pos > -1)
            {
                return str.Substring(0, pos);
            }
            else
            {
                return str;
            }
        }

    }
}
