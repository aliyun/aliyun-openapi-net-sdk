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
        public static DescribeVsDomainPvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainPvDataResponse describeVsDomainPvDataResponse = new DescribeVsDomainPvDataResponse();

			describeVsDomainPvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainPvDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainPvData.RequestId");
			describeVsDomainPvDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainPvData.DomainName");
			describeVsDomainPvDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainPvData.StartTime");
			describeVsDomainPvDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainPvData.EndTime");
			describeVsDomainPvDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainPvData.DataInterval");

			List<DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData> describeVsDomainPvDataResponse_pvDataInterval = new List<DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainPvData.PvDataInterval.Length"); i++) {
				DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData usageData = new DescribeVsDomainPvDataResponse.DescribeVsDomainPvData_UsageData();
				usageData._Value = _ctx.StringValue("DescribeVsDomainPvData.PvDataInterval["+ i +"].Value");
				usageData.TimeStamp = _ctx.StringValue("DescribeVsDomainPvData.PvDataInterval["+ i +"].TimeStamp");

				describeVsDomainPvDataResponse_pvDataInterval.Add(usageData);
			}
			describeVsDomainPvDataResponse.PvDataInterval = describeVsDomainPvDataResponse_pvDataInterval;
        
			return describeVsDomainPvDataResponse;
        }
    }
}
