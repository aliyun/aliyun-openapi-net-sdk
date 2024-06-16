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
        public static DescribeRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRulesResponse describeRulesResponse = new DescribeRulesResponse();

			describeRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeRulesResponse.CurrentPage = _ctx.IntegerValue("DescribeRules.CurrentPage");
			describeRulesResponse.RequestId = _ctx.StringValue("DescribeRules.RequestId");
			describeRulesResponse.PageSize = _ctx.IntegerValue("DescribeRules.PageSize");
			describeRulesResponse.TotalCount = _ctx.IntegerValue("DescribeRules.TotalCount");

			List<DescribeRulesResponse.DescribeRules_Rule> describeRulesResponse_items = new List<DescribeRulesResponse.DescribeRules_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRules.Items.Length"); i++) {
				DescribeRulesResponse.DescribeRules_Rule rule = new DescribeRulesResponse.DescribeRules_Rule();
				rule.DisplayName = _ctx.StringValue("DescribeRules.Items["+ i +"].DisplayName");
				rule.Status = _ctx.IntegerValue("DescribeRules.Items["+ i +"].Status");
				rule.SupportForm = _ctx.IntegerValue("DescribeRules.Items["+ i +"].SupportForm");
				rule.WarnLevel = _ctx.IntegerValue("DescribeRules.Items["+ i +"].WarnLevel");
				rule.UserId = _ctx.LongValue("DescribeRules.Items["+ i +"].UserId");
				rule.DepartName = _ctx.StringValue("DescribeRules.Items["+ i +"].DepartName");
				rule.StatExpress = _ctx.StringValue("DescribeRules.Items["+ i +"].StatExpress");
				rule.GmtModified = _ctx.LongValue("DescribeRules.Items["+ i +"].GmtModified");
				rule.RiskLevelId = _ctx.LongValue("DescribeRules.Items["+ i +"].RiskLevelId");
				rule.Description = _ctx.StringValue("DescribeRules.Items["+ i +"].Description");
				rule.ProductId = _ctx.LongValue("DescribeRules.Items["+ i +"].ProductId");
				rule.Name = _ctx.StringValue("DescribeRules.Items["+ i +"].Name");
				rule.Content = _ctx.StringValue("DescribeRules.Items["+ i +"].Content");
				rule.Target = _ctx.StringValue("DescribeRules.Items["+ i +"].Target");
				rule.LoginName = _ctx.StringValue("DescribeRules.Items["+ i +"].LoginName");
				rule.CategoryName = _ctx.StringValue("DescribeRules.Items["+ i +"].CategoryName");
				rule.ContentCategory = _ctx.StringValue("DescribeRules.Items["+ i +"].ContentCategory");
				rule.HitTotalCount = _ctx.IntegerValue("DescribeRules.Items["+ i +"].HitTotalCount");
				rule.GroupId = _ctx.StringValue("DescribeRules.Items["+ i +"].GroupId");
				rule.CustomType = _ctx.IntegerValue("DescribeRules.Items["+ i +"].CustomType");
				rule.RiskLevelName = _ctx.StringValue("DescribeRules.Items["+ i +"].RiskLevelName");
				rule.GmtCreate = _ctx.LongValue("DescribeRules.Items["+ i +"].GmtCreate");
				rule.Category = _ctx.IntegerValue("DescribeRules.Items["+ i +"].Category");
				rule.MajorKey = _ctx.StringValue("DescribeRules.Items["+ i +"].MajorKey");
				rule.Id = _ctx.LongValue("DescribeRules.Items["+ i +"].Id");
				rule.ProductCode = _ctx.StringValue("DescribeRules.Items["+ i +"].ProductCode");
				rule.MatchType = _ctx.IntegerValue("DescribeRules.Items["+ i +"].MatchType");

				describeRulesResponse_items.Add(rule);
			}
			describeRulesResponse.Items = describeRulesResponse_items;
        
			return describeRulesResponse;
        }
    }
}
