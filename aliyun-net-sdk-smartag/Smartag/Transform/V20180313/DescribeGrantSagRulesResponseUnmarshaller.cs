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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeGrantSagRulesResponseUnmarshaller
    {
        public static DescribeGrantSagRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGrantSagRulesResponse describeGrantSagRulesResponse = new DescribeGrantSagRulesResponse();

			describeGrantSagRulesResponse.HttpResponse = context.HttpResponse;
			describeGrantSagRulesResponse.RequestId = context.StringValue("DescribeGrantSagRules.RequestId");
			describeGrantSagRulesResponse.TotalCount = context.IntegerValue("DescribeGrantSagRules.TotalCount");
			describeGrantSagRulesResponse.PageNumber = context.IntegerValue("DescribeGrantSagRules.PageNumber");
			describeGrantSagRulesResponse.PageSize = context.IntegerValue("DescribeGrantSagRules.PageSize");

			List<DescribeGrantSagRulesResponse.DescribeGrantSagRules_GrantRule> describeGrantSagRulesResponse_grantRules = new List<DescribeGrantSagRulesResponse.DescribeGrantSagRules_GrantRule>();
			for (int i = 0; i < context.Length("DescribeGrantSagRules.GrantRules.Length"); i++) {
				DescribeGrantSagRulesResponse.DescribeGrantSagRules_GrantRule grantRule = new DescribeGrantSagRulesResponse.DescribeGrantSagRules_GrantRule();
				grantRule.InstanceId = context.StringValue("DescribeGrantSagRules.GrantRules["+ i +"].InstanceId");
				grantRule.SmartAGId = context.StringValue("DescribeGrantSagRules.GrantRules["+ i +"].SmartAGId");
				grantRule.CreateTime = context.LongValue("DescribeGrantSagRules.GrantRules["+ i +"].CreateTime");
				grantRule.CcnUid = context.LongValue("DescribeGrantSagRules.GrantRules["+ i +"].CcnUid");
				grantRule.CcnInstanceId = context.StringValue("DescribeGrantSagRules.GrantRules["+ i +"].CcnInstanceId");

				describeGrantSagRulesResponse_grantRules.Add(grantRule);
			}
			describeGrantSagRulesResponse.GrantRules = describeGrantSagRulesResponse_grantRules;
        
			return describeGrantSagRulesResponse;
        }
    }
}
