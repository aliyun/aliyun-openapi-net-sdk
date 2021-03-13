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
    public class DescribeTablesResponseUnmarshaller
    {
        public static DescribeTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTablesResponse describeTablesResponse = new DescribeTablesResponse();

			describeTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeTablesResponse.RequestId = _ctx.StringValue("DescribeTables.RequestId");

			List<DescribeTablesResponse.DescribeTables_Table> describeTablesResponse_items = new List<DescribeTablesResponse.DescribeTables_Table>();
			for (int i = 0; i < _ctx.Length("DescribeTables.Items.Length"); i++) {
				DescribeTablesResponse.DescribeTables_Table table = new DescribeTablesResponse.DescribeTables_Table();
				table.DBClusterId = _ctx.StringValue("DescribeTables.Items["+ i +"].DBClusterId");
				table.SchemaName = _ctx.StringValue("DescribeTables.Items["+ i +"].SchemaName");
				table.TableName = _ctx.StringValue("DescribeTables.Items["+ i +"].TableName");

				describeTablesResponse_items.Add(table);
			}
			describeTablesResponse.Items = describeTablesResponse_items;
        
			return describeTablesResponse;
        }
    }
}
