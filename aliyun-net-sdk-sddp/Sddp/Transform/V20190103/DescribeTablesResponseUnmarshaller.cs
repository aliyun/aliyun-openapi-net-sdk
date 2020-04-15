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
        public static DescribeTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTablesResponse describeTablesResponse = new DescribeTablesResponse();

			describeTablesResponse.HttpResponse = context.HttpResponse;
			describeTablesResponse.RequestId = context.StringValue("DescribeTables.RequestId");
			describeTablesResponse.PageSize = context.IntegerValue("DescribeTables.PageSize");
			describeTablesResponse.CurrentPage = context.IntegerValue("DescribeTables.CurrentPage");
			describeTablesResponse.TotalCount = context.IntegerValue("DescribeTables.TotalCount");

			List<DescribeTablesResponse.DescribeTables_Table> describeTablesResponse_items = new List<DescribeTablesResponse.DescribeTables_Table>();
			for (int i = 0; i < context.Length("DescribeTables.Items.Length"); i++) {
				DescribeTablesResponse.DescribeTables_Table table = new DescribeTablesResponse.DescribeTables_Table();
				table.Id = context.LongValue("DescribeTables.Items["+ i +"].Id");
				table.Name = context.StringValue("DescribeTables.Items["+ i +"].Name");
				table.Owner = context.StringValue("DescribeTables.Items["+ i +"].Owner");
				table.CreationTime = context.LongValue("DescribeTables.Items["+ i +"].CreationTime");
				table.ProductId = context.StringValue("DescribeTables.Items["+ i +"].ProductId");
				table.ProductCode = context.StringValue("DescribeTables.Items["+ i +"].ProductCode");
				table.Sensitive = context.BooleanValue("DescribeTables.Items["+ i +"].Sensitive");
				table.RiskLevelId = context.LongValue("DescribeTables.Items["+ i +"].RiskLevelId");
				table.RiskLevelName = context.StringValue("DescribeTables.Items["+ i +"].RiskLevelName");
				table.DepartName = context.StringValue("DescribeTables.Items["+ i +"].DepartName");
				table.TotalCount = context.IntegerValue("DescribeTables.Items["+ i +"].TotalCount");
				table.SensitiveCount = context.IntegerValue("DescribeTables.Items["+ i +"].SensitiveCount");
				table.SensitiveRatio = context.StringValue("DescribeTables.Items["+ i +"].SensitiveRatio");
				table.InstanceId = context.LongValue("DescribeTables.Items["+ i +"].InstanceId");
				table.S2Count = context.IntegerValue("DescribeTables.Items["+ i +"].S2Count");
				table.S3Count = context.IntegerValue("DescribeTables.Items["+ i +"].S3Count");
				table.TotalRows = context.IntegerValue("DescribeTables.Items["+ i +"].TotalRows");
				table.LastScanTime = context.LongValue("DescribeTables.Items["+ i +"].LastScanTime");

				describeTablesResponse_items.Add(table);
			}
			describeTablesResponse.Items = describeTablesResponse_items;
        
			return describeTablesResponse;
        }
    }
}
