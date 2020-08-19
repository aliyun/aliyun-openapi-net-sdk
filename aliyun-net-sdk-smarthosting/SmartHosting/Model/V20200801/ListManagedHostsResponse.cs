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

namespace Aliyun.Acs.SmartHosting.Model.V20200801
{
	public class ListManagedHostsResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private List<ListManagedHosts_ManagedHostSet> managedHostSets;

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

		public List<ListManagedHosts_ManagedHostSet> ManagedHostSets
		{
			get
			{
				return managedHostSets;
			}
			set	
			{
				managedHostSets = value;
			}
		}

		public class ListManagedHosts_ManagedHostSet
		{

			private string managedHostId;

			private string managedHostName;

			private string mode;

			private string resourceGroupId;

			private string status;

			private List<ListManagedHosts_InstanceSet> instanceSets;

			private List<ListManagedHosts_Tag> tags;

			private List<string> supportedCustomInstanceTypeFamilies;

			private List<string> supportedInstanceTypeFamilies;

			private List<string> supportedInstanceTypes;

			private ListManagedHosts_CapacityAttribute capacityAttribute;

			private ListManagedHosts_HostAttribute hostAttribute;

			private ListManagedHosts_NetworkAssociation networkAssociation;

			public string ManagedHostId
			{
				get
				{
					return managedHostId;
				}
				set	
				{
					managedHostId = value;
				}
			}

			public string ManagedHostName
			{
				get
				{
					return managedHostName;
				}
				set	
				{
					managedHostName = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
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

			public List<ListManagedHosts_InstanceSet> InstanceSets
			{
				get
				{
					return instanceSets;
				}
				set	
				{
					instanceSets = value;
				}
			}

			public List<ListManagedHosts_Tag> Tags
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

			public List<string> SupportedCustomInstanceTypeFamilies
			{
				get
				{
					return supportedCustomInstanceTypeFamilies;
				}
				set	
				{
					supportedCustomInstanceTypeFamilies = value;
				}
			}

			public List<string> SupportedInstanceTypeFamilies
			{
				get
				{
					return supportedInstanceTypeFamilies;
				}
				set	
				{
					supportedInstanceTypeFamilies = value;
				}
			}

			public List<string> SupportedInstanceTypes
			{
				get
				{
					return supportedInstanceTypes;
				}
				set	
				{
					supportedInstanceTypes = value;
				}
			}

			public ListManagedHosts_CapacityAttribute CapacityAttribute
			{
				get
				{
					return capacityAttribute;
				}
				set	
				{
					capacityAttribute = value;
				}
			}

			public ListManagedHosts_HostAttribute HostAttribute
			{
				get
				{
					return hostAttribute;
				}
				set	
				{
					hostAttribute = value;
				}
			}

			public ListManagedHosts_NetworkAssociation NetworkAssociation
			{
				get
				{
					return networkAssociation;
				}
				set	
				{
					networkAssociation = value;
				}
			}

			public class ListManagedHosts_InstanceSet
			{

				private string instanceId;

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
			}

			public class ListManagedHosts_Tag
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

			public class ListManagedHosts_CapacityAttribute
			{

				private int? availableMemories;

				private int? availableVcpus;

				private int? totalMemories;

				private int? totalVcpus;

				public int? AvailableMemories
				{
					get
					{
						return availableMemories;
					}
					set	
					{
						availableMemories = value;
					}
				}

				public int? AvailableVcpus
				{
					get
					{
						return availableVcpus;
					}
					set	
					{
						availableVcpus = value;
					}
				}

				public int? TotalMemories
				{
					get
					{
						return totalMemories;
					}
					set	
					{
						totalMemories = value;
					}
				}

				public int? TotalVcpus
				{
					get
					{
						return totalVcpus;
					}
					set	
					{
						totalVcpus = value;
					}
				}
			}

			public class ListManagedHosts_HostAttribute
			{

				private string cpuModelName;

				private string hostType;

				public string CpuModelName
				{
					get
					{
						return cpuModelName;
					}
					set	
					{
						cpuModelName = value;
					}
				}

				public string HostType
				{
					get
					{
						return hostType;
					}
					set	
					{
						hostType = value;
					}
				}
			}

			public class ListManagedHosts_NetworkAssociation
			{

				private List<ListManagedHosts_SwitchSet> switchSets;

				public List<ListManagedHosts_SwitchSet> SwitchSets
				{
					get
					{
						return switchSets;
					}
					set	
					{
						switchSets = value;
					}
				}

				public class ListManagedHosts_SwitchSet
				{

					private string switchId;

					public string SwitchId
					{
						get
						{
							return switchId;
						}
						set	
						{
							switchId = value;
						}
					}
				}
			}
		}
	}
}
