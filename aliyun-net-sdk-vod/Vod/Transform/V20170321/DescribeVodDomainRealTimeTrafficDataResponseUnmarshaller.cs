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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainRealTimeTrafficDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainRealTimeTrafficDataResponse describeVodDomainRealTimeTrafficDataResponse = new DescribeVodDomainRealTimeTrafficDataResponse();

			describeVodDomainRealTimeTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainRealTimeTrafficDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.EndTime");
			describeVodDomainRealTimeTrafficDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.StartTime");
			describeVodDomainRealTimeTrafficDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.RequestId");
			describeVodDomainRealTimeTrafficDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.DomainName");
			describeVodDomainRealTimeTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.DataInterval");

			List<DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule> describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval = new List<DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval.Length"); i++) {
				DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule dataModule = new DescribeVodDomainRealTimeTrafficDataResponse.DescribeVodDomainRealTimeTrafficData_DataModule();
				dataModule._Value = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].Value");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainRealTimeTrafficData.RealTimeTrafficDataPerInterval["+ i +"].TimeStamp");

				describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval.Add(dataModule);
			}
			describeVodDomainRealTimeTrafficDataResponse.RealTimeTrafficDataPerInterval = describeVodDomainRealTimeTrafficDataResponse_realTimeTrafficDataPerInterval;
        
			return describeVodDomainRealTimeTrafficDataResponse;
        }
    }
}
