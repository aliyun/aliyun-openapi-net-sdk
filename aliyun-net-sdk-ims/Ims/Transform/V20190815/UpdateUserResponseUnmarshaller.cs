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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class UpdateUserResponseUnmarshaller
    {
        public static UpdateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateUserResponse updateUserResponse = new UpdateUserResponse();

			updateUserResponse.HttpResponse = _ctx.HttpResponse;
			updateUserResponse.RequestId = _ctx.StringValue("UpdateUser.RequestId");

			UpdateUserResponse.UpdateUser_User user = new UpdateUserResponse.UpdateUser_User();
			user.DisplayName = _ctx.StringValue("UpdateUser.User.DisplayName");
			user.UserPrincipalName = _ctx.StringValue("UpdateUser.User.UserPrincipalName");
			user.Email = _ctx.StringValue("UpdateUser.User.Email");
			user.UpdateDate = _ctx.StringValue("UpdateUser.User.UpdateDate");
			user.MobilePhone = _ctx.StringValue("UpdateUser.User.MobilePhone");
			user.UserId = _ctx.StringValue("UpdateUser.User.UserId");
			user.Comments = _ctx.StringValue("UpdateUser.User.Comments");
			user.LastLoginDate = _ctx.StringValue("UpdateUser.User.LastLoginDate");
			user.CreateDate = _ctx.StringValue("UpdateUser.User.CreateDate");
			user.ProvisionType = _ctx.StringValue("UpdateUser.User.ProvisionType");
			updateUserResponse.User = user;
        
			return updateUserResponse;
        }
    }
}
