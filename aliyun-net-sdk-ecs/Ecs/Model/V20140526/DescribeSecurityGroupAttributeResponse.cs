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
	public class DescribeSecurityGroupAttributeResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string securityGroupId;

		private string description;

		private string securityGroupName;

		private string vpcId;

		private string innerAccessPolicy;

		private List<DescribeSecurityGroupAttribute_Permission> permissions;

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

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
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

		public string SecurityGroupName
		{
			get
			{
				return securityGroupName;
			}
			set	
			{
				securityGroupName = value;
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

		public string InnerAccessPolicy
		{
			get
			{
				return innerAccessPolicy;
			}
			set	
			{
				innerAccessPolicy = value;
			}
		}

		public List<DescribeSecurityGroupAttribute_Permission> Permissions
		{
			get
			{
				return permissions;
			}
			set	
			{
				permissions = value;
			}
		}

		public class DescribeSecurityGroupAttribute_Permission
		{

			private string ipProtocol;

			private string portRange;

			private string sourcePortRange;

			private string sourceGroupId;

			private string sourceGroupName;

			private string sourceCidrIp;

			private string ipv6SourceCidrIp;

			private string sourcePrefixListId;

			private string sourcePrefixListName;

			private string policy;

			private string nicType;

			private string sourceGroupOwnerAccount;

			private string destGroupId;

			private string destGroupName;

			private string destCidrIp;

			private string ipv6DestCidrIp;

			private string destPrefixListId;

			private string destPrefixListName;

			private string destGroupOwnerAccount;

			private string priority;

			private string direction;

			private string description;

			private string createTime;

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string PortRange
			{
				get
				{
					return portRange;
				}
				set	
				{
					portRange = value;
				}
			}

			public string SourcePortRange
			{
				get
				{
					return sourcePortRange;
				}
				set	
				{
					sourcePortRange = value;
				}
			}

			public string SourceGroupId
			{
				get
				{
					return sourceGroupId;
				}
				set	
				{
					sourceGroupId = value;
				}
			}

			public string SourceGroupName
			{
				get
				{
					return sourceGroupName;
				}
				set	
				{
					sourceGroupName = value;
				}
			}

			public string SourceCidrIp
			{
				get
				{
					return sourceCidrIp;
				}
				set	
				{
					sourceCidrIp = value;
				}
			}

			public string Ipv6SourceCidrIp
			{
				get
				{
					return ipv6SourceCidrIp;
				}
				set	
				{
					ipv6SourceCidrIp = value;
				}
			}

			public string SourcePrefixListId
			{
				get
				{
					return sourcePrefixListId;
				}
				set	
				{
					sourcePrefixListId = value;
				}
			}

			public string SourcePrefixListName
			{
				get
				{
					return sourcePrefixListName;
				}
				set	
				{
					sourcePrefixListName = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string NicType
			{
				get
				{
					return nicType;
				}
				set	
				{
					nicType = value;
				}
			}

			public string SourceGroupOwnerAccount
			{
				get
				{
					return sourceGroupOwnerAccount;
				}
				set	
				{
					sourceGroupOwnerAccount = value;
				}
			}

			public string DestGroupId
			{
				get
				{
					return destGroupId;
				}
				set	
				{
					destGroupId = value;
				}
			}

			public string DestGroupName
			{
				get
				{
					return destGroupName;
				}
				set	
				{
					destGroupName = value;
				}
			}

			public string DestCidrIp
			{
				get
				{
					return destCidrIp;
				}
				set	
				{
					destCidrIp = value;
				}
			}

			public string Ipv6DestCidrIp
			{
				get
				{
					return ipv6DestCidrIp;
				}
				set	
				{
					ipv6DestCidrIp = value;
				}
			}

			public string DestPrefixListId
			{
				get
				{
					return destPrefixListId;
				}
				set	
				{
					destPrefixListId = value;
				}
			}

			public string DestPrefixListName
			{
				get
				{
					return destPrefixListName;
				}
				set	
				{
					destPrefixListName = value;
				}
			}

			public string DestGroupOwnerAccount
			{
				get
				{
					return destGroupOwnerAccount;
				}
				set	
				{
					destGroupOwnerAccount = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}
		}
	}
}
