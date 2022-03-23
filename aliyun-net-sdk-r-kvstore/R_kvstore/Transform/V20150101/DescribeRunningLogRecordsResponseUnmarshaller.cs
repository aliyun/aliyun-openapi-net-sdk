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
    public class DescribeRunningLogRecordsResponseUnmarshaller
    {
        public static DescribeRunningLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRunningLogRecordsResponse describeRunningLogRecordsResponse = new DescribeRunningLogRecordsResponse();

			describeRunningLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeRunningLogRecordsResponse.StartTime = _ctx.StringValue("DescribeRunningLogRecords.StartTime");
			describeRunningLogRecordsResponse.RequestId = _ctx.StringValue("DescribeRunningLogRecords.RequestId");
			describeRunningLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeRunningLogRecords.PageRecordCount");
			describeRunningLogRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeRunningLogRecords.TotalRecordCount");
			describeRunningLogRecordsResponse.PageSize = _ctx.IntegerValue("DescribeRunningLogRecords.PageSize");
			describeRunningLogRecordsResponse.InstanceId = _ctx.StringValue("DescribeRunningLogRecords.InstanceId");
			describeRunningLogRecordsResponse.Engine = _ctx.StringValue("DescribeRunningLogRecords.Engine");
			describeRunningLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeRunningLogRecords.PageNumber");

			List<DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords> describeRunningLogRecordsResponse_items = new List<DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords>();
			for (int i = 0; i < _ctx.Length("DescribeRunningLogRecords.Items.Length"); i++) {
				DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords logRecords = new DescribeRunningLogRecordsResponse.DescribeRunningLogRecords_LogRecords();
				logRecords.ConnInfo = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].ConnInfo");
				logRecords.CreateTime = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].CreateTime");
				logRecords.Category = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].Category");
				logRecords.InstanceId = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].InstanceId");
				logRecords.Content = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].Content");
				logRecords.NodeId = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].NodeId");
				logRecords.Level = _ctx.StringValue("DescribeRunningLogRecords.Items["+ i +"].Level");
				logRecords.Id = _ctx.IntegerValue("DescribeRunningLogRecords.Items["+ i +"].Id");

				describeRunningLogRecordsResponse_items.Add(logRecords);
			}
			describeRunningLogRecordsResponse.Items = describeRunningLogRecordsResponse_items;
        
			return describeRunningLogRecordsResponse;
        }
    }
}
