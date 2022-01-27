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
    public class DescribeVodDomainSrcBpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainSrcBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainSrcBpsDataResponse describeVodDomainSrcBpsDataResponse = new DescribeVodDomainSrcBpsDataResponse();

			describeVodDomainSrcBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainSrcBpsDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainSrcBpsData.EndTime");
			describeVodDomainSrcBpsDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainSrcBpsData.StartTime");
			describeVodDomainSrcBpsDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainSrcBpsData.RequestId");
			describeVodDomainSrcBpsDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainSrcBpsData.DomainName");
			describeVodDomainSrcBpsDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainSrcBpsData.DataInterval");

			List<DescribeVodDomainSrcBpsDataResponse.DescribeVodDomainSrcBpsData_DataModule> describeVodDomainSrcBpsDataResponse_srcBpsDataPerInterval = new List<DescribeVodDomainSrcBpsDataResponse.DescribeVodDomainSrcBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainSrcBpsData.SrcBpsDataPerInterval.Length"); i++) {
				DescribeVodDomainSrcBpsDataResponse.DescribeVodDomainSrcBpsData_DataModule dataModule = new DescribeVodDomainSrcBpsDataResponse.DescribeVodDomainSrcBpsData_DataModule();
				dataModule._Value = _ctx.StringValue("DescribeVodDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].Value");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].HttpsValue");

				describeVodDomainSrcBpsDataResponse_srcBpsDataPerInterval.Add(dataModule);
			}
			describeVodDomainSrcBpsDataResponse.SrcBpsDataPerInterval = describeVodDomainSrcBpsDataResponse_srcBpsDataPerInterval;
        
			return describeVodDomainSrcBpsDataResponse;
        }
    }
}
