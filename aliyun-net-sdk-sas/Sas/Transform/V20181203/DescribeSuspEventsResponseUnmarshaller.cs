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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSuspEventsResponseUnmarshaller
    {
        public static DescribeSuspEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSuspEventsResponse describeSuspEventsResponse = new DescribeSuspEventsResponse();

			describeSuspEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeSuspEventsResponse.RequestId = _ctx.StringValue("DescribeSuspEvents.RequestId");
			describeSuspEventsResponse.Count = _ctx.IntegerValue("DescribeSuspEvents.Count");
			describeSuspEventsResponse.PageSize = _ctx.IntegerValue("DescribeSuspEvents.PageSize");
			describeSuspEventsResponse.TotalCount = _ctx.IntegerValue("DescribeSuspEvents.TotalCount");
			describeSuspEventsResponse.CurrentPage = _ctx.IntegerValue("DescribeSuspEvents.CurrentPage");

			List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary> describeSuspEventsResponse_suspEvents = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary>();
			for (int i = 0; i < _ctx.Length("DescribeSuspEvents.SuspEvents.Length"); i++) {
				DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary warningSummary = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary();
				warningSummary.LastTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].LastTime");
				warningSummary.LastTimeStamp = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].LastTimeStamp");
				warningSummary.OccurrenceTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OccurrenceTime");
				warningSummary.OccurrenceTimeStamp = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].OccurrenceTimeStamp");
				warningSummary.Id = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].Id");
				warningSummary.SecurityEventIds = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].SecurityEventIds");
				warningSummary.UniqueInfo = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].UniqueInfo");
				warningSummary.InstanceName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InstanceName");
				warningSummary.InstanceId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InstanceId");
				warningSummary.InternetIp = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InternetIp");
				warningSummary.IntranetIp = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].IntranetIp");
				warningSummary.Uuid = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Uuid");
				warningSummary.Name = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Name");
				warningSummary.EventSubType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventSubType");
				warningSummary.Level = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Level");
				warningSummary.EventStatus = _ctx.IntegerValue("DescribeSuspEvents.SuspEvents["+ i +"].EventStatus");
				warningSummary.Desc = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Desc");
				warningSummary.OperateMsg = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateMsg");
				warningSummary.OperateErrorCode = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateErrorCode");
				warningSummary.OperateTime = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateTime");
				warningSummary.DataSource = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].DataSource");
				warningSummary.CanBeDealOnLine = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].CanBeDealOnLine");
				warningSummary.SaleVersion = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].SaleVersion");
				warningSummary.AlarmEventType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventType");
				warningSummary.AlarmEventName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventName");
				warningSummary.AlarmUniqueInfo = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmUniqueInfo");
				warningSummary.Advanced = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].Advanced");
				warningSummary.MarkMisRules = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].MarkMisRules");
				warningSummary.Stages = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Stages");
				warningSummary.AlarmEventTypeDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventTypeDisplay");
				warningSummary.AlarmEventNameDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventNameDisplay");
				warningSummary.CanCancelFault = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].CanCancelFault");
				warningSummary.HasTraceInfo = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].HasTraceInfo");
				warningSummary.AutoBreaking = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].AutoBreaking");
				warningSummary.ContainHwMode = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainHwMode");
				warningSummary.ContainerImageId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerImageId");
				warningSummary.ContainerImageName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerImageName");
				warningSummary.ContainerId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerId");
				warningSummary.K8sNamespace = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNamespace");
				warningSummary.K8sClusterId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sClusterId");
				warningSummary.K8sClusterName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sClusterName");
				warningSummary.K8sNodeId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNodeId");
				warningSummary.K8sPodName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sPodName");
				warningSummary.K8sNodeName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNodeName");
				warningSummary.AppName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AppName");

				List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile> warningSummary_details = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile>();
				for (int j = 0; j < _ctx.Length("DescribeSuspEvents.SuspEvents["+ i +"].Details.Length"); j++) {
					DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile quaraFile = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile();
					quaraFile.Name = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Name");
					quaraFile.NameDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].NameDisplay");
					quaraFile.Type = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Type");
					quaraFile.InfoType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].InfoType");
					quaraFile._Value = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Value");
					quaraFile.ValueDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].ValueDisplay");

					warningSummary_details.Add(quaraFile);
				}
				warningSummary.Details = warningSummary_details;

				List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote> warningSummary_eventNotes = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote>();
				for (int j = 0; j < _ctx.Length("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes.Length"); j++) {
					DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote eventNote = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote();
					eventNote.NoteTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].NoteTime");
					eventNote.Note = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].Note");
					eventNote.NoteId = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].NoteId");

					warningSummary_eventNotes.Add(eventNote);
				}
				warningSummary.EventNotes = warningSummary_eventNotes;

				describeSuspEventsResponse_suspEvents.Add(warningSummary);
			}
			describeSuspEventsResponse.SuspEvents = describeSuspEventsResponse_suspEvents;
        
			return describeSuspEventsResponse;
        }
    }
}
