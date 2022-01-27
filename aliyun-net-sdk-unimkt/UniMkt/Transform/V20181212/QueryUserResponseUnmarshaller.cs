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
    public class QueryUserResponseUnmarshaller
    {
        public static QueryUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryUserResponse queryUserResponse = new QueryUserResponse();

			queryUserResponse.HttpResponse = _ctx.HttpResponse;
			queryUserResponse.Code = _ctx.StringValue("QueryUser.Code");
			queryUserResponse.Success = _ctx.BooleanValue("QueryUser.Success");
			queryUserResponse.Message = _ctx.StringValue("QueryUser.Message");
			queryUserResponse.RequestId = _ctx.StringValue("QueryUser.RequestId");

			QueryUserResponse.QueryUser_Model model = new QueryUserResponse.QueryUser_Model();
			model.SspUserId = _ctx.StringValue("QueryUser.Model.SspUserId");
			model.GmtCreateTime = _ctx.LongValue("QueryUser.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("QueryUser.Model.GmtModifiedTime");
			model.IsDeleteTag = _ctx.StringValue("QueryUser.Model.IsDeleteTag");
			model.UserName = _ctx.StringValue("QueryUser.Model.UserName");
			model.YunUid = _ctx.StringValue("QueryUser.Model.YunUid");
			model.YunPersonsId = _ctx.StringValue("QueryUser.Model.YunPersonsId");
			model.MobilePhone = _ctx.StringValue("QueryUser.Model.MobilePhone");
			model.Email = _ctx.StringValue("QueryUser.Model.Email");
			model.Status = _ctx.StringValue("QueryUser.Model.Status");
			model.TenantId = _ctx.StringValue("QueryUser.Model.TenantId");
			model.TenantUserId = _ctx.StringValue("QueryUser.Model.TenantUserId");
			model.RoleCode = _ctx.StringValue("QueryUser.Model.RoleCode");
			queryUserResponse.Model = model;
        
			return queryUserResponse;
        }
    }
}
