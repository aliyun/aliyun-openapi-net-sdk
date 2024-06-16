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
    public class DescribeTenantUsersResponseUnmarshaller
    {
        public static DescribeTenantUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantUsersResponse describeTenantUsersResponse = new DescribeTenantUsersResponse();

			describeTenantUsersResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantUsersResponse.TotalCount = _ctx.IntegerValue("DescribeTenantUsers.TotalCount");
			describeTenantUsersResponse.RequestId = _ctx.StringValue("DescribeTenantUsers.RequestId");

			List<DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem> describeTenantUsersResponse_tenantUsers = new List<DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantUsers.TenantUsers.Length"); i++) {
				DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem tenantUsersItem = new DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem();
				tenantUsersItem.UserType = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].UserType");
				tenantUsersItem.Description = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].Description");
				tenantUsersItem.UserStatus = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].UserStatus");
				tenantUsersItem.UserName = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].UserName");
				tenantUsersItem.TenantId = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].TenantId");
				tenantUsersItem.InstanceId = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].InstanceId");

				List<DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem.DescribeTenantUsers_DatabasesItem> tenantUsersItem_databases = new List<DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem.DescribeTenantUsers_DatabasesItem>();
				for (int j = 0; j < _ctx.Length("DescribeTenantUsers.TenantUsers["+ i +"].Databases.Length"); j++) {
					DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem.DescribeTenantUsers_DatabasesItem databasesItem = new DescribeTenantUsersResponse.DescribeTenantUsers_TenantUsersItem.DescribeTenantUsers_DatabasesItem();
					databasesItem.Database = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].Databases["+ j +"].Database");
					databasesItem.Role = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].Databases["+ j +"].Role");
					databasesItem.Table = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].Databases["+ j +"].Table");
					databasesItem.Privileges = _ctx.StringValue("DescribeTenantUsers.TenantUsers["+ i +"].Databases["+ j +"].Privileges");

					tenantUsersItem_databases.Add(databasesItem);
				}
				tenantUsersItem.Databases = tenantUsersItem_databases;

				describeTenantUsersResponse_tenantUsers.Add(tenantUsersItem);
			}
			describeTenantUsersResponse.TenantUsers = describeTenantUsersResponse_tenantUsers;
        
			return describeTenantUsersResponse;
        }
    }
}
