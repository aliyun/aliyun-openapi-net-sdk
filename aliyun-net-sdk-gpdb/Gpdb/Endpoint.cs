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

namespace Aliyun.Acs.gpdb
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "gpdb.aliyuncs.com" },
            { "cn-beijing", "gpdb.aliyuncs.com" },
            { "cn-shenzhen-finance-1", "gpdb.aliyuncs.com" },
            { "cn-north-2-gov-1", "gpdb.aliyuncs.com" },
            { "cn-qingdao", "gpdb.aliyuncs.com" },
            { "cn-shanghai", "gpdb.aliyuncs.com" },
            { "cn-shanghai-finance-1", "gpdb.aliyuncs.com" },
            { "cn-hongkong", "gpdb.aliyuncs.com" },
            { "cn-hangzhou-finance", "gpdb.aliyuncs.com" },
            { "ap-southeast-1", "gpdb.aliyuncs.com" },
            { "us-east-1", "gpdb.aliyuncs.com" },
            { "us-west-1", "gpdb.aliyuncs.com" },
            { "cn-hangzhou", "gpdb.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
