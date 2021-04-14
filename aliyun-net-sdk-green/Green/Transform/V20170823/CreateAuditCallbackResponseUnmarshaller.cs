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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class CreateAuditCallbackResponseUnmarshaller
    {
        public static CreateAuditCallbackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAuditCallbackResponse createAuditCallbackResponse = new CreateAuditCallbackResponse();

			createAuditCallbackResponse.HttpResponse = _ctx.HttpResponse;
			createAuditCallbackResponse.RequestId = _ctx.StringValue("CreateAuditCallback.RequestId");
			createAuditCallbackResponse.Id = _ctx.LongValue("CreateAuditCallback.Id");
			createAuditCallbackResponse.Name = _ctx.StringValue("CreateAuditCallback.Name");
			createAuditCallbackResponse.Url = _ctx.StringValue("CreateAuditCallback.Url");
			createAuditCallbackResponse.Seed = _ctx.StringValue("CreateAuditCallback.Seed");
			createAuditCallbackResponse.CryptType = _ctx.StringValue("CreateAuditCallback.CryptType");
			createAuditCallbackResponse.CreateTime = _ctx.StringValue("CreateAuditCallback.CreateTime");
			createAuditCallbackResponse.ModifiedTime = _ctx.StringValue("CreateAuditCallback.ModifiedTime");

			List<string> createAuditCallbackResponse_callbackTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateAuditCallback.CallbackTypes.Length"); i++) {
				createAuditCallbackResponse_callbackTypes.Add(_ctx.StringValue("CreateAuditCallback.CallbackTypes["+ i +"]"));
			}
			createAuditCallbackResponse.CallbackTypes = createAuditCallbackResponse_callbackTypes;

			List<string> createAuditCallbackResponse_callbackSuggestions = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateAuditCallback.CallbackSuggestions.Length"); i++) {
				createAuditCallbackResponse_callbackSuggestions.Add(_ctx.StringValue("CreateAuditCallback.CallbackSuggestions["+ i +"]"));
			}
			createAuditCallbackResponse.CallbackSuggestions = createAuditCallbackResponse_callbackSuggestions;
        
			return createAuditCallbackResponse;
        }
    }
}
