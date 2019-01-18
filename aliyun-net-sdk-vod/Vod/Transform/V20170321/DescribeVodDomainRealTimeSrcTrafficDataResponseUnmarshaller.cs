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
    public class DescribeVodDomainRealTimeSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeSrcTrafficDataResponse describeVodDomainRealTimeSrcTrafficDataResponse = new DescribeVodDomainRealTimeSrcTrafficDataResponse();

			describeVodDomainRealTimeSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeSrcTrafficDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.RequestId");
			describeVodDomainRealTimeSrcTrafficDataResponse.DomainName = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.DomainName");
			describeVodDomainRealTimeSrcTrafficDataResponse.StartTime = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.StartTime");
			describeVodDomainRealTimeSrcTrafficDataResponse.EndTime = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.EndTime");
			describeVodDomainRealTimeSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.DataInterval");

			List<DescribeVodDomainRealTimeSrcTrafficDataResponse.DescribeVodDomainRealTimeSrcTrafficData_DataModule> describeVodDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval = new List<DescribeVodDomainRealTimeSrcTrafficDataResponse.DescribeVodDomainRealTimeSrcTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval.Length"); i++) {
				DescribeVodDomainRealTimeSrcTrafficDataResponse.DescribeVodDomainRealTimeSrcTrafficData_DataModule dataModule = new DescribeVodDomainRealTimeSrcTrafficDataResponse.DescribeVodDomainRealTimeSrcTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainRealTimeSrcTrafficData.RealTimeSrcTrafficDataPerInterval["+ i +"].Value");

				describeVodDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval.Add(dataModule);
			}
			describeVodDomainRealTimeSrcTrafficDataResponse.RealTimeSrcTrafficDataPerInterval = describeVodDomainRealTimeSrcTrafficDataResponse_realTimeSrcTrafficDataPerInterval;
        
			return describeVodDomainRealTimeSrcTrafficDataResponse;
        }
    }
}