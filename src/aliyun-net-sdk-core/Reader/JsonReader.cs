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
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Reader
{
    public class JsonReader : IReader
    {
        private static readonly object ArrayEndToken = new object();
        private static readonly object ObjectEndToken = new object();
        private static readonly object CommaToken = new object();
        private static readonly object ColonToken = new object();

        private static readonly Dictionary<char, char> Escapes = new Dictionary<char, char>
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

        private readonly Dictionary<string, string> _map = new Dictionary<string, string>();
        private readonly StringBuilder _sb = new StringBuilder();
        private char _c;

        //private const int FIRST_POSITION = 0;
        //private const int CURRENT_POSITION = 1;
        //private const int NEXT_POSITION = 2;

        private IEnumerator<char> _ct;

        private object _token;

        public Dictionary<string, string> Read(string response, string endpoint)
        {
            return Read(response.AsEnumerable().GetEnumerator(), endpoint);
        }

        public Dictionary<string, string> Read(IEnumerator<char> ci, string endpoint)
        {
            _ct = ci;
            NextChar();
            ReadJson(endpoint);
            return _map;
        }

        private object ReadJson(string baseKey)
        {
            SkipWhiteSpace();
            var ch = _c;
            NextChar();
            switch (ch)
            {
                case '{':
                    ProcessObject(baseKey);
                    break;
                case '}':
                    _token = ObjectEndToken;
                    break;
                case '[':
                    if (_c == '"')
                    {
                        ProcessList(baseKey);
                        break;
                    }
                    ProcessArray(baseKey);
                    break;
                case ']':
                    _token = ArrayEndToken;
                    break;
                case '"':
                    _token = ProcessString();
                    break;
                case ',':
                    _token = CommaToken;
                    break;
                case ':':
                    _token = ColonToken;
                    break;
                case 't':
                    NextChar();
                    NextChar();
                    NextChar();
                    _token = true;
                    break;
                case 'n':
                    NextChar();
                    NextChar();
                    NextChar();
                    _token = null;
                    break;
                case 'f':
                    NextChar();
                    NextChar();
                    NextChar();
                    NextChar();
                    _token = false;
                    break;
                default:
                    //c = ct.previous();
                    if (char.IsDigit(ch) || ch == '-')
                        _token = ProcessNumber(ch);
                    break;
            }
            return _token;
        }

        private void ProcessObject(string baseKey)
        {
            string key = $"{baseKey}.{ReadJson(baseKey)}";
            while (_token != ObjectEndToken)
            {
                ReadJson(key);
                if (_token != ObjectEndToken)
                {
                    var obj = ReadJson(key);

                    if (obj is string || obj is bool || obj is double)
                        DictionaryUtil.Add(_map, key, obj.ToString());

                    if (ReadJson(key) == CommaToken)
                    {
                        key = ReadJson(key).ToString();
                        key = $"{baseKey}.{key}";
                    }
                }
            }
        }

        private void ProcessList(string baseKey)
        {
            var value = ReadJson(baseKey);
            var index = 0;
            while (_token != ArrayEndToken)
            {
                string key = $"{TrimFromLast(baseKey, ".")}[{index++}]";
                DictionaryUtil.Add(_map, key, value.ToString());
                if (ReadJson(baseKey) == CommaToken)
                    value = ReadJson(baseKey);
            }
            DictionaryUtil.Add(_map, TrimFromLast(baseKey, ".") + ".Length", index.ToString());
        }

        private void ProcessArray(string baseKey)
        {
            var index = 0;
            var preKey = baseKey.Substring(0, baseKey.LastIndexOf(".", StringComparison.Ordinal));
            string key = $"{preKey}[{index}]";
            var value = ReadJson(key);

            while (_token != ArrayEndToken)
            {
                DictionaryUtil.Add(_map, preKey + ".Length", (index + 1).ToString());
                if (value is string)
                    DictionaryUtil.Add(_map, key, value.ToString());
                if (ReadJson(baseKey) == CommaToken)
                {
                    key = $"{preKey}[{++index}]";
                    value = ReadJson(key);
                }
            }
        }

        private object ProcessNumber(char preChar)
        {
            _sb.Clear();
            _sb.Append(preChar);
            if ('-' == _c)
                AddChar();
            AddDigits();
            if ('.' == _c)
            {
                AddChar();
                AddDigits();
            }
            if ('e' == _c || 'E' == _c)
            {
                AddChar();
                if ('+' == _c || '-' == _c)
                    AddChar();
                AddDigits();
            }
            return _sb.ToString();
        }

        private void AddDigits()
        {
            while (char.IsDigit(_c))
                AddChar();
        }

        private void SkipWhiteSpace()
        {
            while (char.IsWhiteSpace(_c))
                NextChar();
        }

        private char? NextChar()
        {
            if (_ct.MoveNext())
            {
                _c = _ct.Current;
                return _c;
            }
            return null;
        }

        private object ProcessString()
        {
            _sb.Clear();
            while (_c != '"')
                if (_c == '\\')
                {
                    NextChar();
                    object value = Escapes[_c];
                    if (value != null)
                        AddChar((char) value);
                }
                else
                {
                    AddChar();
                }
            NextChar();
            return _sb.ToString();
        }

        private void AddChar(char ch)
        {
            _sb.Append(ch);
            NextChar();
        }

        private void AddChar()
        {
            AddChar(_c);
        }

        public static string TrimFromLast(string str, string stripString)
        {
            var pos = str.LastIndexOf(stripString, StringComparison.Ordinal);
            if (pos > -1)
                return str.Substring(0, pos);
            return str;
        }
    }
}