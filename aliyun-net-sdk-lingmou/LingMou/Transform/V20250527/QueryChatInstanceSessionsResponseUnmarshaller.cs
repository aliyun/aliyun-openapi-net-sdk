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
    public class QueryChatInstanceSessionsResponseUnmarshaller
    {
        public static QueryChatInstanceSessionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryChatInstanceSessionsResponse queryChatInstanceSessionsResponse = new QueryChatInstanceSessionsResponse();

			queryChatInstanceSessionsResponse.HttpResponse = _ctx.HttpResponse;
			queryChatInstanceSessionsResponse.RequestId = _ctx.StringValue("QueryChatInstanceSessions.requestId");
			queryChatInstanceSessionsResponse.Success = _ctx.BooleanValue("QueryChatInstanceSessions.success");
			queryChatInstanceSessionsResponse.Code = _ctx.StringValue("QueryChatInstanceSessions.code");
			queryChatInstanceSessionsResponse.Message = _ctx.StringValue("QueryChatInstanceSessions.message");
			queryChatInstanceSessionsResponse.HttpStatusCode = _ctx.IntegerValue("QueryChatInstanceSessions.httpStatusCode");

			List<QueryChatInstanceSessionsResponse.QueryChatInstanceSessions_DataItem> queryChatInstanceSessionsResponse_data = new List<QueryChatInstanceSessionsResponse.QueryChatInstanceSessions_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryChatInstanceSessions.Data.Length"); i++) {
				QueryChatInstanceSessionsResponse.QueryChatInstanceSessions_DataItem dataItem = new QueryChatInstanceSessionsResponse.QueryChatInstanceSessions_DataItem();
				dataItem.SessionId = _ctx.StringValue("QueryChatInstanceSessions.Data["+ i +"].sessionId");
				dataItem.MainAccountId = _ctx.LongValue("QueryChatInstanceSessions.Data["+ i +"].mainAccountId");
				dataItem.CreatedAt = _ctx.LongValue("QueryChatInstanceSessions.Data["+ i +"].createdAt");

				queryChatInstanceSessionsResponse_data.Add(dataItem);
			}
			queryChatInstanceSessionsResponse.Data = queryChatInstanceSessionsResponse_data;
        
			return queryChatInstanceSessionsResponse;
        }
    }
}
