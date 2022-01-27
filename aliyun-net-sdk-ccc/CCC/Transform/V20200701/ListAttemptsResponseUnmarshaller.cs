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
    public class ListAttemptsResponseUnmarshaller
    {
        public static ListAttemptsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAttemptsResponse listAttemptsResponse = new ListAttemptsResponse();

			listAttemptsResponse.HttpResponse = _ctx.HttpResponse;
			listAttemptsResponse.Code = _ctx.StringValue("ListAttempts.Code");
			listAttemptsResponse.HttpStatusCode = _ctx.IntegerValue("ListAttempts.HttpStatusCode");
			listAttemptsResponse.Message = _ctx.StringValue("ListAttempts.Message");
			listAttemptsResponse.RequestId = _ctx.StringValue("ListAttempts.RequestId");

			ListAttemptsResponse.ListAttempts_Data data = new ListAttemptsResponse.ListAttempts_Data();
			data.TotalCount = _ctx.IntegerValue("ListAttempts.Data.TotalCount");
			data.PageNumber = _ctx.IntegerValue("ListAttempts.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListAttempts.Data.PageSize");

			List<ListAttemptsResponse.ListAttempts_Data.ListAttempts_AttemptList> data_list = new List<ListAttemptsResponse.ListAttempts_Data.ListAttempts_AttemptList>();
			for (int i = 0; i < _ctx.Length("ListAttempts.Data.List.Length"); i++) {
				ListAttemptsResponse.ListAttempts_Data.ListAttempts_AttemptList attemptList = new ListAttemptsResponse.ListAttempts_Data.ListAttempts_AttemptList();
				attemptList.AttemptId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].AttemptId");
				attemptList.ContactId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].ContactId");
				attemptList.CaseId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].CaseId");
				attemptList.CampaignId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].CampaignId");
				attemptList.InstanceId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].InstanceId");
				attemptList.QueueId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].QueueId");
				attemptList.Caller = _ctx.StringValue("ListAttempts.Data.List["+ i +"].Caller");
				attemptList.Callee = _ctx.StringValue("ListAttempts.Data.List["+ i +"].Callee");
				attemptList.AgentId = _ctx.StringValue("ListAttempts.Data.List["+ i +"].AgentId");
				attemptList.DialTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].DialTime");
				attemptList.DialDuration = _ctx.LongValue("ListAttempts.Data.List["+ i +"].DialDuration");
				attemptList.CustomerEstablishedTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].CustomerEstablishedTime");
				attemptList.CustomerReleasedTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].CustomerReleasedTime");
				attemptList.EnterIvrTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].EnterIvrTime");
				attemptList.IvrDuration = _ctx.LongValue("ListAttempts.Data.List["+ i +"].IvrDuration");
				attemptList.EnqueueTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].EnqueueTime");
				attemptList.QueueDuration = _ctx.LongValue("ListAttempts.Data.List["+ i +"].QueueDuration");
				attemptList.AssignAgentTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].AssignAgentTime");
				attemptList.AgentRingDuration = _ctx.LongValue("ListAttempts.Data.List["+ i +"].AgentRingDuration");
				attemptList.AgentEstablishedTime = _ctx.LongValue("ListAttempts.Data.List["+ i +"].AgentEstablishedTime");

				data_list.Add(attemptList);
			}
			data.List = data_list;
			listAttemptsResponse.Data = data;
        
			return listAttemptsResponse;
        }
    }
}
