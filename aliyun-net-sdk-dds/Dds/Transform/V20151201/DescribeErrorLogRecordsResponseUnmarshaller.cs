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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeErrorLogRecordsResponseUnmarshaller
    {
        public static DescribeErrorLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeErrorLogRecordsResponse describeErrorLogRecordsResponse = new DescribeErrorLogRecordsResponse();

			describeErrorLogRecordsResponse.HttpResponse = context.HttpResponse;
			describeErrorLogRecordsResponse.RequestId = context.StringValue("DescribeErrorLogRecords.RequestId");
			describeErrorLogRecordsResponse.Engine = context.StringValue("DescribeErrorLogRecords.Engine");
			describeErrorLogRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeErrorLogRecords.TotalRecordCount");
			describeErrorLogRecordsResponse.PageNumber = context.IntegerValue("DescribeErrorLogRecords.PageNumber");
			describeErrorLogRecordsResponse.PageRecordCount = context.IntegerValue("DescribeErrorLogRecords.PageRecordCount");

			List<DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords> describeErrorLogRecordsResponse_items = new List<DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords>();
			for (int i = 0; i < context.Length("DescribeErrorLogRecords.Items.Length"); i++) {
				DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords logRecords = new DescribeErrorLogRecordsResponse.DescribeErrorLogRecords_LogRecords();
				logRecords.Id = context.IntegerValue("DescribeErrorLogRecords.Items["+ i +"].Id");
				logRecords.CreateTime = context.StringValue("DescribeErrorLogRecords.Items["+ i +"].CreateTime");
				logRecords.Category = context.StringValue("DescribeErrorLogRecords.Items["+ i +"].Category");
				logRecords.ConnInfo = context.StringValue("DescribeErrorLogRecords.Items["+ i +"].ConnInfo");
				logRecords.Content = context.LongValue("DescribeErrorLogRecords.Items["+ i +"].Content");

				describeErrorLogRecordsResponse_items.Add(logRecords);
			}
			describeErrorLogRecordsResponse.Items = describeErrorLogRecordsResponse_items;
        
			return describeErrorLogRecordsResponse;
        }
    }
}