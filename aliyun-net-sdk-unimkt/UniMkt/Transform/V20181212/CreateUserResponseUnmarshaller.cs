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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUserResponse createUserResponse = new CreateUserResponse();

			createUserResponse.HttpResponse = _ctx.HttpResponse;
			createUserResponse.Code = _ctx.StringValue("CreateUser.Code");
			createUserResponse.Success = _ctx.BooleanValue("CreateUser.Success");
			createUserResponse.Message = _ctx.StringValue("CreateUser.Message");
			createUserResponse.RequestId = _ctx.StringValue("CreateUser.RequestId");

			CreateUserResponse.CreateUser_Model model = new CreateUserResponse.CreateUser_Model();
			model.SspUserId = _ctx.StringValue("CreateUser.Model.SspUserId");
			model.GmtCreateTime = _ctx.LongValue("CreateUser.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("CreateUser.Model.GmtModifiedTime");
			model.IsDeleteTag = _ctx.StringValue("CreateUser.Model.IsDeleteTag");
			model.UserName = _ctx.StringValue("CreateUser.Model.UserName");
			model.YunUid = _ctx.StringValue("CreateUser.Model.YunUid");
			model.YunPersonsId = _ctx.StringValue("CreateUser.Model.YunPersonsId");
			model.MobilePhone = _ctx.StringValue("CreateUser.Model.MobilePhone");
			model.Email = _ctx.StringValue("CreateUser.Model.Email");
			model.Status = _ctx.StringValue("CreateUser.Model.Status");
			model.TenantId = _ctx.StringValue("CreateUser.Model.TenantId");
			model.TenantUserId = _ctx.StringValue("CreateUser.Model.TenantUserId");
			model.RoleCode = _ctx.StringValue("CreateUser.Model.RoleCode");
			createUserResponse.Model = model;
        
			return createUserResponse;
        }
    }
}
