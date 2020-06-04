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
	public class DescribeSecurityGroupsResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeSecurityGroups_SecurityGroup> securityGroups;

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

		public List<DescribeSecurityGroups_SecurityGroup> SecurityGroups
		{
			get
			{
				return securityGroups;
			}
			set	
			{
				securityGroups = value;
			}
		}

		public class DescribeSecurityGroups_SecurityGroup
		{

			private string securityGroupId;

			private string description;

			private string securityGroupName;

			private string vpcId;

			private string creationTime;

			private string securityGroupType;

			private int? availableInstanceAmount;

			private int? ecsCount;

			private string resourceGroupId;

			private long? serviceID;

			private bool? serviceManaged;

			private List<DescribeSecurityGroups_Tag> tags;

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

			public string SecurityGroupType
			{
				get
				{
					return securityGroupType;
				}
				set	
				{
					securityGroupType = value;
				}
			}

			public int? AvailableInstanceAmount
			{
				get
				{
					return availableInstanceAmount;
				}
				set	
				{
					availableInstanceAmount = value;
				}
			}

			public int? EcsCount
			{
				get
				{
					return ecsCount;
				}
				set	
				{
					ecsCount = value;
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

			public List<DescribeSecurityGroups_Tag> Tags
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

			public class DescribeSecurityGroups_Tag
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
		}
	}
}
