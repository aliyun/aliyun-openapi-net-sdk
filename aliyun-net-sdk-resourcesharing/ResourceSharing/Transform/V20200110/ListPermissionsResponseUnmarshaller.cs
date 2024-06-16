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
    public class ListPermissionsResponseUnmarshaller
    {
        public static ListPermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPermissionsResponse listPermissionsResponse = new ListPermissionsResponse();

			listPermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listPermissionsResponse.NextToken = _ctx.StringValue("ListPermissions.NextToken");
			listPermissionsResponse.RequestId = _ctx.StringValue("ListPermissions.RequestId");

			List<ListPermissionsResponse.ListPermissions_Permission> listPermissionsResponse_permissions = new List<ListPermissionsResponse.ListPermissions_Permission>();
			for (int i = 0; i < _ctx.Length("ListPermissions.Permissions.Length"); i++) {
				ListPermissionsResponse.ListPermissions_Permission permission = new ListPermissionsResponse.ListPermissions_Permission();
				permission.PermissionName = _ctx.StringValue("ListPermissions.Permissions["+ i +"].PermissionName");
				permission.PermissionVersion = _ctx.StringValue("ListPermissions.Permissions["+ i +"].PermissionVersion");
				permission.DefaultVersion = _ctx.BooleanValue("ListPermissions.Permissions["+ i +"].DefaultVersion");
				permission.CreateTime = _ctx.StringValue("ListPermissions.Permissions["+ i +"].CreateTime");
				permission.UpdateTime = _ctx.StringValue("ListPermissions.Permissions["+ i +"].UpdateTime");
				permission.ResourceType = _ctx.StringValue("ListPermissions.Permissions["+ i +"].ResourceType");
				permission.DefaultPermission = _ctx.BooleanValue("ListPermissions.Permissions["+ i +"].DefaultPermission");

				listPermissionsResponse_permissions.Add(permission);
			}
			listPermissionsResponse.Permissions = listPermissionsResponse_permissions;
        
			return listPermissionsResponse;
        }
    }
}
