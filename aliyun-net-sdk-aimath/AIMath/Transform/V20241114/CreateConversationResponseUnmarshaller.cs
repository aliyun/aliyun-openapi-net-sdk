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
    public class CreateConversationResponseUnmarshaller
    {
        public static CreateConversationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateConversationResponse createConversationResponse = new CreateConversationResponse();

			createConversationResponse.HttpResponse = _ctx.HttpResponse;
			createConversationResponse.RequestId = _ctx.StringValue("CreateConversation.RequestId");
			createConversationResponse.ConversationId = _ctx.StringValue("CreateConversation.ConversationId");
			createConversationResponse.ErrCode = _ctx.StringValue("CreateConversation.ErrCode");
			createConversationResponse.ErrMsg = _ctx.StringValue("CreateConversation.ErrMsg");
			createConversationResponse.Success = _ctx.BooleanValue("CreateConversation.Success");
        
			return createConversationResponse;
        }
    }
}
