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
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.DisplayName = _ctx.StringValue("GetUser.User.DisplayName");
			user.Email = _ctx.StringValue("GetUser.User.Email");
			user.UpdateDate = _ctx.StringValue("GetUser.User.UpdateDate");
			user.MobilePhone = _ctx.StringValue("GetUser.User.MobilePhone");
			user.UserId = _ctx.StringValue("GetUser.User.UserId");
			user.Comments = _ctx.StringValue("GetUser.User.Comments");
			user.LastLoginDate = _ctx.StringValue("GetUser.User.LastLoginDate");
			user.CreateDate = _ctx.StringValue("GetUser.User.CreateDate");
			user.UserName = _ctx.StringValue("GetUser.User.UserName");
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
