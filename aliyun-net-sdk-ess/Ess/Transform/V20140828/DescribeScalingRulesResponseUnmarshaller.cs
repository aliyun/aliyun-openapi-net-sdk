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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ess.Model.V20140828;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingRulesResponseUnmarshaller
    {
        public static DescribeScalingRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingRulesResponse describeScalingRulesResponse = new DescribeScalingRulesResponse();

			describeScalingRulesResponse.HttpResponse = context.HttpResponse;
			describeScalingRulesResponse.TotalCount = context.IntegerValue("DescribeScalingRules.TotalCount");
			describeScalingRulesResponse.PageNumber = context.IntegerValue("DescribeScalingRules.PageNumber");
			describeScalingRulesResponse.PageSize = context.IntegerValue("DescribeScalingRules.PageSize");
			describeScalingRulesResponse.RequestId = context.StringValue("DescribeScalingRules.RequestId");

			List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule> describeScalingRulesResponse_scalingRules = new List<DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule>();
			for (int i = 0; i < context.Length("DescribeScalingRules.ScalingRules.Length"); i++) {
				DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule scalingRule = new DescribeScalingRulesResponse.DescribeScalingRules_ScalingRule();
				scalingRule.ScalingRuleId = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleId");
				scalingRule.ScalingGroupId = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingGroupId");
				scalingRule.ScalingRuleName = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleName");
				scalingRule.Cooldown = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].Cooldown");
				scalingRule.AdjustmentType = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].AdjustmentType");
				scalingRule.AdjustmentValue = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].AdjustmentValue");
				scalingRule.MinSize = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].MinSize");
				scalingRule.MaxSize = context.IntegerValue("DescribeScalingRules.ScalingRules["+ i +"].MaxSize");
				scalingRule.ScalingRuleAri = context.StringValue("DescribeScalingRules.ScalingRules["+ i +"].ScalingRuleAri");

				describeScalingRulesResponse_scalingRules.Add(scalingRule);
			}
			describeScalingRulesResponse.ScalingRules = describeScalingRulesResponse_scalingRules;
        
			return describeScalingRulesResponse;
        }
    }
}