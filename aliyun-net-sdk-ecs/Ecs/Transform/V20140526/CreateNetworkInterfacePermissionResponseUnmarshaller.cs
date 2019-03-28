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
        public static CreateNetworkInterfacePermissionResponse Unmarshall(UnmarshallerContext context)
        {
			CreateNetworkInterfacePermissionResponse createNetworkInterfacePermissionResponse = new CreateNetworkInterfacePermissionResponse();

			createNetworkInterfacePermissionResponse.HttpResponse = context.HttpResponse;
			createNetworkInterfacePermissionResponse.RequestId = context.StringValue("CreateNetworkInterfacePermission.RequestId");

			CreateNetworkInterfacePermissionResponse.CreateNetworkInterfacePermission_NetworkInterfacePermission networkInterfacePermission = new CreateNetworkInterfacePermissionResponse.CreateNetworkInterfacePermission_NetworkInterfacePermission();
			networkInterfacePermission.AccountId = context.LongValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.AccountId");
			networkInterfacePermission.ServiceName = context.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.ServiceName");
			networkInterfacePermission.NetworkInterfaceId = context.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.NetworkInterfaceId");
			networkInterfacePermission.NetworkInterfacePermissionId = context.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.NetworkInterfacePermissionId");
			networkInterfacePermission.Permission = context.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.Permission");
			networkInterfacePermission.PermissionState = context.StringValue("CreateNetworkInterfacePermission.NetworkInterfacePermission.PermissionState");
			createNetworkInterfacePermissionResponse.NetworkInterfacePermission = networkInterfacePermission;
        
			return createNetworkInterfacePermissionResponse;
        }
    }
}
