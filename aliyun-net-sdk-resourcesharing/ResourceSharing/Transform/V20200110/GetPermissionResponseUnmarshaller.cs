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
    public class GetPermissionResponseUnmarshaller
    {
        public static GetPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPermissionResponse getPermissionResponse = new GetPermissionResponse();

			getPermissionResponse.HttpResponse = _ctx.HttpResponse;
			getPermissionResponse.RequestId = _ctx.StringValue("GetPermission.RequestId");

			GetPermissionResponse.GetPermission_Permission permission = new GetPermissionResponse.GetPermission_Permission();
			permission.PermissionName = _ctx.StringValue("GetPermission.Permission.PermissionName");
			permission.PermissionVersion = _ctx.StringValue("GetPermission.Permission.PermissionVersion");
			permission.Permission = _ctx.StringValue("GetPermission.Permission.Permission");
			permission.ResourceType = _ctx.StringValue("GetPermission.Permission.ResourceType");
			permission.DefaultVersion = _ctx.BooleanValue("GetPermission.Permission.DefaultVersion");
			permission.CreateTime = _ctx.StringValue("GetPermission.Permission.CreateTime");
			permission.UpdateTime = _ctx.StringValue("GetPermission.Permission.UpdateTime");
			permission.DefaultPermission = _ctx.BooleanValue("GetPermission.Permission.DefaultPermission");
			getPermissionResponse.Permission = permission;
        
			return getPermissionResponse;
        }
    }
}
