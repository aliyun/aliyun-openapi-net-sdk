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
    public class DescribeVodDomainRealTimeSrcBpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeSrcBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeSrcBpsDataResponse describeVodDomainRealTimeSrcBpsDataResponse = new DescribeVodDomainRealTimeSrcBpsDataResponse();

			describeVodDomainRealTimeSrcBpsDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeSrcBpsDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.RequestId");
			describeVodDomainRealTimeSrcBpsDataResponse.DomainName = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.DomainName");
			describeVodDomainRealTimeSrcBpsDataResponse.StartTime = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.StartTime");
			describeVodDomainRealTimeSrcBpsDataResponse.EndTime = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.EndTime");
			describeVodDomainRealTimeSrcBpsDataResponse.DataInterval = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.DataInterval");

			List<DescribeVodDomainRealTimeSrcBpsDataResponse.DescribeVodDomainRealTimeSrcBpsData_DataModule> describeVodDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval = new List<DescribeVodDomainRealTimeSrcBpsDataResponse.DescribeVodDomainRealTimeSrcBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval.Length"); i++) {
				DescribeVodDomainRealTimeSrcBpsDataResponse.DescribeVodDomainRealTimeSrcBpsData_DataModule dataModule = new DescribeVodDomainRealTimeSrcBpsDataResponse.DescribeVodDomainRealTimeSrcBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainRealTimeSrcBpsData.RealTimeSrcBpsDataPerInterval["+ i +"].Value");

				describeVodDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval.Add(dataModule);
			}
			describeVodDomainRealTimeSrcBpsDataResponse.RealTimeSrcBpsDataPerInterval = describeVodDomainRealTimeSrcBpsDataResponse_realTimeSrcBpsDataPerInterval;
        
			return describeVodDomainRealTimeSrcBpsDataResponse;
        }
    }
}