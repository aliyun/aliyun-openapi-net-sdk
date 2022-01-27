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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeRecordsResponseUnmarshaller
    {
        public static DescribeRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordsResponse describeRecordsResponse = new DescribeRecordsResponse();

			describeRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordsResponse.RequestId = _ctx.StringValue("DescribeRecords.RequestId");
			describeRecordsResponse.PageSize = _ctx.LongValue("DescribeRecords.PageSize");
			describeRecordsResponse.PageNum = _ctx.LongValue("DescribeRecords.PageNum");
			describeRecordsResponse.PageCount = _ctx.LongValue("DescribeRecords.PageCount");
			describeRecordsResponse.TotalCount = _ctx.LongValue("DescribeRecords.TotalCount");
			describeRecordsResponse.NextStartTime = _ctx.StringValue("DescribeRecords.NextStartTime");

			List<DescribeRecordsResponse.DescribeRecords_Record> describeRecordsResponse_records = new List<DescribeRecordsResponse.DescribeRecords_Record>();
			for (int i = 0; i < _ctx.Length("DescribeRecords.Records.Length"); i++) {
				DescribeRecordsResponse.DescribeRecords_Record record = new DescribeRecordsResponse.DescribeRecords_Record();
				record.Id = _ctx.StringValue("DescribeRecords.Records["+ i +"].Id");
				record.StreamId = _ctx.StringValue("DescribeRecords.Records["+ i +"].StreamId");
				record.TemplateId = _ctx.StringValue("DescribeRecords.Records["+ i +"].TemplateId");
				record.Type = _ctx.StringValue("DescribeRecords.Records["+ i +"].Type");
				record.Url = _ctx.StringValue("DescribeRecords.Records["+ i +"].Url");
				record.FileFormat = _ctx.StringValue("DescribeRecords.Records["+ i +"].FileFormat");
				record.OssBucket = _ctx.StringValue("DescribeRecords.Records["+ i +"].OssBucket");
				record.OssObject = _ctx.StringValue("DescribeRecords.Records["+ i +"].OssObject");
				record.OssEndpoint = _ctx.StringValue("DescribeRecords.Records["+ i +"].OssEndpoint");
				record.StartTime = _ctx.StringValue("DescribeRecords.Records["+ i +"].StartTime");
				record.EndTime = _ctx.StringValue("DescribeRecords.Records["+ i +"].EndTime");
				record.Height = _ctx.LongValue("DescribeRecords.Records["+ i +"].Height");
				record.Width = _ctx.LongValue("DescribeRecords.Records["+ i +"].Width");

				describeRecordsResponse_records.Add(record);
			}
			describeRecordsResponse.Records = describeRecordsResponse_records;
        
			return describeRecordsResponse;
        }
    }
}
