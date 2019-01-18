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
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListCallDetailRecordsResponseUnmarshaller
    {
        public static ListCallDetailRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCallDetailRecordsResponse listCallDetailRecordsResponse = new ListCallDetailRecordsResponse();

			listCallDetailRecordsResponse.HttpResponse = context.HttpResponse;
			listCallDetailRecordsResponse.RequestId = context.StringValue("ListCallDetailRecords.RequestId");
			listCallDetailRecordsResponse.Success = context.BooleanValue("ListCallDetailRecords.Success");
			listCallDetailRecordsResponse.Code = context.StringValue("ListCallDetailRecords.Code");
			listCallDetailRecordsResponse.Message = context.StringValue("ListCallDetailRecords.Message");
			listCallDetailRecordsResponse.HttpStatusCode = context.IntegerValue("ListCallDetailRecords.HttpStatusCode");

			ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords callDetailRecords = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords();
			callDetailRecords.TotalCount = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.TotalCount");
			callDetailRecords.PageNumber = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.PageNumber");
			callDetailRecords.PageSize = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.PageSize");

			List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord> callDetailRecords_list = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord>();
			for (int i = 0; i < context.Length("ListCallDetailRecords.CallDetailRecords.List.Length"); i++) {
				ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord callDetailRecord = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord();
				callDetailRecord.ContactId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactId");
				callDetailRecord.StartTime = context.LongValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].StartTime");
				callDetailRecord.Duration = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Duration");
				callDetailRecord.Satisfaction = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Satisfaction");
				callDetailRecord.ContactType = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactType");
				callDetailRecord.ContactDisposition = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactDisposition");
				callDetailRecord.CallingNumber = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].CallingNumber");
				callDetailRecord.CalledNumber = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].CalledNumber");
				callDetailRecord.AgentNames = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].AgentNames");
				callDetailRecord.SkillGroupNames = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].SkillGroupNames");
				callDetailRecord.InstanceId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].InstanceId");
				callDetailRecord.ExtraAttr = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ExtraAttr");

				List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent> callDetailRecord_agents = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent>();
				for (int j = 0; j < context.Length("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents.Length"); j++) {
					ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent callDetailAgent = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent();
					callDetailAgent.ContactId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].ContactId");
					callDetailAgent.AgentId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentId");
					callDetailAgent.AgentName = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentName");
					callDetailAgent.SkillGroupName = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].SkillGroupName");
					callDetailAgent.QueueTime = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].QueueTime");
					callDetailAgent.RingTime = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].RingTime");
					callDetailAgent.StartTime = context.LongValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].StartTime");
					callDetailAgent.TalkTime = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].TalkTime");
					callDetailAgent.HoldTime = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].HoldTime");
					callDetailAgent.WorkTime = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].WorkTime");

					callDetailRecord_agents.Add(callDetailAgent);
				}
				callDetailRecord.Agents = callDetailRecord_agents;

				List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording> callDetailRecord_recordings = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording>();
				for (int j = 0; j < context.Length("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings.Length"); j++) {
					ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording recording = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording();
					recording.ContactId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactId");
					recording.ContactType = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactType");
					recording.AgentId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentId");
					recording.AgentName = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentName");
					recording.CallingNumber = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CallingNumber");
					recording.CalledNumber = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].CalledNumber");
					recording.StartTime = context.LongValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].StartTime");
					recording.Duration = context.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Duration");
					recording.FileName = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileName");
					recording.FilePath = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FilePath");
					recording.FileDescription = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileDescription");
					recording.Channel = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Channel");
					recording.InstanceId = context.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].InstanceId");

					callDetailRecord_recordings.Add(recording);
				}
				callDetailRecord.Recordings = callDetailRecord_recordings;

				callDetailRecords_list.Add(callDetailRecord);
			}
			callDetailRecords.List = callDetailRecords_list;
			listCallDetailRecordsResponse.CallDetailRecords = callDetailRecords;
        
			return listCallDetailRecordsResponse;
        }
    }
}