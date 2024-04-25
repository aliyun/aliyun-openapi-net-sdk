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
    public class DescribeVodDomainHitRateDataResponseUnmarshaller
    {
        public static DescribeVodDomainHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainHitRateDataResponse describeVodDomainHitRateDataResponse = new DescribeVodDomainHitRateDataResponse();

			describeVodDomainHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainHitRateDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainHitRateData.EndTime");
			describeVodDomainHitRateDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainHitRateData.StartTime");
			describeVodDomainHitRateDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainHitRateData.RequestId");
			describeVodDomainHitRateDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainHitRateData.DomainName");
			describeVodDomainHitRateDataResponse.DataInterval = _ctx.StringValue("DescribeVodDomainHitRateData.DataInterval");

			List<DescribeVodDomainHitRateDataResponse.DescribeVodDomainHitRateData_DataModule> describeVodDomainHitRateDataResponse_hitRateInterval = new List<DescribeVodDomainHitRateDataResponse.DescribeVodDomainHitRateData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainHitRateData.HitRateInterval.Length"); i++) {
				DescribeVodDomainHitRateDataResponse.DescribeVodDomainHitRateData_DataModule dataModule = new DescribeVodDomainHitRateDataResponse.DescribeVodDomainHitRateData_DataModule();
				dataModule._Value = _ctx.StringValue("DescribeVodDomainHitRateData.HitRateInterval["+ i +"].Value");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodDomainHitRateData.HitRateInterval["+ i +"].TimeStamp");
				dataModule.HttpsValue = _ctx.StringValue("DescribeVodDomainHitRateData.HitRateInterval["+ i +"].HttpsValue");

				describeVodDomainHitRateDataResponse_hitRateInterval.Add(dataModule);
			}
			describeVodDomainHitRateDataResponse.HitRateInterval = describeVodDomainHitRateDataResponse_hitRateInterval;
        
			return describeVodDomainHitRateDataResponse;
        }
    }
}
