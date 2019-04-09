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
using System.Runtime.InteropServices;
using System.Text;

namespace Aliyun.Acs.Core.Utils
{
    public static class IniFileHelper
    {
        public static int capacity = 512;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string section, string key, string defaultValue, [In, Out] char[] value, int size, string filePath);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileSection(string section, IntPtr keyValue, int size, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        [
            return :MarshalAs(UnmanagedType.Bool)
        ]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

        public static bool WriteValue(string section, string key, string value, string filePath)
        {
            bool result = WritePrivateProfileString(section, key, value, filePath);
            return result;
        }

        public static bool DeleteSection(string section, string filepath)
        {
            bool result = WritePrivateProfileString(section, null, null, filepath);
            return result;
        }

        public static bool DeleteKey(string section, string key, string filepath)
        {
            bool result = WritePrivateProfileString(section, key, null, filepath);
            return result;
        }

        public static string ReadValue(string section, string key, string filePath, string defaultValue = "")
        {
            var value = new StringBuilder(capacity);
            GetPrivateProfileString(section, key, defaultValue, value, value.Capacity, filePath);
            return value.ToString();
        }

        public static string[] ReadSections(string filePath)
        {
            // first line will not recognize if ini file is saved in UTF-8 with BOM 
            while (true)
            {
                char[] chars = new char[capacity];
                int size = GetPrivateProfileString(null, null, "", chars, capacity, filePath);

                if (size == 0)
                {
                    return null;
                }

                if (size < capacity - 2)
                {
                    string result = new String(chars, 0, size);
                    string[] sections = result.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
                    return sections;
                }

                capacity = capacity * 2;
            }
        }

        public static string[] ReadKeys(string section, string filePath)
        {
            // first line will not recognize if ini file is saved in UTF-8 with BOM 
            while (true)
            {
                char[] chars = new char[capacity];
                int size = GetPrivateProfileString(section, null, "", chars, capacity, filePath);

                if (size == 0)
                {
                    return null;
                }

                if (size < capacity - 2)
                {
                    string result = new String(chars, 0, size);
                    string[] keys = result.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
                    return keys;
                }

                capacity = capacity * 2;
            }
        }

        public static string[] ReadKeyValuePairs(string section, string filePath)
        {
            while (true)
            {
                IntPtr returnedString = Marshal.AllocCoTaskMem(capacity * sizeof(char));
                int size = GetPrivateProfileSection(section, returnedString, capacity, filePath);

                if (size == 0)
                {
                    Marshal.FreeCoTaskMem(returnedString);
                    return null;
                }

                if (size < capacity - 2)
                {
                    string result = Marshal.PtrToStringAuto(returnedString, size - 1);
                    Marshal.FreeCoTaskMem(returnedString);
                    string[] keyValuePairs = result.Split('\0');
                    return keyValuePairs;
                }

                Marshal.FreeCoTaskMem(returnedString);
                capacity = capacity * 2;
            }
        }
    }
}
