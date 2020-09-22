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
    public class DescribeVsDomainRecordDataResponseUnmarshaller
    {
        public static DescribeVsDomainRecordDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainRecordDataResponse describeVsDomainRecordDataResponse = new DescribeVsDomainRecordDataResponse();

			describeVsDomainRecordDataResponse.HttpResponse = context.HttpResponse;
			describeVsDomainRecordDataResponse.RequestId = context.StringValue("DescribeVsDomainRecordData.RequestId");
			describeVsDomainRecordDataResponse.DomainName = context.StringValue("DescribeVsDomainRecordData.DomainName");
			describeVsDomainRecordDataResponse.StartTime = context.StringValue("DescribeVsDomainRecordData.StartTime");
			describeVsDomainRecordDataResponse.EndTime = context.StringValue("DescribeVsDomainRecordData.EndTime");

			List<DescribeVsDomainRecordDataResponse.DescribeVsDomainRecordData_DataModule> describeVsDomainRecordDataResponse_recordDataPerInterval = new List<DescribeVsDomainRecordDataResponse.DescribeVsDomainRecordData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVsDomainRecordData.RecordDataPerInterval.Length"); i++) {
				DescribeVsDomainRecordDataResponse.DescribeVsDomainRecordData_DataModule dataModule = new DescribeVsDomainRecordDataResponse.DescribeVsDomainRecordData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVsDomainRecordData.RecordDataPerInterval["+ i +"].TimeStamp");
				dataModule.RecordValue = context.StringValue("DescribeVsDomainRecordData.RecordDataPerInterval["+ i +"].RecordValue");

				describeVsDomainRecordDataResponse_recordDataPerInterval.Add(dataModule);
			}
			describeVsDomainRecordDataResponse.RecordDataPerInterval = describeVsDomainRecordDataResponse_recordDataPerInterval;
        
			return describeVsDomainRecordDataResponse;
        }
    }
}
