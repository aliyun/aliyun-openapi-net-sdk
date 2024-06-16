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
    public class ListMessageResponseUnmarshaller
    {
        public static ListMessageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMessageResponse listMessageResponse = new ListMessageResponse();

			listMessageResponse.HttpResponse = _ctx.HttpResponse;
			listMessageResponse.RequestId = _ctx.StringValue("ListMessage.RequestId");

			ListMessageResponse.ListMessage_Result result = new ListMessageResponse.ListMessage_Result();
			result.HasMore = _ctx.BooleanValue("ListMessage.Result.HasMore");

			List<ListMessageResponse.ListMessage_Result.ListMessage_MessageListItem> result_messageList = new List<ListMessageResponse.ListMessage_Result.ListMessage_MessageListItem>();
			for (int i = 0; i < _ctx.Length("ListMessage.Result.MessageList.Length"); i++) {
				ListMessageResponse.ListMessage_Result.ListMessage_MessageListItem messageListItem = new ListMessageResponse.ListMessage_Result.ListMessage_MessageListItem();
				messageListItem.Data = _ctx.StringValue("ListMessage.Result.MessageList["+ i +"].Data");
				messageListItem.GroupId = _ctx.StringValue("ListMessage.Result.MessageList["+ i +"].GroupId");
				messageListItem.MessageId = _ctx.StringValue("ListMessage.Result.MessageList["+ i +"].MessageId");
				messageListItem.SenderId = _ctx.StringValue("ListMessage.Result.MessageList["+ i +"].SenderId");
				messageListItem.Type = _ctx.IntegerValue("ListMessage.Result.MessageList["+ i +"].Type");

				result_messageList.Add(messageListItem);
			}
			result.MessageList = result_messageList;
			listMessageResponse.Result = result;
        
			return listMessageResponse;
        }
    }
}
