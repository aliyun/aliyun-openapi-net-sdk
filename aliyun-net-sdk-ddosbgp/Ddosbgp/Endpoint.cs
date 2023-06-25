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

namespace Aliyun.Acs.ddosbgp
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "cn-shenzhen", "ddosbgp.aliyuncs.com" },
            { "cn-beijing", "ddosbgp.aliyuncs.com" },
            { "ap-south-1", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "eu-west-1", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "ap-northeast-1", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "cn-shenzhen-finance-1", "ddosbgp.aliyuncs.com" },
            { "me-east-1", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "cn-chengdu", "ddosbgp.aliyuncs.com" },
            { "cn-north-2-gov-1", "ddosbgp.aliyuncs.com" },
            { "cn-qingdao", "ddosbgp.aliyuncs.com" },
            { "cn-shanghai", "ddosbgp.aliyuncs.com" },
            { "cn-shanghai-finance-1", "ddosbgp.aliyuncs.com" },
            { "cn-hangzhou-finance", "ddosbgp.aliyuncs.com" },
            { "ap-southeast-2", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-3", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "eu-central-1", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "cn-huhehaote", "ddosbgp.aliyuncs.com" },
            { "ap-southeast-5", "ddosbgp.ap-southeast-1.aliyuncs.com" },
            { "cn-zhangjiakou", "ddosbgp.aliyuncs.com" },
            { "cn-hangzhou", "ddosbgp.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
