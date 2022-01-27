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
    public class CreateTenantResponseUnmarshaller
    {
        public static CreateTenantResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTenantResponse createTenantResponse = new CreateTenantResponse();

			createTenantResponse.HttpResponse = _ctx.HttpResponse;
			createTenantResponse.Code = _ctx.StringValue("CreateTenant.Code");
			createTenantResponse.Success = _ctx.BooleanValue("CreateTenant.Success");
			createTenantResponse.Message = _ctx.StringValue("CreateTenant.Message");
			createTenantResponse.RequestId = _ctx.StringValue("CreateTenant.RequestId");

			CreateTenantResponse.CreateTenant_Model model = new CreateTenantResponse.CreateTenant_Model();
			model.CreateTime = _ctx.LongValue("CreateTenant.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreateTenant.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreateTenant.Model.TenantId");
			model.TenantName = _ctx.StringValue("CreateTenant.Model.TenantName");
			model.Business = _ctx.StringValue("CreateTenant.Model.Business");
			model.TenantDescription = _ctx.StringValue("CreateTenant.Model.TenantDescription");
			model.UserName = _ctx.StringValue("CreateTenant.Model.UserName");
			model.SettleInfo = _ctx.StringValue("CreateTenant.Model.SettleInfo");
			model.ExtInfo = _ctx.StringValue("CreateTenant.Model.ExtInfo");
			model.Status = _ctx.StringValue("CreateTenant.Model.Status");
			createTenantResponse.Model = model;
        
			return createTenantResponse;
        }
    }
}
