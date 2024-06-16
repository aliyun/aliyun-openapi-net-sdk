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
    public class DescribeMeterLiveRtcDurationResponseUnmarshaller
    {
        public static DescribeMeterLiveRtcDurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMeterLiveRtcDurationResponse describeMeterLiveRtcDurationResponse = new DescribeMeterLiveRtcDurationResponse();

			describeMeterLiveRtcDurationResponse.HttpResponse = _ctx.HttpResponse;
			describeMeterLiveRtcDurationResponse.AudioSummaryDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.AudioSummaryDuration");
			describeMeterLiveRtcDurationResponse.RequestId = _ctx.StringValue("DescribeMeterLiveRtcDuration.RequestId");
			describeMeterLiveRtcDurationResponse.TotalSummaryDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.TotalSummaryDuration");
			describeMeterLiveRtcDurationResponse.V480SummaryDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.V480SummaryDuration");
			describeMeterLiveRtcDurationResponse.V720SummaryDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.V720SummaryDuration");
			describeMeterLiveRtcDurationResponse.V1080SummaryDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.V1080SummaryDuration");

			List<DescribeMeterLiveRtcDurationResponse.DescribeMeterLiveRtcDuration_DataItem> describeMeterLiveRtcDurationResponse_data = new List<DescribeMeterLiveRtcDurationResponse.DescribeMeterLiveRtcDuration_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeMeterLiveRtcDuration.Data.Length"); i++) {
				DescribeMeterLiveRtcDurationResponse.DescribeMeterLiveRtcDuration_DataItem dataItem = new DescribeMeterLiveRtcDurationResponse.DescribeMeterLiveRtcDuration_DataItem();
				dataItem.AudioDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.Data["+ i +"].AudioDuration");
				dataItem.Timestamp = _ctx.StringValue("DescribeMeterLiveRtcDuration.Data["+ i +"].Timestamp");
				dataItem.TotalDuration = _ctx.LongValue("DescribeMeterLiveRtcDuration.Data["+ i +"].TotalDuration");
				dataItem.V480Duration = _ctx.LongValue("DescribeMeterLiveRtcDuration.Data["+ i +"].V480Duration");
				dataItem.V720Duration = _ctx.LongValue("DescribeMeterLiveRtcDuration.Data["+ i +"].V720Duration");
				dataItem.V1080Duration = _ctx.LongValue("DescribeMeterLiveRtcDuration.Data["+ i +"].V1080Duration");

				describeMeterLiveRtcDurationResponse_data.Add(dataItem);
			}
			describeMeterLiveRtcDurationResponse.Data = describeMeterLiveRtcDurationResponse_data;
        
			return describeMeterLiveRtcDurationResponse;
        }
    }
}
