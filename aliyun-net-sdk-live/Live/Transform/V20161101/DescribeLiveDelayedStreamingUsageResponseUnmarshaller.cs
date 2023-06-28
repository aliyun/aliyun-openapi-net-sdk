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
    public class DescribeLiveDelayedStreamingUsageResponseUnmarshaller
    {
        public static DescribeLiveDelayedStreamingUsageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDelayedStreamingUsageResponse describeLiveDelayedStreamingUsageResponse = new DescribeLiveDelayedStreamingUsageResponse();

			describeLiveDelayedStreamingUsageResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDelayedStreamingUsageResponse.EndTime = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.EndTime");
			describeLiveDelayedStreamingUsageResponse.StartTime = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.StartTime");
			describeLiveDelayedStreamingUsageResponse.RequestId = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.RequestId");

			List<DescribeLiveDelayedStreamingUsageResponse.DescribeLiveDelayedStreamingUsage_DelayDataItem> describeLiveDelayedStreamingUsageResponse_delayData = new List<DescribeLiveDelayedStreamingUsageResponse.DescribeLiveDelayedStreamingUsage_DelayDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDelayedStreamingUsage.DelayData.Length"); i++) {
				DescribeLiveDelayedStreamingUsageResponse.DescribeLiveDelayedStreamingUsage_DelayDataItem delayDataItem = new DescribeLiveDelayedStreamingUsageResponse.DescribeLiveDelayedStreamingUsage_DelayDataItem();
				delayDataItem.Duration = _ctx.LongValue("DescribeLiveDelayedStreamingUsage.DelayData["+ i +"].Duration");
				delayDataItem.TimeStamp = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.DelayData["+ i +"].TimeStamp");
				delayDataItem.StreamName = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.DelayData["+ i +"].StreamName");
				delayDataItem.DomainName = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.DelayData["+ i +"].DomainName");
				delayDataItem.Region = _ctx.StringValue("DescribeLiveDelayedStreamingUsage.DelayData["+ i +"].Region");

				describeLiveDelayedStreamingUsageResponse_delayData.Add(delayDataItem);
			}
			describeLiveDelayedStreamingUsageResponse.DelayData = describeLiveDelayedStreamingUsageResponse_delayData;
        
			return describeLiveDelayedStreamingUsageResponse;
        }
    }
}
