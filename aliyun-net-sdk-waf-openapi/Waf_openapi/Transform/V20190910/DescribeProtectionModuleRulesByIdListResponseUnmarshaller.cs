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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeProtectionModuleRulesByIdListResponseUnmarshaller
    {
        public static DescribeProtectionModuleRulesByIdListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProtectionModuleRulesByIdListResponse describeProtectionModuleRulesByIdListResponse = new DescribeProtectionModuleRulesByIdListResponse();

			describeProtectionModuleRulesByIdListResponse.HttpResponse = context.HttpResponse;
			describeProtectionModuleRulesByIdListResponse.RequestId = context.StringValue("DescribeProtectionModuleRulesByIdList.RequestId");
			describeProtectionModuleRulesByIdListResponse.TotalCount = context.IntegerValue("DescribeProtectionModuleRulesByIdList.TotalCount");

			List<DescribeProtectionModuleRulesByIdListResponse.DescribeProtectionModuleRulesByIdList_Rule> describeProtectionModuleRulesByIdListResponse_rules = new List<DescribeProtectionModuleRulesByIdListResponse.DescribeProtectionModuleRulesByIdList_Rule>();
			for (int i = 0; i < context.Length("DescribeProtectionModuleRulesByIdList.Rules.Length"); i++) {
				DescribeProtectionModuleRulesByIdListResponse.DescribeProtectionModuleRulesByIdList_Rule rule = new DescribeProtectionModuleRulesByIdListResponse.DescribeProtectionModuleRulesByIdList_Rule();
				rule.RuleId = context.LongValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].RuleId");
				rule.Name = context.StringValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Name");
				rule.Enabled = context.IntegerValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Enabled");
				rule.Version = context.LongValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Version");
				rule.Content = context.StringValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Content");
				rule.Time = context.LongValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Time");
				rule.Status = context.LongValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Status");
				rule.Origin = context.StringValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Origin");
				rule.Scene = context.StringValue("DescribeProtectionModuleRulesByIdList.Rules["+ i +"].Scene");

				describeProtectionModuleRulesByIdListResponse_rules.Add(rule);
			}
			describeProtectionModuleRulesByIdListResponse.Rules = describeProtectionModuleRulesByIdListResponse_rules;
        
			return describeProtectionModuleRulesByIdListResponse;
        }
    }
}
