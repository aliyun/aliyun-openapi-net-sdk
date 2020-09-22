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
    public class DescribeStreamVodListResponseUnmarshaller
    {
        public static DescribeStreamVodListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamVodListResponse describeStreamVodListResponse = new DescribeStreamVodListResponse();

			describeStreamVodListResponse.HttpResponse = context.HttpResponse;
			describeStreamVodListResponse.RequestId = context.StringValue("DescribeStreamVodList.RequestId");

			List<DescribeStreamVodListResponse.DescribeStreamVodList_Record> describeStreamVodListResponse_records = new List<DescribeStreamVodListResponse.DescribeStreamVodList_Record>();
			for (int i = 0; i < context.Length("DescribeStreamVodList.Records.Length"); i++) {
				DescribeStreamVodListResponse.DescribeStreamVodList_Record record = new DescribeStreamVodListResponse.DescribeStreamVodList_Record();
				record.StartTime = context.LongValue("DescribeStreamVodList.Records["+ i +"].StartTime");
				record.EndTime = context.LongValue("DescribeStreamVodList.Records["+ i +"].EndTime");

				describeStreamVodListResponse_records.Add(record);
			}
			describeStreamVodListResponse.Records = describeStreamVodListResponse_records;
        
			return describeStreamVodListResponse;
        }
    }
}
