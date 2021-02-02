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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeErrorLogRecordsResponseUnmarshaller
    {
        public static DescribeErrorLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeErrorLogRecordsResponse describeErrorLogRecordsResponse = new DescribeErrorLogRecordsResponse();

			describeErrorLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeErrorLogRecordsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeErrorLogRecords.TotalRecordCount");
			describeErrorLogRecordsResponse.PageRecordCount = _ctx.IntegerValue("DescribeErrorLogRecords.PageRecordCount");
			describeErrorLogRecordsResponse.RequestId = _ctx.StringValue("DescribeErrorLogRecords.RequestId");
			describeErrorLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeErrorLogRecords.PageNumber");
			describeErrorLogRecordsResponse.Engine = _ctx.StringValue("DescribeErrorLogRecords.Engine");

			List<DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords> describeErrorLogRecordsResponse_items = new List<DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords>();
			for (int i = 0; i < _ctx.Length("DescribeErrorLogRecords.Items.Length"); i++) {
				DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords logRecords = new DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords();
				logRecords.ConnInfo = _ctx.StringValue("DescribeErrorLogRecords.Items["+ i +"].ConnInfo");
				logRecords.Category = _ctx.StringValue("DescribeErrorLogRecords.Items["+ i +"].Category");
				logRecords.Content = _ctx.StringValue("DescribeErrorLogRecords.Items["+ i +"].Content");
				logRecords.CreateTime = _ctx.StringValue("DescribeErrorLogRecords.Items["+ i +"].CreateTime");
				logRecords.Id = _ctx.IntegerValue("DescribeErrorLogRecords.Items["+ i +"].Id");

				describeErrorLogRecordsResponse_items.Add(logRecords);
			}
			describeErrorLogRecordsResponse.Items = describeErrorLogRecordsResponse_items;
        
			return describeErrorLogRecordsResponse;
        }
    }
}
