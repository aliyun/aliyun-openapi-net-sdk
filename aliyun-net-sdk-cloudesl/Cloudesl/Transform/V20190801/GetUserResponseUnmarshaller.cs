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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = context.HttpResponse;
			getUserResponse.ErrorMessage = context.StringValue("GetUser.ErrorMessage");
			getUserResponse.ErrorCode = context.StringValue("GetUser.ErrorCode");
			getUserResponse.Message = context.StringValue("GetUser.Message");
			getUserResponse.DynamicCode = context.StringValue("GetUser.DynamicCode");
			getUserResponse.Code = context.StringValue("GetUser.Code");
			getUserResponse.DynamicMessage = context.StringValue("GetUser.DynamicMessage");
			getUserResponse.RequestId = context.StringValue("GetUser.RequestId");
			getUserResponse.Success = context.BooleanValue("GetUser.Success");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.Stores = context.StringValue("GetUser.User.Stores");
			user.UserName = context.StringValue("GetUser.User.UserName");
			user.UserId = context.StringValue("GetUser.User.UserId");
			user.UserType = context.StringValue("GetUser.User.UserType");
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
