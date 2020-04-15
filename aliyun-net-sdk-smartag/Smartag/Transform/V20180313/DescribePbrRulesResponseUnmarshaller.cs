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
    public class DescribePbrRulesResponseUnmarshaller
    {
        public static DescribePbrRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePbrRulesResponse describePbrRulesResponse = new DescribePbrRulesResponse();

			describePbrRulesResponse.HttpResponse = context.HttpResponse;
			describePbrRulesResponse.RequestId = context.StringValue("DescribePbrRules.RequestId");
			describePbrRulesResponse.TotalCount = context.IntegerValue("DescribePbrRules.TotalCount");
			describePbrRulesResponse.PageNumber = context.IntegerValue("DescribePbrRules.PageNumber");
			describePbrRulesResponse.PageSize = context.IntegerValue("DescribePbrRules.PageSize");

			List<DescribePbrRulesResponse.DescribePbrRules_PbrRule> describePbrRulesResponse_pbrRules = new List<DescribePbrRulesResponse.DescribePbrRules_PbrRule>();
			for (int i = 0; i < context.Length("DescribePbrRules.PbrRules.Length"); i++) {
				DescribePbrRulesResponse.DescribePbrRules_PbrRule pbrRule = new DescribePbrRulesResponse.DescribePbrRules_PbrRule();
				pbrRule.PbrRuleId = context.StringValue("DescribePbrRules.PbrRules["+ i +"].PbrRuleId");
				pbrRule.SrcCidr = context.StringValue("DescribePbrRules.PbrRules["+ i +"].SrcCidr");
				pbrRule.DstCidr = context.StringValue("DescribePbrRules.PbrRules["+ i +"].DstCidr");
				pbrRule.SrcPort = context.StringValue("DescribePbrRules.PbrRules["+ i +"].SrcPort");
				pbrRule.DstPort = context.StringValue("DescribePbrRules.PbrRules["+ i +"].DstPort");
				pbrRule.Protocol = context.StringValue("DescribePbrRules.PbrRules["+ i +"].Protocol");
				pbrRule.Name = context.StringValue("DescribePbrRules.PbrRules["+ i +"].Name");
				pbrRule.Description = context.StringValue("DescribePbrRules.PbrRules["+ i +"].Description");

				describePbrRulesResponse_pbrRules.Add(pbrRule);
			}
			describePbrRulesResponse.PbrRules = describePbrRulesResponse_pbrRules;
        
			return describePbrRulesResponse;
        }
    }
}
