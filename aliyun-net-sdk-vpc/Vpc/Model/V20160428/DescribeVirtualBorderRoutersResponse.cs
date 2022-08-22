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
	public class DescribeVirtualBorderRoutersResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeVirtualBorderRouters_VirtualBorderRouterType> virtualBorderRouterSet;

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

		public List<DescribeVirtualBorderRouters_VirtualBorderRouterType> VirtualBorderRouterSet
		{
			get
			{
				return virtualBorderRouterSet;
			}
			set	
			{
				virtualBorderRouterSet = value;
			}
		}

		public class DescribeVirtualBorderRouters_VirtualBorderRouterType
		{

			private string creationTime;

			private string status;

			private string type;

			private long? minTxInterval;

			private string peerIpv6GatewayIp;

			private string pConnVbrExpireTime;

			private string physicalConnectionOwnerUid;

			private string activationTime;

			private string physicalConnectionBusinessStatus;

			private string description;

			private string terminationTime;

			private long? minRxInterval;

			private string peerGatewayIp;

			private string name;

			private string vbrId;

			private int? vlanId;

			private string vlanInterfaceId;

			private string circuitCode;

			private string localIpv6GatewayIp;

			private string localGatewayIp;

			private string peeringSubnetMask;

			private bool? enableIpv6;

			private string routeTableId;

			private long? detectMultiplier;

			private string eccId;

			private string cloudBoxInstanceId;

			private string recoveryTime;

			private string physicalConnectionStatus;

			private string peeringIpv6SubnetMask;

			private string accessPointId;

			private string pConnVbrChargeType;

			private string physicalConnectionId;

			private List<DescribeVirtualBorderRouters_AssociatedPhysicalConnection> associatedPhysicalConnections;

			private List<DescribeVirtualBorderRouters_AssociatedCen> associatedCens;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public long? MinTxInterval
			{
				get
				{
					return minTxInterval;
				}
				set	
				{
					minTxInterval = value;
				}
			}

			public string PeerIpv6GatewayIp
			{
				get
				{
					return peerIpv6GatewayIp;
				}
				set	
				{
					peerIpv6GatewayIp = value;
				}
			}

			public string PConnVbrExpireTime
			{
				get
				{
					return pConnVbrExpireTime;
				}
				set	
				{
					pConnVbrExpireTime = value;
				}
			}

			public string PhysicalConnectionOwnerUid
			{
				get
				{
					return physicalConnectionOwnerUid;
				}
				set	
				{
					physicalConnectionOwnerUid = value;
				}
			}

			public string ActivationTime
			{
				get
				{
					return activationTime;
				}
				set	
				{
					activationTime = value;
				}
			}

			public string PhysicalConnectionBusinessStatus
			{
				get
				{
					return physicalConnectionBusinessStatus;
				}
				set	
				{
					physicalConnectionBusinessStatus = value;
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

			public string TerminationTime
			{
				get
				{
					return terminationTime;
				}
				set	
				{
					terminationTime = value;
				}
			}

			public long? MinRxInterval
			{
				get
				{
					return minRxInterval;
				}
				set	
				{
					minRxInterval = value;
				}
			}

			public string PeerGatewayIp
			{
				get
				{
					return peerGatewayIp;
				}
				set	
				{
					peerGatewayIp = value;
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

			public string VbrId
			{
				get
				{
					return vbrId;
				}
				set	
				{
					vbrId = value;
				}
			}

			public int? VlanId
			{
				get
				{
					return vlanId;
				}
				set	
				{
					vlanId = value;
				}
			}

			public string VlanInterfaceId
			{
				get
				{
					return vlanInterfaceId;
				}
				set	
				{
					vlanInterfaceId = value;
				}
			}

			public string CircuitCode
			{
				get
				{
					return circuitCode;
				}
				set	
				{
					circuitCode = value;
				}
			}

			public string LocalIpv6GatewayIp
			{
				get
				{
					return localIpv6GatewayIp;
				}
				set	
				{
					localIpv6GatewayIp = value;
				}
			}

			public string LocalGatewayIp
			{
				get
				{
					return localGatewayIp;
				}
				set	
				{
					localGatewayIp = value;
				}
			}

			public string PeeringSubnetMask
			{
				get
				{
					return peeringSubnetMask;
				}
				set	
				{
					peeringSubnetMask = value;
				}
			}

			public bool? EnableIpv6
			{
				get
				{
					return enableIpv6;
				}
				set	
				{
					enableIpv6 = value;
				}
			}

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public long? DetectMultiplier
			{
				get
				{
					return detectMultiplier;
				}
				set	
				{
					detectMultiplier = value;
				}
			}

			public string EccId
			{
				get
				{
					return eccId;
				}
				set	
				{
					eccId = value;
				}
			}

			public string CloudBoxInstanceId
			{
				get
				{
					return cloudBoxInstanceId;
				}
				set	
				{
					cloudBoxInstanceId = value;
				}
			}

			public string RecoveryTime
			{
				get
				{
					return recoveryTime;
				}
				set	
				{
					recoveryTime = value;
				}
			}

			public string PhysicalConnectionStatus
			{
				get
				{
					return physicalConnectionStatus;
				}
				set	
				{
					physicalConnectionStatus = value;
				}
			}

			public string PeeringIpv6SubnetMask
			{
				get
				{
					return peeringIpv6SubnetMask;
				}
				set	
				{
					peeringIpv6SubnetMask = value;
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

			public string PConnVbrChargeType
			{
				get
				{
					return pConnVbrChargeType;
				}
				set	
				{
					pConnVbrChargeType = value;
				}
			}

			public string PhysicalConnectionId
			{
				get
				{
					return physicalConnectionId;
				}
				set	
				{
					physicalConnectionId = value;
				}
			}

			public List<DescribeVirtualBorderRouters_AssociatedPhysicalConnection> AssociatedPhysicalConnections
			{
				get
				{
					return associatedPhysicalConnections;
				}
				set	
				{
					associatedPhysicalConnections = value;
				}
			}

			public List<DescribeVirtualBorderRouters_AssociatedCen> AssociatedCens
			{
				get
				{
					return associatedCens;
				}
				set	
				{
					associatedCens = value;
				}
			}

			public class DescribeVirtualBorderRouters_AssociatedPhysicalConnection
			{

				private string status;

				private string vlanInterfaceId;

				private string circuitCode;

				private string peerIpv6GatewayIp;

				private string localIpv6GatewayIp;

				private string physicalConnectionOwnerUid;

				private string localGatewayIp;

				private string physicalConnectionBusinessStatus;

				private string peeringSubnetMask;

				private bool? enableIpv6;

				private string physicalConnectionStatus;

				private string peerGatewayIp;

				private string peeringIpv6SubnetMask;

				private string physicalConnectionId;

				private string vlanId;

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

				public string VlanInterfaceId
				{
					get
					{
						return vlanInterfaceId;
					}
					set	
					{
						vlanInterfaceId = value;
					}
				}

				public string CircuitCode
				{
					get
					{
						return circuitCode;
					}
					set	
					{
						circuitCode = value;
					}
				}

				public string PeerIpv6GatewayIp
				{
					get
					{
						return peerIpv6GatewayIp;
					}
					set	
					{
						peerIpv6GatewayIp = value;
					}
				}

				public string LocalIpv6GatewayIp
				{
					get
					{
						return localIpv6GatewayIp;
					}
					set	
					{
						localIpv6GatewayIp = value;
					}
				}

				public string PhysicalConnectionOwnerUid
				{
					get
					{
						return physicalConnectionOwnerUid;
					}
					set	
					{
						physicalConnectionOwnerUid = value;
					}
				}

				public string LocalGatewayIp
				{
					get
					{
						return localGatewayIp;
					}
					set	
					{
						localGatewayIp = value;
					}
				}

				public string PhysicalConnectionBusinessStatus
				{
					get
					{
						return physicalConnectionBusinessStatus;
					}
					set	
					{
						physicalConnectionBusinessStatus = value;
					}
				}

				public string PeeringSubnetMask
				{
					get
					{
						return peeringSubnetMask;
					}
					set	
					{
						peeringSubnetMask = value;
					}
				}

				public bool? EnableIpv6
				{
					get
					{
						return enableIpv6;
					}
					set	
					{
						enableIpv6 = value;
					}
				}

				public string PhysicalConnectionStatus
				{
					get
					{
						return physicalConnectionStatus;
					}
					set	
					{
						physicalConnectionStatus = value;
					}
				}

				public string PeerGatewayIp
				{
					get
					{
						return peerGatewayIp;
					}
					set	
					{
						peerGatewayIp = value;
					}
				}

				public string PeeringIpv6SubnetMask
				{
					get
					{
						return peeringIpv6SubnetMask;
					}
					set	
					{
						peeringIpv6SubnetMask = value;
					}
				}

				public string PhysicalConnectionId
				{
					get
					{
						return physicalConnectionId;
					}
					set	
					{
						physicalConnectionId = value;
					}
				}

				public string VlanId
				{
					get
					{
						return vlanId;
					}
					set	
					{
						vlanId = value;
					}
				}
			}

			public class DescribeVirtualBorderRouters_AssociatedCen
			{

				private long? cenOwnerId;

				private string cenId;

				private string cenStatus;

				public long? CenOwnerId
				{
					get
					{
						return cenOwnerId;
					}
					set	
					{
						cenOwnerId = value;
					}
				}

				public string CenId
				{
					get
					{
						return cenId;
					}
					set	
					{
						cenId = value;
					}
				}

				public string CenStatus
				{
					get
					{
						return cenStatus;
					}
					set	
					{
						cenStatus = value;
					}
				}
			}
		}
	}
}
