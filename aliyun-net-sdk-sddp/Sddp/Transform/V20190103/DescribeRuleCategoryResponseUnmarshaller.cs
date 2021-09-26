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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeRuleCategoryResponseUnmarshaller
    {
        public static DescribeRuleCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRuleCategoryResponse describeRuleCategoryResponse = new DescribeRuleCategoryResponse();

			describeRuleCategoryResponse.HttpResponse = _ctx.HttpResponse;
			describeRuleCategoryResponse.RequestId = _ctx.StringValue("DescribeRuleCategory.RequestId");

			List<DescribeRuleCategoryResponse.DescribeRuleCategory_Rule> describeRuleCategoryResponse_ruleList = new List<DescribeRuleCategoryResponse.DescribeRuleCategory_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRuleCategory.RuleList.Length"); i++) {
				DescribeRuleCategoryResponse.DescribeRuleCategory_Rule rule = new DescribeRuleCategoryResponse.DescribeRuleCategory_Rule();
				rule.GroupId = _ctx.StringValue("DescribeRuleCategory.RuleList["+ i +"].GroupId");
				rule.Name = _ctx.StringValue("DescribeRuleCategory.RuleList["+ i +"].Name");

				List<DescribeRuleCategoryResponse.DescribeRuleCategory_Rule.DescribeRuleCategory_ChildRule> rule_childList = new List<DescribeRuleCategoryResponse.DescribeRuleCategory_Rule.DescribeRuleCategory_ChildRule>();
				for (int j = 0; j < _ctx.Length("DescribeRuleCategory.RuleList["+ i +"].ChildList.Length"); j++) {
					DescribeRuleCategoryResponse.DescribeRuleCategory_Rule.DescribeRuleCategory_ChildRule childRule = new DescribeRuleCategoryResponse.DescribeRuleCategory_Rule.DescribeRuleCategory_ChildRule();
					childRule.Id = _ctx.LongValue("DescribeRuleCategory.RuleList["+ i +"].ChildList["+ j +"].Id");
					childRule.GroupId = _ctx.StringValue("DescribeRuleCategory.RuleList["+ i +"].ChildList["+ j +"].GroupId");
					childRule.Name = _ctx.StringValue("DescribeRuleCategory.RuleList["+ i +"].ChildList["+ j +"].Name");
					childRule.ParentId = _ctx.StringValue("DescribeRuleCategory.RuleList["+ i +"].ChildList["+ j +"].ParentId");

					rule_childList.Add(childRule);
				}
				rule.ChildList = rule_childList;

				describeRuleCategoryResponse_ruleList.Add(rule);
			}
			describeRuleCategoryResponse.RuleList = describeRuleCategoryResponse_ruleList;

			List<DescribeRuleCategoryResponse.DescribeRuleCategory_Product> describeRuleCategoryResponse_productList = new List<DescribeRuleCategoryResponse.DescribeRuleCategory_Product>();
			for (int i = 0; i < _ctx.Length("DescribeRuleCategory.ProductList.Length"); i++) {
				DescribeRuleCategoryResponse.DescribeRuleCategory_Product product = new DescribeRuleCategoryResponse.DescribeRuleCategory_Product();
				product._Value = _ctx.StringValue("DescribeRuleCategory.ProductList["+ i +"].value");
				product.Label = _ctx.StringValue("DescribeRuleCategory.ProductList["+ i +"].label");

				describeRuleCategoryResponse_productList.Add(product);
			}
			describeRuleCategoryResponse.ProductList = describeRuleCategoryResponse_productList;
        
			return describeRuleCategoryResponse;
        }
    }
}
