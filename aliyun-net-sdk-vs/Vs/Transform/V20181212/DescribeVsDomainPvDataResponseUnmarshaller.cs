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
    public class DescribeVsDomainPvDataResponseUnmarshaller
    {
        public static DescribeVsDomainPvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainPvDataResponse describeVsDomainPvDataResponse = new DescribeVsDomainPvDataResponse();

			describeVsDomainPvDataResponse.HttpResponse = context.HttpResponse;
			describeVsDomainPvDataResponse.RequestId = context.StringValue("DescribeVsDomainPvData.RequestId");
			describeVsDomainPvDataResponse.DomainName = context.StringValue("DescribeVsDomainPvData.DomainName");
			describeVsDomainPvDataResponse.StartTime = context.StringValue("DescribeVsDomainPvData.StartTime");

			List<DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData> describeVsDomainPvDataResponse_pvDataInterval = new List<DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeVsDomainPvData.PvDataInterval.Length"); i++) {
				DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData usageData = new DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData();
				usageData._Value = context.StringValue("DescribeVsDomainPvData.PvDataInterval["+ i +"].Value");
				usageData.TimeStamp = context.StringValue("DescribeVsDomainPvData.PvDataInterval["+ i +"].TimeStamp");

				describeVsDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeVsDomainPvDataResponse.PvDataInterval = describeVsDomainPvDataResponse_pvDataInterval;
        
			return describeVsDomainPvDataResponse;
        }
    }
}
