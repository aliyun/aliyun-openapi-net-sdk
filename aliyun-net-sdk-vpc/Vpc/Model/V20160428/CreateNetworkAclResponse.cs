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
	public class CreateNetworkAclResponse : AcsResponse
	{

		private string networkAclId;

		private string requestId;

		private CreateNetworkAcl_NetworkAclAttribute networkAclAttribute;

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

		public CreateNetworkAcl_NetworkAclAttribute NetworkAclAttribute
		{
			get
			{
				return networkAclAttribute;
			}
			set	
			{
				networkAclAttribute = value;
			}
		}

		public class CreateNetworkAcl_NetworkAclAttribute
		{

			private string status;

			private string vpcId;

			private string creationTime;

			private string description;

			private string networkAclName;

			private string networkAclId;

			private string regionId;

			private List<CreateNetworkAcl_IngressAclEntry> ingressAclEntries;

			private List<CreateNetworkAcl_EgressAclEntry> egressAclEntries;

			private List<CreateNetworkAcl_Resource> resources;

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

			public List<CreateNetworkAcl_IngressAclEntry> IngressAclEntries
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

			public List<CreateNetworkAcl_EgressAclEntry> EgressAclEntries
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

			public List<CreateNetworkAcl_Resource> Resources
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

			public class CreateNetworkAcl_IngressAclEntry
			{

				private string networkAclEntryId;

				private string entryType;

				private string networkAclEntryName;

				private string policy;

				private string description;

				private string sourceCidrIp;

				private string protocol;

				private string port;

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
			}

			public class CreateNetworkAcl_EgressAclEntry
			{

				private string networkAclEntryId;

				private string entryType;

				private string networkAclEntryName;

				private string policy;

				private string description;

				private string protocol;

				private string destinationCidrIp;

				private string port;

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
			}

			public class CreateNetworkAcl_Resource
			{

				private string status;

				private string resourceType;

				private string resourceId;

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
			}
		}
	}
}
