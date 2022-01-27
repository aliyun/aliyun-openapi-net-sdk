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
    public class ListTenantResponseUnmarshaller
    {
        public static ListTenantResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTenantResponse listTenantResponse = new ListTenantResponse();

			listTenantResponse.HttpResponse = _ctx.HttpResponse;
			listTenantResponse.Code = _ctx.StringValue("ListTenant.Code");
			listTenantResponse.Success = _ctx.BooleanValue("ListTenant.Success");
			listTenantResponse.Message = _ctx.StringValue("ListTenant.Message");
			listTenantResponse.RequestId = _ctx.StringValue("ListTenant.RequestId");
			listTenantResponse.PageNumber = _ctx.IntegerValue("ListTenant.PageNumber");
			listTenantResponse.PageSize = _ctx.IntegerValue("ListTenant.PageSize");
			listTenantResponse.Total = _ctx.LongValue("ListTenant.Total");

			List<ListTenantResponse.ListTenant_Tenant> listTenantResponse_model = new List<ListTenantResponse.ListTenant_Tenant>();
			for (int i = 0; i < _ctx.Length("ListTenant.Model.Length"); i++) {
				ListTenantResponse.ListTenant_Tenant tenant = new ListTenantResponse.ListTenant_Tenant();
				tenant.CreateTime = _ctx.LongValue("ListTenant.Model["+ i +"].CreateTime");
				tenant.ModifyTime = _ctx.LongValue("ListTenant.Model["+ i +"].ModifyTime");
				tenant.TenantId = _ctx.StringValue("ListTenant.Model["+ i +"].TenantId");
				tenant.Business = _ctx.StringValue("ListTenant.Model["+ i +"].Business");
				tenant.TenantName = _ctx.StringValue("ListTenant.Model["+ i +"].TenantName");
				tenant.Status = _ctx.StringValue("ListTenant.Model["+ i +"].Status");
				tenant.SettleInfo = _ctx.StringValue("ListTenant.Model["+ i +"].SettleInfo");
				tenant.ExtInfo = _ctx.StringValue("ListTenant.Model["+ i +"].ExtInfo");
				tenant.BizId = _ctx.StringValue("ListTenant.Model["+ i +"].BizId");
				tenant.Version = _ctx.LongValue("ListTenant.Model["+ i +"].Version");
				tenant.TenantDescription = _ctx.StringValue("ListTenant.Model["+ i +"].TenantDescription");

				listTenantResponse_model.Add(tenant);
			}
			listTenantResponse.Model = listTenantResponse_model;
        
			return listTenantResponse;
        }
    }
}
