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
using Aliyun.Acs.AIMath.Model.V20241114;

namespace Aliyun.Acs.AIMath.Transform.V20241114
{
    public class ChatMessageResponseUnmarshaller
    {
        public static ChatMessageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChatMessageResponse chatMessageResponse = new ChatMessageResponse();

			chatMessageResponse.HttpResponse = _ctx.HttpResponse;
			chatMessageResponse.RequestId = _ctx.StringValue("ChatMessage.RequestId");
			chatMessageResponse.EventType = _ctx.StringValue("ChatMessage.EventType");
			chatMessageResponse.Content = _ctx.StringValue("ChatMessage.Content");
			chatMessageResponse.Success = _ctx.BooleanValue("ChatMessage.Success");
			chatMessageResponse.ErrMsg = _ctx.StringValue("ChatMessage.ErrMsg");
			chatMessageResponse.ErrCode = _ctx.StringValue("ChatMessage.ErrCode");
        
			return chatMessageResponse;
        }
    }
}
