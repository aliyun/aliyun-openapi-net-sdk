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
    public class UpdateUserResponseUnmarshaller
    {
        public static UpdateUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateUserResponse updateUserResponse = new UpdateUserResponse();

			updateUserResponse.HttpResponse = _ctx.HttpResponse;
			updateUserResponse.Code = _ctx.StringValue("UpdateUser.Code");
			updateUserResponse.Success = _ctx.BooleanValue("UpdateUser.Success");
			updateUserResponse.Message = _ctx.StringValue("UpdateUser.Message");
			updateUserResponse.RequestId = _ctx.StringValue("UpdateUser.RequestId");

			UpdateUserResponse.UpdateUser_Model model = new UpdateUserResponse.UpdateUser_Model();
			model.SspUserId = _ctx.StringValue("UpdateUser.Model.SspUserId");
			model.GmtCreateTime = _ctx.LongValue("UpdateUser.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("UpdateUser.Model.GmtModifiedTime");
			model.IsDeleteTag = _ctx.StringValue("UpdateUser.Model.IsDeleteTag");
			model.UserName = _ctx.StringValue("UpdateUser.Model.UserName");
			model.YunUid = _ctx.StringValue("UpdateUser.Model.YunUid");
			model.YunPersonsId = _ctx.StringValue("UpdateUser.Model.YunPersonsId");
			model.MobilePhone = _ctx.StringValue("UpdateUser.Model.MobilePhone");
			model.Email = _ctx.StringValue("UpdateUser.Model.Email");
			model.Status = _ctx.StringValue("UpdateUser.Model.Status");
			model.TenantId = _ctx.StringValue("UpdateUser.Model.TenantId");
			model.TenantUserId = _ctx.StringValue("UpdateUser.Model.TenantUserId");
			model.RoleCode = _ctx.StringValue("UpdateUser.Model.RoleCode");
			updateUserResponse.Model = model;
        
			return updateUserResponse;
        }
    }
}
