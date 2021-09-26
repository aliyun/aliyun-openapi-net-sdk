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
    public class DescribeVsDomainBpsDataResponseUnmarshaller
    {
        public static DescribeVsDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainBpsDataResponse describeVsDomainBpsDataResponse = new DescribeVsDomainBpsDataResponse();

			describeVsDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainBpsDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainBpsData.RequestId");
			describeVsDomainBpsDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainBpsData.DomainName");
			describeVsDomainBpsDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainBpsData.StartTime");
			describeVsDomainBpsDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainBpsData.EndTime");
			describeVsDomainBpsDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainBpsData.DataInterval");

			List<DescribeVsDomainBpsDataResponse.DescribeVsDomainBpsData_DataModule> describeVsDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeVsDomainBpsDataResponse.DescribeVsDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeVsDomainBpsDataResponse.DescribeVsDomainBpsData_DataModule dataModule = new DescribeVsDomainBpsDataResponse.DescribeVsDomainBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVsDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = _ctx.StringValue("DescribeVsDomainBpsData.BpsDataPerInterval["+ i +"].BpsValue");

				describeVsDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeVsDomainBpsDataResponse.BpsDataPerInterval = describeVsDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeVsDomainBpsDataResponse;
        }
    }
}
