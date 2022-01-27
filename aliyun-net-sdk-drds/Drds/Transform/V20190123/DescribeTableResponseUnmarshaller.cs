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
    public class DescribeTableResponseUnmarshaller
    {
        public static DescribeTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTableResponse describeTableResponse = new DescribeTableResponse();

			describeTableResponse.HttpResponse = _ctx.HttpResponse;
			describeTableResponse.RequestId = _ctx.StringValue("DescribeTable.RequestId");
			describeTableResponse.Success = _ctx.BooleanValue("DescribeTable.Success");

			DescribeTableResponse.DescribeTable_Data data = new DescribeTableResponse.DescribeTable_Data();

			List<DescribeTableResponse.DescribeTable_Data.DescribeTable_ColumnInfo> data_list = new List<DescribeTableResponse.DescribeTable_Data.DescribeTable_ColumnInfo>();
			for (int i = 0; i < _ctx.Length("DescribeTable.Data.List.Length"); i++) {
				DescribeTableResponse.DescribeTable_Data.DescribeTable_ColumnInfo columnInfo = new DescribeTableResponse.DescribeTable_Data.DescribeTable_ColumnInfo();
				columnInfo.ColumnName = _ctx.StringValue("DescribeTable.Data.List["+ i +"].ColumnName");
				columnInfo.ColumnType = _ctx.StringValue("DescribeTable.Data.List["+ i +"].ColumnType");
				columnInfo.Extra = _ctx.StringValue("DescribeTable.Data.List["+ i +"].Extra");
				columnInfo.Index = _ctx.StringValue("DescribeTable.Data.List["+ i +"].Index");
				columnInfo.IsAllowNull = _ctx.StringValue("DescribeTable.Data.List["+ i +"].IsAllowNull");
				columnInfo.IsPk = _ctx.StringValue("DescribeTable.Data.List["+ i +"].IsPk");

				data_list.Add(columnInfo);
			}
			data.List = data_list;
			describeTableResponse.Data = data;
        
			return describeTableResponse;
        }
    }
}
