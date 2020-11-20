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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcPeakUserCntDataResponseUnmarshaller
    {
        public static DescribeRtcPeakUserCntDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcPeakUserCntDataResponse describeRtcPeakUserCntDataResponse = new DescribeRtcPeakUserCntDataResponse();

			describeRtcPeakUserCntDataResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcPeakUserCntDataResponse.RequestId = _ctx.StringValue("DescribeRtcPeakUserCntData.RequestId");

			List<DescribeRtcPeakUserCntDataResponse.DescribeRtcPeakUserCntData_PeakUserCntModule> describeRtcPeakUserCntDataResponse_peakUserCntDataPerInterval = new List<DescribeRtcPeakUserCntDataResponse.DescribeRtcPeakUserCntData_PeakUserCntModule>();
			for (int i = 0; i < _ctx.Length("DescribeRtcPeakUserCntData.PeakUserCntDataPerInterval.Length"); i++) {
				DescribeRtcPeakUserCntDataResponse.DescribeRtcPeakUserCntData_PeakUserCntModule peakUserCntModule = new DescribeRtcPeakUserCntDataResponse.DescribeRtcPeakUserCntData_PeakUserCntModule();
				peakUserCntModule.TimeStamp = _ctx.StringValue("DescribeRtcPeakUserCntData.PeakUserCntDataPerInterval["+ i +"].TimeStamp");
				peakUserCntModule.ActiveUserPeak = _ctx.LongValue("DescribeRtcPeakUserCntData.PeakUserCntDataPerInterval["+ i +"].ActiveUserPeak");
				peakUserCntModule.ActiveUserPeakTime = _ctx.StringValue("DescribeRtcPeakUserCntData.PeakUserCntDataPerInterval["+ i +"].ActiveUserPeakTime");

				describeRtcPeakUserCntDataResponse_peakUserCntDataPerInterval.Add(peakUserCntModule);
			}
			describeRtcPeakUserCntDataResponse.PeakUserCntDataPerInterval = describeRtcPeakUserCntDataResponse_peakUserCntDataPerInterval;
        
			return describeRtcPeakUserCntDataResponse;
        }
    }
}
