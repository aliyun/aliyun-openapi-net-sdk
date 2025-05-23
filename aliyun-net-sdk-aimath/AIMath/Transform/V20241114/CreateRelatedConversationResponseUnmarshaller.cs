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
    public class CreateRelatedConversationResponseUnmarshaller
    {
        public static CreateRelatedConversationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRelatedConversationResponse createRelatedConversationResponse = new CreateRelatedConversationResponse();

			createRelatedConversationResponse.HttpResponse = _ctx.HttpResponse;
			createRelatedConversationResponse.RequestId = _ctx.StringValue("CreateRelatedConversation.RequestId");
			createRelatedConversationResponse.ConversationId = _ctx.StringValue("CreateRelatedConversation.ConversationId");
			createRelatedConversationResponse.ErrCode = _ctx.StringValue("CreateRelatedConversation.ErrCode");
			createRelatedConversationResponse.ErrMsg = _ctx.StringValue("CreateRelatedConversation.ErrMsg");
			createRelatedConversationResponse.Success = _ctx.BooleanValue("CreateRelatedConversation.Success");
        
			return createRelatedConversationResponse;
        }
    }
}
