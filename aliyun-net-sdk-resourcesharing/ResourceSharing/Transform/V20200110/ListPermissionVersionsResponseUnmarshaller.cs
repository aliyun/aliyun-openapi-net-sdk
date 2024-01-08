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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class ListPermissionVersionsResponseUnmarshaller
    {
        public static ListPermissionVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPermissionVersionsResponse listPermissionVersionsResponse = new ListPermissionVersionsResponse();

			listPermissionVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listPermissionVersionsResponse.NextToken = _ctx.StringValue("ListPermissionVersions.NextToken");
			listPermissionVersionsResponse.RequestId = _ctx.StringValue("ListPermissionVersions.RequestId");

			List<ListPermissionVersionsResponse.ListPermissionVersions_Permission> listPermissionVersionsResponse_permissions = new List<ListPermissionVersionsResponse.ListPermissionVersions_Permission>();
			for (int i = 0; i < _ctx.Length("ListPermissionVersions.Permissions.Length"); i++) {
				ListPermissionVersionsResponse.ListPermissionVersions_Permission permission = new ListPermissionVersionsResponse.ListPermissionVersions_Permission();
				permission.PermissionName = _ctx.StringValue("ListPermissionVersions.Permissions["+ i +"].PermissionName");
				permission.PermissionVersion = _ctx.StringValue("ListPermissionVersions.Permissions["+ i +"].PermissionVersion");
				permission.DefaultVersion = _ctx.BooleanValue("ListPermissionVersions.Permissions["+ i +"].DefaultVersion");
				permission.CreateTime = _ctx.StringValue("ListPermissionVersions.Permissions["+ i +"].CreateTime");
				permission.UpdateTime = _ctx.StringValue("ListPermissionVersions.Permissions["+ i +"].UpdateTime");
				permission.ResourceType = _ctx.StringValue("ListPermissionVersions.Permissions["+ i +"].ResourceType");
				permission.DefaultPermission = _ctx.BooleanValue("ListPermissionVersions.Permissions["+ i +"].DefaultPermission");

				listPermissionVersionsResponse_permissions.Add(permission);
			}
			listPermissionVersionsResponse.Permissions = listPermissionVersionsResponse_permissions;
        
			return listPermissionVersionsResponse;
        }
    }
}
