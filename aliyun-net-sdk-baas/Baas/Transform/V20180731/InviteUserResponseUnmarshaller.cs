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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class InviteUserResponseUnmarshaller
    {
        public static InviteUserResponse Unmarshall(UnmarshallerContext context)
        {
			InviteUserResponse inviteUserResponse = new InviteUserResponse();

			inviteUserResponse.HttpResponse = context.HttpResponse;
			inviteUserResponse.RequestId = context.StringValue("InviteUser.RequestId");

			InviteUserResponse.InviteUser_Result result = new InviteUserResponse.InviteUser_Result();
			result.Bid = context.StringValue("InviteUser.Result.Bid");
			result.Bizid = context.StringValue("InviteUser.Result.Bizid");
			result.Code = context.StringValue("InviteUser.Result.Code");
			result.CreateTime = context.LongValue("InviteUser.Result.CreateTime");
			result.Email = context.StringValue("InviteUser.Result.Email");
			result.FromBid = context.StringValue("InviteUser.Result.FromBid");
			result.FromUserId = context.IntegerValue("InviteUser.Result.FromUserId");
			result.Status = context.IntegerValue("InviteUser.Result.Status");
			result.UpdateTime = context.LongValue("InviteUser.Result.UpdateTime");
			result.UserId = context.IntegerValue("InviteUser.Result.UserId");
			inviteUserResponse.Result = result;
        
			return inviteUserResponse;
        }
    }
}