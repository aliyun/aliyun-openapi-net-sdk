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

namespace Aliyun.Acs.sgw
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-qingdao", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-beijing", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-hongkong", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-huhehaote", "sgw.cn-shanghai.aliyuncs.com" },
            { "us-east-1", "sgw.us-west-1.aliyuncs.com" },
            { "cn-zhangjiakou", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-chengdu", "sgw.cn-shanghai.aliyuncs.com" },
            { "cn-hangzhou", "sgw.cn-shanghai.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
