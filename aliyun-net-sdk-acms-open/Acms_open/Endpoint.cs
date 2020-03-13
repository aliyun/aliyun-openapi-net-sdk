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

namespace Aliyun.Acs.acms_open
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "acm.cn-shenzhen.aliyuncs.com" },
            { "cn-beijing", "acm.cn-beijing.aliyuncs.com" },
            { "cn-shenzhen-finance-1", "acm.cn-shenzhen-finance-1.aliyuncs.com" },
            { "cn-north-2-gov-1", "acm.cn-north-2-gov-1.aliyuncs.com" },
            { "cn-qingdao", "acm.cn-qingdao.aliyuncs.com" },
            { "cn-shanghai", "acm.cn-shanghai.aliyuncs.com" },
            { "cn-shanghai-finance-1", "acm.cn-shanghai-finance-1.aliyuncs.com" },
            { "cn-hongkong", "acm.cn-hongkong.aliyuncs.com" },
            { "cn-hangzhou-finance", "acm.cn-hangzhou-finance.aliyuncs.com" },
            { "ap-southeast-1", "acm.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-2", "acm.ap-southeast-2.aliyuncs.com" },
            { "eu-central-1", "acm.eu-central-1.aliyuncs.com" },
            { "us-east-1", "acm.us-east-1.aliyuncs.com" },
            { "cn-zhangjiakou", "acm.cn-zhangjiakou.aliyuncs.com" },
            { "us-west-1", "acm.us-west-1.aliyuncs.com" },
            { "cn-hangzhou", "acm.cn-hangzhou.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
