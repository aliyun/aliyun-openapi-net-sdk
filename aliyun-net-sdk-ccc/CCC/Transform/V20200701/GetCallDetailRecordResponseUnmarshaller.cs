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

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem> data_agentEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.AgentEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem agentEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem();
				agentEventsItem.AgentId = _ctx.StringValue("GetCallDetailRecord.Data.AgentEvents["+ i +"].AgentId");
				agentEventsItem.AgentName = _ctx.StringValue("GetCallDetailRecord.Data.AgentEvents["+ i +"].AgentName");
				agentEventsItem.SkillGroupId = _ctx.StringValue("GetCallDetailRecord.Data.AgentEvents["+ i +"].SkillGroupId");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem.GetCallDetailRecord_EventSequenceItem> agentEventsItem_eventSequence = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem.GetCallDetailRecord_EventSequenceItem>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.AgentEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem.GetCallDetailRecord_EventSequenceItem eventSequenceItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_AgentEventsItem.GetCallDetailRecord_EventSequenceItem();
					eventSequenceItem._Event = _ctx.StringValue("GetCallDetailRecord.Data.AgentEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.AgentEvents["+ i +"].EventSequence["+ j +"].EventTime");

					agentEventsItem_eventSequence.Add(eventSequenceItem);
				}
				agentEventsItem.EventSequence = agentEventsItem_eventSequence;

				data_agentEvents.Add(agentEventsItem);
			}
			data.AgentEvents = data_agentEvents;

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem> data_ivrEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.IvrEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem ivrEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem();
				ivrEventsItem.FlowId = _ctx.StringValue("GetCallDetailRecord.Data.IvrEvents["+ i +"].FlowId");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem.GetCallDetailRecord_EventSequenceItem2> ivrEventsItem_eventSequence1 = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem.GetCallDetailRecord_EventSequenceItem2>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.IvrEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem.GetCallDetailRecord_EventSequenceItem2 eventSequenceItem2 = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_IvrEventsItem.GetCallDetailRecord_EventSequenceItem2();
					eventSequenceItem2._Event = _ctx.StringValue("GetCallDetailRecord.Data.IvrEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem2.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.IvrEvents["+ i +"].EventSequence["+ j +"].EventTime");

					ivrEventsItem_eventSequence1.Add(eventSequenceItem2);
				}
				ivrEventsItem.EventSequence1 = ivrEventsItem_eventSequence1;

				data_ivrEvents.Add(ivrEventsItem);
			}
			data.IvrEvents = data_ivrEvents;

			List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem> data_queueEvents = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem>();
			for (int i = 0; i < _ctx.Length("GetCallDetailRecord.Data.QueueEvents.Length"); i++) {
				GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem queueEventsItem = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem();
				queueEventsItem.FlowId = _ctx.StringValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].FlowId");
				queueEventsItem.QueueId = _ctx.StringValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].QueueId");
				queueEventsItem.QueueName = _ctx.StringValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].QueueName");
				queueEventsItem.QueueType = _ctx.IntegerValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].QueueType");

				List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem.GetCallDetailRecord_EventSequenceItem4> queueEventsItem_eventSequence3 = new List<GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem.GetCallDetailRecord_EventSequenceItem4>();
				for (int j = 0; j < _ctx.Length("GetCallDetailRecord.Data.QueueEvents["+ i +"].EventSequence.Length"); j++) {
					GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem.GetCallDetailRecord_EventSequenceItem4 eventSequenceItem4 = new GetCallDetailRecordResponse.GetCallDetailRecord_Data.GetCallDetailRecord_QueueEventsItem.GetCallDetailRecord_EventSequenceItem4();
					eventSequenceItem4._Event = _ctx.StringValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].EventSequence["+ j +"].Event");
					eventSequenceItem4.EventTime = _ctx.LongValue("GetCallDetailRecord.Data.QueueEvents["+ i +"].EventSequence["+ j +"].EventTime");

					queueEventsItem_eventSequence3.Add(eventSequenceItem4);
				}
				queueEventsItem.EventSequence3 = queueEventsItem_eventSequence3;

				data_queueEvents.Add(queueEventsItem);
			}
			data.QueueEvents = data_queueEvents;
			getCallDetailRecordResponse.Data = data;
        
			return getCallDetailRecordResponse;
        }
    }
}
