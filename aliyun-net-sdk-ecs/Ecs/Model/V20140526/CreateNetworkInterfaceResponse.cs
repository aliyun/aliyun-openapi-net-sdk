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
	public class CreateNetworkInterfaceResponse : AcsResponse
	{

		private string status;

		private string type;

		private string vpcId;

		private string networkInterfaceName;

		private string macAddress;

		private string networkInterfaceId;

		private long? serviceID;

		private string ownerId;

		private bool? serviceManaged;

		private string vSwitchId;

		private string requestId;

		private string description;

		private string resourceGroupId;

		private string zoneId;

		private string privateIpAddress;

		private List<CreateNetworkInterface_PrivateIpSet> privateIpSets;

		private List<CreateNetworkInterface_Tag> tags;

		private List<CreateNetworkInterface_Ipv6Set> ipv6Sets;

		private List<string> securityGroupIds;

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

		public List<CreateNetworkInterface_PrivateIpSet> PrivateIpSets
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

		public List<CreateNetworkInterface_Tag> Tags
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

		public List<CreateNetworkInterface_Ipv6Set> Ipv6Sets
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

		public class CreateNetworkInterface_PrivateIpSet
		{

			private string privateIpAddress;

			private bool? primary;

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
		}

		public class CreateNetworkInterface_Tag
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

		public class CreateNetworkInterface_Ipv6Set
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
	}
}
