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
    public class DescribeVodDomainTrafficDataResponseUnmarshaller
    {
        public static DescribeVodDomainTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainTrafficDataResponse describeVodDomainTrafficDataResponse = new DescribeVodDomainTrafficDataResponse();

			describeVodDomainTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainTrafficDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainTrafficData.RequestId");
			describeVodDomainTrafficDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainTrafficData.DomainName");
			describeVodDomainTrafficDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainTrafficData.StartTime");
			describeVodDomainTrafficDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainTrafficData.EndTime");
			describeVodDomainTrafficDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainTrafficData.DataInterval");

			List<DescribeVodDomainTrafficDataResponse.DescribeVodDomainTrafficData_DataModule> describeVodDomainTrafficDataResponse_trafficDataPerInterval = new List<DescribeVodDomainTrafficDataResponse.DescribeVodDomainTrafficData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainTrafficData.TrafficDataPerInterval.Length"); i++) {
				DescribeVodDomainTrafficDataResponse.DescribeVodDomainTrafficData_DataModule dataModule = new DescribeVodDomainTrafficDataResponse.DescribeVodDomainTrafficData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].OverseasValue");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = _ctx.StringValue("DescribeVodDomainTrafficData.TrafficDataPerInterval["+ i +"].HttpsOverseasValue");

				describeVodDomainTrafficDataResponse_trafficDataPerInterval.Add(dataModule);
			}
			describeVodDomainTrafficDataResponse.TrafficDataPerInterval = describeVodDomainTrafficDataResponse_trafficDataPerInterval;
        
			return describeVodDomainTrafficDataResponse;
        }
    }
}
