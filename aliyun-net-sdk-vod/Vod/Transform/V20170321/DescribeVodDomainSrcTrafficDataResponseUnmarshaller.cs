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
    public class DescribeVodDomainSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeVodDomainSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainSrcTrafficDataResponse describeVodDomainSrcTrafficDataResponse = new DescribeVodDomainSrcTrafficDataResponse();

			describeVodDomainSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainSrcTrafficDataResponse.RequestId = context.StringValue("DescribeVodDomainSrcTrafficData.RequestId");
			describeVodDomainSrcTrafficDataResponse.DomainName = context.StringValue("DescribeVodDomainSrcTrafficData.DomainName");
			describeVodDomainSrcTrafficDataResponse.StartTime = context.StringValue("DescribeVodDomainSrcTrafficData.StartTime");
			describeVodDomainSrcTrafficDataResponse.EndTime = context.StringValue("DescribeVodDomainSrcTrafficData.EndTime");
			describeVodDomainSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeVodDomainSrcTrafficData.DataInterval");

			List<DescribeVodDomainSrcTrafficDataResponse.DescribeVodDomainSrcTrafficData_DataModule> describeVodDomainSrcTrafficDataResponse_srcTrafficDataPerInterval = new List<DescribeVodDomainSrcTrafficDataResponse.DescribeVodDomainSrcTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainSrcTrafficData.SrcTrafficDataPerInterval.Length"); i++) {
				DescribeVodDomainSrcTrafficDataResponse.DescribeVodDomainSrcTrafficData_DataModule dataModule = new DescribeVodDomainSrcTrafficDataResponse.DescribeVodDomainSrcTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"].Value");
				dataModule.HttpsValue = context.StringValue("DescribeVodDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"].HttpsValue");

				describeVodDomainSrcTrafficDataResponse_srcTrafficDataPerInterval.Add(dataModule);
			}
			describeVodDomainSrcTrafficDataResponse.SrcTrafficDataPerInterval = describeVodDomainSrcTrafficDataResponse_srcTrafficDataPerInterval;
        
			return describeVodDomainSrcTrafficDataResponse;
        }
    }
}