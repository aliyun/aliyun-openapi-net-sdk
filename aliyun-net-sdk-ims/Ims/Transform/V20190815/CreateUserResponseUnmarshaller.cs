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
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUserResponse createUserResponse = new CreateUserResponse();

			createUserResponse.HttpResponse = _ctx.HttpResponse;
			createUserResponse.RequestId = _ctx.StringValue("CreateUser.RequestId");

			CreateUserResponse.CreateUser_User user = new CreateUserResponse.CreateUser_User();
			user.DisplayName = _ctx.StringValue("CreateUser.User.DisplayName");
			user.UserPrincipalName = _ctx.StringValue("CreateUser.User.UserPrincipalName");
			user.Email = _ctx.StringValue("CreateUser.User.Email");
			user.UpdateDate = _ctx.StringValue("CreateUser.User.UpdateDate");
			user.MobilePhone = _ctx.StringValue("CreateUser.User.MobilePhone");
			user.UserId = _ctx.StringValue("CreateUser.User.UserId");
			user.Comments = _ctx.StringValue("CreateUser.User.Comments");
			user.LastLoginDate = _ctx.StringValue("CreateUser.User.LastLoginDate");
			user.CreateDate = _ctx.StringValue("CreateUser.User.CreateDate");
			user.ProvisionType = _ctx.StringValue("CreateUser.User.ProvisionType");
			user.ExternalId = _ctx.StringValue("CreateUser.User.ExternalId");

			List<CreateUserResponse.CreateUser_User.CreateUser_Tag> user_tags = new List<CreateUserResponse.CreateUser_User.CreateUser_Tag>();
			for (int i = 0; i < _ctx.Length("CreateUser.User.Tags.Length"); i++) {
				CreateUserResponse.CreateUser_User.CreateUser_Tag tag = new CreateUserResponse.CreateUser_User.CreateUser_Tag();
				tag.TagKey = _ctx.StringValue("CreateUser.User.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("CreateUser.User.Tags["+ i +"].TagValue");

				user_tags.Add(tag);
			}
			user.Tags = user_tags;
			createUserResponse.User = user;
        
			return createUserResponse;
        }
    }
}
