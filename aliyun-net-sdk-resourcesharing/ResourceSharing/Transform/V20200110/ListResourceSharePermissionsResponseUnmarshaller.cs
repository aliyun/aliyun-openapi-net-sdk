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
    public class ListResourceSharePermissionsResponseUnmarshaller
    {
        public static ListResourceSharePermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceSharePermissionsResponse listResourceSharePermissionsResponse = new ListResourceSharePermissionsResponse();

			listResourceSharePermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listResourceSharePermissionsResponse.NextToken = _ctx.StringValue("ListResourceSharePermissions.NextToken");
			listResourceSharePermissionsResponse.RequestId = _ctx.StringValue("ListResourceSharePermissions.RequestId");

			List<ListResourceSharePermissionsResponse.ListResourceSharePermissions_Permission> listResourceSharePermissionsResponse_permissions = new List<ListResourceSharePermissionsResponse.ListResourceSharePermissions_Permission>();
			for (int i = 0; i < _ctx.Length("ListResourceSharePermissions.Permissions.Length"); i++) {
				ListResourceSharePermissionsResponse.ListResourceSharePermissions_Permission permission = new ListResourceSharePermissionsResponse.ListResourceSharePermissions_Permission();
				permission.PermissionName = _ctx.StringValue("ListResourceSharePermissions.Permissions["+ i +"].PermissionName");
				permission.PermissionVersion = _ctx.StringValue("ListResourceSharePermissions.Permissions["+ i +"].PermissionVersion");
				permission.DefaultVersion = _ctx.BooleanValue("ListResourceSharePermissions.Permissions["+ i +"].DefaultVersion");
				permission.CreateTime = _ctx.StringValue("ListResourceSharePermissions.Permissions["+ i +"].CreateTime");
				permission.UpdateTime = _ctx.StringValue("ListResourceSharePermissions.Permissions["+ i +"].UpdateTime");
				permission.ResourceType = _ctx.StringValue("ListResourceSharePermissions.Permissions["+ i +"].ResourceType");
				permission.DefaultPermission = _ctx.BooleanValue("ListResourceSharePermissions.Permissions["+ i +"].DefaultPermission");

				listResourceSharePermissionsResponse_permissions.Add(permission);
			}
			listResourceSharePermissionsResponse.Permissions = listResourceSharePermissionsResponse_permissions;
        
			return listResourceSharePermissionsResponse;
        }
    }
}
