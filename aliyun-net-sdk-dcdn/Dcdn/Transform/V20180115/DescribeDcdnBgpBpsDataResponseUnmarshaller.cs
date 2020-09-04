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
    public class DescribeDcdnBgpBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnBgpBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnBgpBpsDataResponse describeDcdnBgpBpsDataResponse = new DescribeDcdnBgpBpsDataResponse();

			describeDcdnBgpBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnBgpBpsDataResponse.RequestId = context.StringValue("DescribeDcdnBgpBpsData.RequestId");
			describeDcdnBgpBpsDataResponse.StartTime = context.StringValue("DescribeDcdnBgpBpsData.StartTime");
			describeDcdnBgpBpsDataResponse.EndTime = context.StringValue("DescribeDcdnBgpBpsData.EndTime");

			List<DescribeDcdnBgpBpsDataResponse.DescribeDcdnBgpBpsData_BgpData> describeDcdnBgpBpsDataResponse_bgpDataInterval = new List<DescribeDcdnBgpBpsDataResponse.DescribeDcdnBgpBpsData_BgpData>();
			for (int i = 0; i < context.Length("DescribeDcdnBgpBpsData.BgpDataInterval.Length"); i++) {
				DescribeDcdnBgpBpsDataResponse.DescribeDcdnBgpBpsData_BgpData bgpData = new DescribeDcdnBgpBpsDataResponse.DescribeDcdnBgpBpsData_BgpData();
				bgpData._In = context.FloatValue("DescribeDcdnBgpBpsData.BgpDataInterval["+ i +"].In");
				bgpData._Out = context.FloatValue("DescribeDcdnBgpBpsData.BgpDataInterval["+ i +"].Out");
				bgpData.TimeStamp = context.StringValue("DescribeDcdnBgpBpsData.BgpDataInterval["+ i +"].TimeStamp");

				describeDcdnBgpBpsDataResponse_bgpDataInterval.Add(bgpData);
			}
			describeDcdnBgpBpsDataResponse.BgpDataInterval = describeDcdnBgpBpsDataResponse_bgpDataInterval;
        
			return describeDcdnBgpBpsDataResponse;
        }
    }
}
