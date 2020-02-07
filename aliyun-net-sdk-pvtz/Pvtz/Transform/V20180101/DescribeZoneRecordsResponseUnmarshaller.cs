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
using Aliyun.Acs.pvtz.Model.V20180101;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeZoneRecordsResponseUnmarshaller
    {
        public static DescribeZoneRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZoneRecordsResponse describeZoneRecordsResponse = new DescribeZoneRecordsResponse();

			describeZoneRecordsResponse.HttpResponse = context.HttpResponse;
			describeZoneRecordsResponse.RequestId = context.StringValue("DescribeZoneRecords.RequestId");
			describeZoneRecordsResponse.TotalItems = context.IntegerValue("DescribeZoneRecords.TotalItems");
			describeZoneRecordsResponse.TotalPages = context.IntegerValue("DescribeZoneRecords.TotalPages");
			describeZoneRecordsResponse.PageSize = context.IntegerValue("DescribeZoneRecords.PageSize");
			describeZoneRecordsResponse.PageNumber = context.IntegerValue("DescribeZoneRecords.PageNumber");

			List<DescribeZoneRecordsResponse.DescribeZoneRecords_Record> describeZoneRecordsResponse_records = new List<DescribeZoneRecordsResponse.DescribeZoneRecords_Record>();
			for (int i = 0; i < context.Length("DescribeZoneRecords.Records.Length"); i++) {
				DescribeZoneRecordsResponse.DescribeZoneRecords_Record record = new DescribeZoneRecordsResponse.DescribeZoneRecords_Record();
				record.RecordId = context.LongValue("DescribeZoneRecords.Records["+ i +"].RecordId");
				record.Rr = context.StringValue("DescribeZoneRecords.Records["+ i +"].Rr");
				record.Type = context.StringValue("DescribeZoneRecords.Records["+ i +"].Type");
				record.Ttl = context.IntegerValue("DescribeZoneRecords.Records["+ i +"].Ttl");
				record.Priority = context.IntegerValue("DescribeZoneRecords.Records["+ i +"].Priority");
				record._Value = context.StringValue("DescribeZoneRecords.Records["+ i +"].Value");
				record.Status = context.StringValue("DescribeZoneRecords.Records["+ i +"].Status");
				record.RegionId = context.StringValue("DescribeZoneRecords.Records["+ i +"].RegionId");
				record.Remark = context.StringValue("DescribeZoneRecords.Records["+ i +"].Remark");

				describeZoneRecordsResponse_records.Add(record);
			}
			describeZoneRecordsResponse.Records = describeZoneRecordsResponse_records;
        
			return describeZoneRecordsResponse;
        }
    }
}
