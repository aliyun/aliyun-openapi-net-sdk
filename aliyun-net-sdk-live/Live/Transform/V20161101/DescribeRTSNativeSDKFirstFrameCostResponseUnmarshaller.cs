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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRTSNativeSDKFirstFrameCostResponseUnmarshaller
    {
        public static DescribeRTSNativeSDKFirstFrameCostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRTSNativeSDKFirstFrameCostResponse describeRTSNativeSDKFirstFrameCostResponse = new DescribeRTSNativeSDKFirstFrameCostResponse();

			describeRTSNativeSDKFirstFrameCostResponse.HttpResponse = _ctx.HttpResponse;
			describeRTSNativeSDKFirstFrameCostResponse.RequestId = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.RequestId");
			describeRTSNativeSDKFirstFrameCostResponse.DataInterval = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.DataInterval");
			describeRTSNativeSDKFirstFrameCostResponse.StartTime = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.StartTime");
			describeRTSNativeSDKFirstFrameCostResponse.EndTime = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.EndTime");

			List<DescribeRTSNativeSDKFirstFrameCostResponse.DescribeRTSNativeSDKFirstFrameCost_Data> describeRTSNativeSDKFirstFrameCostResponse_firstFrameCostData = new List<DescribeRTSNativeSDKFirstFrameCostResponse.DescribeRTSNativeSDKFirstFrameCost_Data>();
			for (int i = 0; i < _ctx.Length("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData.Length"); i++) {
				DescribeRTSNativeSDKFirstFrameCostResponse.DescribeRTSNativeSDKFirstFrameCost_Data data = new DescribeRTSNativeSDKFirstFrameCostResponse.DescribeRTSNativeSDKFirstFrameCost_Data();
				data.TimeStamp = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].TimeStamp");
				data.Initialized = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].Initialized");
				data.Connected = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].Connected");
				data.FinishGetStreamInfo = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].FinishGetStreamInfo");
				data.FirstPacket = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].FirstPacket");
				data.FirstFrameComplete = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameCost.FirstFrameCostData["+ i +"].FirstFrameComplete");

				describeRTSNativeSDKFirstFrameCostResponse_firstFrameCostData.Add(data);
			}
			describeRTSNativeSDKFirstFrameCostResponse.FirstFrameCostData = describeRTSNativeSDKFirstFrameCostResponse_firstFrameCostData;
        
			return describeRTSNativeSDKFirstFrameCostResponse;
        }
    }
}
