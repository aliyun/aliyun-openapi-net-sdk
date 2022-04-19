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
			describeSuspEventsResponse.CurrentPage = _ctx.IntegerValue("DescribeSuspEvents.CurrentPage");
			describeSuspEventsResponse.PageSize = _ctx.IntegerValue("DescribeSuspEvents.PageSize");
			describeSuspEventsResponse.RequestId = _ctx.StringValue("DescribeSuspEvents.RequestId");
			describeSuspEventsResponse.TotalCount = _ctx.IntegerValue("DescribeSuspEvents.TotalCount");
			describeSuspEventsResponse.Count = _ctx.IntegerValue("DescribeSuspEvents.Count");

			List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary> describeSuspEventsResponse_suspEvents = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary>();
			for (int i = 0; i < _ctx.Length("DescribeSuspEvents.SuspEvents.Length"); i++) {
				DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary warningSummary = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary();
				warningSummary.Stages = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Stages");
				warningSummary.InternetIp = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InternetIp");
				warningSummary.K8sClusterName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sClusterName");
				warningSummary.ContainerImageId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerImageId");
				warningSummary.LastTimeStamp = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].LastTimeStamp");
				warningSummary.OccurrenceTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OccurrenceTime");
				warningSummary.AlarmUniqueInfo = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmUniqueInfo");
				warningSummary.Desc = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Desc");
				warningSummary.CanCancelFault = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].CanCancelFault");
				warningSummary.AlarmEventNameDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventNameDisplay");
				warningSummary.AppName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AppName");
				warningSummary.SecurityEventIds = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].SecurityEventIds");
				warningSummary.K8sClusterId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sClusterId");
				warningSummary.ContainerImageName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerImageName");
				warningSummary.MarkMisRules = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].MarkMisRules");
				warningSummary.CanBeDealOnLine = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].CanBeDealOnLine");
				warningSummary.ContainHwMode = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainHwMode");
				warningSummary.K8sNodeId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNodeId");
				warningSummary.InstanceName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InstanceName");
				warningSummary.EventStatus = _ctx.IntegerValue("DescribeSuspEvents.SuspEvents["+ i +"].EventStatus");
				warningSummary.SaleVersion = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].SaleVersion");
				warningSummary.OperateErrorCode = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateErrorCode");
				warningSummary.Name = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Name");
				warningSummary.HasTraceInfo = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].HasTraceInfo");
				warningSummary.DataSource = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].DataSource");
				warningSummary.OperateTime = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateTime");
				warningSummary.EventSubType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventSubType");
				warningSummary.Advanced = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].Advanced");
				warningSummary.OccurrenceTimeStamp = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].OccurrenceTimeStamp");
				warningSummary.InstanceId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].InstanceId");
				warningSummary.AlarmEventTypeDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventTypeDisplay");
				warningSummary.IntranetIp = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].IntranetIp");
				warningSummary.LastTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].LastTime");
				warningSummary.OperateMsg = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].OperateMsg");
				warningSummary.Uuid = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Uuid");
				warningSummary.K8sPodName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sPodName");
				warningSummary.ContainerId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].ContainerId");
				warningSummary.AlarmEventType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventType");
				warningSummary.K8sNamespace = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNamespace");
				warningSummary.AutoBreaking = _ctx.BooleanValue("DescribeSuspEvents.SuspEvents["+ i +"].AutoBreaking");
				warningSummary.K8sNodeName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].K8sNodeName");
				warningSummary.AlarmEventName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].AlarmEventName");
				warningSummary.UniqueInfo = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].UniqueInfo");
				warningSummary.MaliciousRuleStatus = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].MaliciousRuleStatus");
				warningSummary.Level = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Level");
				warningSummary.Id = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].Id");

				List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_TacticItem> warningSummary_tacticItems = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_TacticItem>();
				for (int j = 0; j < _ctx.Length("DescribeSuspEvents.SuspEvents["+ i +"].TacticItems.Length"); j++) {
					DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_TacticItem tacticItem = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_TacticItem();
					tacticItem.TacticId = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].TacticItems["+ j +"].TacticId");
					tacticItem.TacticDisplayName = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].TacticItems["+ j +"].TacticDisplayName");

					warningSummary_tacticItems.Add(tacticItem);
				}
				warningSummary.TacticItems = warningSummary_tacticItems;

				List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile> warningSummary_details = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile>();
				for (int j = 0; j < _ctx.Length("DescribeSuspEvents.SuspEvents["+ i +"].Details.Length"); j++) {
					DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile quaraFile = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_QuaraFile();
					quaraFile.Type = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Type");
					quaraFile._Value = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Value");
					quaraFile.Name = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].Name");
					quaraFile.NameDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].NameDisplay");
					quaraFile.InfoType = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].InfoType");
					quaraFile.ValueDisplay = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].Details["+ j +"].ValueDisplay");

					warningSummary_details.Add(quaraFile);
				}
				warningSummary.Details = warningSummary_details;

				List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote> warningSummary_eventNotes = new List<DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote>();
				for (int j = 0; j < _ctx.Length("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes.Length"); j++) {
					DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote eventNote = new DescribeSuspEventsResponse.DescribeSuspEvents_WarningSummary.DescribeSuspEvents_EventNote();
					eventNote.Note = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].Note");
					eventNote.NoteId = _ctx.LongValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].NoteId");
					eventNote.NoteTime = _ctx.StringValue("DescribeSuspEvents.SuspEvents["+ i +"].EventNotes["+ j +"].NoteTime");

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
