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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeGlobalAccelerationInstancesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeGlobalAccelerationInstances_GlobalAccelerationInstance> globalAccelerationInstances;

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

			private string reservationActiveTime;

			private string creationTime;

			private string status;

			private string reservationOrderType;

			private string bandwidthType;

			private string chargeType;

			private string globalAccelerationInstanceId;

			private string serviceLocation;

			private string reservationInternetChargeType;

			private string regionId;

			private string accelerationLocation;

			private string ipAddress;

			private string description;

			private string bandwidth;

			private string expiredTime;

			private string reservationBandwidth;

			private string internetChargeType;

			private string name;

			private string hasReservationData;

			private List<DescribeGlobalAccelerationInstances_LockReason> operationLocks;

			private List<DescribeGlobalAccelerationInstances_BackendServer> backendServers;

			private List<DescribeGlobalAccelerationInstances_PublicIpAddress> publicIpAddresses;

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

				private string serverIpAddress;

				private string serverId;

				private string serverType;

				private string regionId;

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
			}

			public class DescribeGlobalAccelerationInstances_PublicIpAddress
			{

				private string ipAddress;

				private string allocationId;

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
			}
		}
	}
}
