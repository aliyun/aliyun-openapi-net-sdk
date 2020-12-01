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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class RequestLoginInfoResponseUnmarshaller
    {
        public static RequestLoginInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RequestLoginInfoResponse requestLoginInfoResponse = new RequestLoginInfoResponse();

			requestLoginInfoResponse.HttpResponse = _ctx.HttpResponse;
			requestLoginInfoResponse.RequestId = _ctx.StringValue("RequestLoginInfo.RequestId");
			requestLoginInfoResponse.Success = _ctx.BooleanValue("RequestLoginInfo.Success");
			requestLoginInfoResponse.Code = _ctx.StringValue("RequestLoginInfo.Code");
			requestLoginInfoResponse.Message = _ctx.StringValue("RequestLoginInfo.Message");
			requestLoginInfoResponse.HttpStatusCode = _ctx.IntegerValue("RequestLoginInfo.HttpStatusCode");

			RequestLoginInfoResponse.RequestLoginInfo_LoginInfo loginInfo = new RequestLoginInfoResponse.RequestLoginInfo_LoginInfo();
			loginInfo.UserName = _ctx.StringValue("RequestLoginInfo.LoginInfo.UserName");
			loginInfo.DisplayName = _ctx.StringValue("RequestLoginInfo.LoginInfo.DisplayName");
			loginInfo.PhoneNumber = _ctx.StringValue("RequestLoginInfo.LoginInfo.PhoneNumber");
			loginInfo.Region = _ctx.StringValue("RequestLoginInfo.LoginInfo.Region");
			loginInfo.WebRtcUrl = _ctx.StringValue("RequestLoginInfo.LoginInfo.WebRtcUrl");
			loginInfo.AgentServerUrl = _ctx.StringValue("RequestLoginInfo.LoginInfo.AgentServerUrl");
			loginInfo.Extension = _ctx.StringValue("RequestLoginInfo.LoginInfo.Extension");
			loginInfo.TenantId = _ctx.StringValue("RequestLoginInfo.LoginInfo.TenantId");
			loginInfo.Signature = _ctx.StringValue("RequestLoginInfo.LoginInfo.Signature");
			loginInfo.SignData = _ctx.StringValue("RequestLoginInfo.LoginInfo.SignData");

			List<RequestLoginInfoResponse.RequestLoginInfo_LoginInfo.RequestLoginInfo_Role> loginInfo_roles = new List<RequestLoginInfoResponse.RequestLoginInfo_LoginInfo.RequestLoginInfo_Role>();
			for (int i = 0; i < _ctx.Length("RequestLoginInfo.LoginInfo.Roles.Length"); i++) {
				RequestLoginInfoResponse.RequestLoginInfo_LoginInfo.RequestLoginInfo_Role role = new RequestLoginInfoResponse.RequestLoginInfo_LoginInfo.RequestLoginInfo_Role();
				role.RoleId = _ctx.StringValue("RequestLoginInfo.LoginInfo.Roles["+ i +"].RoleId");
				role.InstanceId = _ctx.StringValue("RequestLoginInfo.LoginInfo.Roles["+ i +"].InstanceId");
				role.RoleName = _ctx.StringValue("RequestLoginInfo.LoginInfo.Roles["+ i +"].RoleName");
				role.RoleDescription = _ctx.StringValue("RequestLoginInfo.LoginInfo.Roles["+ i +"].RoleDescription");

				loginInfo_roles.Add(role);
			}
			loginInfo.Roles = loginInfo_roles;
			requestLoginInfoResponse.LoginInfo = loginInfo;
        
			return requestLoginInfoResponse;
        }
    }
}
