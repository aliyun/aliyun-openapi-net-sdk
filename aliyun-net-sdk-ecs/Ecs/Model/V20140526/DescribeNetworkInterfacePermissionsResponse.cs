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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeNetworkInterfacePermissionsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeNetworkInterfacePermissions_NetworkInterfacePermission> networkInterfacePermissions;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeNetworkInterfacePermissions_NetworkInterfacePermission> NetworkInterfacePermissions
		{
			get
			{
				return networkInterfacePermissions;
			}
			set	
			{
				networkInterfacePermissions = value;
			}
		}

		public class DescribeNetworkInterfacePermissions_NetworkInterfacePermission
		{

			private long? accountId;

			private string serviceName;

			private string networkInterfaceId;

			private string networkInterfacePermissionId;

			private string permission;

			private string permissionState;

			public long? AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string NetworkInterfaceId
			{
				get
				{
					return networkInterfaceId;
				}
				set	
				{
					networkInterfaceId = value;
				}
			}

			public string NetworkInterfacePermissionId
			{
				get
				{
					return networkInterfacePermissionId;
				}
				set	
				{
					networkInterfacePermissionId = value;
				}
			}

			public string Permission
			{
				get
				{
					return permission;
				}
				set	
				{
					permission = value;
				}
			}

			public string PermissionState
			{
				get
				{
					return permissionState;
				}
				set	
				{
					permissionState = value;
				}
			}
		}
	}
}
