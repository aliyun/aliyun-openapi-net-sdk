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
using Aliyun.Acs.Ons.Model.V20170918;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20170918
{
    public class OnsConsumerStatusResponseUnmarshaller
    {
        public static OnsConsumerStatusResponse Unmarshall(UnmarshallerContext context)
        {
			OnsConsumerStatusResponse onsConsumerStatusResponse = new OnsConsumerStatusResponse();

			onsConsumerStatusResponse.HttpResponse = context.HttpResponse;
			onsConsumerStatusResponse.RequestId = context.StringValue("OnsConsumerStatus.RequestId");
			onsConsumerStatusResponse.HelpUrl = context.StringValue("OnsConsumerStatus.HelpUrl");

			OnsConsumerStatusResponse.OnsConsumerStatus_Data data = new OnsConsumerStatusResponse.OnsConsumerStatus_Data();
			data.Online = context.BooleanValue("OnsConsumerStatus.Data.Online");
			data.TotalDiff = context.LongValue("OnsConsumerStatus.Data.TotalDiff");
			data.ConsumeTps = context.FloatValue("OnsConsumerStatus.Data.ConsumeTps");
			data.LastTimestamp = context.LongValue("OnsConsumerStatus.Data.LastTimestamp");
			data.DelayTime = context.LongValue("OnsConsumerStatus.Data.DelayTime");
			data.ConsumeModel = context.StringValue("OnsConsumerStatus.Data.ConsumeModel");
			data.SubscriptionSame = context.BooleanValue("OnsConsumerStatus.Data.SubscriptionSame");
			data.RebalanceOK = context.BooleanValue("OnsConsumerStatus.Data.RebalanceOK");

			List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConnectionDo> data_connectionSet = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConnectionDo>();
			for (int i = 0; i < context.Length("OnsConsumerStatus.Data.ConnectionSet.Length"); i++) {
				OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConnectionDo connectionDo = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConnectionDo();
				connectionDo.ClientId = context.StringValue("OnsConsumerStatus.Data.ConnectionSet["+ i +"].ClientId");
				connectionDo.ClientAddr = context.StringValue("OnsConsumerStatus.Data.ConnectionSet["+ i +"].ClientAddr");
				connectionDo.Language = context.StringValue("OnsConsumerStatus.Data.ConnectionSet["+ i +"].Language");
				connectionDo.Version = context.StringValue("OnsConsumerStatus.Data.ConnectionSet["+ i +"].Version");

				data_connectionSet.Add(connectionDo);
			}
			data.ConnectionSet = data_connectionSet;

			List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_DetailInTopicDo> data_detailInTopicList = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_DetailInTopicDo>();
			for (int i = 0; i < context.Length("OnsConsumerStatus.Data.DetailInTopicList.Length"); i++) {
				OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_DetailInTopicDo detailInTopicDo = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_DetailInTopicDo();
				detailInTopicDo.Topic = context.StringValue("OnsConsumerStatus.Data.DetailInTopicList["+ i +"].Topic");
				detailInTopicDo.TotalDiff = context.LongValue("OnsConsumerStatus.Data.DetailInTopicList["+ i +"].TotalDiff");
				detailInTopicDo.LastTimestamp = context.LongValue("OnsConsumerStatus.Data.DetailInTopicList["+ i +"].LastTimestamp");
				detailInTopicDo.DelayTime = context.LongValue("OnsConsumerStatus.Data.DetailInTopicList["+ i +"].DelayTime");

				data_detailInTopicList.Add(detailInTopicDo);
			}
			data.DetailInTopicList = data_detailInTopicList;

			List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo> data_consumerConnectionInfoList = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo>();
			for (int i = 0; i < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList.Length"); i++) {
				OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo consumerConnectionInfoDo = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo();
				consumerConnectionInfoDo.ClientId = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].ClientId");
				consumerConnectionInfoDo.Connection = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Connection");
				consumerConnectionInfoDo.Language = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Language");
				consumerConnectionInfoDo.Version = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Version");
				consumerConnectionInfoDo.ConsumeModel = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].ConsumeModel");
				consumerConnectionInfoDo.ConsumeType = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].ConsumeType");
				consumerConnectionInfoDo.ThreadCount = context.IntegerValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].ThreadCount");
				consumerConnectionInfoDo.StartTimeStamp = context.LongValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].StartTimeStamp");
				consumerConnectionInfoDo.LastTimeStamp = context.LongValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].LastTimeStamp");

				List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_SubscriptionData> consumerConnectionInfoDo_subscriptionSet = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_SubscriptionData>();
				for (int j = 0; j < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet.Length"); j++) {
					OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_SubscriptionData subscriptionData = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_SubscriptionData();
					subscriptionData.Topic = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet["+ j +"].Topic");
					subscriptionData.SubString = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet["+ j +"].SubString");
					subscriptionData.SubVersion = context.LongValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet["+ j +"].SubVersion");

					List<string> subscriptionData_tagsSet = new List<string>();
					for (int k = 0; k < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet["+ j +"].TagsSet.Length"); k++) {
						subscriptionData_tagsSet.Add(context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].SubscriptionSet["+ j +"].TagsSet["+ k +"]"));
					}
					subscriptionData.TagsSet = subscriptionData_tagsSet;

					consumerConnectionInfoDo_subscriptionSet.Add(subscriptionData);
				}
				consumerConnectionInfoDo.SubscriptionSet = consumerConnectionInfoDo_subscriptionSet;

				List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ConsumerRunningDataDo> consumerConnectionInfoDo_runningDataList = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ConsumerRunningDataDo>();
				for (int j = 0; j < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList.Length"); j++) {
					OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ConsumerRunningDataDo consumerRunningDataDo = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ConsumerRunningDataDo();
					consumerRunningDataDo.ConsumerId = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].ConsumerId");
					consumerRunningDataDo.Topic = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].Topic");
					consumerRunningDataDo.Rt = context.FloatValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].Rt");
					consumerRunningDataDo.OkTps = context.FloatValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].OkTps");
					consumerRunningDataDo.FailedTps = context.FloatValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].FailedTps");
					consumerRunningDataDo.FailedCountPerHour = context.LongValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].RunningDataList["+ j +"].FailedCountPerHour");

					consumerConnectionInfoDo_runningDataList.Add(consumerRunningDataDo);
				}
				consumerConnectionInfoDo.RunningDataList = consumerConnectionInfoDo_runningDataList;

				List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ThreadTrackDo> consumerConnectionInfoDo_jstack = new List<OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ThreadTrackDo>();
				for (int j = 0; j < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Jstack.Length"); j++) {
					OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ThreadTrackDo threadTrackDo = new OnsConsumerStatusResponse.OnsConsumerStatus_Data.OnsConsumerStatus_ConsumerConnectionInfoDo.OnsConsumerStatus_ThreadTrackDo();
					threadTrackDo.Thread = context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Jstack["+ j +"].Thread");

					List<string> threadTrackDo_trackList = new List<string>();
					for (int k = 0; k < context.Length("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Jstack["+ j +"].TrackList.Length"); k++) {
						threadTrackDo_trackList.Add(context.StringValue("OnsConsumerStatus.Data.ConsumerConnectionInfoList["+ i +"].Jstack["+ j +"].TrackList["+ k +"]"));
					}
					threadTrackDo.TrackList = threadTrackDo_trackList;

					consumerConnectionInfoDo_jstack.Add(threadTrackDo);
				}
				consumerConnectionInfoDo.Jstack = consumerConnectionInfoDo_jstack;

				data_consumerConnectionInfoList.Add(consumerConnectionInfoDo);
			}
			data.ConsumerConnectionInfoList = data_consumerConnectionInfoList;
			onsConsumerStatusResponse.Data = data;
        
			return onsConsumerStatusResponse;
        }
    }
}