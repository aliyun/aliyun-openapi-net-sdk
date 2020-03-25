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
        public static DescribeRtcQualityMetricResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRtcQualityMetricResponse describeRtcQualityMetricResponse = new DescribeRtcQualityMetricResponse();

			describeRtcQualityMetricResponse.HttpResponse = context.HttpResponse;
			describeRtcQualityMetricResponse.RequestId = context.StringValue("DescribeRtcQualityMetric.RequestId");

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric qualityMetric = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo subInfo = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_User user = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_User();
			user.UserId = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.UserId");
			user.SDKVersion = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.SDKVersion");
			user.OS = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.OS");
			user.Province = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.User.Province");
			subInfo.User = user;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem> subInfo_data = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem>();
			for (int i = 0; i < context.Length("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem dataItem = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem();
				dataItem.Time = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Time");

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Fps fps = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Fps();
				fps.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Small");
				fps.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Large");
				fps.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Super");
				fps.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Fps.Share");
				dataItem.Fps = fps;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Resolution resolution = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Resolution();
				resolution.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Small");
				resolution.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Large");
				resolution.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Super");
				resolution.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Resolution.Share");
				dataItem.Resolution = resolution;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_BitRate bitRate = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_BitRate();
				bitRate.Audio = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Audio");
				bitRate.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Small");
				bitRate.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Large");
				bitRate.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Super");
				bitRate.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].BitRate.Share");
				dataItem.BitRate = bitRate;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Network network = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_DataItem.DescribeRtcQualityMetric_Network();
				network.Loss = context.FloatValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Network.Loss");
				network.Rtt = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Data["+ i +"].Network.Rtt");
				dataItem.Network = network;

				subInfo_data.Add(dataItem);
			}
			subInfo.Data = subInfo_data;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem> subInfo_events = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem>();
			for (int i = 0; i < context.Length("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem eventsItem = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_SubInfo.DescribeRtcQualityMetric_EventsItem();
				eventsItem.Time = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Time");
				eventsItem.EventId = context.LongValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].EventId");
				eventsItem.Name = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Name");
				eventsItem.Category = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Category");
				eventsItem.Result = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Result");
				eventsItem.Description = context.StringValue("DescribeRtcQualityMetric.QualityMetric.SubInfo.Events["+ i +"].Description");

				subInfo_events.Add(eventsItem);
			}
			subInfo.Events = subInfo_events;
			qualityMetric.SubInfo = subInfo;

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo pubInfo = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo();

			DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_User1 user1 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_User1();
			user1.UserId = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.UserId");
			user1.SDKVersion = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.SDKVersion");
			user1.OS = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.OS");
			user1.Province = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.User.Province");
			pubInfo.User1 = user1;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4> pubInfo_data2 = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4>();
			for (int i = 0; i < context.Length("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4 dataItem4 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4();
				dataItem4.Time = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Time");

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Fps5 fps5 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Fps5();
				fps5.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Small");
				fps5.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Large");
				fps5.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Super");
				fps5.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Fps.Share");
				dataItem4.Fps5 = fps5;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Resolution6 resolution6 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Resolution6();
				resolution6.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Small");
				resolution6.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Large");
				resolution6.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Super");
				resolution6.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Resolution.Share");
				dataItem4.Resolution6 = resolution6;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_BitRate7 bitRate7 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_BitRate7();
				bitRate7.Audio = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Audio");
				bitRate7.Small = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Small");
				bitRate7.Large = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Large");
				bitRate7.Super = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Super");
				bitRate7.Share = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].BitRate.Share");
				dataItem4.BitRate7 = bitRate7;

				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Network8 network8 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_DataItem4.DescribeRtcQualityMetric_Network8();
				network8.Loss = context.FloatValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Network.Loss");
				network8.Rtt = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Data["+ i +"].Network.Rtt");
				dataItem4.Network8 = network8;

				pubInfo_data2.Add(dataItem4);
			}
			pubInfo.Data2 = pubInfo_data2;

			List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9> pubInfo_events3 = new List<DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9>();
			for (int i = 0; i < context.Length("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events.Length"); i++) {
				DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9 eventsItem9 = new DescribeRtcQualityMetricResponse.DescribeRtcQualityMetric_QualityMetric.DescribeRtcQualityMetric_PubInfo.DescribeRtcQualityMetric_EventsItem9();
				eventsItem9.Time = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Time");
				eventsItem9.EventId = context.LongValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].EventId");
				eventsItem9.Name = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Name");
				eventsItem9.Category = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Category");
				eventsItem9.Result = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Result");
				eventsItem9.Description = context.StringValue("DescribeRtcQualityMetric.QualityMetric.PubInfo.Events["+ i +"].Description");

				pubInfo_events3.Add(eventsItem9);
			}
			pubInfo.Events3 = pubInfo_events3;
			qualityMetric.PubInfo = pubInfo;
			describeRtcQualityMetricResponse.QualityMetric = qualityMetric;
        
			return describeRtcQualityMetricResponse;
        }
    }
}
