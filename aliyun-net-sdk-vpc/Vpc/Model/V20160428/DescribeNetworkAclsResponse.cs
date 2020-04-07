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
	public class DescribeNetworkAclsResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private string pageNumber;

		private string pageSize;

		private List<DescribeNetworkAcls_NetworkAcl> networkAcls;

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

		public string TotalCount
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

		public string PageNumber
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

		public string PageSize
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

		public List<DescribeNetworkAcls_NetworkAcl> NetworkAcls
		{
			get
			{
				return networkAcls;
			}
			set	
			{
				networkAcls = value;
			}
		}

		public class DescribeNetworkAcls_NetworkAcl
		{

			private string networkAclId;

			private string regionId;

			private string networkAclName;

			private string description;

			private string vpcId;

			private string creationTime;

			private string status;

			private long? ownerId;

			private List<DescribeNetworkAcls_IngressAclEntry> ingressAclEntries;

			private List<DescribeNetworkAcls_EgressAclEntry> egressAclEntries;

			private List<DescribeNetworkAcls_Resource> resources;

			public string NetworkAclId
			{
				get
				{
					return networkAclId;
				}
				set	
				{
					networkAclId = value;
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

			public string NetworkAclName
			{
				get
				{
					return networkAclName;
				}
				set	
				{
					networkAclName = value;
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

			public List<DescribeNetworkAcls_IngressAclEntry> IngressAclEntries
			{
				get
				{
					return ingressAclEntries;
				}
				set	
				{
					ingressAclEntries = value;
				}
			}

			public List<DescribeNetworkAcls_EgressAclEntry> EgressAclEntries
			{
				get
				{
					return egressAclEntries;
				}
				set	
				{
					egressAclEntries = value;
				}
			}

			public List<DescribeNetworkAcls_Resource> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public class DescribeNetworkAcls_IngressAclEntry
			{

				private string networkAclEntryId;

				private string policy;

				private string protocol;

				private string sourceCidrIp;

				private string port;

				private string entryType;

				private string networkAclEntryName;

				private string description;

				public string NetworkAclEntryId
				{
					get
					{
						return networkAclEntryId;
					}
					set	
					{
						networkAclEntryId = value;
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

				public string Protocol
				{
					get
					{
						return protocol;
					}
					set	
					{
						protocol = value;
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

				public string Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string EntryType
				{
					get
					{
						return entryType;
					}
					set	
					{
						entryType = value;
					}
				}

				public string NetworkAclEntryName
				{
					get
					{
						return networkAclEntryName;
					}
					set	
					{
						networkAclEntryName = value;
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
			}

			public class DescribeNetworkAcls_EgressAclEntry
			{

				private string networkAclEntryId;

				private string policy;

				private string protocol;

				private string destinationCidrIp;

				private string port;

				private string entryType;

				private string description;

				private string networkAclEntryName;

				public string NetworkAclEntryId
				{
					get
					{
						return networkAclEntryId;
					}
					set	
					{
						networkAclEntryId = value;
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

				public string Protocol
				{
					get
					{
						return protocol;
					}
					set	
					{
						protocol = value;
					}
				}

				public string DestinationCidrIp
				{
					get
					{
						return destinationCidrIp;
					}
					set	
					{
						destinationCidrIp = value;
					}
				}

				public string Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string EntryType
				{
					get
					{
						return entryType;
					}
					set	
					{
						entryType = value;
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

				public string NetworkAclEntryName
				{
					get
					{
						return networkAclEntryName;
					}
					set	
					{
						networkAclEntryName = value;
					}
				}
			}

			public class DescribeNetworkAcls_Resource
			{

				private string resourceId;

				private string resourceType;

				private string status;

				public string ResourceId
				{
					get
					{
						return resourceId;
					}
					set	
					{
						resourceId = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
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
			}
		}
	}
}
