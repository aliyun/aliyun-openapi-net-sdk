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
using Aliyun.Acs.LingMou.Model.V20250527;

namespace Aliyun.Acs.LingMou.Transform.V20250527
{
    public class CloseChatInstanceSessionsResponseUnmarshaller
    {
        public static CloseChatInstanceSessionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CloseChatInstanceSessionsResponse closeChatInstanceSessionsResponse = new CloseChatInstanceSessionsResponse();

			closeChatInstanceSessionsResponse.HttpResponse = _ctx.HttpResponse;
			closeChatInstanceSessionsResponse.RequestId = _ctx.StringValue("CloseChatInstanceSessions.requestId");
			closeChatInstanceSessionsResponse.Success = _ctx.BooleanValue("CloseChatInstanceSessions.success");
			closeChatInstanceSessionsResponse.Code = _ctx.StringValue("CloseChatInstanceSessions.code");
			closeChatInstanceSessionsResponse.Message = _ctx.StringValue("CloseChatInstanceSessions.message");
			closeChatInstanceSessionsResponse.HttpStatusCode = _ctx.IntegerValue("CloseChatInstanceSessions.httpStatusCode");

			List<CloseChatInstanceSessionsResponse.CloseChatInstanceSessions_DataItem> closeChatInstanceSessionsResponse_data = new List<CloseChatInstanceSessionsResponse.CloseChatInstanceSessions_DataItem>();
			for (int i = 0; i < _ctx.Length("CloseChatInstanceSessions.Data.Length"); i++) {
				CloseChatInstanceSessionsResponse.CloseChatInstanceSessions_DataItem dataItem = new CloseChatInstanceSessionsResponse.CloseChatInstanceSessions_DataItem();
				dataItem.SessionId = _ctx.StringValue("CloseChatInstanceSessions.Data["+ i +"].sessionId");
				dataItem.MainAccountId = _ctx.LongValue("CloseChatInstanceSessions.Data["+ i +"].mainAccountId");
				dataItem.CreatedAt = _ctx.LongValue("CloseChatInstanceSessions.Data["+ i +"].createdAt");

				closeChatInstanceSessionsResponse_data.Add(dataItem);
			}
			closeChatInstanceSessionsResponse.Data = closeChatInstanceSessionsResponse_data;
        
			return closeChatInstanceSessionsResponse;
        }
    }
}
