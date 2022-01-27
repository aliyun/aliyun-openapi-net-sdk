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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class GetUserResponseUnmarshaller
    {
        public static GetUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserResponse getUserResponse = new GetUserResponse();

			getUserResponse.HttpResponse = _ctx.HttpResponse;
			getUserResponse.ErrorMessage = _ctx.StringValue("GetUser.ErrorMessage");
			getUserResponse.ErrorCode = _ctx.StringValue("GetUser.ErrorCode");
			getUserResponse.Message = _ctx.StringValue("GetUser.Message");
			getUserResponse.DynamicCode = _ctx.StringValue("GetUser.DynamicCode");
			getUserResponse.Code = _ctx.StringValue("GetUser.Code");
			getUserResponse.DynamicMessage = _ctx.StringValue("GetUser.DynamicMessage");
			getUserResponse.RequestId = _ctx.StringValue("GetUser.RequestId");
			getUserResponse.Success = _ctx.BooleanValue("GetUser.Success");

			GetUserResponse.GetUser_User user = new GetUserResponse.GetUser_User();
			user.Stores = _ctx.StringValue("GetUser.User.Stores");
			user.UserName = _ctx.StringValue("GetUser.User.UserName");
			user.UserId = _ctx.StringValue("GetUser.User.UserId");
			user.UserType = _ctx.StringValue("GetUser.User.UserType");
			user.OwnerId = _ctx.StringValue("GetUser.User.OwnerId");
			user.Bid = _ctx.StringValue("GetUser.User.Bid");

			List<GetUserResponse.GetUser_User.GetUser_DingTalkInfo> user_dingTalkInfos = new List<GetUserResponse.GetUser_User.GetUser_DingTalkInfo>();
			for (int i = 0; i < _ctx.Length("GetUser.User.DingTalkInfos.Length"); i++) {
				GetUserResponse.GetUser_User.GetUser_DingTalkInfo dingTalkInfo = new GetUserResponse.GetUser_User.GetUser_DingTalkInfo();
				dingTalkInfo.DingTalkCompanyId = _ctx.StringValue("GetUser.User.DingTalkInfos["+ i +"].DingTalkCompanyId");
				dingTalkInfo.DingTalkUserId = _ctx.StringValue("GetUser.User.DingTalkInfos["+ i +"].DingTalkUserId");

				user_dingTalkInfos.Add(dingTalkInfo);
			}
			user.DingTalkInfos = user_dingTalkInfos;
			getUserResponse.User = user;
        
			return getUserResponse;
        }
    }
}
