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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListRecentCallRecordsResponseUnmarshaller
    {
        public static ListRecentCallRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecentCallRecordsResponse listRecentCallRecordsResponse = new ListRecentCallRecordsResponse();

			listRecentCallRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listRecentCallRecordsResponse.RequestId = _ctx.StringValue("ListRecentCallRecords.RequestId");
			listRecentCallRecordsResponse.Success = _ctx.BooleanValue("ListRecentCallRecords.Success");
			listRecentCallRecordsResponse.Code = _ctx.StringValue("ListRecentCallRecords.Code");
			listRecentCallRecordsResponse.Message = _ctx.StringValue("ListRecentCallRecords.Message");
			listRecentCallRecordsResponse.HttpStatusCode = _ctx.IntegerValue("ListRecentCallRecords.HttpStatusCode");

			ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords callDetailRecords = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords();
			callDetailRecords.TotalCount = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.TotalCount");
			callDetailRecords.PageNumber = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.PageNumber");
			callDetailRecords.PageSize = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.PageSize");

			List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord> callDetailRecords_list = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord>();
			for (int i = 0; i < _ctx.Length("ListRecentCallRecords.CallDetailRecords.List.Length"); i++) {
				ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord callDetailRecord = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord();
				callDetailRecord.ContactId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactId");
				callDetailRecord.StartTime = _ctx.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].StartTime");
				callDetailRecord.Duration = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Duration");
				callDetailRecord.Satisfaction = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Satisfaction");
				callDetailRecord.ContactType = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactType");
				callDetailRecord.ContactDisposition = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactDisposition");
				callDetailRecord.CallingNumber = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].CallingNumber");
				callDetailRecord.CalledNumber = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].CalledNumber");
				callDetailRecord.AgentNames = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].AgentNames");
				callDetailRecord.SkillGroupNames = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].SkillGroupNames");
				callDetailRecord.InstanceId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].InstanceId");
				callDetailRecord.ExtraAttr = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ExtraAttr");
				callDetailRecord.ExtraAttr1 = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ExtraAttr");
				callDetailRecord.SatisfactionDesc = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].SatisfactionDesc");
				callDetailRecord.Feedback = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Feedback");

				List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent> callDetailRecord_agents = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent>();
				for (int j = 0; j < _ctx.Length("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents.Length"); j++) {
					ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent callDetailAgent = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent();
					callDetailAgent.ContactId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].ContactId");
					callDetailAgent.AgentId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentId");
					callDetailAgent.AgentName = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentName");
					callDetailAgent.SkillGroupName = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].SkillGroupName");
					callDetailAgent.QueueTime = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].QueueTime");
					callDetailAgent.RingTime = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].RingTime");
					callDetailAgent.StartTime = _ctx.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].StartTime");
					callDetailAgent.TalkTime = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].TalkTime");
					callDetailAgent.HoldTime = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].HoldTime");
					callDetailAgent.WorkTime = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].WorkTime");
					callDetailAgent.Satisfaction = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Satisfaction");
					callDetailAgent.Feedback = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Feedback");

					callDetailRecord_agents.Add(callDetailAgent);
				}
				callDetailRecord.Agents = callDetailRecord_agents;

				List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording> callDetailRecord_recordings = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording>();
				for (int j = 0; j < _ctx.Length("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings.Length"); j++) {
					ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording recording = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording();
					recording.ContactId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactId");
					recording.ContactType = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactType");
					recording.AgentId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentId");
					recording.AgentName = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentName");
					recording.CallingNumber = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CallingNumber");
					recording.CalledNumber = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CalledNumber");
					recording.StartTime = _ctx.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].StartTime");
					recording.Duration = _ctx.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Duration");
					recording.FileName = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileName");
					recording.FilePath = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FilePath");
					recording.FileDescription = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileDescription");
					recording.Channel = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Channel");
					recording.InstanceId = _ctx.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].InstanceId");

					callDetailRecord_recordings.Add(recording);
				}
				callDetailRecord.Recordings = callDetailRecord_recordings;

				callDetailRecords_list.Add(callDetailRecord);
			}
			callDetailRecords.List = callDetailRecords_list;
			listRecentCallRecordsResponse.CallDetailRecords = callDetailRecords;
        
			return listRecentCallRecordsResponse;
        }
    }
}
