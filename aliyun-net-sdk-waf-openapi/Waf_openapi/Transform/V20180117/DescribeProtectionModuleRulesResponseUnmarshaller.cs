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

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.waf_openapi.Model.V20180117;

namespace Aliyun.Acs.waf_openapi.Transform.V20180117
{
    public class DescribeProtectionModuleRulesResponseUnmarshaller
    {
        public static DescribeProtectionModuleRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProtectionModuleRulesResponse describeProtectionModuleRulesResponse = new DescribeProtectionModuleRulesResponse();

			describeProtectionModuleRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeProtectionModuleRulesResponse.RequestId = _ctx.StringValue("DescribeProtectionModuleRules.RequestId");
			describeProtectionModuleRulesResponse.TaskStatus = _ctx.IntegerValue("DescribeProtectionModuleRules.TaskStatus");
			describeProtectionModuleRulesResponse.Total = _ctx.IntegerValue("DescribeProtectionModuleRules.Total");

			List<DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_ModuleRulesItem> describeProtectionModuleRulesResponse_moduleRules = new List<DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_ModuleRulesItem>();
			for (int i = 0; i < _ctx.Length("DescribeProtectionModuleRules.ModuleRules.Length"); i++) {
				DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_ModuleRulesItem moduleRulesItem = new DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_ModuleRulesItem();
				moduleRulesItem.Id = _ctx.LongValue("DescribeProtectionModuleRules.ModuleRules["+ i +"].Id");
				moduleRulesItem.Version = _ctx.LongValue("DescribeProtectionModuleRules.ModuleRules["+ i +"].Version");
				moduleRulesItem.Content = _ctx.StringValue("DescribeProtectionModuleRules.ModuleRules["+ i +"].Content");
				moduleRulesItem.Time = _ctx.LongValue("DescribeProtectionModuleRules.ModuleRules["+ i +"].Time");

				describeProtectionModuleRulesResponse_moduleRules.Add(moduleRulesItem);
			}
			describeProtectionModuleRulesResponse.ModuleRules = describeProtectionModuleRulesResponse_moduleRules;
        
			return describeProtectionModuleRulesResponse;
        }
    }
}
