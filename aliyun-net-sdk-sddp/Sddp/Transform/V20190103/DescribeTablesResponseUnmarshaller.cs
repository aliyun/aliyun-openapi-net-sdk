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
			describeTablesResponse.RequestId = _ctx.StringValue("DescribeTables.RequestId");
			describeTablesResponse.PageSize = _ctx.IntegerValue("DescribeTables.PageSize");
			describeTablesResponse.CurrentPage = _ctx.IntegerValue("DescribeTables.CurrentPage");
			describeTablesResponse.TotalCount = _ctx.IntegerValue("DescribeTables.TotalCount");

			List<DescribeTablesResponse.DescribeTables_Table> describeTablesResponse_items = new List<DescribeTablesResponse.DescribeTables_Table>();
			for (int i = 0; i < _ctx.Length("DescribeTables.Items.Length"); i++) {
				DescribeTablesResponse.DescribeTables_Table table = new DescribeTablesResponse.DescribeTables_Table();
				table.Id = _ctx.LongValue("DescribeTables.Items["+ i +"].Id");
				table.Name = _ctx.StringValue("DescribeTables.Items["+ i +"].Name");
				table.Owner = _ctx.StringValue("DescribeTables.Items["+ i +"].Owner");
				table.CreationTime = _ctx.LongValue("DescribeTables.Items["+ i +"].CreationTime");
				table.ProductId = _ctx.StringValue("DescribeTables.Items["+ i +"].ProductId");
				table.ProductCode = _ctx.StringValue("DescribeTables.Items["+ i +"].ProductCode");
				table.Sensitive = _ctx.BooleanValue("DescribeTables.Items["+ i +"].Sensitive");
				table.RiskLevelId = _ctx.LongValue("DescribeTables.Items["+ i +"].RiskLevelId");
				table.RiskLevelName = _ctx.StringValue("DescribeTables.Items["+ i +"].RiskLevelName");
				table.DepartName = _ctx.StringValue("DescribeTables.Items["+ i +"].DepartName");
				table.TotalCount = _ctx.IntegerValue("DescribeTables.Items["+ i +"].TotalCount");
				table.SensitiveCount = _ctx.IntegerValue("DescribeTables.Items["+ i +"].SensitiveCount");
				table.SensitiveRatio = _ctx.StringValue("DescribeTables.Items["+ i +"].SensitiveRatio");
				table.InstanceId = _ctx.LongValue("DescribeTables.Items["+ i +"].InstanceId");
				table.S2Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S2Count");
				table.S3Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S3Count");
				table.S1Count = _ctx.IntegerValue("DescribeTables.Items["+ i +"].S1Count");
				table.CountDetails = _ctx.StringValue("DescribeTables.Items["+ i +"].CountDetails");
				table.TotalRows = _ctx.IntegerValue("DescribeTables.Items["+ i +"].TotalRows");
				table.LastScanTime = _ctx.LongValue("DescribeTables.Items["+ i +"].LastScanTime");
				table.RegionName = _ctx.StringValue("DescribeTables.Items["+ i +"].RegionName");
				table.InstanceName = _ctx.StringValue("DescribeTables.Items["+ i +"].InstanceName");
				table.SensLevelName = _ctx.StringValue("DescribeTables.Items["+ i +"].SensLevelName");
				table.InstanceDescription = _ctx.StringValue("DescribeTables.Items["+ i +"].InstanceDescription");
				table.TenantName = _ctx.StringValue("DescribeTables.Items["+ i +"].TenantName");

				List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule> table_ruleList = new List<DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule>();
				for (int j = 0; j < _ctx.Length("DescribeTables.Items["+ i +"].RuleList.Length"); j++) {
					DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule rule = new DescribeTablesResponse.DescribeTables_Table.DescribeTables_Rule();
					rule.Name = _ctx.StringValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].Name");
					rule.DisplayName = _ctx.StringValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].DisplayName");
					rule.Count = _ctx.LongValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].Count");
					rule.RiskLevelId = _ctx.LongValue("DescribeTables.Items["+ i +"].RuleList["+ j +"].RiskLevelId");

					table_ruleList.Add(rule);
				}
				table.RuleList = table_ruleList;

				describeTablesResponse_items.Add(table);
			}
			describeTablesResponse.Items = describeTablesResponse_items;
        
			return describeTablesResponse;
        }
    }
}
