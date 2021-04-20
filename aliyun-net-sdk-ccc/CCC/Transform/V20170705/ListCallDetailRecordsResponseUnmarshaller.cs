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
    public class ListCallDetailRecordsResponseUnmarshaller
    {
        public static ListCallDetailRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallDetailRecordsResponse listCallDetailRecordsResponse = new ListCallDetailRecordsResponse();

			listCallDetailRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listCallDetailRecordsResponse.RequestId = _ctx.StringValue("ListCallDetailRecords.RequestId");
			listCallDetailRecordsResponse.Success = _ctx.BooleanValue("ListCallDetailRecords.Success");
			listCallDetailRecordsResponse.Code = _ctx.StringValue("ListCallDetailRecords.Code");
			listCallDetailRecordsResponse.Message = _ctx.StringValue("ListCallDetailRecords.Message");
			listCallDetailRecordsResponse.HttpStatusCode = _ctx.IntegerValue("ListCallDetailRecords.HttpStatusCode");

			ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords callDetailRecords = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords();
			callDetailRecords.TotalCount = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.TotalCount");
			callDetailRecords.PageNumber = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.PageNumber");
			callDetailRecords.PageSize = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.PageSize");

			List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord> callDetailRecords_list = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord>();
			for (int i = 0; i < _ctx.Length("ListCallDetailRecords.CallDetailRecords.List.Length"); i++) {
				ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord callDetailRecord = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord();
				callDetailRecord.ContactId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactId");
				callDetailRecord.StartTime = _ctx.LongValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].StartTime");
				callDetailRecord.Duration = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Duration");
				callDetailRecord.Satisfaction = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Satisfaction");
				callDetailRecord.SatisfactionDesc = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].SatisfactionDesc");
				callDetailRecord.Feedback = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Feedback");
				callDetailRecord.ContactType = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactType");
				callDetailRecord.ContactDisposition = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].ContactDisposition");
				callDetailRecord.CallingNumber = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].CallingNumber");
				callDetailRecord.CalledNumber = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].CalledNumber");
				callDetailRecord.AgentNames = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].AgentNames");
				callDetailRecord.SkillGroupNames = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].SkillGroupNames");
				callDetailRecord.InstanceId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].InstanceId");
				callDetailRecord.SkillGroupIdList = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].SkillGroupIdList");

				List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent> callDetailRecord_agents = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent>();
				for (int j = 0; j < _ctx.Length("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents.Length"); j++) {
					ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent callDetailAgent = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_CallDetailAgent();
					callDetailAgent.AgentId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].AgentId");
					callDetailAgent.Satisfaction = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Satisfaction");
					callDetailAgent.Feedback = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Agents["+ j +"].Feedback");

					callDetailRecord_agents.Add(callDetailAgent);
				}
				callDetailRecord.Agents = callDetailRecord_agents;

				List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording> callDetailRecord_recordings = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording>();
				for (int j = 0; j < _ctx.Length("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings.Length"); j++) {
					ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording recording = new ListCallDetailRecordsResponse.ListCallDetailRecords_CallDetailRecords.ListCallDetailRecords_CallDetailRecord.ListCallDetailRecords_Recording();
					recording.ContactId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].ContactId");
					recording.AgentId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentId");
					recording.AgentName = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].AgentName");
					recording.StartTime = _ctx.LongValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].StartTime");
					recording.Duration = _ctx.IntegerValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].Duration");
					recording.FileName = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileName");
					recording.FileDescription = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].FileDescription");
					recording.QualityCheckTid = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].QualityCheckTid");
					recording.QualityCheckTaskId = _ctx.StringValue("ListCallDetailRecords.CallDetailRecords.List["+ i +"].Recordings["+ j +"].QualityCheckTaskId");

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
