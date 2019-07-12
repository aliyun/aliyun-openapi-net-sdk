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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRecordsResponseUnmarshaller
    {
        public static DescribeRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecordsResponse describeRecordsResponse = new DescribeRecordsResponse();

			describeRecordsResponse.HttpResponse = context.HttpResponse;
			describeRecordsResponse.RequestId = context.StringValue("DescribeRecords.RequestId");

			List<DescribeRecordsResponse.DescribeRecords_Record> describeRecordsResponse_records = new List<DescribeRecordsResponse.DescribeRecords_Record>();
			for (int i = 0; i < context.Length("DescribeRecords.Records.Length"); i++) {
				DescribeRecordsResponse.DescribeRecords_Record record = new DescribeRecordsResponse.DescribeRecords_Record();
				record.RecordId = context.StringValue("DescribeRecords.Records["+ i +"].RecordId");
				record.AppId = context.StringValue("DescribeRecords.Records["+ i +"].AppId");
				record.BoardId = context.IntegerValue("DescribeRecords.Records["+ i +"].BoardId");
				record.RecordStartTime = context.LongValue("DescribeRecords.Records["+ i +"].RecordStartTime");
				record.StartTime = context.LongValue("DescribeRecords.Records["+ i +"].StartTime");
				record.EndTime = context.LongValue("DescribeRecords.Records["+ i +"].EndTime");
				record.State = context.IntegerValue("DescribeRecords.Records["+ i +"].State");
				record.OssPath = context.StringValue("DescribeRecords.Records["+ i +"].OssPath");
				record.OssBucket = context.StringValue("DescribeRecords.Records["+ i +"].OssBucket");
				record.OssEndpoint = context.StringValue("DescribeRecords.Records["+ i +"].OssEndpoint");

				describeRecordsResponse_records.Add(record);
			}
			describeRecordsResponse.Records = describeRecordsResponse_records;
        
			return describeRecordsResponse;
        }
    }
}
