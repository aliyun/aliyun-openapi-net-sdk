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
    public class ListCallDetailRecordsResponseUnmarshaller
    {
        public static ListCallDetailRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallDetailRecordsResponse listCallDetailRecordsResponse = new ListCallDetailRecordsResponse();

			listCallDetailRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listCallDetailRecordsResponse.Code = _ctx.StringValue("ListCallDetailRecords.Code");
			listCallDetailRecordsResponse.HttpStatusCode = _ctx.IntegerValue("ListCallDetailRecords.HttpStatusCode");
			listCallDetailRecordsResponse.Message = _ctx.StringValue("ListCallDetailRecords.Message");
			listCallDetailRecordsResponse.RequestId = _ctx.StringValue("ListCallDetailRecords.RequestId");

			ListCallDetailRecordsResponse.ListCallDetailRecords_Data data = new ListCallDetailRecordsResponse.ListCallDetailRecords_Data();
			data.PageNumber = _ctx.IntegerValue("ListCallDetailRecords.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListCallDetailRecords.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListCallDetailRecords.Data.TotalCount");

			List<ListCallDetailRecordsResponse.ListCallDetailRecords_Data.ListCallDetailRecords_CallDetailRecord> data_list = new List<ListCallDetailRecordsResponse.ListCallDetailRecords_Data.ListCallDetailRecords_CallDetailRecord>();
			for (int i = 0; i < _ctx.Length("ListCallDetailRecords.Data.List.Length"); i++) {
				ListCallDetailRecordsResponse.ListCallDetailRecords_Data.ListCallDetailRecords_CallDetailRecord callDetailRecord = new ListCallDetailRecordsResponse.ListCallDetailRecords_Data.ListCallDetailRecords_CallDetailRecord();
				callDetailRecord.ContactDisposition = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].ContactDisposition");
				callDetailRecord.ContactType = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].ContactType");
				callDetailRecord.EstablishedTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].EstablishedTime");
				callDetailRecord.CalledNumber = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].CalledNumber");
				callDetailRecord.AdditionalBroker = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].AdditionalBroker");
				callDetailRecord.SatisfactionIndex = _ctx.IntegerValue("ListCallDetailRecords.Data.List["+ i +"].SatisfactionIndex");
				callDetailRecord.SatisfactionSurveyChannel = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].SatisfactionSurveyChannel");
				callDetailRecord.ReleaseTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].ReleaseTime");
				callDetailRecord.WaitTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].WaitTime");
				callDetailRecord.SkillGroupNames = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].SkillGroupNames");
				callDetailRecord.IvrTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].IvrTime");
				callDetailRecord.SatisfactionDescription = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].SatisfactionDescription");
				callDetailRecord.ReleaseInitiator = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].ReleaseInitiator");
				callDetailRecord.AgentIds = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].AgentIds");
				callDetailRecord.CallDuration = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].CallDuration");
				callDetailRecord.RecordingReady = _ctx.BooleanValue("ListCallDetailRecords.Data.List["+ i +"].RecordingReady");
				callDetailRecord.InstanceId = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].InstanceId");
				callDetailRecord.RingTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].RingTime");
				callDetailRecord.SatisfactionSurveyOffered = _ctx.BooleanValue("ListCallDetailRecords.Data.List["+ i +"].SatisfactionSurveyOffered");
				callDetailRecord.AgentNames = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].AgentNames");
				callDetailRecord.StartTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].StartTime");
				callDetailRecord.ContactId = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].ContactId");
				callDetailRecord.RecordingDuration = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].RecordingDuration");
				callDetailRecord.CallingNumber = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].CallingNumber");
				callDetailRecord.QueueTime = _ctx.LongValue("ListCallDetailRecords.Data.List["+ i +"].QueueTime");
				callDetailRecord.Broker = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].Broker");
				callDetailRecord.SkillGroupIds = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].SkillGroupIds");
				callDetailRecord.CallerLocation = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].CallerLocation");
				callDetailRecord.CalleeLocation = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].CalleeLocation");
				callDetailRecord.EarlyMediaState = _ctx.StringValue("ListCallDetailRecords.Data.List["+ i +"].EarlyMediaState");

				data_list.Add(callDetailRecord);
			}
			data.List = data_list;
			listCallDetailRecordsResponse.Data = data;
        
			return listCallDetailRecordsResponse;
        }
    }
}
