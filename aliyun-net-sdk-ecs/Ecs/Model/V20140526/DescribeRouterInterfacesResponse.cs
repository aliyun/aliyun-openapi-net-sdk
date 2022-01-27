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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeRouterInterfacesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeRouterInterfaces_RouterInterfaceType> routerInterfaceSet;

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

		public List<DescribeRouterInterfaces_RouterInterfaceType> RouterInterfaceSet
		{
			get
			{
				return routerInterfaceSet;
			}
			set	
			{
				routerInterfaceSet = value;
			}
		}

		public class DescribeRouterInterfaces_RouterInterfaceType
		{

			private string healthCheckTargetIp;

			private string creationTime;

			private string status;

			private string spec;

			private string oppositeInterfaceId;

			private string routerInterfaceId;

			private string chargeType;

			private string oppositeRouterType;

			private string oppositeInterfaceOwnerId;

			private string description;

			private string name;

			private string oppositeRouterId;

			private string oppositeInterfaceSpec;

			private string routerId;

			private string oppositeInterfaceBusinessStatus;

			private string connectedTime;

			private string oppositeInterfaceStatus;

			private string healthCheckSourceIp;

			private string endTime;

			private string oppositeRegionId;

			private string oppositeAccessPointId;

			private string businessStatus;

			private string role;

			private string routerType;

			private string accessPointId;

			public string HealthCheckTargetIp
			{
				get
				{
					return healthCheckTargetIp;
				}
				set	
				{
					healthCheckTargetIp = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public string OppositeInterfaceId
			{
				get
				{
					return oppositeInterfaceId;
				}
				set	
				{
					oppositeInterfaceId = value;
				}
			}

			public string RouterInterfaceId
			{
				get
				{
					return routerInterfaceId;
				}
				set	
				{
					routerInterfaceId = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string OppositeRouterType
			{
				get
				{
					return oppositeRouterType;
				}
				set	
				{
					oppositeRouterType = value;
				}
			}

			public string OppositeInterfaceOwnerId
			{
				get
				{
					return oppositeInterfaceOwnerId;
				}
				set	
				{
					oppositeInterfaceOwnerId = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string OppositeRouterId
			{
				get
				{
					return oppositeRouterId;
				}
				set	
				{
					oppositeRouterId = value;
				}
			}

			public string OppositeInterfaceSpec
			{
				get
				{
					return oppositeInterfaceSpec;
				}
				set	
				{
					oppositeInterfaceSpec = value;
				}
			}

			public string RouterId
			{
				get
				{
					return routerId;
				}
				set	
				{
					routerId = value;
				}
			}

			public string OppositeInterfaceBusinessStatus
			{
				get
				{
					return oppositeInterfaceBusinessStatus;
				}
				set	
				{
					oppositeInterfaceBusinessStatus = value;
				}
			}

			public string ConnectedTime
			{
				get
				{
					return connectedTime;
				}
				set	
				{
					connectedTime = value;
				}
			}

			public string OppositeInterfaceStatus
			{
				get
				{
					return oppositeInterfaceStatus;
				}
				set	
				{
					oppositeInterfaceStatus = value;
				}
			}

			public string HealthCheckSourceIp
			{
				get
				{
					return healthCheckSourceIp;
				}
				set	
				{
					healthCheckSourceIp = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string OppositeRegionId
			{
				get
				{
					return oppositeRegionId;
				}
				set	
				{
					oppositeRegionId = value;
				}
			}

			public string OppositeAccessPointId
			{
				get
				{
					return oppositeAccessPointId;
				}
				set	
				{
					oppositeAccessPointId = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public string RouterType
			{
				get
				{
					return routerType;
				}
				set	
				{
					routerType = value;
				}
			}

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}
		}
	}
}
