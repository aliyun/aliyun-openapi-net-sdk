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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSecurityGroupsResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private string regionId;

		private string nextToken;

		private List<DescribeSecurityGroups_SecurityGroup> securityGroups;

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

			private string creationTime;

			private string vpcId;

			private bool? serviceManaged;

			private string description;

			private string securityGroupId;

			private string resourceGroupId;

			private string securityGroupName;

			private int? ecsCount;

			private long? serviceID;

			private string securityGroupType;

			private int? availableInstanceAmount;

			private List<DescribeSecurityGroups_Tag> tags;

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
		}
	}
}
