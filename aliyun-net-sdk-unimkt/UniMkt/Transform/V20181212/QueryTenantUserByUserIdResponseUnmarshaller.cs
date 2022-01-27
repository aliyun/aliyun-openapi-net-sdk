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
    public class QueryTenantUserByUserIdResponseUnmarshaller
    {
        public static QueryTenantUserByUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTenantUserByUserIdResponse queryTenantUserByUserIdResponse = new QueryTenantUserByUserIdResponse();

			queryTenantUserByUserIdResponse.HttpResponse = _ctx.HttpResponse;
			queryTenantUserByUserIdResponse.Code = _ctx.StringValue("QueryTenantUserByUserId.Code");
			queryTenantUserByUserIdResponse.Success = _ctx.BooleanValue("QueryTenantUserByUserId.Success");
			queryTenantUserByUserIdResponse.Message = _ctx.StringValue("QueryTenantUserByUserId.Message");
			queryTenantUserByUserIdResponse.RequestId = _ctx.StringValue("QueryTenantUserByUserId.RequestId");

			QueryTenantUserByUserIdResponse.QueryTenantUserByUserId_Model model = new QueryTenantUserByUserIdResponse.QueryTenantUserByUserId_Model();
			model.CreateTime = _ctx.LongValue("QueryTenantUserByUserId.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QueryTenantUserByUserId.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QueryTenantUserByUserId.Model.TenantId");
			model.TenantName = _ctx.StringValue("QueryTenantUserByUserId.Model.TenantName");
			model.Business = _ctx.StringValue("QueryTenantUserByUserId.Model.Business");
			model.UserId = _ctx.StringValue("QueryTenantUserByUserId.Model.UserId");
			model.UserName = _ctx.StringValue("QueryTenantUserByUserId.Model.UserName");
			model.OriginSite = _ctx.StringValue("QueryTenantUserByUserId.Model.OriginSite");
			model.OriginSiteUserId = _ctx.StringValue("QueryTenantUserByUserId.Model.OriginSiteUserId");
			model.OriginSiteUserName = _ctx.StringValue("QueryTenantUserByUserId.Model.OriginSiteUserName");
			model.Status = _ctx.StringValue("QueryTenantUserByUserId.Model.Status");
			model.Version = _ctx.LongValue("QueryTenantUserByUserId.Model.Version");
			model.ExtInfo = _ctx.StringValue("QueryTenantUserByUserId.Model.ExtInfo");
			queryTenantUserByUserIdResponse.Model = model;
        
			return queryTenantUserByUserIdResponse;
        }
    }
}
