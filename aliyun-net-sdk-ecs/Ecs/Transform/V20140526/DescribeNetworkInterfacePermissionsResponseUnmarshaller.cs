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
    public class DescribeNetworkInterfacePermissionsResponseUnmarshaller
    {
        public static DescribeNetworkInterfacePermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkInterfacePermissionsResponse describeNetworkInterfacePermissionsResponse = new DescribeNetworkInterfacePermissionsResponse();

			describeNetworkInterfacePermissionsResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkInterfacePermissionsResponse.RequestId = _ctx.StringValue("DescribeNetworkInterfacePermissions.RequestId");
			describeNetworkInterfacePermissionsResponse.TotalCount = _ctx.IntegerValue("DescribeNetworkInterfacePermissions.TotalCount");
			describeNetworkInterfacePermissionsResponse.PageNumber = _ctx.IntegerValue("DescribeNetworkInterfacePermissions.PageNumber");
			describeNetworkInterfacePermissionsResponse.PageSize = _ctx.IntegerValue("DescribeNetworkInterfacePermissions.PageSize");

			List<DescribeNetworkInterfacePermissionsResponse.DescribeNetworkInterfacePermissions_NetworkInterfacePermission> describeNetworkInterfacePermissionsResponse_networkInterfacePermissions = new List<DescribeNetworkInterfacePermissionsResponse.DescribeNetworkInterfacePermissions_NetworkInterfacePermission>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions.Length"); i++) {
				DescribeNetworkInterfacePermissionsResponse.DescribeNetworkInterfacePermissions_NetworkInterfacePermission networkInterfacePermission = new DescribeNetworkInterfacePermissionsResponse.DescribeNetworkInterfacePermissions_NetworkInterfacePermission();
				networkInterfacePermission.AccountId = _ctx.LongValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].AccountId");
				networkInterfacePermission.ServiceName = _ctx.StringValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].ServiceName");
				networkInterfacePermission.NetworkInterfaceId = _ctx.StringValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].NetworkInterfaceId");
				networkInterfacePermission.NetworkInterfacePermissionId = _ctx.StringValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].NetworkInterfacePermissionId");
				networkInterfacePermission.Permission = _ctx.StringValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].Permission");
				networkInterfacePermission.PermissionState = _ctx.StringValue("DescribeNetworkInterfacePermissions.NetworkInterfacePermissions["+ i +"].PermissionState");

				describeNetworkInterfacePermissionsResponse_networkInterfacePermissions.Add(networkInterfacePermission);
			}
			describeNetworkInterfacePermissionsResponse.NetworkInterfacePermissions = describeNetworkInterfacePermissionsResponse_networkInterfacePermissions;
        
			return describeNetworkInterfacePermissionsResponse;
        }
    }
}
