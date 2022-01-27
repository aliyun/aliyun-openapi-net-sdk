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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSlowLogRecords.RequestId");
			describeSlowLogRecordsResponse.InstanceId = _ctx.StringValue("DescribeSlowLogRecords.InstanceId");
			describeSlowLogRecordsResponse.StartTime = _ctx.StringValue("DescribeSlowLogRecords.StartTime");
			describeSlowLogRecordsResponse.Engine = _ctx.StringValue("DescribeSlowLogRecords.Engine");
			describeSlowLogRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.TotalRecordCount");
			describeSlowLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeSlowLogRecords.PageNumber");
			describeSlowLogRecordsResponse.PageSize = _ctx.IntegerValue("DescribeSlowLogRecords.PageSize");
			describeSlowLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeSlowLogRecords.PageRecordCount");

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.Items.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords logRecords = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_LogRecords();
				logRecords.NodeId = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].NodeId");
				logRecords.IPAddress = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].IPAddress");
				logRecords.DBName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DBName");
				logRecords.DataBaseName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].DataBaseName");
				logRecords.Command = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].Command");
				logRecords.ElapsedTime = _ctx.LongValue("DescribeSlowLogRecords.Items["+ i +"].ElapsedTime");
				logRecords.ExecuteTime = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].ExecuteTime");
				logRecords.Account = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].Account");
				logRecords.AccountName = _ctx.StringValue("DescribeSlowLogRecords.Items["+ i +"].AccountName");

				describeSlowLogRecordsResponse_items.Add(logRecords);
			}
			describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
