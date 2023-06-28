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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeDownloadRecordsResponseUnmarshaller
    {
        public static DescribeDownloadRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDownloadRecordsResponse describeDownloadRecordsResponse = new DescribeDownloadRecordsResponse();

			describeDownloadRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeDownloadRecordsResponse.RequestId = _ctx.StringValue("DescribeDownloadRecords.RequestId");

			List<DescribeDownloadRecordsResponse.DescribeDownloadRecords_Items> describeDownloadRecordsResponse_records = new List<DescribeDownloadRecordsResponse.DescribeDownloadRecords_Items>();
			for (int i = 0; i < _ctx.Length("DescribeDownloadRecords.Records.Length"); i++) {
				DescribeDownloadRecordsResponse.DescribeDownloadRecords_Items items = new DescribeDownloadRecordsResponse.DescribeDownloadRecords_Items();
				items.Status = _ctx.StringValue("DescribeDownloadRecords.Records["+ i +"].Status");
				items.DownloadId = _ctx.LongValue("DescribeDownloadRecords.Records["+ i +"].DownloadId");
				items.ExceptionMsg = _ctx.StringValue("DescribeDownloadRecords.Records["+ i +"].ExceptionMsg");
				items.Url = _ctx.StringValue("DescribeDownloadRecords.Records["+ i +"].Url");
				items.FileName = _ctx.StringValue("DescribeDownloadRecords.Records["+ i +"].FileName");

				describeDownloadRecordsResponse_records.Add(items);
			}
			describeDownloadRecordsResponse.Records = describeDownloadRecordsResponse_records;
        
			return describeDownloadRecordsResponse;
        }
    }
}
