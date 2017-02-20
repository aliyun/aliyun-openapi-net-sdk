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
using System.Globalization;
using System.Security.Cryptography;
using Aliyun.Acs.Core.Http;

namespace Aliyun.Acs.Core.Utils
{
    public class ParameterHelper
    {
        // ReSharper disable once InconsistentNaming
        private const string ISO8601_DATE_FORMAT = "yyyy-MM-dd'T'HH:mm:ss'Z'";

        public static string FormatIso8601Date(DateTime date)
        {
            return date.ToUniversalTime().ToString(ISO8601_DATE_FORMAT, new CultureInfo("en-US"));
        }

        public static string GetRFC2616Date(DateTime datetime)
        {
            if (DateTime.MinValue == datetime)
                datetime = DateTime.Now;
            return datetime.ToUniversalTime().GetDateTimeFormats('r')[0];
        }

        public static string Md5Sum(byte[] buff)
        {
            var md5 = MD5.Create();
            var output = md5.ComputeHash(buff);
            return BitConverter.ToString(output).Replace("-", "");
        }

        public static string FormatTypeToString(FormatType? formatType)
        {
            if (FormatType.XML == formatType)
                return "application/xml";
            if (FormatType.JSON == formatType)
                return "application/json";
            return "application/octet-stream";
        }

        public static FormatType? StingToFormatType(string format)
        {
            if (format.ToLower().Equals("application/xml") || format.ToLower().Equals("text/xml"))
                return FormatType.XML;
            if (format.ToLower().Equals("application/json"))
                return FormatType.JSON;
            return FormatType.RAW;
        }

        public static MethodType? StringToMethodType(string method)
        {
            //switch (method.ToUpper())
            //{
            //    case "GET":
            //    {
            //        return MethodType.GET;
            //    }
            //    case "PUT":
            //    {
            //        return MethodType.PUT;
            //    }
            //    case "POST":
            //    {
            //        return MethodType.POST;
            //    }
            //    case "DELETE":
            //    {
            //        return MethodType.DELETE;
            //    }
            //    case "HEAD":
            //    {
            //        return MethodType.HEAD;
            //    }
            //    case "OPTIONS":
            //    {
            //        return MethodType.OPTIONS;
            //    }
            //    default:
            //    {
            //        return null;
            //    }
            //}
            MethodType type;
            if (Enum.TryParse(method.ToUpper(), out type))
                return type;
            return null;
        }
    }
}