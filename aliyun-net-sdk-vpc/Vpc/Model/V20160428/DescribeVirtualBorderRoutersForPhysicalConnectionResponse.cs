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
	public class DescribeVirtualBorderRoutersForPhysicalConnectionResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> virtualBorderRouterForPhysicalConnectionSet;

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

		public List<DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> VirtualBorderRouterForPhysicalConnectionSet
		{
			get
			{
				return virtualBorderRouterForPhysicalConnectionSet;
			}
			set	
			{
				virtualBorderRouterForPhysicalConnectionSet = value;
			}
		}

		public class DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType
		{

			private string vbrId;

			private long? vbrOwnerUid;

			private string eccId;

			private string type;

			private string creationTime;

			private string activationTime;

			private string terminationTime;

			private string recoveryTime;

			private int? vlanId;

			private string status;

			private string circuitCode;

			private string localGatewayIp;

			private string peerGatewayIp;

			private string peeringSubnetMask;

			private string pConnVbrChargeType;

			private string pConnVbrExpireTime;

			private string pConnVbrBussinessStatus;

			private string bandwidth;

			private string localIpv6GatewayIp;

			private string peerIpv6GatewayIp;

			private string peeringIpv6SubnetMask;

			private bool? enableIpv6;

			private string bandwidthStatus;

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

			public long? VbrOwnerUid
			{
				get
				{
					return vbrOwnerUid;
				}
				set	
				{
					vbrOwnerUid = value;
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

			public string PConnVbrBussinessStatus
			{
				get
				{
					return pConnVbrBussinessStatus;
				}
				set	
				{
					pConnVbrBussinessStatus = value;
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

			public string BandwidthStatus
			{
				get
				{
					return bandwidthStatus;
				}
				set	
				{
					bandwidthStatus = value;
				}
			}
		}
	}
}
