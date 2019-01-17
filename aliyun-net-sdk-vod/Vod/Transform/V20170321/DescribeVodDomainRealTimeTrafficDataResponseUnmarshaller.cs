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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeTrafficDataResponse describeVodDomainRealTimeTrafficDataResponse = new DescribeVodDomainRealTimeTrafficDataResponse();

			describeVodDomainRealTimeTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeTrafficDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeTrafficData.RequestId");
			describeVodDomainRealTimeTrafficDataResponse.DomainName = context.StringValue("DescribeVodDomainRealTimeTrafficData.DomainName");
			describeVodDomainRealTimeTrafficDataResponse.StartTime = context.StringValue("DescribeVodDomainRealTimeTrafficData.StartTime");
			describeVodDomainRealTimeTrafficDataResponse.EndTime = context.StringValue("DescribeVodDomainRealTimeTrafficData.EndTime");
			describeVodDomainRealTimeTrafficDataResponse.DataInterval = context.StringValue("DescribeVodDomainRealTimeTrafficData.DataInterval");

			List<DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule> describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule dataModule = new DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");

				describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeVodDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeVodDomainRealTimeTrafficDataResponse;
        }
    }
}