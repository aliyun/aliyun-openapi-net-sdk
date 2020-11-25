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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class CreateNetworkInterfacePermissionResponseUnmarshaller
    {
        public static CreateNetworkInterfacePermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNetworkInterfacePermissionResponse createNetworkInterfacePermissionResponse = new CreateNetworkInterfacePermissionResponse();

			createNetworkInterfacePermissionResponse.HttpResponse = _ctx.HttpResponse;
			createNetworkInterfacePermissionResponse.RequestId = _ctx.StringValue("CreateNetworkInterfacePermission.RequestId");

			CreateNetworkInterfacePermissionResponse.CreateNetworkInterfacePermission_NetworkInterfacePermission networkInterfacePermission = new CreateNetworkInterfacePermissionResponse.CreateNetworkInterfacePermission_NetworkInterfacePermission();
			networkInterfacePermission.AccountId = _ctx.LongValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.AccountId");
			networkInterfacePermission.ServiceName = _ctx.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.ServiceName");
			networkInterfacePermission.NetworkInterfaceId = _ctx.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.NetworkInterfaceId");
			networkInterfacePermission.NetworkInterfacePermissionId = _ctx.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.NetworkInterfacePermissionId");
			networkInterfacePermission.Permission = _ctx.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.Permission");
			networkInterfacePermission.PermissionState = _ctx.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.PermissionState");
			createNetworkInterfacePermissionResponse.NetworkInterfacePermission = networkInterfacePermission;
        
			return createNetworkInterfacePermissionResponse;
        }
    }
}
