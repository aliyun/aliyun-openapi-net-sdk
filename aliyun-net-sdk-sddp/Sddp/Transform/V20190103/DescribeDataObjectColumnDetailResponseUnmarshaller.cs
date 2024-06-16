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
    public class DescribeDataObjectColumnDetailResponseUnmarshaller
    {
        public static DescribeDataObjectColumnDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataObjectColumnDetailResponse describeDataObjectColumnDetailResponse = new DescribeDataObjectColumnDetailResponse();

			describeDataObjectColumnDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDataObjectColumnDetailResponse.CurrentPage = _ctx.IntegerValue("DescribeDataObjectColumnDetail.CurrentPage");
			describeDataObjectColumnDetailResponse.RequestId = _ctx.StringValue("DescribeDataObjectColumnDetail.RequestId");
			describeDataObjectColumnDetailResponse.PageSize = _ctx.IntegerValue("DescribeDataObjectColumnDetail.PageSize");
			describeDataObjectColumnDetailResponse.TotalCount = _ctx.IntegerValue("DescribeDataObjectColumnDetail.TotalCount");

			List<DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule> describeDataObjectColumnDetailResponse_items = new List<DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeDataObjectColumnDetail.Items.Length"); i++) {
				DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule rule = new DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule();
				rule.ColumnName = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].ColumnName");
				rule.DataType = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].DataType");
				rule.ColumnComment = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].ColumnComment");
				rule.PrimaryKey = _ctx.BooleanValue("DescribeDataObjectColumnDetail.Items["+ i +"].PrimaryKey");
				rule.Id = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].Id");
				rule.RiskLevelId = _ctx.LongValue("DescribeDataObjectColumnDetail.Items["+ i +"].RiskLevelId");
				rule.RiskLevelName = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].RiskLevelName");
				rule.RuleId = _ctx.LongValue("DescribeDataObjectColumnDetail.Items["+ i +"].RuleId");
				rule.RuleName = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].RuleName");

				List<string> rule_categories = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjectColumnDetail.Items["+ i +"].Categories.Length"); j++) {
					rule_categories.Add(_ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].Categories["+ j +"]"));
				}
				rule.Categories = rule_categories;

				List<DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule.DescribeDataObjectColumnDetail_ModelTagsItem> rule_modelTags = new List<DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule.DescribeDataObjectColumnDetail_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataObjectColumnDetail.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule.DescribeDataObjectColumnDetail_ModelTagsItem modelTagsItem = new DescribeDataObjectColumnDetailResponse.DescribeDataObjectColumnDetail_Rule.DescribeDataObjectColumnDetail_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeDataObjectColumnDetail.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeDataObjectColumnDetail.Items["+ i +"].ModelTags["+ j +"].Name");

					rule_modelTags.Add(modelTagsItem);
				}
				rule.ModelTags = rule_modelTags;

				describeDataObjectColumnDetailResponse_items.Add(rule);
			}
			describeDataObjectColumnDetailResponse.Items = describeDataObjectColumnDetailResponse_items;
        
			return describeDataObjectColumnDetailResponse;
        }
    }
}
