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
    public class DescribeRtcQualityMetricResponseUnmarshaller
    {
        public static DescribeRtcQualityMetricResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcQualityMetricResponse describeRtcQualityMetricResponse = new DescribeRtcQualityMetricResponse();

			describeRtcQualityMetricResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcQualityMetricResponse.RequestId = _ctx.StringValue("DescribeRtcQualityMetric.RequestId");

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric qualityMetric = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo subInfo = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_User user = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_User();
			user.UserId = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.UserId");
			user.SDKVersion = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.SDKVersion");
			user.OS = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.OS");
			user.Province = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.Province");
			subInfo.User = user;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem> subInfo_data = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem dataItem = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem();
				dataItem.Time = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Time");

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Fps fps = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Fps();
				fps.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Small");
				fps.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Large");
				fps.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Super");
				fps.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Share");
				dataItem.Fps = fps;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Resolution resolution = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Resolution();
				resolution.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Small");
				resolution.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Large");
				resolution.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Super");
				resolution.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Share");
				dataItem.Resolution = resolution;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_BitRate bitRate = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_BitRate();
				bitRate.Audio = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Audio");
				bitRate.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Small");
				bitRate.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Large");
				bitRate.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Super");
				bitRate.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Share");
				dataItem.BitRate = bitRate;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Network network = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Network();
				network.Loss = _ctx.FloatValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Network.Loss");
				network.Rtt = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Network.Rtt");
				dataItem.Network = network;

				subInfo_data.Add(dataItem);
			}
			subInfo.Data = subInfo_data;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem> subInfo_events = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem>();
			for (int i = 0; i < _ctx.Length("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem eventsItem = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem();
				eventsItem.Time = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Time");
				eventsItem.EventId = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].EventId");
				eventsItem.Name = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Name");
				eventsItem.Category = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Category");
				eventsItem.Result = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Result");
				eventsItem.Description = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Description");

				subInfo_events.Add(eventsItem);
			}
			subInfo.Events = subInfo_events;
			qualityMetric.SubInfo = subInfo;

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo pubInfo = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_User1 user1 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_User1();
			user1.UserId = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.UserId");
			user1.SDKVersion = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.SDKVersion");
			user1.OS = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.OS");
			user1.Province = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.Province");
			pubInfo.User1 = user1;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4> pubInfo_data2 = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4>();
			for (int i = 0; i < _ctx.Length("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4 dataItem4 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4();
				dataItem4.Time = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Time");

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Fps5 fps5 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Fps5();
				fps5.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Small");
				fps5.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Large");
				fps5.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Super");
				fps5.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Share");
				dataItem4.Fps5 = fps5;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Resolution6 resolution6 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Resolution6();
				resolution6.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Small");
				resolution6.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Large");
				resolution6.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Super");
				resolution6.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Share");
				dataItem4.Resolution6 = resolution6;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_BitRate7 bitRate7 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_BitRate7();
				bitRate7.Audio = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Audio");
				bitRate7.Small = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Small");
				bitRate7.Large = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Large");
				bitRate7.Super = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Super");
				bitRate7.Share = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Share");
				dataItem4.BitRate7 = bitRate7;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Network8 network8 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Network8();
				network8.Loss = _ctx.FloatValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Network.Loss");
				network8.Rtt = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Network.Rtt");
				dataItem4.Network8 = network8;

				pubInfo_data2.Add(dataItem4);
			}
			pubInfo.Data2 = pubInfo_data2;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9> pubInfo_events3 = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9>();
			for (int i = 0; i < _ctx.Length("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9 eventsItem9 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9();
				eventsItem9.Time = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Time");
				eventsItem9.EventId = _ctx.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].EventId");
				eventsItem9.Name = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Name");
				eventsItem9.Category = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Category");
				eventsItem9.Result = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Result");
				eventsItem9.Description = _ctx.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Description");

				pubInfo_events3.Add(eventsItem9);
			}
			pubInfo.Events3 = pubInfo_events3;
			qualityMetric.PubInfo = pubInfo;
			describeRtcQualityMetricResponse.QualityMetric = qualityMetric;
        
			return describeRtcQualityMetricResponse;
        }
    }
}
