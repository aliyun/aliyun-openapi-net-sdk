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
    public class UpdateUserResponseUnmarshaller
    {
        public static UpdateUserResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateUserResponse updateUserResponse = new UpdateUserResponse();

			updateUserResponse.HttpResponse = context.HttpResponse;
			updateUserResponse.RequestId = context.StringValue("UpdateUser.RequestId");

			UpdateUserResponse.UpdateUser_User user = new UpdateUserResponse.UpdateUser_User();
			user.UserId = context.StringValue("UpdateUser.User.UserId");
			user.UserName = context.StringValue("UpdateUser.User.UserName");
			user.DisplayName = context.StringValue("UpdateUser.User.DisplayName");
			user.MobilePhone = context.StringValue("UpdateUser.User.MobilePhone");
			user.Email = context.StringValue("UpdateUser.User.Email");
			user.Comments = context.StringValue("UpdateUser.User.Comments");
			user.CreateDate = context.StringValue("UpdateUser.User.CreateDate");
			user.UpdateDate = context.StringValue("UpdateUser.User.UpdateDate");
			updateUserResponse.User = user;
        
			return updateUserResponse;
        }
    }
}