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
	public class ListManagedPrivateSpacesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private List<ListManagedPrivateSpaces_ManagedPrivateSpaceSet> managedPrivateSpaceSets;

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

		public List<ListManagedPrivateSpaces_ManagedPrivateSpaceSet> ManagedPrivateSpaceSets
		{
			get
			{
				return managedPrivateSpaceSets;
			}
			set	
			{
				managedPrivateSpaceSets = value;
			}
		}

		public class ListManagedPrivateSpaces_ManagedPrivateSpaceSet
		{

			private string creationTime;

			private string description;

			private string managedPrivateSpaceId;

			private string managedPrivateSpaceName;

			private string resourceGroupId;

			private string saleMode;

			private string zoneId;

			private List<ListManagedPrivateSpaces_DeploymentAttribute> deploymentAttributes;

			private List<ListManagedPrivateSpaces_ManagedHostSet> managedHostSets;

			private List<ListManagedPrivateSpaces_Tag> tags;

			private ListManagedPrivateSpaces_CapacityAttribute capacityAttribute;

			private ListManagedPrivateSpaces_LifecycleAttribute lifecycleAttribute;

			private ListManagedPrivateSpaces_LocationAttribute locationAttribute;

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

			public string ManagedPrivateSpaceId
			{
				get
				{
					return managedPrivateSpaceId;
				}
				set	
				{
					managedPrivateSpaceId = value;
				}
			}

			public string ManagedPrivateSpaceName
			{
				get
				{
					return managedPrivateSpaceName;
				}
				set	
				{
					managedPrivateSpaceName = value;
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

			public string SaleMode
			{
				get
				{
					return saleMode;
				}
				set	
				{
					saleMode = value;
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

			public List<ListManagedPrivateSpaces_DeploymentAttribute> DeploymentAttributes
			{
				get
				{
					return deploymentAttributes;
				}
				set	
				{
					deploymentAttributes = value;
				}
			}

			public List<ListManagedPrivateSpaces_ManagedHostSet> ManagedHostSets
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

			public List<ListManagedPrivateSpaces_Tag> Tags
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

			public ListManagedPrivateSpaces_CapacityAttribute CapacityAttribute
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

			public ListManagedPrivateSpaces_LifecycleAttribute LifecycleAttribute
			{
				get
				{
					return lifecycleAttribute;
				}
				set	
				{
					lifecycleAttribute = value;
				}
			}

			public ListManagedPrivateSpaces_LocationAttribute LocationAttribute
			{
				get
				{
					return locationAttribute;
				}
				set	
				{
					locationAttribute = value;
				}
			}

			public class ListManagedPrivateSpaces_DeploymentAttribute
			{

				private string contractId;

				private string createTime;

				private string description;

				private List<ListManagedPrivateSpaces_DeploymentStep> deploymentSteps;

				public string ContractId
				{
					get
					{
						return contractId;
					}
					set	
					{
						contractId = value;
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

				public List<ListManagedPrivateSpaces_DeploymentStep> DeploymentSteps
				{
					get
					{
						return deploymentSteps;
					}
					set	
					{
						deploymentSteps = value;
					}
				}

				public class ListManagedPrivateSpaces_DeploymentStep
				{

					private string actualTime;

					private bool? currentStep;

					private string expectTime;

					private string status;

					public string ActualTime
					{
						get
						{
							return actualTime;
						}
						set	
						{
							actualTime = value;
						}
					}

					public bool? CurrentStep
					{
						get
						{
							return currentStep;
						}
						set	
						{
							currentStep = value;
						}
					}

					public string ExpectTime
					{
						get
						{
							return expectTime;
						}
						set	
						{
							expectTime = value;
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

			public class ListManagedPrivateSpaces_ManagedHostSet
			{

				private string managedHostId;

				private string managedHostStatus;

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

				public string ManagedHostStatus
				{
					get
					{
						return managedHostStatus;
					}
					set	
					{
						managedHostStatus = value;
					}
				}
			}

			public class ListManagedPrivateSpaces_Tag
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

			public class ListManagedPrivateSpaces_CapacityAttribute
			{

				private int? availableHostCount;

				private int? availableMemories;

				private int? availableVcpus;

				private int? reservedHostCount;

				private int? reservedMemories;

				private int? reservedVcpus;

				private int? totalHostCount;

				private int? totalMemories;

				private int? totalVcpus;

				public int? AvailableHostCount
				{
					get
					{
						return availableHostCount;
					}
					set	
					{
						availableHostCount = value;
					}
				}

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

				public int? ReservedHostCount
				{
					get
					{
						return reservedHostCount;
					}
					set	
					{
						reservedHostCount = value;
					}
				}

				public int? ReservedMemories
				{
					get
					{
						return reservedMemories;
					}
					set	
					{
						reservedMemories = value;
					}
				}

				public int? ReservedVcpus
				{
					get
					{
						return reservedVcpus;
					}
					set	
					{
						reservedVcpus = value;
					}
				}

				public int? TotalHostCount
				{
					get
					{
						return totalHostCount;
					}
					set	
					{
						totalHostCount = value;
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

			public class ListManagedPrivateSpaces_LifecycleAttribute
			{

				private string deliveryTime;

				private string expirationTime;

				private string receptionTime;

				public string DeliveryTime
				{
					get
					{
						return deliveryTime;
					}
					set	
					{
						deliveryTime = value;
					}
				}

				public string ExpirationTime
				{
					get
					{
						return expirationTime;
					}
					set	
					{
						expirationTime = value;
					}
				}

				public string ReceptionTime
				{
					get
					{
						return receptionTime;
					}
					set	
					{
						receptionTime = value;
					}
				}
			}

			public class ListManagedPrivateSpaces_LocationAttribute
			{

				private string address;

				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}
			}
		}
	}
}
