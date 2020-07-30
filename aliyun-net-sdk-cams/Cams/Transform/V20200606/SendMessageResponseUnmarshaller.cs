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
using Aliyun.Acs.cams.Model.V20200606;

namespace Aliyun.Acs.cams.Transform.V20200606
{
    public class SendMessageResponseUnmarshaller
    {
        public static SendMessageResponse Unmarshall(UnmarshallerContext context)
        {
			SendMessageResponse sendMessageResponse = new SendMessageResponse();

			sendMessageResponse.HttpResponse = context.HttpResponse;
			sendMessageResponse.RequestId = context.StringValue("SendMessage.RequestId");
			sendMessageResponse.ResultCode = context.StringValue("SendMessage.ResultCode");
			sendMessageResponse.ResultMessage = context.StringValue("SendMessage.ResultMessage");

			SendMessageResponse.SendMessage_Module module = new SendMessageResponse.SendMessage_Module();
			module.FromId = context.StringValue("SendMessage.Module.FromId");
			module.ToId = context.StringValue("SendMessage.Module.ToId");
			module.MessageId = context.StringValue("SendMessage.Module.MessageId");
			sendMessageResponse.Module = module;
        
			return sendMessageResponse;
        }
    }
}
