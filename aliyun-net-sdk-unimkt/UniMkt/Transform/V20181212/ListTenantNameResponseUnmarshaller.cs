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
    public class ListTenantNameResponseUnmarshaller
    {
        public static ListTenantNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTenantNameResponse listTenantNameResponse = new ListTenantNameResponse();

			listTenantNameResponse.HttpResponse = _ctx.HttpResponse;
			listTenantNameResponse.Code = _ctx.StringValue("ListTenantName.Code");
			listTenantNameResponse.Success = _ctx.BooleanValue("ListTenantName.Success");
			listTenantNameResponse.Message = _ctx.StringValue("ListTenantName.Message");
			listTenantNameResponse.RequestId = _ctx.StringValue("ListTenantName.RequestId");
			listTenantNameResponse.PageNumber = _ctx.IntegerValue("ListTenantName.PageNumber");
			listTenantNameResponse.PageSize = _ctx.IntegerValue("ListTenantName.PageSize");
			listTenantNameResponse.Total = _ctx.LongValue("ListTenantName.Total");

			List<ListTenantNameResponse.ListTenantName_Tenant> listTenantNameResponse_model = new List<ListTenantNameResponse.ListTenantName_Tenant>();
			for (int i = 0; i < _ctx.Length("ListTenantName.Model.Length"); i++) {
				ListTenantNameResponse.ListTenantName_Tenant tenant = new ListTenantNameResponse.ListTenantName_Tenant();
				tenant.TenantId = _ctx.StringValue("ListTenantName.Model["+ i +"].TenantId");
				tenant.TenantName = _ctx.StringValue("ListTenantName.Model["+ i +"].TenantName");
				tenant.TenantDescription = _ctx.StringValue("ListTenantName.Model["+ i +"].TenantDescription");

				listTenantNameResponse_model.Add(tenant);
			}
			listTenantNameResponse.Model = listTenantNameResponse_model;
        
			return listTenantNameResponse;
        }
    }
}
