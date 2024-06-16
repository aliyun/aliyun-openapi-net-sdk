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
    public class DescribeDataObjectsResponseUnmarshaller
    {
        public static DescribeDataObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataObjectsResponse describeDataObjectsResponse = new DescribeDataObjectsResponse();

			describeDataObjectsResponse.HttpResponse = _ctx.HttpResponse;
			describeDataObjectsResponse.CurrentPage = _ctx.IntegerValue("DescribeDataObjects.CurrentPage");
			describeDataObjectsResponse.RequestId = _ctx.StringValue("DescribeDataObjects.RequestId");
			describeDataObjectsResponse.PageSize = _ctx.IntegerValue("DescribeDataObjects.PageSize");
			describeDataObjectsResponse.TotalCount = _ctx.IntegerValue("DescribeDataObjects.TotalCount");

			List<DescribeDataObjectsResponse.DescribeDataObjects_Rule> describeDataObjectsResponse_items = new List<DescribeDataObjectsResponse.DescribeDataObjects_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeDataObjects.Items.Length"); i++) {
				DescribeDataObjectsResponse.DescribeDataObjects_Rule rule = new DescribeDataObjectsResponse.DescribeDataObjects_Rule();
				rule.Name = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].Name");
				rule.Id = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].Id");
				rule.TemplateId = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].TemplateId");
				rule.ProductId = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].ProductId");
				rule.InstanceDescription = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].InstanceDescription");
				rule.ProductCode = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].ProductCode");
				rule.InstanceId = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].InstanceId");
				rule.LastScanTime = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].LastScanTime");
				rule.SensitiveCount = _ctx.IntegerValue("DescribeDataObjects.Items["+ i +"].SensitiveCount");
				rule.ObjectType = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].ObjectType");
				rule.Path = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].Path");
				rule.RegionName = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].RegionName");
				rule.ObjectFileCategory = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].ObjectFileCategory");

				List<string> rule_categories = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjects.Items["+ i +"].Categories.Length"); j++) {
					rule_categories.Add(_ctx.StringValue("DescribeDataObjects.Items["+ i +"].Categories["+ j +"]"));
				}
				rule.Categories = rule_categories;

				List<DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_ModelTagsItem> rule_modelTags = new List<DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjects.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_ModelTagsItem modelTagsItem = new DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].ModelTags["+ j +"].Name");

					rule_modelTags.Add(modelTagsItem);
				}
				rule.ModelTags = rule_modelTags;

				List<DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_RuleListItem> rule_ruleList = new List<DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_RuleListItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjects.Items["+ i +"].RuleList.Length"); j++) {
					DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_RuleListItem ruleListItem = new DescribeDataObjectsResponse.DescribeDataObjects_Rule.DescribeDataObjects_RuleListItem();
					ruleListItem.RuleId = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].RuleList["+ j +"].RuleId");
					ruleListItem.RuleName = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].RuleList["+ j +"].RuleName");
					ruleListItem.RiskLevelId = _ctx.LongValue("DescribeDataObjects.Items["+ i +"].RuleList["+ j +"].RiskLevelId");
					ruleListItem.RiskLevelName = _ctx.StringValue("DescribeDataObjects.Items["+ i +"].RuleList["+ j +"].RiskLevelName");
					ruleListItem.RuleCount = _ctx.IntegerValue("DescribeDataObjects.Items["+ i +"].RuleList["+ j +"].RuleCount");

					rule_ruleList.Add(ruleListItem);
				}
				rule.RuleList = rule_ruleList;

				describeDataObjectsResponse_items.Add(rule);
			}
			describeDataObjectsResponse.Items = describeDataObjectsResponse_items;
        
			return describeDataObjectsResponse;
        }
    }
}
