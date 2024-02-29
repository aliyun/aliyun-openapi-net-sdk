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
    public class DescribeColumnsV2ResponseUnmarshaller
    {
        public static DescribeColumnsV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeColumnsV2Response describeColumnsV2Response = new DescribeColumnsV2Response();

			describeColumnsV2Response.HttpResponse = _ctx.HttpResponse;
			describeColumnsV2Response.CurrentPage = _ctx.IntegerValue("DescribeColumnsV2.CurrentPage");
			describeColumnsV2Response.RequestId = _ctx.StringValue("DescribeColumnsV2.RequestId");
			describeColumnsV2Response.PageSize = _ctx.IntegerValue("DescribeColumnsV2.PageSize");
			describeColumnsV2Response.TotalCount = _ctx.IntegerValue("DescribeColumnsV2.TotalCount");

			List<DescribeColumnsV2Response.DescribeColumnsV2_Column> describeColumnsV2Response_items = new List<DescribeColumnsV2Response.DescribeColumnsV2_Column>();
			for (int i = 0; i < _ctx.Length("DescribeColumnsV2.Items.Length"); i++) {
				DescribeColumnsV2Response.DescribeColumnsV2_Column column = new DescribeColumnsV2Response.DescribeColumnsV2_Column();
				column.CreationTime = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].CreationTime");
				column.TableName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].TableName");
				column.DataType = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].DataType");
				column.OdpsRiskLevelValue = _ctx.IntegerValue("DescribeColumnsV2.Items["+ i +"].OdpsRiskLevelValue");
				column.DepartName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].DepartName");
				column.InstanceId = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].InstanceId");
				column.RiskLevelId = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].RiskLevelId");
				column.RuleName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].RuleName");
				column.RuleId = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].RuleId");
				column.Sensitive = _ctx.BooleanValue("DescribeColumnsV2.Items["+ i +"].Sensitive");
				column.SensLevelName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].SensLevelName");
				column.InstanceName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].InstanceName");
				column.RiskLevelName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].RiskLevelName");
				column.OdpsRiskLevelName = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].OdpsRiskLevelName");
				column.Name = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].Name");
				column.TableId = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].TableId");
				column.Id = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].Id");
				column.ProductCode = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].ProductCode");
				column.RevisionStatus = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].RevisionStatus");
				column.RevisionId = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].RevisionId");

				List<string> column_sampleList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeColumnsV2.Items["+ i +"].SampleList.Length"); j++) {
					column_sampleList.Add(_ctx.StringValue("DescribeColumnsV2.Items["+ i +"].SampleList["+ j +"]"));
				}
				column.SampleList = column_sampleList;

				List<DescribeColumnsV2Response.DescribeColumnsV2_Column.DescribeColumnsV2_ModelTagsItem> column_modelTags = new List<DescribeColumnsV2Response.DescribeColumnsV2_Column.DescribeColumnsV2_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeColumnsV2.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeColumnsV2Response.DescribeColumnsV2_Column.DescribeColumnsV2_ModelTagsItem modelTagsItem = new DescribeColumnsV2Response.DescribeColumnsV2_Column.DescribeColumnsV2_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeColumnsV2.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeColumnsV2.Items["+ i +"].ModelTags["+ j +"].Name");

					column_modelTags.Add(modelTagsItem);
				}
				column.ModelTags = column_modelTags;

				describeColumnsV2Response_items.Add(column);
			}
			describeColumnsV2Response.Items = describeColumnsV2Response_items;
        
			return describeColumnsV2Response;
        }
    }
}
