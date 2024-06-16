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
    public class DescribeTablesResponseUnmarshaller
    {
        public static DescribeTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTablesResponse describeTablesResponse = new DescribeTablesResponse();

			describeTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeTablesResponse.CurrentPage = _ctx.IntegerValue("DescribeTables.CurrentPage");
			describeTablesResponse.RequestId = _ctx.StringValue("DescribeTables.RequestId");
			describeTablesResponse.PageSize = _ctx.IntegerValue("DescribeTables.PageSize");
			describeTablesResponse.TotalCount = _ctx.IntegerValue("DescribeTables.TotalCount");

			List<DescribeTablesResponse.DescribeTables_Table> describeTablesResponse_items = new List<DescribeTablesResponse.DescribeTables_Table>();
			for (int i = 0; i < _ctx.Length("DescribeTables.Items.Length"); i++) {
				DescribeTablesResponse.DescribeTables_Table table = new DescribeTablesResponse.DescribeTables_Table();
				table.CreationTime = _ctx.LongValue("DescribeTables.Items["+ i +"].CreationTime");
				table.Owner = _ctx.StringValue("DescribeTables.Items["+ i +"].Owner");
				table.CountDetails = _ctx.StringValue("DescribeTables.Items["+ i +"].CountDetails");
				table.SensitiveRatio = _ctx.StringValue("DescribeTables.Items["+ i +"].SensitiveRatio");
				table.TenantName = _ctx.StringValue("DescribeTables.Items["+ i +"].TenantName");
				table.DepartName = _ctx.StringValue("DescribeTables.Items["+ i +"].DepartName");
				table.RiskLevelId = _ctx.LongValue("DescribeTables.Items["+ i +"].RiskLevelId");
				table.InstanceName = _ctx.StringValue("DescribeTables.Items["+ i +"].InstanceName");
				table.S3Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S3Count");
				table.S1Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S1Count");
				table.ProductId = _ctx.StringValue("DescribeTables.Items["+ i +"].ProductId");
				table.Name = _ctx.StringValue("DescribeTables.Items["+ i +"].Name");
				table.S2Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S2Count");
				table.InstanceId = _ctx.LongValue("DescribeTables.Items["+ i +"].InstanceId");
				table.TotalCount = _ctx.IntegerValue("DescribeTables.Items["+ i +"].TotalCount");
				table.InstanceDescription = _ctx.StringValue("DescribeTables.Items["+ i +"].InstanceDescription");
				table.Sensitive = _ctx.BooleanValue("DescribeTables.Items["+ i +"].Sensitive");
				table.SensLevelName = _ctx.StringValue("DescribeTables.Items["+ i +"].SensLevelName");
				table.LastScanTime = _ctx.LongValue("DescribeTables.Items["+ i +"].LastScanTime");
				table.RegionName = _ctx.StringValue("DescribeTables.Items["+ i +"].RegionName");
				table.RiskLevelName = _ctx.StringValue("DescribeTables.Items["+ i +"].RiskLevelName");
				table.TotalRows = _ctx.IntegerValue("DescribeTables.Items["+ i +"].TotalRows");
				table.SensitiveCount = _ctx.IntegerValue("DescribeTables.Items["+ i +"].SensitiveCount");
				table.Id = _ctx.LongValue("DescribeTables.Items["+ i +"].Id");
				table.ProductCode = _ctx.StringValue("DescribeTables.Items["+ i +"].ProductCode");
				table.ObjectHex = _ctx.StringValue("DescribeTables.Items["+ i +"].ObjectHex");
				table.DataType = _ctx.IntegerValue("DescribeTables.Items["+ i +"].DataType");

				List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule> table_ruleList = new List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeTables.Items["+ i +"].RuleList.Length"); j++) {
					DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule rule = new DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule();
					rule.DisplayName = _ctx.StringValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].DisplayName");
					rule.Name = _ctx.StringValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].Name");
					rule.RiskLevelId = _ctx.LongValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].RiskLevelId");
					rule.Count = _ctx.LongValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].Count");

					table_ruleList.Add(rule);
				}
				table.RuleList = table_ruleList;

				List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_ModelTagsItem> table_modelTags = new List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_ModelTagsItem>();
				for (int j = 0; j < _ctx.Length("DescribeTables.Items["+ i +"].ModelTags.Length"); j++) {
					DescribeTablesResponse.DescribeTables_Table.DescribeTables_ModelTagsItem modelTagsItem = new DescribeTablesResponse.DescribeTables_Table.DescribeTables_ModelTagsItem();
					modelTagsItem.Id = _ctx.LongValue("DescribeTables.Items["+ i +"].ModelTags["+ j +"].Id");
					modelTagsItem.Name = _ctx.StringValue("DescribeTables.Items["+ i +"].ModelTags["+ j +"].Name");

					table_modelTags.Add(modelTagsItem);
				}
				table.ModelTags = table_modelTags;

				describeTablesResponse_items.Add(table);
			}
			describeTablesResponse.Items = describeTablesResponse_items;
        
			return describeTablesResponse;
        }
    }
}
