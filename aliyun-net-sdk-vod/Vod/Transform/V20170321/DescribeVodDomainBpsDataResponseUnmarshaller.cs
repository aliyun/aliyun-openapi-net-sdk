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
    public class DescribeVodDomainBpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainBpsDataResponse describeVodDomainBpsDataResponse = new DescribeVodDomainBpsDataResponse();

			describeVodDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainBpsDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainBpsData.RequestId");
			describeVodDomainBpsDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainBpsData.DomainName");
			describeVodDomainBpsDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainBpsData.StartTime");
			describeVodDomainBpsDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainBpsData.EndTime");
			describeVodDomainBpsDataResponse.LocationNameEn = _ctx.StringValue("DescribeVodDomainBpsData.LocationNameEn");
			describeVodDomainBpsDataResponse.IspNameEn = _ctx.StringValue("DescribeVodDomainBpsData.IspNameEn");
			describeVodDomainBpsDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainBpsData.DataInterval");

			List<DescribeVodDomainBpsDataResponse.DescribeVodDomainBpsData_DataModule> describeVodDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeVodDomainBpsDataResponse.DescribeVodDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeVodDomainBpsDataResponse.DescribeVodDomainBpsData_DataModule dataModule = new DescribeVodDomainBpsDataResponse.DescribeVodDomainBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].OverseasValue");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = _ctx.StringValue("DescribeVodDomainBpsData.BpsDataPerInterval["+ i +"].HttpsOverseasValue");

				describeVodDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeVodDomainBpsDataResponse.BpsDataPerInterval = describeVodDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeVodDomainBpsDataResponse;
        }
    }
}
