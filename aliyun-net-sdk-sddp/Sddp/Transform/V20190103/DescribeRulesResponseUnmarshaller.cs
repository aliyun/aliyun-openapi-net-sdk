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
    public class DescribeRulesResponseUnmarshaller
    {
        public static DescribeRulesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRulesResponse describeRulesResponse = new DescribeRulesResponse();

			describeRulesResponse.HttpResponse = context.HttpResponse;
			describeRulesResponse.RequestId = context.StringValue("DescribeRules.RequestId");
			describeRulesResponse.PageSize = context.IntegerValue("DescribeRules.PageSize");
			describeRulesResponse.CurrentPage = context.IntegerValue("DescribeRules.CurrentPage");
			describeRulesResponse.TotalCount = context.IntegerValue("DescribeRules.TotalCount");

			List<DescribeRulesResponse.DescribeRules_Rule> describeRulesResponse_items = new List<DescribeRulesResponse.DescribeRules_Rule>();
			for (int i = 0; i < context.Length("DescribeRules.Items.Length"); i++) {
				DescribeRulesResponse.DescribeRules_Rule rule = new DescribeRulesResponse.DescribeRules_Rule();
				rule.Id = context.LongValue("DescribeRules.Items["+ i +"].Id");
				rule.GmtCreate = context.LongValue("DescribeRules.Items["+ i +"].GmtCreate");
				rule.GmtModified = context.LongValue("DescribeRules.Items["+ i +"].GmtModified");
				rule.CustomType = context.IntegerValue("DescribeRules.Items["+ i +"].CustomType");
				rule.Name = context.StringValue("DescribeRules.Items["+ i +"].Name");
				rule.Description = context.StringValue("DescribeRules.Items["+ i +"].Description");
				rule.UserId = context.LongValue("DescribeRules.Items["+ i +"].UserId");
				rule.LoginName = context.StringValue("DescribeRules.Items["+ i +"].LoginName");
				rule.DisplayName = context.StringValue("DescribeRules.Items["+ i +"].DisplayName");
				rule.Category = context.IntegerValue("DescribeRules.Items["+ i +"].Category");
				rule.CategoryName = context.StringValue("DescribeRules.Items["+ i +"].CategoryName");
				rule.Status = context.IntegerValue("DescribeRules.Items["+ i +"].Status");
				rule.RiskLevelName = context.StringValue("DescribeRules.Items["+ i +"].RiskLevelName");
				rule.RiskLevelId = context.LongValue("DescribeRules.Items["+ i +"].RiskLevelId");
				rule.Content = context.StringValue("DescribeRules.Items["+ i +"].Content");
				rule.DepartName = context.StringValue("DescribeRules.Items["+ i +"].DepartName");
				rule.StatExpress = context.StringValue("DescribeRules.Items["+ i +"].StatExpress");
				rule.ProductId = context.LongValue("DescribeRules.Items["+ i +"].ProductId");
				rule.HitTotalCount = context.IntegerValue("DescribeRules.Items["+ i +"].HitTotalCount");
				rule.ProductCode = context.StringValue("DescribeRules.Items["+ i +"].ProductCode");
				rule.WarnLevel = context.IntegerValue("DescribeRules.Items["+ i +"].WarnLevel");
				rule.MajorKey = context.StringValue("DescribeRules.Items["+ i +"].MajorKey");

				describeRulesResponse_items.Add(rule);
			}
			describeRulesResponse.Items = describeRulesResponse_items;
        
			return describeRulesResponse;
        }
    }
}
