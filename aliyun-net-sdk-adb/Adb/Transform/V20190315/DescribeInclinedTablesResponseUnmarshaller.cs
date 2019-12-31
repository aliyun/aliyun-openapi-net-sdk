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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeInclinedTablesResponseUnmarshaller
    {
        public static DescribeInclinedTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInclinedTablesResponse describeInclinedTablesResponse = new DescribeInclinedTablesResponse();

			describeInclinedTablesResponse.HttpResponse = context.HttpResponse;
			describeInclinedTablesResponse.RequestId = context.StringValue("DescribeInclinedTables.RequestId");
			describeInclinedTablesResponse.TotalCount = context.StringValue("DescribeInclinedTables.TotalCount");
			describeInclinedTablesResponse.PageNumber = context.StringValue("DescribeInclinedTables.PageNumber");
			describeInclinedTablesResponse.PageSize = context.StringValue("DescribeInclinedTables.PageSize");

			List<DescribeInclinedTablesResponse.DescribeInclinedTables_Table> describeInclinedTablesResponse_items = new List<DescribeInclinedTablesResponse.DescribeInclinedTables_Table>();
			for (int i = 0; i < context.Length("DescribeInclinedTables.Items.Length"); i++) {
				DescribeInclinedTablesResponse.DescribeInclinedTables_Table table = new DescribeInclinedTablesResponse.DescribeInclinedTables_Table();
				table.Schema = context.StringValue("DescribeInclinedTables.Items["+ i +"].Schema");
				table.Name = context.StringValue("DescribeInclinedTables.Items["+ i +"].Name");
				table.Type = context.StringValue("DescribeInclinedTables.Items["+ i +"].Type");
				table.Size = context.LongValue("DescribeInclinedTables.Items["+ i +"].Size");
				table.IsIncline = context.BooleanValue("DescribeInclinedTables.Items["+ i +"].IsIncline");

				describeInclinedTablesResponse_items.Add(table);
			}
			describeInclinedTablesResponse.Items = describeInclinedTablesResponse_items;
        
			return describeInclinedTablesResponse;
        }
    }
}
