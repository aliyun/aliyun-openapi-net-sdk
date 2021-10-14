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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.Code = _ctx.StringValue("GetUser.Code");
			getUserResponse.HttpStatusCode = _ctx.IntegerValue("GetUser.HttpStatusCode");
			getUserResponse.Message = _ctx.StringValue("GetUser.Message");
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");

			List<string> getUserResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("GetUser.Params.Length"); i++) {
				getUserResponse_params.Add(_ctx.StringValue("GetUser.Params["+ i +"]"));
			}
			getUserResponse._Params = getUserResponse_params;

			GetUserResponse.GetUser_Data data = new GetUserResponse.GetUser_Data();
			data.DisplayName = _ctx.StringValue("GetUser.Data.DisplayName");
			data.Email = _ctx.StringValue("GetUser.Data.Email");
			data.Extension = _ctx.StringValue("GetUser.Data.Extension");
			data.InstanceId = _ctx.StringValue("GetUser.Data.InstanceId");
			data.LoginName = _ctx.StringValue("GetUser.Data.LoginName");
			data.Mobile = _ctx.StringValue("GetUser.Data.Mobile");
			data.RoleId = _ctx.StringValue("GetUser.Data.RoleId");
			data.RoleName = _ctx.StringValue("GetUser.Data.RoleName");
			data.UserId = _ctx.StringValue("GetUser.Data.UserId");
			data.WorkMode = _ctx.StringValue("GetUser.Data.WorkMode");
			getUserResponse.Data = data;
        
			return getUserResponse;
        }
    }
}
