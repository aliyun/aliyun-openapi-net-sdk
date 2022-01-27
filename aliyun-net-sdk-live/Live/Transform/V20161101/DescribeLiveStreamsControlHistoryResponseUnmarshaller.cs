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
    public class DescribeLiveStreamsControlHistoryResponseUnmarshaller
    {
        public static DescribeLiveStreamsControlHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsControlHistoryResponse describeLiveStreamsControlHistoryResponse = new DescribeLiveStreamsControlHistoryResponse();

			describeLiveStreamsControlHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsControlHistoryResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsControlHistory.RequestId");

			List<DescribeLiveStreamsControlHistoryResponse.DescribeLiveStreamsControlHistory_LiveStreamControlInfo> describeLiveStreamsControlHistoryResponse_controlInfo = new List<DescribeLiveStreamsControlHistoryResponse.DescribeLiveStreamsControlHistory_LiveStreamControlInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsControlHistory.ControlInfo.Length"); i++) {
				DescribeLiveStreamsControlHistoryResponse.DescribeLiveStreamsControlHistory_LiveStreamControlInfo liveStreamControlInfo = new DescribeLiveStreamsControlHistoryResponse.DescribeLiveStreamsControlHistory_LiveStreamControlInfo();
				liveStreamControlInfo.StreamName = _ctx.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].StreamName");
				liveStreamControlInfo.ClientIP = _ctx.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].ClientIP");
				liveStreamControlInfo.Action = _ctx.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].Action");
				liveStreamControlInfo.TimeStamp = _ctx.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].TimeStamp");

				describeLiveStreamsControlHistoryResponse_controlInfo.Add(liveStreamControlInfo);
			}
			describeLiveStreamsControlHistoryResponse.ControlInfo = describeLiveStreamsControlHistoryResponse_controlInfo;
        
			return describeLiveStreamsControlHistoryResponse;
        }
    }
}
