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
    public class DescribeRtcChannelCntDataResponseUnmarshaller
    {
        public static DescribeRtcChannelCntDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcChannelCntDataResponse describeRtcChannelCntDataResponse = new DescribeRtcChannelCntDataResponse();

			describeRtcChannelCntDataResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcChannelCntDataResponse.RequestId = _ctx.StringValue("DescribeRtcChannelCntData.RequestId");

			List<DescribeRtcChannelCntDataResponse.DescribeRtcChannelCntData_ChannelCntModule> describeRtcChannelCntDataResponse_channelCntDataPerInterval = new List<DescribeRtcChannelCntDataResponse.DescribeRtcChannelCntData_ChannelCntModule>();
			for (int i = 0; i < _ctx.Length("DescribeRtcChannelCntData.ChannelCntDataPerInterval.Length"); i++) {
				DescribeRtcChannelCntDataResponse.DescribeRtcChannelCntData_ChannelCntModule channelCntModule = new DescribeRtcChannelCntDataResponse.DescribeRtcChannelCntData_ChannelCntModule();
				channelCntModule.TimeStamp = _ctx.StringValue("DescribeRtcChannelCntData.ChannelCntDataPerInterval["+ i +"].TimeStamp");
				channelCntModule.ActiveChannelCnt = _ctx.LongValue("DescribeRtcChannelCntData.ChannelCntDataPerInterval["+ i +"].ActiveChannelCnt");

				describeRtcChannelCntDataResponse_channelCntDataPerInterval.Add(channelCntModule);
			}
			describeRtcChannelCntDataResponse.ChannelCntDataPerInterval = describeRtcChannelCntDataResponse_channelCntDataPerInterval;
        
			return describeRtcChannelCntDataResponse;
        }
    }
}
