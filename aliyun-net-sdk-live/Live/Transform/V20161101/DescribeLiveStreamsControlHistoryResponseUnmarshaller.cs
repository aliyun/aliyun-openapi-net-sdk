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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Live.Transform.V20161101
{
    public class DescribeLiveStreamsControlHistoryResponseUnmarshaller
    {
        public static DescribeLiveStreamsControlHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamsControlHistoryResponse describeLiveStreamsControlHistoryResponse = new DescribeLiveStreamsControlHistoryResponse();

			describeLiveStreamsControlHistoryResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamsControlHistoryResponse.RequestId = context.StringValue("DescribeLiveStreamsControlHistory.RequestId");

			List<DescribeLiveStreamsControlHistoryResponse.LiveStreamControlInfo> controlInfo = new List<DescribeLiveStreamsControlHistoryResponse.LiveStreamControlInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamsControlHistory.ControlInfo.Length"); i++) {
				DescribeLiveStreamsControlHistoryResponse.LiveStreamControlInfo liveStreamControlInfo = new DescribeLiveStreamsControlHistoryResponse.LiveStreamControlInfo();
				liveStreamControlInfo.StreamName = context.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].StreamName");
				liveStreamControlInfo.ClientIP = context.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].ClientIP");
				liveStreamControlInfo.Action = context.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].Action");
				liveStreamControlInfo.TimeStamp = context.StringValue("DescribeLiveStreamsControlHistory.ControlInfo["+ i +"].TimeStamp");

				controlInfo.Add(liveStreamControlInfo);
			}
			describeLiveStreamsControlHistoryResponse.ControlInfo = controlInfo;
        
			return describeLiveStreamsControlHistoryResponse;
        }
    }
}