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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ListRtcMPUEventSubRecordResponseUnmarshaller
    {
        public static ListRtcMPUEventSubRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRtcMPUEventSubRecordResponse listRtcMPUEventSubRecordResponse = new ListRtcMPUEventSubRecordResponse();

			listRtcMPUEventSubRecordResponse.HttpResponse = _ctx.HttpResponse;
			listRtcMPUEventSubRecordResponse.RequestId = _ctx.StringValue("ListRtcMPUEventSubRecord.RequestId");
			listRtcMPUEventSubRecordResponse.Count = _ctx.LongValue("ListRtcMPUEventSubRecord.Count");
			listRtcMPUEventSubRecordResponse.HasMore = _ctx.BooleanValue("ListRtcMPUEventSubRecord.HasMore");

			List<ListRtcMPUEventSubRecordResponse.ListRtcMPUEventSubRecord_SubInfo> listRtcMPUEventSubRecordResponse_logs = new List<ListRtcMPUEventSubRecordResponse.ListRtcMPUEventSubRecord_SubInfo>();
			for (int i = 0; i < _ctx.Length("ListRtcMPUEventSubRecord.Logs.Length"); i++) {
				ListRtcMPUEventSubRecordResponse.ListRtcMPUEventSubRecord_SubInfo subInfo = new ListRtcMPUEventSubRecordResponse.ListRtcMPUEventSubRecord_SubInfo();
				subInfo.AppId = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].AppId");
				subInfo.SubId = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].SubId");
				subInfo.MsgId = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].MsgId");
				subInfo.Data = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].Data");
				subInfo.Time = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].Time");
				subInfo.Cost = _ctx.LongValue("ListRtcMPUEventSubRecord.Logs["+ i +"].Cost");
				subInfo.CallbackUrl = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].CallbackUrl");
				subInfo.HTTPCode = _ctx.StringValue("ListRtcMPUEventSubRecord.Logs["+ i +"].HTTPCode");

				listRtcMPUEventSubRecordResponse_logs.Add(subInfo);
			}
			listRtcMPUEventSubRecordResponse.Logs = listRtcMPUEventSubRecordResponse_logs;
        
			return listRtcMPUEventSubRecordResponse;
        }
    }
}
