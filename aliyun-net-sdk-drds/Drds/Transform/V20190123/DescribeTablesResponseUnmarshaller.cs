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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeTablesResponseUnmarshaller
    {
        public static DescribeTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTablesResponse describeTablesResponse = new DescribeTablesResponse();

			describeTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeTablesResponse.RequestId = _ctx.StringValue("DescribeTables.RequestId");
			describeTablesResponse.Success = _ctx.BooleanValue("DescribeTables.Success");
			describeTablesResponse.PageNumber = _ctx.IntegerValue("DescribeTables.PageNumber");
			describeTablesResponse.PageSize = _ctx.IntegerValue("DescribeTables.PageSize");
			describeTablesResponse.Total = _ctx.IntegerValue("DescribeTables.Total");

			List<DescribeTablesResponse.DescribeTables_ListItem> describeTablesResponse_list = new List<DescribeTablesResponse.DescribeTables_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeTables.List.Length"); i++) {
				DescribeTablesResponse.DescribeTables_ListItem listItem = new DescribeTablesResponse.DescribeTables_ListItem();
				listItem.Table = _ctx.StringValue("DescribeTables.List["+ i +"].Table");
				listItem.ShardKey = _ctx.StringValue("DescribeTables.List["+ i +"].ShardKey");
				listItem.IsShard = _ctx.BooleanValue("DescribeTables.List["+ i +"].IsShard");
				listItem.IsLocked = _ctx.BooleanValue("DescribeTables.List["+ i +"].IsLocked");
				listItem.DbInstType = _ctx.IntegerValue("DescribeTables.List["+ i +"].DbInstType");
				listItem.Broadcast = _ctx.BooleanValue("DescribeTables.List["+ i +"].Broadcast");
				listItem.AllowFullTableScan = _ctx.BooleanValue("DescribeTables.List["+ i +"].AllowFullTableScan");
				listItem.Status = _ctx.IntegerValue("DescribeTables.List["+ i +"].Status");

				describeTablesResponse_list.Add(listItem);
			}
			describeTablesResponse.List = describeTablesResponse_list;
        
			return describeTablesResponse;
        }
    }
}
