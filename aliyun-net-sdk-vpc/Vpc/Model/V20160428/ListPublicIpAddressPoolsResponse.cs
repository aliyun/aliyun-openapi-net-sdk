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
	public class ListPublicIpAddressPoolsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private int? totalCount;

		private List<ListPublicIpAddressPools_PublicIpAddressPool> publicIpAddressPoolList;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
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

		public List<ListPublicIpAddressPools_PublicIpAddressPool> PublicIpAddressPoolList
		{
			get
			{
				return publicIpAddressPoolList;
			}
			set	
			{
				publicIpAddressPoolList = value;
			}
		}

		public class ListPublicIpAddressPools_PublicIpAddressPool
		{

			private string publicIpAddressPoolId;

			private string regionId;

			private string creationTime;

			private string isp;

			private string name;

			private string status;

			private string description;

			private int? totalIpNum;

			private int? usedIpNum;

			private bool? ipAddressRemaining;

			private bool? userType;

			private long? ownerId;

			private string shareType;

			private string resourceGroupId;

			private List<ListPublicIpAddressPools_PublicIpCidrBlock> publicIpCidrBlockList;

			private List<ListPublicIpAddressPools_Tag> tags;

			public string PublicIpAddressPoolId
			{
				get
				{
					return publicIpAddressPoolId;
				}
				set	
				{
					publicIpAddressPoolId = value;
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

			public string Isp
			{
				get
				{
					return isp;
				}
				set	
				{
					isp = value;
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

			public int? TotalIpNum
			{
				get
				{
					return totalIpNum;
				}
				set	
				{
					totalIpNum = value;
				}
			}

			public int? UsedIpNum
			{
				get
				{
					return usedIpNum;
				}
				set	
				{
					usedIpNum = value;
				}
			}

			public bool? IpAddressRemaining
			{
				get
				{
					return ipAddressRemaining;
				}
				set	
				{
					ipAddressRemaining = value;
				}
			}

			public bool? UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			public long? OwnerId
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

			public string ShareType
			{
				get
				{
					return shareType;
				}
				set	
				{
					shareType = value;
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

			public List<ListPublicIpAddressPools_PublicIpCidrBlock> PublicIpCidrBlockList
			{
				get
				{
					return publicIpCidrBlockList;
				}
				set	
				{
					publicIpCidrBlockList = value;
				}
			}

			public List<ListPublicIpAddressPools_Tag> Tags
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

			public class ListPublicIpAddressPools_PublicIpCidrBlock
			{

				private string cidrBlock;

				private string status;

				private int? totalIpNum;

				private int? usedIpNum;

				private string creationTime;

				public string CidrBlock
				{
					get
					{
						return cidrBlock;
					}
					set	
					{
						cidrBlock = value;
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

				public int? TotalIpNum
				{
					get
					{
						return totalIpNum;
					}
					set	
					{
						totalIpNum = value;
					}
				}

				public int? UsedIpNum
				{
					get
					{
						return usedIpNum;
					}
					set	
					{
						usedIpNum = value;
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
			}

			public class ListPublicIpAddressPools_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
