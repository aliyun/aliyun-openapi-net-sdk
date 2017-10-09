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
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = context.HttpResponse;
			getUserResponse.RequestId = context.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.UserId = context.StringValue("GetUser.User.UserId");
			user.UserName = context.StringValue("GetUser.User.UserName");
			user.DisplayName = context.StringValue("GetUser.User.DisplayName");
			user.MobilePhone = context.StringValue("GetUser.User.MobilePhone");
			user.Email = context.StringValue("GetUser.User.Email");
			user.Comments = context.StringValue("GetUser.User.Comments");
			user.CreateDate = context.StringValue("GetUser.User.CreateDate");
			user.UpdateDate = context.StringValue("GetUser.User.UpdateDate");
			user.LastLoginDate = context.StringValue("GetUser.User.LastLoginDate");
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}