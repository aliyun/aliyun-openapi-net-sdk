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
    public class DescribeBroadcastTablesResponseUnmarshaller
    {
        public static DescribeBroadcastTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBroadcastTablesResponse describeBroadcastTablesResponse = new DescribeBroadcastTablesResponse();

			describeBroadcastTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeBroadcastTablesResponse.RequestId = _ctx.StringValue("DescribeBroadcastTables.RequestId");
			describeBroadcastTablesResponse.Success = _ctx.BooleanValue("DescribeBroadcastTables.Success");
			describeBroadcastTablesResponse.IsShard = _ctx.BooleanValue("DescribeBroadcastTables.IsShard");
			describeBroadcastTablesResponse.PageNumber = _ctx.IntegerValue("DescribeBroadcastTables.PageNumber");
			describeBroadcastTablesResponse.PageSize = _ctx.IntegerValue("DescribeBroadcastTables.PageSize");
			describeBroadcastTablesResponse.Total = _ctx.IntegerValue("DescribeBroadcastTables.Total");

			List<DescribeBroadcastTablesResponse.DescribeBroadcastTables_ListItem> describeBroadcastTablesResponse_list = new List<DescribeBroadcastTablesResponse.DescribeBroadcastTables_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeBroadcastTables.List.Length"); i++) {
				DescribeBroadcastTablesResponse.DescribeBroadcastTables_ListItem listItem = new DescribeBroadcastTablesResponse.DescribeBroadcastTables_ListItem();
				listItem.Table = _ctx.StringValue("DescribeBroadcastTables.List["+ i +"].Table");
				listItem.BroadcastType = _ctx.StringValue("DescribeBroadcastTables.List["+ i +"].BroadcastType");
				listItem.IsShard = _ctx.BooleanValue("DescribeBroadcastTables.List["+ i +"].IsShard");
				listItem.DbInstType = _ctx.IntegerValue("DescribeBroadcastTables.List["+ i +"].DbInstType");
				listItem.Broadcast = _ctx.BooleanValue("DescribeBroadcastTables.List["+ i +"].Broadcast");
				listItem.Status = _ctx.IntegerValue("DescribeBroadcastTables.List["+ i +"].Status");

				describeBroadcastTablesResponse_list.Add(listItem);
			}
			describeBroadcastTablesResponse.List = describeBroadcastTablesResponse_list;
        
			return describeBroadcastTablesResponse;
        }
    }
}
