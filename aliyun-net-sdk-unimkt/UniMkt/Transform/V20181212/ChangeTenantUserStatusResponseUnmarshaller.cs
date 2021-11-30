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
    public class ChangeTenantUserStatusResponseUnmarshaller
    {
        public static ChangeTenantUserStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeTenantUserStatusResponse changeTenantUserStatusResponse = new ChangeTenantUserStatusResponse();

			changeTenantUserStatusResponse.HttpResponse = _ctx.HttpResponse;
			changeTenantUserStatusResponse.Code = _ctx.StringValue("ChangeTenantUserStatus.Code");
			changeTenantUserStatusResponse.Success = _ctx.BooleanValue("ChangeTenantUserStatus.Success");
			changeTenantUserStatusResponse.Message = _ctx.StringValue("ChangeTenantUserStatus.Message");
			changeTenantUserStatusResponse.RequestId = _ctx.StringValue("ChangeTenantUserStatus.RequestId");

			ChangeTenantUserStatusResponse.ChangeTenantUserStatus_Model model = new ChangeTenantUserStatusResponse.ChangeTenantUserStatus_Model();
			model.CreateTime = _ctx.LongValue("ChangeTenantUserStatus.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ChangeTenantUserStatus.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ChangeTenantUserStatus.Model.TenantId");
			model.TenantName = _ctx.StringValue("ChangeTenantUserStatus.Model.TenantName");
			model.Business = _ctx.StringValue("ChangeTenantUserStatus.Model.Business");
			model.UserId = _ctx.StringValue("ChangeTenantUserStatus.Model.UserId");
			model.UserName = _ctx.StringValue("ChangeTenantUserStatus.Model.UserName");
			model.OriginSite = _ctx.StringValue("ChangeTenantUserStatus.Model.OriginSite");
			model.OriginSiteUserId = _ctx.StringValue("ChangeTenantUserStatus.Model.OriginSiteUserId");
			model.Status = _ctx.StringValue("ChangeTenantUserStatus.Model.Status");
			model.Version = _ctx.LongValue("ChangeTenantUserStatus.Model.Version");
			model.OriginSiteUserName = _ctx.StringValue("ChangeTenantUserStatus.Model.OriginSiteUserName");
			model.ExtInfo = _ctx.StringValue("ChangeTenantUserStatus.Model.ExtInfo");
			changeTenantUserStatusResponse.Model = model;
        
			return changeTenantUserStatusResponse;
        }
    }
}
