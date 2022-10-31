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
    public class DescribeRTSNativeSDKPlayTimeResponseUnmarshaller
    {
        public static DescribeRTSNativeSDKPlayTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRTSNativeSDKPlayTimeResponse describeRTSNativeSDKPlayTimeResponse = new DescribeRTSNativeSDKPlayTimeResponse();

			describeRTSNativeSDKPlayTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeRTSNativeSDKPlayTimeResponse.RequestId = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.RequestId");
			describeRTSNativeSDKPlayTimeResponse.DataInterval = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.DataInterval");
			describeRTSNativeSDKPlayTimeResponse.StartTime = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.StartTime");
			describeRTSNativeSDKPlayTimeResponse.EndTime = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.EndTime");

			List<DescribeRTSNativeSDKPlayTimeResponse.DescribeRTSNativeSDKPlayTime_Data> describeRTSNativeSDKPlayTimeResponse_playTimeData = new List<DescribeRTSNativeSDKPlayTimeResponse.DescribeRTSNativeSDKPlayTime_Data>();
			for (int i = 0; i < _ctx.Length("DescribeRTSNativeSDKPlayTime.PlayTimeData.Length"); i++) {
				DescribeRTSNativeSDKPlayTimeResponse.DescribeRTSNativeSDKPlayTime_Data data = new DescribeRTSNativeSDKPlayTimeResponse.DescribeRTSNativeSDKPlayTime_Data();
				data.TimeStamp = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.PlayTimeData["+ i +"].TimeStamp");
				data.PlayTime = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.PlayTimeData["+ i +"].PlayTime");
				data.StallTime = _ctx.StringValue("DescribeRTSNativeSDKPlayTime.PlayTimeData["+ i +"].StallTime");

				describeRTSNativeSDKPlayTimeResponse_playTimeData.Add(data);
			}
			describeRTSNativeSDKPlayTimeResponse.PlayTimeData = describeRTSNativeSDKPlayTimeResponse_playTimeData;
        
			return describeRTSNativeSDKPlayTimeResponse;
        }
    }
}
