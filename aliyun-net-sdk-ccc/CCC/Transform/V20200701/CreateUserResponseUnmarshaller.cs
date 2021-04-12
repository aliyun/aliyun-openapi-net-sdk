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
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUserResponse createUserResponse = new CreateUserResponse();

			createUserResponse.HttpResponse = _ctx.HttpResponse;
			createUserResponse.Code = _ctx.StringValue("CreateUser.Code");
			createUserResponse.HttpStatusCode = _ctx.IntegerValue("CreateUser.HttpStatusCode");
			createUserResponse.Message = _ctx.StringValue("CreateUser.Message");
			createUserResponse.RequestId = _ctx.StringValue("CreateUser.RequestId");

			List<string> createUserResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateUser.Params.Length"); i++) {
				createUserResponse_params.Add(_ctx.StringValue("CreateUser.Params["+ i +"]"));
			}
			createUserResponse._Params = createUserResponse_params;

			CreateUserResponse.CreateUser_Data data = new CreateUserResponse.CreateUser_Data();
			data.DisplayName = _ctx.StringValue("CreateUser.Data.DisplayName");
			data.Email = _ctx.StringValue("CreateUser.Data.Email");
			data.Extension = _ctx.StringValue("CreateUser.Data.Extension");
			data.LoginName = _ctx.StringValue("CreateUser.Data.LoginName");
			data.Mobile = _ctx.StringValue("CreateUser.Data.Mobile");
			data.UserId = _ctx.StringValue("CreateUser.Data.UserId");
			data.WorkMode = _ctx.StringValue("CreateUser.Data.WorkMode");
			createUserResponse.Data = data;
        
			return createUserResponse;
        }
    }
}
