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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnBgpTrafficDataResponseUnmarshaller
    {
        public static DescribeDcdnBgpTrafficDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnBgpTrafficDataResponse describeDcdnBgpTrafficDataResponse = new DescribeDcdnBgpTrafficDataResponse();

			describeDcdnBgpTrafficDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnBgpTrafficDataResponse.RequestId = _ctx.StringValue("DescribeDcdnBgpTrafficData.RequestId");
			describeDcdnBgpTrafficDataResponse.StartTime = _ctx.StringValue("DescribeDcdnBgpTrafficData.StartTime");
			describeDcdnBgpTrafficDataResponse.EndTime = _ctx.StringValue("DescribeDcdnBgpTrafficData.EndTime");

			List<DescribeDcdnBgpTrafficDataResponse.DescribeDcdnBgpTrafficData_BgpData> describeDcdnBgpTrafficDataResponse_bgpDataInterval = new List<DescribeDcdnBgpTrafficDataResponse.DescribeDcdnBgpTrafficData_BgpData>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnBgpTrafficData.BgpDataInterval.Length"); i++) {
				DescribeDcdnBgpTrafficDataResponse.DescribeDcdnBgpTrafficData_BgpData bgpData = new DescribeDcdnBgpTrafficDataResponse.DescribeDcdnBgpTrafficData_BgpData();
				bgpData._In = _ctx.LongValue("DescribeDcdnBgpTrafficData.BgpDataInterval["+ i +"].In");
				bgpData._Out = _ctx.LongValue("DescribeDcdnBgpTrafficData.BgpDataInterval["+ i +"].Out");
				bgpData.TimeStamp = _ctx.StringValue("DescribeDcdnBgpTrafficData.BgpDataInterval["+ i +"].TimeStamp");

				describeDcdnBgpTrafficDataResponse_bgpDataInterval.Add(bgpData);
			}
			describeDcdnBgpTrafficDataResponse.BgpDataInterval = describeDcdnBgpTrafficDataResponse_bgpDataInterval;
        
			return describeDcdnBgpTrafficDataResponse;
        }
    }
}
