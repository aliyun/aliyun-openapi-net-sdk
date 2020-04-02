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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryMessagesResponseUnmarshaller
    {
        public static QueryMessagesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMessagesResponse queryMessagesResponse = new QueryMessagesResponse();

			queryMessagesResponse.HttpResponse = context.HttpResponse;
			queryMessagesResponse.RequestId = context.StringValue("QueryMessages.RequestId");
			queryMessagesResponse.LogsId = context.StringValue("QueryMessages.LogsId");
			queryMessagesResponse.SubCode = context.StringValue("QueryMessages.SubCode");
			queryMessagesResponse.SubMessage = context.StringValue("QueryMessages.SubMessage");
			queryMessagesResponse.Code = context.StringValue("QueryMessages.Code");
			queryMessagesResponse.Message = context.StringValue("QueryMessages.Message");
			queryMessagesResponse.Success = context.BooleanValue("QueryMessages.Success");

			List<QueryMessagesResponse.QueryMessages_BizMessage> queryMessagesResponse_bizMessages = new List<QueryMessagesResponse.QueryMessages_BizMessage>();
			for (int i = 0; i < context.Length("QueryMessages.BizMessages.Length"); i++) {
				QueryMessagesResponse.QueryMessages_BizMessage bizMessage = new QueryMessagesResponse.QueryMessages_BizMessage();
				bizMessage.Topic = context.StringValue("QueryMessages.BizMessages["+ i +"].Topic");
				bizMessage.DataId = context.LongValue("QueryMessages.BizMessages["+ i +"].DataId");
				bizMessage.PubTime = context.StringValue("QueryMessages.BizMessages["+ i +"].PubTime");
				bizMessage.ContentMapJson = context.StringValue("QueryMessages.BizMessages["+ i +"].ContentMapJson");

				queryMessagesResponse_bizMessages.Add(bizMessage);
			}
			queryMessagesResponse.BizMessages = queryMessagesResponse_bizMessages;
        
			return queryMessagesResponse;
        }
    }
}
