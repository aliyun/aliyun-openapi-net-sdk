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
	public class DescribeNetworkInterfacesResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private List<DescribeNetworkInterfaces_NetworkInterfaceSet> networkInterfaceSets;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public List<DescribeNetworkInterfaces_NetworkInterfaceSet> NetworkInterfaceSets
		{
			get
			{
				return networkInterfaceSets;
			}
			set	
			{
				networkInterfaceSets = value;
			}
		}

		public class DescribeNetworkInterfaces_NetworkInterfaceSet
		{

			private string creationTime;

			private string vpcId;

			private string type;

			private string status;

			private string networkInterfaceTrafficMode;

			private string networkInterfaceName;

			private string macAddress;

			private int? queuePairNumber;

			private string networkInterfaceId;

			private long? serviceID;

			private string instanceId;

			private string ownerId;

			private bool? serviceManaged;

			private string vSwitchId;

			private string description;

			private string resourceGroupId;

			private string zoneId;

			private string privateIpAddress;

			private int? queueNumber;

			private List<DescribeNetworkInterfaces_PrivateIpSet> privateIpSets;

			private List<DescribeNetworkInterfaces_Ipv6Set> ipv6Sets;

			private List<DescribeNetworkInterfaces_Tag> tags;

			private List<string> securityGroupIds;

			private DescribeNetworkInterfaces_AssociatedPublicIp associatedPublicIp;

			private DescribeNetworkInterfaces_Attachment attachment;

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

			public List<DescribeNetworkInterfaces_PrivateIpSet> PrivateIpSets
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

			public List<DescribeNetworkInterfaces_Ipv6Set> Ipv6Sets
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

			public List<DescribeNetworkInterfaces_Tag> Tags
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

			public DescribeNetworkInterfaces_AssociatedPublicIp AssociatedPublicIp
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

			public DescribeNetworkInterfaces_Attachment Attachment
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

			public class DescribeNetworkInterfaces_PrivateIpSet
			{

				private string privateIpAddress;

				private bool? primary;

				private DescribeNetworkInterfaces_AssociatedPublicIp1 associatedPublicIp1;

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

				public DescribeNetworkInterfaces_AssociatedPublicIp1 AssociatedPublicIp1
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

				public class DescribeNetworkInterfaces_AssociatedPublicIp1
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

			public class DescribeNetworkInterfaces_Ipv6Set
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

			public class DescribeNetworkInterfaces_Tag
			{

				private string tagValue;

				private string tagKey;

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
			}

			public class DescribeNetworkInterfaces_AssociatedPublicIp
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

			public class DescribeNetworkInterfaces_Attachment
			{

				private int? deviceIndex;

				private string instanceId;

				private string trunkNetworkInterfaceId;

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
			}
		}
	}
}
