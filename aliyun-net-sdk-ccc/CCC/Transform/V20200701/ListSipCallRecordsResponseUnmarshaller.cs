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
    public class ListSipCallRecordsResponseUnmarshaller
    {
        public static ListSipCallRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSipCallRecordsResponse listSipCallRecordsResponse = new ListSipCallRecordsResponse();

			listSipCallRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listSipCallRecordsResponse.Code = _ctx.StringValue("ListSipCallRecords.Code");
			listSipCallRecordsResponse.HttpStatusCode = _ctx.IntegerValue("ListSipCallRecords.HttpStatusCode");
			listSipCallRecordsResponse.Message = _ctx.StringValue("ListSipCallRecords.Message");
			listSipCallRecordsResponse.RequestId = _ctx.StringValue("ListSipCallRecords.RequestId");

			List<ListSipCallRecordsResponse.ListSipCallRecords_SipCallRecords> listSipCallRecordsResponse_data = new List<ListSipCallRecordsResponse.ListSipCallRecords_SipCallRecords>();
			for (int i = 0; i < _ctx.Length("ListSipCallRecords.Data.Length"); i++) {
				ListSipCallRecordsResponse.ListSipCallRecords_SipCallRecords sipCallRecords = new ListSipCallRecordsResponse.ListSipCallRecords_SipCallRecords();
				sipCallRecords.InstanceId = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].InstanceId");
				sipCallRecords.CallId = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].CallId");
				sipCallRecords.ContactId = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].ContactId");
				sipCallRecords.Caller = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].Caller");
				sipCallRecords.Callee = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].Callee");
				sipCallRecords.CallerClusterId = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].CallerClusterId");
				sipCallRecords.CalleeClusterId = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].CalleeClusterId");
				sipCallRecords.LastResponseCode = _ctx.IntegerValue("ListSipCallRecords.Data["+ i +"].LastResponseCode");
				sipCallRecords.LastResponseText = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].LastResponseText");
				sipCallRecords.InviteTime = _ctx.LongValue("ListSipCallRecords.Data["+ i +"].InviteTime");
				sipCallRecords.RingTime = _ctx.LongValue("ListSipCallRecords.Data["+ i +"].RingTime");
				sipCallRecords.EstablishedTime = _ctx.LongValue("ListSipCallRecords.Data["+ i +"].EstablishedTime");
				sipCallRecords.ReleasedTime = _ctx.LongValue("ListSipCallRecords.Data["+ i +"].ReleasedTime");
				sipCallRecords.ReleaseReasonCode = _ctx.IntegerValue("ListSipCallRecords.Data["+ i +"].ReleaseReasonCode");
				sipCallRecords.EarlyMediaUrl = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].EarlyMediaUrl");
				sipCallRecords.EarlyMediaText = _ctx.StringValue("ListSipCallRecords.Data["+ i +"].EarlyMediaText");

				listSipCallRecordsResponse_data.Add(sipCallRecords);
			}
			listSipCallRecordsResponse.Data = listSipCallRecordsResponse_data;
        
			return listSipCallRecordsResponse;
        }
    }
}
