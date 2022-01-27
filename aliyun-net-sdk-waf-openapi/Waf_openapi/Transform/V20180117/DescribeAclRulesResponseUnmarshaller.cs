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
    public class DescribeAclRulesResponseUnmarshaller
    {
        public static DescribeAclRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAclRulesResponse describeAclRulesResponse = new DescribeAclRulesResponse();

			describeAclRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeAclRulesResponse.RequestId = _ctx.StringValue("DescribeAclRules.RequestId");

			DescribeAclRulesResponse.DescribeAclRules_Result result = new DescribeAclRulesResponse.DescribeAclRules_Result();
			result.Total = _ctx.IntegerValue("DescribeAclRules.Result.Total");

			List<DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule> result_aclRules = new List<DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule>();
			for (int i = 0; i < _ctx.Length("DescribeAclRules.Result.AclRules.Length"); i++) {
				DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule aclRule = new DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule();
				aclRule.ContinueWaf = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueWaf");
				aclRule.ContinueBlockGeo = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueBlockGeo");
				aclRule.ContinueSA = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueSA");
				aclRule.ContinueSdk = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueSdk");
				aclRule.ContinueDataRiskControl = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueDataRiskControl");
				aclRule.ContinueCc = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].ContinueCc");
				aclRule.IsDefault = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].IsDefault");
				aclRule.Name = _ctx.StringValue("DescribeAclRules.Result.AclRules["+ i +"].Name");
				aclRule.Action = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].Action");
				aclRule.Id = _ctx.LongValue("DescribeAclRules.Result.AclRules["+ i +"].Id");
				aclRule.Order = _ctx.IntegerValue("DescribeAclRules.Result.AclRules["+ i +"].Order");

				List<DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule.DescribeAclRules_Condition> aclRule_conditions = new List<DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule.DescribeAclRules_Condition>();
				for (int j = 0; j < _ctx.Length("DescribeAclRules.Result.AclRules["+ i +"].Conditions.Length"); j++) {
					DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule.DescribeAclRules_Condition condition = new DescribeAclRulesResponse.DescribeAclRules_Result.DescribeAclRules_AclRule.DescribeAclRules_Condition();
					condition.Contain = _ctx.StringValue("DescribeAclRules.Result.AclRules["+ i +"].Conditions["+ j +"].Contain");
					condition._Value = _ctx.StringValue("DescribeAclRules.Result.AclRules["+ i +"].Conditions["+ j +"].Value");
					condition.Key = _ctx.StringValue("DescribeAclRules.Result.AclRules["+ i +"].Conditions["+ j +"].Key");

					aclRule_conditions.Add(condition);
				}
				aclRule.Conditions = aclRule_conditions;

				result_aclRules.Add(aclRule);
			}
			result.AclRules = result_aclRules;
			describeAclRulesResponse.Result = result;
        
			return describeAclRulesResponse;
        }
    }
}
