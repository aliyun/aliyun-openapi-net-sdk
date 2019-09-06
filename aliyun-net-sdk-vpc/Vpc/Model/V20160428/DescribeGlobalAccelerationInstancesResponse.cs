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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeGlobalAccelerationInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGlobalAccelerationInstances_GlobalAccelerationInstance> globalAccelerationInstances;

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

		public List<DescribeGlobalAccelerationInstances_GlobalAccelerationInstance> GlobalAccelerationInstances
		{
			get
			{
				return globalAccelerationInstances;
			}
			set	
			{
				globalAccelerationInstances = value;
			}
		}

		public class DescribeGlobalAccelerationInstances_GlobalAccelerationInstance
		{

			private string regionId;

			private string globalAccelerationInstanceId;

			private string ipAddress;

			private string status;

			private string bandwidth;

			private string internetChargeType;

			private string chargeType;

			private string bandwidthType;

			private string accelerationLocation;

			private string serviceLocation;

			private string name;

			private string description;

			private string expiredTime;

			private string creationTime;

			private string hasReservationData;

			private string reservationBandwidth;

			private string reservationInternetChargeType;

			private string reservationActiveTime;

			private string reservationOrderType;

			private List<DescribeGlobalAccelerationInstances_LockReason> operationLocks;

			private List<DescribeGlobalAccelerationInstances_BackendServer> backendServers;

			private List<DescribeGlobalAccelerationInstances_PublicIpAddress> publicIpAddresses;

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

			public string GlobalAccelerationInstanceId
			{
				get
				{
					return globalAccelerationInstanceId;
				}
				set	
				{
					globalAccelerationInstanceId = value;
				}
			}

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
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

			public string Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
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

			public string BandwidthType
			{
				get
				{
					return bandwidthType;
				}
				set	
				{
					bandwidthType = value;
				}
			}

			public string AccelerationLocation
			{
				get
				{
					return accelerationLocation;
				}
				set	
				{
					accelerationLocation = value;
				}
			}

			public string ServiceLocation
			{
				get
				{
					return serviceLocation;
				}
				set	
				{
					serviceLocation = value;
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

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public string HasReservationData
			{
				get
				{
					return hasReservationData;
				}
				set	
				{
					hasReservationData = value;
				}
			}

			public string ReservationBandwidth
			{
				get
				{
					return reservationBandwidth;
				}
				set	
				{
					reservationBandwidth = value;
				}
			}

			public string ReservationInternetChargeType
			{
				get
				{
					return reservationInternetChargeType;
				}
				set	
				{
					reservationInternetChargeType = value;
				}
			}

			public string ReservationActiveTime
			{
				get
				{
					return reservationActiveTime;
				}
				set	
				{
					reservationActiveTime = value;
				}
			}

			public string ReservationOrderType
			{
				get
				{
					return reservationOrderType;
				}
				set	
				{
					reservationOrderType = value;
				}
			}

			public List<DescribeGlobalAccelerationInstances_LockReason> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<DescribeGlobalAccelerationInstances_BackendServer> BackendServers
			{
				get
				{
					return backendServers;
				}
				set	
				{
					backendServers = value;
				}
			}

			public List<DescribeGlobalAccelerationInstances_PublicIpAddress> PublicIpAddresses
			{
				get
				{
					return publicIpAddresses;
				}
				set	
				{
					publicIpAddresses = value;
				}
			}

			public class DescribeGlobalAccelerationInstances_LockReason
			{

				private string lockReason;

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class DescribeGlobalAccelerationInstances_BackendServer
			{

				private string regionId;

				private string serverId;

				private string serverIpAddress;

				private string serverType;

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

				public string ServerId
				{
					get
					{
						return serverId;
					}
					set	
					{
						serverId = value;
					}
				}

				public string ServerIpAddress
				{
					get
					{
						return serverIpAddress;
					}
					set	
					{
						serverIpAddress = value;
					}
				}

				public string ServerType
				{
					get
					{
						return serverType;
					}
					set	
					{
						serverType = value;
					}
				}
			}

			public class DescribeGlobalAccelerationInstances_PublicIpAddress
			{

				private string allocationId;

				private string ipAddress;

				public string AllocationId
				{
					get
					{
						return allocationId;
					}
					set	
					{
						allocationId = value;
					}
				}

				public string IpAddress
				{
					get
					{
						return ipAddress;
					}
					set	
					{
						ipAddress = value;
					}
				}
			}
		}
	}
}
