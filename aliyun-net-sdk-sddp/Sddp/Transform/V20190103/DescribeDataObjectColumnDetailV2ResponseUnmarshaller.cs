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
    public class DescribeDataObjectColumnDetailV2ResponseUnmarshaller
    {
        public static DescribeDataObjectColumnDetailV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataObjectColumnDetailV2Response describeDataObjectColumnDetailV2Response = new DescribeDataObjectColumnDetailV2Response();

			describeDataObjectColumnDetailV2Response.HttpResponse = _ctx.HttpResponse;
			describeDataObjectColumnDetailV2Response.CurrentPage = _ctx.IntegerValue("DescribeDataObjectColumnDetailV2.CurrentPage");
			describeDataObjectColumnDetailV2Response.RequestId = _ctx.StringValue("DescribeDataObjectColumnDetailV2.RequestId");
			describeDataObjectColumnDetailV2Response.PageSize = _ctx.IntegerValue("DescribeDataObjectColumnDetailV2.PageSize");
			describeDataObjectColumnDetailV2Response.TotalCount = _ctx.IntegerValue("DescribeDataObjectColumnDetailV2.TotalCount");

			List<DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule> describeDataObjectColumnDetailV2Response_items = new List<DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeDataObjectColumnDetailV2.Items.Length"); i++) {
				DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule rule = new DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule();
				rule.ColumnName = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].ColumnName");
				rule.DataType = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].DataType");
				rule.ColumnComment = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].ColumnComment");
				rule.PrimaryKey = _ctx.BooleanValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].PrimaryKey");
				rule.Id = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].Id");
				rule.RiskLevelId = _ctx.LongValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].RiskLevelId");
				rule.RiskLevelName = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].RiskLevelName");
				rule.RuleId = _ctx.LongValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].RuleId");
				rule.RuleName = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].RuleName");

				List<string> rule_categories = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjectColumnDetailV2.Items["+ i +"].Categories.Length"); j++) {
					rule_categories.Add(_ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].Categories["+ j +"]"));
				}
				rule.Categories = rule_categories;

				List<DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule.DescribeDataObjectColumnDetailV2_ModelTagsItem> rule_modelTags = new List<DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule.DescribeDataObjectColumnDetailV2_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjectColumnDetailV2.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule.DescribeDataObjectColumnDetailV2_ModelTagsItem modelTagsItem = new DescribeDataObjectColumnDetailV2Response.DescribeDataObjectColumnDetailV2_Rule.DescribeDataObjectColumnDetailV2_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeDataObjectColumnDetailV2.Items["+ i +"].ModelTags["+ j +"].Name");

					rule_modelTags.Add(modelTagsItem);
				}
				rule.ModelTags = rule_modelTags;

				describeDataObjectColumnDetailV2Response_items.Add(rule);
			}
			describeDataObjectColumnDetailV2Response.Items = describeDataObjectColumnDetailV2Response_items;
        
			return describeDataObjectColumnDetailV2Response;
        }
    }
}
