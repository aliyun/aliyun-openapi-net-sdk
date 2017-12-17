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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class RequestLoginInfoResponseUnmarshaller
    {
        public static RequestLoginInfoResponse Unmarshall(UnmarshallerContext context)
        {
			RequestLoginInfoResponse requestLoginInfoResponse = new RequestLoginInfoResponse();

			requestLoginInfoResponse.HttpResponse = context.HttpResponse;
			requestLoginInfoResponse.RequestId = context.StringValue("RequestLoginInfo.RequestId");
			requestLoginInfoResponse.Success = context.BooleanValue("RequestLoginInfo.Success");
			requestLoginInfoResponse.Code = context.StringValue("RequestLoginInfo.Code");
			requestLoginInfoResponse.Message = context.StringValue("RequestLoginInfo.Message");
			requestLoginInfoResponse.HttpStatusCode = context.IntegerValue("RequestLoginInfo.HttpStatusCode");

			RequestLoginInfoResponse.RequestLoginInfo_LoginInfo loginInfo = new RequestLoginInfoResponse.RequestLoginInfo_LoginInfo();
			loginInfo.UserName = context.StringValue("RequestLoginInfo.LoginInfo.UserName");
			loginInfo.DisplayName = context.StringValue("RequestLoginInfo.LoginInfo.DisplayName");
			loginInfo.Region = context.StringValue("RequestLoginInfo.LoginInfo.Region");
			loginInfo.WebRtcUrl = context.StringValue("RequestLoginInfo.LoginInfo.WebRtcUrl");
			loginInfo.AgentServerUrl = context.StringValue("RequestLoginInfo.LoginInfo.AgentServerUrl");
			loginInfo.Extension = context.StringValue("RequestLoginInfo.LoginInfo.Extension");
			loginInfo.TenantId = context.StringValue("RequestLoginInfo.LoginInfo.TenantId");
			loginInfo.Signature = context.StringValue("RequestLoginInfo.LoginInfo.Signature");
			loginInfo.SignData = context.StringValue("RequestLoginInfo.LoginInfo.SignData");
			requestLoginInfoResponse.LoginInfo = loginInfo;
        
			return requestLoginInfoResponse;
        }
    }
}