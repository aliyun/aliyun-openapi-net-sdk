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
        public static ListRecentCallRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			ListRecentCallRecordsResponse listRecentCallRecordsResponse = new ListRecentCallRecordsResponse();

			listRecentCallRecordsResponse.HttpResponse = context.HttpResponse;
			listRecentCallRecordsResponse.RequestId = context.StringValue("ListRecentCallRecords.RequestId");
			listRecentCallRecordsResponse.Success = context.BooleanValue("ListRecentCallRecords.Success");
			listRecentCallRecordsResponse.Code = context.StringValue("ListRecentCallRecords.Code");
			listRecentCallRecordsResponse.Message = context.StringValue("ListRecentCallRecords.Message");
			listRecentCallRecordsResponse.HttpStatusCode = context.IntegerValue("ListRecentCallRecords.HttpStatusCode");

			ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords callDetailRecords = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords();
			callDetailRecords.TotalCount = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.TotalCount");
			callDetailRecords.PageNumber = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.PageNumber");
			callDetailRecords.PageSize = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.PageSize");

			List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord> callDetailRecords_list = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord>();
			for (int i = 0; i < context.Length("ListRecentCallRecords.CallDetailRecords.List.Length"); i++) {
				ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord callDetailRecord = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord();
				callDetailRecord.ContactId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactId");
				callDetailRecord.StartTime = context.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].StartTime");
				callDetailRecord.Duration = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Duration");
				callDetailRecord.Satisfaction = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Satisfaction");
				callDetailRecord.ContactType = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactType");
				callDetailRecord.ContactDisposition = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ContactDisposition");
				callDetailRecord.CallingNumber = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].CallingNumber");
				callDetailRecord.CalledNumber = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].CalledNumber");
				callDetailRecord.AgentNames = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].AgentNames");
				callDetailRecord.SkillGroupNames = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].SkillGroupNames");
				callDetailRecord.InstanceId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].InstanceId");
				callDetailRecord.ExtraAttr = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ExtraAttr");
				callDetailRecord.ExtraAttr1 = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].ExtraAttr");
				callDetailRecord.SatisfactionDesc = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].SatisfactionDesc");
				callDetailRecord.Feedback = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Feedback");

				List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent> callDetailRecord_agents = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent>();
				for (int j = 0; j < context.Length("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents.Length"); j++) {
					ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent callDetailAgent = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_CallDetailAgent();
					callDetailAgent.ContactId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].ContactId");
					callDetailAgent.AgentId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentId");
					callDetailAgent.AgentName = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentName");
					callDetailAgent.SkillGroupName = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].SkillGroupName");
					callDetailAgent.QueueTime = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].QueueTime");
					callDetailAgent.RingTime = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].RingTime");
					callDetailAgent.StartTime = context.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].StartTime");
					callDetailAgent.TalkTime = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].TalkTime");
					callDetailAgent.HoldTime = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].HoldTime");
					callDetailAgent.WorkTime = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].WorkTime");
					callDetailAgent.Satisfaction = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Satisfaction");
					callDetailAgent.Feedback = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Feedback");

					callDetailRecord_agents.Add(callDetailAgent);
				}
				callDetailRecord.Agents = callDetailRecord_agents;

				List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording> callDetailRecord_recordings = new List<ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording>();
				for (int j = 0; j < context.Length("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings.Length"); j++) {
					ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording recording = new ListRecentCallRecordsResponse.ListRecentCallRecords_CallDetailRecords.ListRecentCallRecords_CallDetailRecord.ListRecentCallRecords_Recording();
					recording.ContactId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactId");
					recording.ContactType = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactType");
					recording.AgentId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentId");
					recording.AgentName = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentName");
					recording.CallingNumber = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CallingNumber");
					recording.CalledNumber = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CalledNumber");
					recording.StartTime = context.LongValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].StartTime");
					recording.Duration = context.IntegerValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Duration");
					recording.FileName = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileName");
					recording.FilePath = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FilePath");
					recording.FileDescription = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileDescription");
					recording.Channel = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Channel");
					recording.InstanceId = context.StringValue("ListRecentCallRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].InstanceId");

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
