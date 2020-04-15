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
    public class DescribeGrantSagVbrRulesResponseUnmarshaller
    {
        public static DescribeGrantSagVbrRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGrantSagVbrRulesResponse describeGrantSagVbrRulesResponse = new DescribeGrantSagVbrRulesResponse();

			describeGrantSagVbrRulesResponse.HttpResponse = context.HttpResponse;
			describeGrantSagVbrRulesResponse.RequestId = context.StringValue("DescribeGrantSagVbrRules.RequestId");
			describeGrantSagVbrRulesResponse.TotalCount = context.IntegerValue("DescribeGrantSagVbrRules.TotalCount");
			describeGrantSagVbrRulesResponse.PageNumber = context.IntegerValue("DescribeGrantSagVbrRules.PageNumber");
			describeGrantSagVbrRulesResponse.PageSize = context.IntegerValue("DescribeGrantSagVbrRules.PageSize");

			List<DescribeGrantSagVbrRulesResponse.DescribeGrantSagVbrRules_GrantRule> describeGrantSagVbrRulesResponse_grantRules = new List<DescribeGrantSagVbrRulesResponse.DescribeGrantSagVbrRules_GrantRule>();
			for (int i = 0; i < context.Length("DescribeGrantSagVbrRules.GrantRules.Length"); i++) {
				DescribeGrantSagVbrRulesResponse.DescribeGrantSagVbrRules_GrantRule grantRule = new DescribeGrantSagVbrRulesResponse.DescribeGrantSagVbrRules_GrantRule();
				grantRule.CreateTime = context.LongValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].CreateTime");
				grantRule.InstanceId = context.StringValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].InstanceId");
				grantRule.VbrUid = context.LongValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].VbrUid");
				grantRule.VbrInstanceId = context.StringValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].VbrInstanceId");
				grantRule.VbrRegionId = context.StringValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].VbrRegionId");
				grantRule.SmartAGUid = context.LongValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].SmartAGUid");
				grantRule.SmartAGId = context.StringValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].SmartAGId");
				grantRule.Bound = context.BooleanValue("DescribeGrantSagVbrRules.GrantRules["+ i +"].Bound");

				describeGrantSagVbrRulesResponse_grantRules.Add(grantRule);
			}
			describeGrantSagVbrRulesResponse.GrantRules = describeGrantSagVbrRulesResponse_grantRules;
        
			return describeGrantSagVbrRulesResponse;
        }
    }
}
