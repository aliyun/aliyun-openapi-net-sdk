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
	public class DescribeNetworkInterfaceAttributeResponse : AcsResponse
	{

		private string requestId;

		private string networkInterfaceId;

		private string status;

		private string type;

		private string vpcId;

		private string vSwitchId;

		private string zoneId;

		private string privateIpAddress;

		private string macAddress;

		private string networkInterfaceName;

		private string description;

		private string instanceId;

		private string creationTime;

		private string resourceGroupId;

		private long? serviceID;

		private bool? serviceManaged;

		private int? queueNumber;

		private string ownerId;

		private string networkInterfaceTrafficMode;

		private int? queuePairNumber;

		private List<DescribeNetworkInterfaceAttribute_PrivateIpSet> privateIpSets;

		private List<DescribeNetworkInterfaceAttribute_Ipv6Set> ipv6Sets;

		private List<DescribeNetworkInterfaceAttribute_Tag> tags;

		private List<string> securityGroupIds;

		private DescribeNetworkInterfaceAttribute_AssociatedPublicIp associatedPublicIp;

		private DescribeNetworkInterfaceAttribute_Attachment attachment;

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

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
			}
		}

		public string MacAddress
		{
			get
			{
				return macAddress;
			}
			set	
			{
				macAddress = value;
			}
		}

		public string NetworkInterfaceName
		{
			get
			{
				return networkInterfaceName;
			}
			set	
			{
				networkInterfaceName = value;
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		public long? ServiceID
		{
			get
			{
				return serviceID;
			}
			set	
			{
				serviceID = value;
			}
		}

		public bool? ServiceManaged
		{
			get
			{
				return serviceManaged;
			}
			set	
			{
				serviceManaged = value;
			}
		}

		public int? QueueNumber
		{
			get
			{
				return queueNumber;
			}
			set	
			{
				queueNumber = value;
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
			}
		}

		public string NetworkInterfaceTrafficMode
		{
			get
			{
				return networkInterfaceTrafficMode;
			}
			set	
			{
				networkInterfaceTrafficMode = value;
			}
		}

		public int? QueuePairNumber
		{
			get
			{
				return queuePairNumber;
			}
			set	
			{
				queuePairNumber = value;
			}
		}

		public List<DescribeNetworkInterfaceAttribute_PrivateIpSet> PrivateIpSets
		{
			get
			{
				return privateIpSets;
			}
			set	
			{
				privateIpSets = value;
			}
		}

		public List<DescribeNetworkInterfaceAttribute_Ipv6Set> Ipv6Sets
		{
			get
			{
				return ipv6Sets;
			}
			set	
			{
				ipv6Sets = value;
			}
		}

		public List<DescribeNetworkInterfaceAttribute_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public List<string> SecurityGroupIds
		{
			get
			{
				return securityGroupIds;
			}
			set	
			{
				securityGroupIds = value;
			}
		}

		public DescribeNetworkInterfaceAttribute_AssociatedPublicIp AssociatedPublicIp
		{
			get
			{
				return associatedPublicIp;
			}
			set	
			{
				associatedPublicIp = value;
			}
		}

		public DescribeNetworkInterfaceAttribute_Attachment Attachment
		{
			get
			{
				return attachment;
			}
			set	
			{
				attachment = value;
			}
		}

		public class DescribeNetworkInterfaceAttribute_PrivateIpSet
		{

			private string privateIpAddress;

			private bool? primary;

			private DescribeNetworkInterfaceAttribute_AssociatedPublicIp1 associatedPublicIp1;

			public string PrivateIpAddress
			{
				get
				{
					return privateIpAddress;
				}
				set	
				{
					privateIpAddress = value;
				}
			}

			public bool? Primary
			{
				get
				{
					return primary;
				}
				set	
				{
					primary = value;
				}
			}

			public DescribeNetworkInterfaceAttribute_AssociatedPublicIp1 AssociatedPublicIp1
			{
				get
				{
					return associatedPublicIp1;
				}
				set	
				{
					associatedPublicIp1 = value;
				}
			}

			public class DescribeNetworkInterfaceAttribute_AssociatedPublicIp1
			{

				private string publicIpAddress;

				private string allocationId;

				public string PublicIpAddress
				{
					get
					{
						return publicIpAddress;
					}
					set	
					{
						publicIpAddress = value;
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

		public class DescribeNetworkInterfaceAttribute_Ipv6Set
		{

			private string ipv6Address;

			public string Ipv6Address
			{
				get
				{
					return ipv6Address;
				}
				set	
				{
					ipv6Address = value;
				}
			}
		}

		public class DescribeNetworkInterfaceAttribute_Tag
		{

			private string tagKey;

			private string tagValue;

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}
		}

		public class DescribeNetworkInterfaceAttribute_AssociatedPublicIp
		{

			private string publicIpAddress;

			private string allocationId;

			public string PublicIpAddress
			{
				get
				{
					return publicIpAddress;
				}
				set	
				{
					publicIpAddress = value;
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

		public class DescribeNetworkInterfaceAttribute_Attachment
		{

			private string instanceId;

			private string trunkNetworkInterfaceId;

			private int? deviceIndex;

			private List<string> memberNetworkInterfaceIds;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string TrunkNetworkInterfaceId
			{
				get
				{
					return trunkNetworkInterfaceId;
				}
				set	
				{
					trunkNetworkInterfaceId = value;
				}
			}

			public int? DeviceIndex
			{
				get
				{
					return deviceIndex;
				}
				set	
				{
					deviceIndex = value;
				}
			}

			public List<string> MemberNetworkInterfaceIds
			{
				get
				{
					return memberNetworkInterfaceIds;
				}
				set	
				{
					memberNetworkInterfaceIds = value;
				}
			}
		}
	}
}
