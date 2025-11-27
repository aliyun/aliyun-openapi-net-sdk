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
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.DisplayName = _ctx.StringValue("GetUser.User.DisplayName");
			user.UserPrincipalName = _ctx.StringValue("GetUser.User.UserPrincipalName");
			user.Email = _ctx.StringValue("GetUser.User.Email");
			user.UpdateDate = _ctx.StringValue("GetUser.User.UpdateDate");
			user.MobilePhone = _ctx.StringValue("GetUser.User.MobilePhone");
			user.UserId = _ctx.StringValue("GetUser.User.UserId");
			user.Comments = _ctx.StringValue("GetUser.User.Comments");
			user.LastLoginDate = _ctx.StringValue("GetUser.User.LastLoginDate");
			user.CreateDate = _ctx.StringValue("GetUser.User.CreateDate");
			user.ProvisionType = _ctx.StringValue("GetUser.User.ProvisionType");

			List<GetUserResponse.GetUser_User.GetUser_Tag> user_tags = new List<GetUserResponse.GetUser_User.GetUser_Tag>();
			for (int i = 0; i < _ctx.Length("GetUser.User.Tags.Length"); i++) {
				GetUserResponse.GetUser_User.GetUser_Tag tag = new GetUserResponse.GetUser_User.GetUser_Tag();
				tag.TagKey = _ctx.StringValue("GetUser.User.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("GetUser.User.Tags["+ i +"].TagValue");

				user_tags.Add(tag);
			}
			user.Tags = user_tags;
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
