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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUserResponse createUserResponse = new CreateUserResponse();

			createUserResponse.HttpResponse = _ctx.HttpResponse;
			createUserResponse.RequestId = _ctx.StringValue("CreateUser.RequestId");

			CreateUserResponse.CreateUser_User user = new CreateUserResponse.CreateUser_User();
			user.DisplayName = _ctx.StringValue("CreateUser.User.DisplayName");
			user.Email = _ctx.StringValue("CreateUser.User.Email");
			user.MobilePhone = _ctx.StringValue("CreateUser.User.MobilePhone");
			user.UserId = _ctx.StringValue("CreateUser.User.UserId");
			user.Comments = _ctx.StringValue("CreateUser.User.Comments");
			user.CreateDate = _ctx.StringValue("CreateUser.User.CreateDate");
			user.UserName = _ctx.StringValue("CreateUser.User.UserName");
			createUserResponse.User = user;
        
			return createUserResponse;
        }
    }
}
