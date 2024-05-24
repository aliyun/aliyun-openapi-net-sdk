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
    public class DescribeMeterLiveBypassDurationResponseUnmarshaller
    {
        public static DescribeMeterLiveBypassDurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMeterLiveBypassDurationResponse describeMeterLiveBypassDurationResponse = new DescribeMeterLiveBypassDurationResponse();

			describeMeterLiveBypassDurationResponse.HttpResponse = _ctx.HttpResponse;
			describeMeterLiveBypassDurationResponse.AudioSummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.AudioSummaryDuration");
			describeMeterLiveBypassDurationResponse.RequestId = _ctx.StringValue("DescribeMeterLiveBypassDuration.RequestId");
			describeMeterLiveBypassDurationResponse.SingleAudioSummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.SingleAudioSummaryDuration");
			describeMeterLiveBypassDurationResponse.SingleVideoSummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.SingleVideoSummaryDuration");
			describeMeterLiveBypassDurationResponse.TotalSummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.TotalSummaryDuration");
			describeMeterLiveBypassDurationResponse.V480SummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.V480SummaryDuration");
			describeMeterLiveBypassDurationResponse.V720SummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.V720SummaryDuration");
			describeMeterLiveBypassDurationResponse.V1080SummaryDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.V1080SummaryDuration");

			List<DescribeMeterLiveBypassDurationResponse.DescribeMeterLiveBypassDuration_DataItem> describeMeterLiveBypassDurationResponse_data = new List<DescribeMeterLiveBypassDurationResponse.DescribeMeterLiveBypassDuration_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeMeterLiveBypassDuration.Data.Length"); i++) {
				DescribeMeterLiveBypassDurationResponse.DescribeMeterLiveBypassDuration_DataItem dataItem = new DescribeMeterLiveBypassDurationResponse.DescribeMeterLiveBypassDuration_DataItem();
				dataItem.AudioDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].AudioDuration");
				dataItem.Single_Audio = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].Single_Audio");
				dataItem.Single_Video = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].Single_Video");
				dataItem.Timestamp = _ctx.StringValue("DescribeMeterLiveBypassDuration.Data["+ i +"].Timestamp");
				dataItem.TotalDuration = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].TotalDuration");
				dataItem.V480Duration = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].V480Duration");
				dataItem.V720Duration = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].V720Duration");
				dataItem.V1080Duration = _ctx.LongValue("DescribeMeterLiveBypassDuration.Data["+ i +"].V1080Duration");

				describeMeterLiveBypassDurationResponse_data.Add(dataItem);
			}
			describeMeterLiveBypassDurationResponse.Data = describeMeterLiveBypassDurationResponse_data;
        
			return describeMeterLiveBypassDurationResponse;
        }
    }
}
