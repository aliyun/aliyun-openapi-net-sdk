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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class SendMessageResponseUnmarshaller
    {
        public static SendMessageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SendMessageResponse sendMessageResponse = new SendMessageResponse();

			sendMessageResponse.HttpResponse = _ctx.HttpResponse;
			sendMessageResponse.Data = _ctx.BooleanValue("SendMessage.Data");
			sendMessageResponse.Success = _ctx.BooleanValue("SendMessage.Success");
			sendMessageResponse.Code = _ctx.IntegerValue("SendMessage.Code");
			sendMessageResponse.Message = _ctx.StringValue("SendMessage.Message");
			sendMessageResponse.ErrCode = _ctx.StringValue("SendMessage.ErrCode");
			sendMessageResponse.RequestId = _ctx.StringValue("SendMessage.RequestId");
        
			return sendMessageResponse;
        }
    }
}
