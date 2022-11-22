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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class ModifyTenantUserStatusResponseUnmarshaller
    {
        public static ModifyTenantUserStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyTenantUserStatusResponse modifyTenantUserStatusResponse = new ModifyTenantUserStatusResponse();

			modifyTenantUserStatusResponse.HttpResponse = _ctx.HttpResponse;
			modifyTenantUserStatusResponse.RequestId = _ctx.StringValue("ModifyTenantUserStatus.RequestId");

			List<ModifyTenantUserStatusResponse.ModifyTenantUserStatus_TenantUserItem> modifyTenantUserStatusResponse_tenantUser = new List<ModifyTenantUserStatusResponse.ModifyTenantUserStatus_TenantUserItem>();
			for (int i = 0; i < _ctx.Length("ModifyTenantUserStatus.TenantUser.Length"); i++) {
				ModifyTenantUserStatusResponse.ModifyTenantUserStatus_TenantUserItem tenantUserItem = new ModifyTenantUserStatusResponse.ModifyTenantUserStatus_TenantUserItem();
				tenantUserItem.UserStatus = _ctx.StringValue("ModifyTenantUserStatus.TenantUser["+ i +"].UserStatus");
				tenantUserItem.UserName = _ctx.StringValue("ModifyTenantUserStatus.TenantUser["+ i +"].UserName");
				tenantUserItem.TenantId = _ctx.StringValue("ModifyTenantUserStatus.TenantUser["+ i +"].TenantId");

				modifyTenantUserStatusResponse_tenantUser.Add(tenantUserItem);
			}
			modifyTenantUserStatusResponse.TenantUser = modifyTenantUserStatusResponse_tenantUser;
        
			return modifyTenantUserStatusResponse;
        }
    }
}
