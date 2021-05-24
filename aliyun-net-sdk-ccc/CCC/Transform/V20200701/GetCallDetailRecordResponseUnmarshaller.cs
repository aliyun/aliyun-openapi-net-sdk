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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetCallDetailRecordResponseUnmarshaller
    {
        public static GetCallDetailRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCallDetailRecordResponse getCallDetailRecordResponse = new GetCallDetailRecordResponse();

			getCallDetailRecordResponse.HttpResponse = _ctx.HttpResponse;
			getCallDetailRecordResponse.Code = _ctx.StringValue("GetCallDetailRecord.Code");
			getCallDetailRecordResponse.HttpStatusCode = _ctx.IntegerValue("GetCallDetailRecord.HttpStatusCode");
			getCallDetailRecordResponse.Message = _ctx.StringValue("GetCallDetailRecord.Message");
			getCallDetailRecordResponse.RequestId = _ctx.StringValue("GetCallDetailRecord.RequestId");

			GetCallDetailRecordResponse.GetCallDetailRecord_Data data = new GetCallDetailRecordResponse.GetCallDetailRecord_Data();
			data.AgentIds = _ctx.StringValue("GetCallDetailRecord.Data.AgentIds");
			data.AgentNames = _ctx.StringValue("GetCallDetailRecord.Data.AgentNames");
			data.CalledNumber = _ctx.StringValue("GetCallDetailRecord.Data.CalledNumber");
			data.CallingNumber = _ctx.StringValue("GetCallDetailRecord.Data.CallingNumber");
			data.ContactDisposition = _ctx.StringValue("GetCallDetailRecord.Data.ContactDisposition");
			data.ContactId = _ctx.StringValue("GetCallDetailRecord.Data.ContactId");
			data.ContactType = _ctx.StringValue("GetCallDetailRecord.Data.ContactType");
			data.CallDuration = _ctx.LongValue("GetCallDetailRecord.Data.CallDuration");
			data.EstablishedTime = _ctx.LongValue("GetCallDetailRecord.Data.EstablishedTime");
			data.InstanceId = _ctx.StringValue("GetCallDetailRecord.Data.InstanceId");
			data.StartTime = _ctx.LongValue("GetCallDetailRecord.Data.StartTime");
			data.ReleaseTime = _ctx.LongValue("GetCallDetailRecord.Data.ReleaseTime");
			data.SkillGroupIds = _ctx.StringValue("GetCallDetailRecord.Data.SkillGroupIds");
			data.SkillGroupNames = _ctx.StringValue("GetCallDetailRecord.Data.SkillGroupNames");
			data.SatisfactionSurveyOffered = _ctx.BooleanValue("GetCallDetailRecord.Data.SatisfactionSurveyOffered");
			data.Satisfaction = _ctx.IntegerValue("GetCallDetailRecord.Data.Satisfaction");
			data.SatisfactionSurveyChannel = _ctx.StringValue("GetCallDetailRecord.Data.SatisfactionSurveyChannel");
			data.ReleaseInitiator = _ctx.StringValue("GetCallDetailRecord.Data.ReleaseInitiator");
			data.RecordingReady = _ctx.BooleanValue("GetCallDetailRecord.Data.RecordingReady");

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem> data_cdrAgentEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.CdrAgentEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem cdrAgentEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem();
				cdrAgentEventsItem.AgentId = _ctx.StringValue("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].AgentId");
				cdrAgentEventsItem.AgentName = _ctx.StringValue("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].AgentName");
				cdrAgentEventsItem.SkillGroupId = _ctx.StringValue("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].SkillGroupId");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem.GetCallDetailRecord_EventSequenceItem> cdrAgentEventsItem_eventSequence = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem.GetCallDetailRecord_EventSequenceItem>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem.GetCallDetailRecord_EventSequenceItem eventSequenceItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrAgentEventsItem.GetCallDetailRecord_EventSequenceItem();
					eventSequenceItem._Event = _ctx.StringValue("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.CdrAgentEvents["+ i +"].EventSequence["+ j +"].EventTime");

					cdrAgentEventsItem_eventSequence.Add(eventSequenceItem);
				}
				cdrAgentEventsItem.EventSequence = cdrAgentEventsItem_eventSequence;

				data_cdrAgentEvents.Add(cdrAgentEventsItem);
			}
			data.CdrAgentEvents = data_cdrAgentEvents;

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem> data_cdrIvrEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.CdrIvrEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem cdrIvrEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem();
				cdrIvrEventsItem.FlowId = _ctx.StringValue("GetCallDetailRecord.Data.CdrIvrEvents["+ i +"].FlowId");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem.GetCallDetailRecord_EventSequenceItem2> cdrIvrEventsItem_eventSequence1 = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem.GetCallDetailRecord_EventSequenceItem2>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.CdrIvrEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem.GetCallDetailRecord_EventSequenceItem2 eventSequenceItem2 = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrIvrEventsItem.GetCallDetailRecord_EventSequenceItem2();
					eventSequenceItem2._Event = _ctx.StringValue("GetCallDetailRecord.Data.CdrIvrEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem2.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.CdrIvrEvents["+ i +"].EventSequence["+ j +"].EventTime");

					cdrIvrEventsItem_eventSequence1.Add(eventSequenceItem2);
				}
				cdrIvrEventsItem.EventSequence1 = cdrIvrEventsItem_eventSequence1;

				data_cdrIvrEvents.Add(cdrIvrEventsItem);
			}
			data.CdrIvrEvents = data_cdrIvrEvents;

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem> data_cdrQueueEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.CdrQueueEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem cdrQueueEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem();
				cdrQueueEventsItem.FlowId = _ctx.StringValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].FlowId");
				cdrQueueEventsItem.QueueId = _ctx.StringValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].QueueId");
				cdrQueueEventsItem.QueueName = _ctx.StringValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].QueueName");
				cdrQueueEventsItem.QueueType = _ctx.IntegerValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].QueueType");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem.GetCallDetailRecord_EventSequenceItem4> cdrQueueEventsItem_eventSequence3 = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem.GetCallDetailRecord_EventSequenceItem4>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem.GetCallDetailRecord_EventSequenceItem4 eventSequenceItem4 = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_CdrQueueEventsItem.GetCallDetailRecord_EventSequenceItem4();
					eventSequenceItem4._Event = _ctx.StringValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem4.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.CdrQueueEvents["+ i +"].EventSequence["+ j +"].EventTime");

					cdrQueueEventsItem_eventSequence3.Add(eventSequenceItem4);
				}
				cdrQueueEventsItem.EventSequence3 = cdrQueueEventsItem_eventSequence3;

				data_cdrQueueEvents.Add(cdrQueueEventsItem);
			}
			data.CdrQueueEvents = data_cdrQueueEvents;
			getCallDetailRecordResponse.Data = data;
        
			return getCallDetailRecordResponse;
        }
    }
}
