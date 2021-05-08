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
    public class QueryTenantUserResponseUnmarshaller
    {
        public static QueryTenantUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTenantUserResponse queryTenantUserResponse = new QueryTenantUserResponse();

			queryTenantUserResponse.HttpResponse = _ctx.HttpResponse;
			queryTenantUserResponse.Code = _ctx.StringValue("QueryTenantUser.Code");
			queryTenantUserResponse.Success = _ctx.BooleanValue("QueryTenantUser.Success");
			queryTenantUserResponse.Message = _ctx.StringValue("QueryTenantUser.Message");
			queryTenantUserResponse.RequestId = _ctx.StringValue("QueryTenantUser.RequestId");

			QueryTenantUserResponse.QueryTenantUser_Model model = new QueryTenantUserResponse.QueryTenantUser_Model();
			model.CreateTime = _ctx.LongValue("QueryTenantUser.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QueryTenantUser.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QueryTenantUser.Model.TenantId");
			model.TenantName = _ctx.StringValue("QueryTenantUser.Model.TenantName");
			model.Business = _ctx.StringValue("QueryTenantUser.Model.Business");
			model.UserId = _ctx.StringValue("QueryTenantUser.Model.UserId");
			model.UserName = _ctx.StringValue("QueryTenantUser.Model.UserName");
			model.OriginSite = _ctx.StringValue("QueryTenantUser.Model.OriginSite");
			model.OriginSiteUserId = _ctx.StringValue("QueryTenantUser.Model.OriginSiteUserId");
			model.OriginSiteUserName = _ctx.StringValue("QueryTenantUser.Model.OriginSiteUserName");
			model.Status = _ctx.StringValue("QueryTenantUser.Model.Status");
			model.Version = _ctx.LongValue("QueryTenantUser.Model.Version");
			model.ExtInfo = _ctx.StringValue("QueryTenantUser.Model.ExtInfo");
			queryTenantUserResponse.Model = model;
        
			return queryTenantUserResponse;
        }
    }
}
