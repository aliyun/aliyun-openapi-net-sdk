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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetMessageCallbackResponseUnmarshaller
    {
        public static GetMessageCallbackResponse Unmarshall(UnmarshallerContext context)
        {
			GetMessageCallbackResponse getMessageCallbackResponse = new GetMessageCallbackResponse();

			getMessageCallbackResponse.HttpResponse = context.HttpResponse;
			getMessageCallbackResponse.RequestId = context.StringValue("GetMessageCallback.RequestId");

			GetMessageCallbackResponse.GetMessageCallback_MessageCallback messageCallback = new GetMessageCallbackResponse.GetMessageCallback_MessageCallback();
			messageCallback.CallbackType = context.StringValue("GetMessageCallback.MessageCallback.CallbackType");
			messageCallback.CallbackURL = context.StringValue("GetMessageCallback.MessageCallback.CallbackURL");
			messageCallback.EventTypeList = context.StringValue("GetMessageCallback.MessageCallback.EventTypeList");
			messageCallback.AuthSwitch = context.StringValue("GetMessageCallback.MessageCallback.AuthSwitch");
			messageCallback.AuthKey = context.StringValue("GetMessageCallback.MessageCallback.AuthKey");
			messageCallback.MnsEndpoint = context.StringValue("GetMessageCallback.MessageCallback.MnsEndpoint");
			messageCallback.MnsQueueName = context.StringValue("GetMessageCallback.MessageCallback.MnsQueueName");
			messageCallback.AppId = context.StringValue("GetMessageCallback.MessageCallback.AppId");
			getMessageCallbackResponse.MessageCallback = messageCallback;
        
			return getMessageCallbackResponse;
        }
    }
}
