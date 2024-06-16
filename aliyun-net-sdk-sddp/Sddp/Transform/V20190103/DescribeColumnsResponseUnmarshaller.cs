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
    public class DescribeColumnsResponseUnmarshaller
    {
        public static DescribeColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeColumnsResponse describeColumnsResponse = new DescribeColumnsResponse();

			describeColumnsResponse.HttpResponse = _ctx.HttpResponse;
			describeColumnsResponse.CurrentPage = _ctx.IntegerValue("DescribeColumns.CurrentPage");
			describeColumnsResponse.RequestId = _ctx.StringValue("DescribeColumns.RequestId");
			describeColumnsResponse.PageSize = _ctx.IntegerValue("DescribeColumns.PageSize");
			describeColumnsResponse.TotalCount = _ctx.IntegerValue("DescribeColumns.TotalCount");

			List<DescribeColumnsResponse.DescribeColumns_Column> describeColumnsResponse_items = new List<DescribeColumnsResponse.DescribeColumns_Column>();
			for (int i = 0; i < _ctx.Length("DescribeColumns.Items.Length"); i++) {
				DescribeColumnsResponse.DescribeColumns_Column column = new DescribeColumnsResponse.DescribeColumns_Column();
				column.CreationTime = _ctx.LongValue("DescribeColumns.Items["+ i +"].CreationTime");
				column.TableName = _ctx.StringValue("DescribeColumns.Items["+ i +"].TableName");
				column.DataType = _ctx.StringValue("DescribeColumns.Items["+ i +"].DataType");
				column.OdpsRiskLevelValue = _ctx.IntegerValue("DescribeColumns.Items["+ i +"].OdpsRiskLevelValue");
				column.DepartName = _ctx.StringValue("DescribeColumns.Items["+ i +"].DepartName");
				column.InstanceId = _ctx.LongValue("DescribeColumns.Items["+ i +"].InstanceId");
				column.RiskLevelId = _ctx.LongValue("DescribeColumns.Items["+ i +"].RiskLevelId");
				column.RuleName = _ctx.StringValue("DescribeColumns.Items["+ i +"].RuleName");
				column.RuleId = _ctx.LongValue("DescribeColumns.Items["+ i +"].RuleId");
				column.Sensitive = _ctx.BooleanValue("DescribeColumns.Items["+ i +"].Sensitive");
				column.SensLevelName = _ctx.StringValue("DescribeColumns.Items["+ i +"].SensLevelName");
				column.InstanceName = _ctx.StringValue("DescribeColumns.Items["+ i +"].InstanceName");
				column.RiskLevelName = _ctx.StringValue("DescribeColumns.Items["+ i +"].RiskLevelName");
				column.OdpsRiskLevelName = _ctx.StringValue("DescribeColumns.Items["+ i +"].OdpsRiskLevelName");
				column.Name = _ctx.StringValue("DescribeColumns.Items["+ i +"].Name");
				column.TableId = _ctx.LongValue("DescribeColumns.Items["+ i +"].TableId");
				column.Id = _ctx.StringValue("DescribeColumns.Items["+ i +"].Id");
				column.ProductCode = _ctx.StringValue("DescribeColumns.Items["+ i +"].ProductCode");
				column.RevisionStatus = _ctx.LongValue("DescribeColumns.Items["+ i +"].RevisionStatus");
				column.RevisionId = _ctx.LongValue("DescribeColumns.Items["+ i +"].RevisionId");

				List<string> column_sampleList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeColumns.Items["+ i +"].SampleList.Length"); j++) {
					column_sampleList.Add(_ctx.StringValue("DescribeColumns.Items["+ i +"].SampleList["+ j +"]"));
				}
				column.SampleList = column_sampleList;

				List<DescribeColumnsResponse.DescribeColumns_Column.DescribeColumns_ModelTagsItem> column_modelTags = new List<DescribeColumnsResponse.DescribeColumns_Column.DescribeColumns_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeColumns.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeColumnsResponse.DescribeColumns_Column.DescribeColumns_ModelTagsItem modelTagsItem = new DescribeColumnsResponse.DescribeColumns_Column.DescribeColumns_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeColumns.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeColumns.Items["+ i +"].ModelTags["+ j +"].Name");

					column_modelTags.Add(modelTagsItem);
				}
				column.ModelTags = column_modelTags;

				describeColumnsResponse_items.Add(column);
			}
			describeColumnsResponse.Items = describeColumnsResponse_items;
        
			return describeColumnsResponse;
        }
    }
}
