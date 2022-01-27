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
    public class DescribeVsDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeVsDomainTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainTrafficDataResponse describeVsDomainTrafficDataResponse = new DescribeVsDomainTrafficDataResponse();

			describeVsDomainTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainTrafficDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainTrafficData.RequestId");
			describeVsDomainTrafficDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainTrafficData.DomainName");
			describeVsDomainTrafficDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainTrafficData.StartTime");
			describeVsDomainTrafficDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainTrafficData.EndTime");
			describeVsDomainTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainTrafficData.DataInterval");

			List<DescribeVsDomainTrafficDataResponse.DescribeVsDomainTrafficData_DataModule> describeVsDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeVsDomainTrafficDataResponse.DescribeVsDomainTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeVsDomainTrafficDataResponse.DescribeVsDomainTrafficData_DataModule dataModule = new DescribeVsDomainTrafficDataResponse.DescribeVsDomainTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVsDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.TrafficValue = _ctx.StringValue("DescribeVsDomainTrafficData.TrafficDataPerInterval["+ i +"].TrafficValue");

				describeVsDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeVsDomainTrafficDataResponse.TrafficDataPerInterval = describeVsDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeVsDomainTrafficDataResponse;
        }
    }
}
