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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeDistributeTableListResponseUnmarshaller
    {
        public static DescribeDistributeTableListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDistributeTableListResponse describeDistributeTableListResponse = new DescribeDistributeTableListResponse();

			describeDistributeTableListResponse.HttpResponse = _ctx.HttpResponse;
			describeDistributeTableListResponse.RequestId = _ctx.StringValue("DescribeDistributeTableList.RequestId");
			describeDistributeTableListResponse.Success = _ctx.BooleanValue("DescribeDistributeTableList.Success");
			describeDistributeTableListResponse.Message = _ctx.StringValue("DescribeDistributeTableList.Message");

			DescribeDistributeTableListResponse.DescribeDistributeTableList_Data data = new DescribeDistributeTableListResponse.DescribeDistributeTableList_Data();

			List<DescribeDistributeTableListResponse.DescribeDistributeTableList_Data.DescribeDistributeTableList_Table> data_tables = new List<DescribeDistributeTableListResponse.DescribeDistributeTableList_Data.DescribeDistributeTableList_Table>();
			for (int i = 0; i < _ctx.Length("DescribeDistributeTableList.Data.Tables.Length"); i++) {
				DescribeDistributeTableListResponse.DescribeDistributeTableList_Data.DescribeDistributeTableList_Table table = new DescribeDistributeTableListResponse.DescribeDistributeTableList_Data.DescribeDistributeTableList_Table();
				table.TableName = _ctx.StringValue("DescribeDistributeTableList.Data.Tables["+ i +"].TableName");
				table.TableType = _ctx.StringValue("DescribeDistributeTableList.Data.Tables["+ i +"].TableType");
				table.DbKey = _ctx.StringValue("DescribeDistributeTableList.Data.Tables["+ i +"].DbKey");
				table.TbKey = _ctx.StringValue("DescribeDistributeTableList.Data.Tables["+ i +"].TbKey");

				data_tables.Add(table);
			}
			data.Tables = data_tables;
			describeDistributeTableListResponse.Data = data;
        
			return describeDistributeTableListResponse;
        }
    }
}
