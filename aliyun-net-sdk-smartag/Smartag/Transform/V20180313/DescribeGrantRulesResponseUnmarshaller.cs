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
    public class DescribeGrantRulesResponseUnmarshaller
    {
        public static DescribeGrantRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGrantRulesResponse describeGrantRulesResponse = new DescribeGrantRulesResponse();

			describeGrantRulesResponse.HttpResponse = context.HttpResponse;
			describeGrantRulesResponse.RequestId = context.StringValue("DescribeGrantRules.RequestId");
			describeGrantRulesResponse.TotalCount = context.IntegerValue("DescribeGrantRules.TotalCount");
			describeGrantRulesResponse.PageNumber = context.IntegerValue("DescribeGrantRules.PageNumber");
			describeGrantRulesResponse.PageSize = context.IntegerValue("DescribeGrantRules.PageSize");

			List<DescribeGrantRulesResponse.DescribeGrantRules_GrantRule> describeGrantRulesResponse_grantRules = new List<DescribeGrantRulesResponse.DescribeGrantRules_GrantRule>();
			for (int i = 0; i < context.Length("DescribeGrantRules.GrantRules.Length"); i++) {
				DescribeGrantRulesResponse.DescribeGrantRules_GrantRule grantRule = new DescribeGrantRulesResponse.DescribeGrantRules_GrantRule();
				grantRule.GrantRuleId = context.StringValue("DescribeGrantRules.GrantRules["+ i +"].GrantRuleId");
				grantRule.CenUid = context.LongValue("DescribeGrantRules.GrantRules["+ i +"].CenUid");
				grantRule.CcnUid = context.LongValue("DescribeGrantRules.GrantRules["+ i +"].CcnUid");
				grantRule.CenInstanceId = context.StringValue("DescribeGrantRules.GrantRules["+ i +"].CenInstanceId");
				grantRule.CcnInstanceId = context.StringValue("DescribeGrantRules.GrantRules["+ i +"].CcnInstanceId");
				grantRule.GmtCreate = context.LongValue("DescribeGrantRules.GrantRules["+ i +"].GmtCreate");
				grantRule.GmtModified = context.LongValue("DescribeGrantRules.GrantRules["+ i +"].GmtModified");
				grantRule.RegionId = context.StringValue("DescribeGrantRules.GrantRules["+ i +"].RegionId");

				describeGrantRulesResponse_grantRules.Add(grantRule);
			}
			describeGrantRulesResponse.GrantRules = describeGrantRulesResponse_grantRules;
        
			return describeGrantRulesResponse;
        }
    }
}
