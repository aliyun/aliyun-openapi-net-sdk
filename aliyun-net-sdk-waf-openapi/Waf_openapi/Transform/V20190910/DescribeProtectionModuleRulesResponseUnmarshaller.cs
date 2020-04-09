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
    public class DescribeProtectionModuleRulesResponseUnmarshaller
    {
        public static DescribeProtectionModuleRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProtectionModuleRulesResponse describeProtectionModuleRulesResponse = new DescribeProtectionModuleRulesResponse();

			describeProtectionModuleRulesResponse.HttpResponse = context.HttpResponse;
			describeProtectionModuleRulesResponse.RequestId = context.StringValue("DescribeProtectionModuleRules.RequestId");
			describeProtectionModuleRulesResponse.TotalCount = context.IntegerValue("DescribeProtectionModuleRules.TotalCount");

			List<DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_Rule> describeProtectionModuleRulesResponse_rules = new List<DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_Rule>();
			for (int i = 0; i < context.Length("DescribeProtectionModuleRules.Rules.Length"); i++) {
				DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_Rule rule = new DescribeProtectionModuleRulesResponse.DescribeProtectionModuleRules_Rule();
				rule.RuleId = context.LongValue("DescribeProtectionModuleRules.Rules["+ i +"].RuleId");
				rule.Version = context.LongValue("DescribeProtectionModuleRules.Rules["+ i +"].Version");
				rule.Content = context.StringValue("DescribeProtectionModuleRules.Rules["+ i +"].Content");
				rule.Time = context.LongValue("DescribeProtectionModuleRules.Rules["+ i +"].Time");
				rule.Status = context.LongValue("DescribeProtectionModuleRules.Rules["+ i +"].Status");

				describeProtectionModuleRulesResponse_rules.Add(rule);
			}
			describeProtectionModuleRulesResponse.Rules = describeProtectionModuleRulesResponse_rules;
        
			return describeProtectionModuleRulesResponse;
        }
    }
}
