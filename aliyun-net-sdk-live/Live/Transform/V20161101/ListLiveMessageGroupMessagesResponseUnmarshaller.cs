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
    public class ListLiveMessageGroupMessagesResponseUnmarshaller
    {
        public static ListLiveMessageGroupMessagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveMessageGroupMessagesResponse listLiveMessageGroupMessagesResponse = new ListLiveMessageGroupMessagesResponse();

			listLiveMessageGroupMessagesResponse.HttpResponse = _ctx.HttpResponse;
			listLiveMessageGroupMessagesResponse.RequestId = _ctx.StringValue("ListLiveMessageGroupMessages.RequestId");
			listLiveMessageGroupMessagesResponse.GroupId = _ctx.StringValue("ListLiveMessageGroupMessages.GroupId");
			listLiveMessageGroupMessagesResponse.NextPageToken = _ctx.LongValue("ListLiveMessageGroupMessages.NextPageToken");
			listLiveMessageGroupMessagesResponse.Hasmore = _ctx.BooleanValue("ListLiveMessageGroupMessages.Hasmore");

			List<ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages> listLiveMessageGroupMessagesResponse_messageList = new List<ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages>();
			for (int i = 0; i < _ctx.Length("ListLiveMessageGroupMessages.MessageList.Length"); i++) {
				ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages messages = new ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages();
				messages.Body = _ctx.StringValue("ListLiveMessageGroupMessages.MessageList["+ i +"].Body");
				messages.Timestamp = _ctx.LongValue("ListLiveMessageGroupMessages.MessageList["+ i +"].Timestamp");
				messages.MsgTid = _ctx.StringValue("ListLiveMessageGroupMessages.MessageList["+ i +"].MsgTid");
				messages.MsgType = _ctx.LongValue("ListLiveMessageGroupMessages.MessageList["+ i +"].MsgType");
				messages.SeqNumber = _ctx.LongValue("ListLiveMessageGroupMessages.MessageList["+ i +"].SeqNumber");
				messages.TotalMessages = _ctx.LongValue("ListLiveMessageGroupMessages.MessageList["+ i +"].TotalMessages");

				ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages.ListLiveMessageGroupMessages_Sender sender = new ListLiveMessageGroupMessagesResponse.ListLiveMessageGroupMessages_Messages.ListLiveMessageGroupMessages_Sender();
				sender.UserId = _ctx.StringValue("ListLiveMessageGroupMessages.MessageList["+ i +"].Sender.UserId");
				sender.UserInfo = _ctx.StringValue("ListLiveMessageGroupMessages.MessageList["+ i +"].Sender.UserInfo");
				messages.Sender = sender;

				listLiveMessageGroupMessagesResponse_messageList.Add(messages);
			}
			listLiveMessageGroupMessagesResponse.MessageList = listLiveMessageGroupMessagesResponse_messageList;
        
			return listLiveMessageGroupMessagesResponse;
        }
    }
}
