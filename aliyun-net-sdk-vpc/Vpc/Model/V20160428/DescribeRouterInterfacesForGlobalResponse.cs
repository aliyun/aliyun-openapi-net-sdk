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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeRouterInterfacesForGlobalResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string desc;

		private bool? success;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeRouterInterfacesForGlobal_RouterInterfaceType> routerInterfaceSet;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string Desc
		{
			get
			{
				return desc;
			}
			set	
			{
				desc = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<DescribeRouterInterfacesForGlobal_RouterInterfaceType> RouterInterfaceSet
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

		public class DescribeRouterInterfacesForGlobal_RouterInterfaceType
		{

			private string businessStatus;

			private string accessPointId;

			private string chargeType;

			private string connectedTime;

			private string creationTime;

			private string routerInterfaceId;

			private string oppositeInterfaceBusinessStatus;

			private string oppositeInterfaceId;

			private long? oppositeInterfaceOwnerId;

			private string oppositeInterfaceSpec;

			private string oppositeInterfaceStatus;

			private string oppositeRegionId;

			private string oppositeAccessPointId;

			private string oppositeRouterId;

			private string oppositeRouterType;

			private string oppositeVpcInstanceId;

			private string regionId;

			private string role;

			private string routerId;

			private string routerType;

			private string spec;

			private string status;

			private string vpcInstanceId;

			private string name;

			private string description;

			private string healthCheckSourceIp;

			private string healthCheckTargetIp;

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

			public long? OppositeInterfaceOwnerId
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

			public string OppositeVpcInstanceId
			{
				get
				{
					return oppositeVpcInstanceId;
				}
				set	
				{
					oppositeVpcInstanceId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
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
		}
	}
}