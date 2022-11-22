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
    public class DescribeRTSNativeSDKFirstFrameDelayResponseUnmarshaller
    {
        public static DescribeRTSNativeSDKFirstFrameDelayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRTSNativeSDKFirstFrameDelayResponse describeRTSNativeSDKFirstFrameDelayResponse = new DescribeRTSNativeSDKFirstFrameDelayResponse();

			describeRTSNativeSDKFirstFrameDelayResponse.HttpResponse = _ctx.HttpResponse;
			describeRTSNativeSDKFirstFrameDelayResponse.RequestId = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.RequestId");
			describeRTSNativeSDKFirstFrameDelayResponse.DataInterval = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.DataInterval");
			describeRTSNativeSDKFirstFrameDelayResponse.StartTime = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.StartTime");
			describeRTSNativeSDKFirstFrameDelayResponse.EndTime = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.EndTime");

			List<DescribeRTSNativeSDKFirstFrameDelayResponse.DescribeRTSNativeSDKFirstFrameDelay_Data> describeRTSNativeSDKFirstFrameDelayResponse_frameDelayData = new List<DescribeRTSNativeSDKFirstFrameDelayResponse.DescribeRTSNativeSDKFirstFrameDelay_Data>();
			for (int i = 0; i < _ctx.Length("DescribeRTSNativeSDKFirstFrameDelay.FrameDelayData.Length"); i++) {
				DescribeRTSNativeSDKFirstFrameDelayResponse.DescribeRTSNativeSDKFirstFrameDelay_Data data = new DescribeRTSNativeSDKFirstFrameDelayResponse.DescribeRTSNativeSDKFirstFrameDelay_Data();
				data.TimeStamp = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.FrameDelayData["+ i +"].TimeStamp");
				data.FrameDelay = _ctx.StringValue("DescribeRTSNativeSDKFirstFrameDelay.FrameDelayData["+ i +"].FrameDelay");

				describeRTSNativeSDKFirstFrameDelayResponse_frameDelayData.Add(data);
			}
			describeRTSNativeSDKFirstFrameDelayResponse.FrameDelayData = describeRTSNativeSDKFirstFrameDelayResponse_frameDelayData;
        
			return describeRTSNativeSDKFirstFrameDelayResponse;
        }
    }
}
