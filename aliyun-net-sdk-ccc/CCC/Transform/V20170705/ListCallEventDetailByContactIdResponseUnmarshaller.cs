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
    public class ListCallEventDetailByContactIdResponseUnmarshaller
    {
        public static ListCallEventDetailByContactIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallEventDetailByContactIdResponse listCallEventDetailByContactIdResponse = new ListCallEventDetailByContactIdResponse();

			listCallEventDetailByContactIdResponse.HttpResponse = _ctx.HttpResponse;
			listCallEventDetailByContactIdResponse.RequestId = _ctx.StringValue("ListCallEventDetailByContactId.RequestId");
			listCallEventDetailByContactIdResponse.Success = _ctx.BooleanValue("ListCallEventDetailByContactId.Success");
			listCallEventDetailByContactIdResponse.Code = _ctx.StringValue("ListCallEventDetailByContactId.Code");
			listCallEventDetailByContactIdResponse.Message = _ctx.StringValue("ListCallEventDetailByContactId.Message");
			listCallEventDetailByContactIdResponse.HttpStatusCode = _ctx.IntegerValue("ListCallEventDetailByContactId.HttpStatusCode");

			ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data data = new ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data();
			data.Caller = _ctx.StringValue("ListCallEventDetailByContactId.Data.Caller");
			data.Callee = _ctx.StringValue("ListCallEventDetailByContactId.Data.Callee");
			data.CallType = _ctx.StringValue("ListCallEventDetailByContactId.Data.CallType");
			data.StartTime = _ctx.StringValue("ListCallEventDetailByContactId.Data.StartTime");
			data.PrivacyNumber = _ctx.StringValue("ListCallEventDetailByContactId.Data.PrivacyNumber");
			data.ReleaseAgent = _ctx.StringValue("ListCallEventDetailByContactId.Data.ReleaseAgent");
			data.ReleaseReason = _ctx.StringValue("ListCallEventDetailByContactId.Data.ReleaseReason");

			List<ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail> data_events = new List<ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail>();
			for (int i = 0; i < _ctx.Length("ListCallEventDetailByContactId.Data.Events.Length"); i++) {
				ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail callEventDetail = new ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail();
				callEventDetail.TimeStamp = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].TimeStamp");
				callEventDetail._Event = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].Event");
				callEventDetail.AgentName = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].AgentName");
				callEventDetail.Status = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].Status");
				callEventDetail.CallMode = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].CallMode");
				callEventDetail.Duration = _ctx.IntegerValue("ListCallEventDetailByContactId.Data.Events["+ i +"].Duration");

				ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail.ListCallEventDetailByContactId_DetailData detailData = new ListCallEventDetailByContactIdResponse.ListCallEventDetailByContactId_Data.ListCallEventDetailByContactId_CallEventDetail.ListCallEventDetailByContactId_DetailData();
				detailData.EventType = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].DetailData.EventType");
				detailData.Helper = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].DetailData.Helper");
				detailData.SatisfactionalResearch = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].DetailData.SatisfactionalResearch");
				detailData.SkillGroup = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].DetailData.SkillGroup");
				detailData.HangUper = _ctx.StringValue("ListCallEventDetailByContactId.Data.Events["+ i +"].DetailData.HangUper");
				callEventDetail.DetailData = detailData;

				data_events.Add(callEventDetail);
			}
			data.Events = data_events;
			listCallEventDetailByContactIdResponse.Data = data;
        
			return listCallEventDetailByContactIdResponse;
        }
    }
}
