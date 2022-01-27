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
    public class CreateTenantUserResponseUnmarshaller
    {
        public static CreateTenantUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTenantUserResponse createTenantUserResponse = new CreateTenantUserResponse();

			createTenantUserResponse.HttpResponse = _ctx.HttpResponse;
			createTenantUserResponse.Code = _ctx.StringValue("CreateTenantUser.Code");
			createTenantUserResponse.Success = _ctx.BooleanValue("CreateTenantUser.Success");
			createTenantUserResponse.Message = _ctx.StringValue("CreateTenantUser.Message");
			createTenantUserResponse.RequestId = _ctx.StringValue("CreateTenantUser.RequestId");

			CreateTenantUserResponse.CreateTenantUser_Model model = new CreateTenantUserResponse.CreateTenantUser_Model();
			model.CreateTime = _ctx.LongValue("CreateTenantUser.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreateTenantUser.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreateTenantUser.Model.TenantId");
			model.TenantName = _ctx.StringValue("CreateTenantUser.Model.TenantName");
			model.Business = _ctx.StringValue("CreateTenantUser.Model.Business");
			model.UserId = _ctx.StringValue("CreateTenantUser.Model.UserId");
			model.UserName = _ctx.StringValue("CreateTenantUser.Model.UserName");
			model.SettleInfo = _ctx.StringValue("CreateTenantUser.Model.SettleInfo");
			model.ExtInfo = _ctx.StringValue("CreateTenantUser.Model.ExtInfo");
			model.Status = _ctx.StringValue("CreateTenantUser.Model.Status");
			model.OriginSite = _ctx.StringValue("CreateTenantUser.Model.OriginSite");
			model.OriginSiteUserId = _ctx.StringValue("CreateTenantUser.Model.OriginSiteUserId");
			model.OriginSiteUserName = _ctx.StringValue("CreateTenantUser.Model.OriginSiteUserName");
			model.Status1 = _ctx.StringValue("CreateTenantUser.Model.Status");
			model.ExtInfo2 = _ctx.StringValue("CreateTenantUser.Model.ExtInfo");
			model.Version = _ctx.StringValue("CreateTenantUser.Model.Version");
			createTenantUserResponse.Model = model;
        
			return createTenantUserResponse;
        }
    }
}
