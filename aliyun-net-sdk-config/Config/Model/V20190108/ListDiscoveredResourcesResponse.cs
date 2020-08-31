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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class ListDiscoveredResourcesResponse : AcsResponse
	{

		private string requestId;

		private ListDiscoveredResources_DiscoveredResourceProfiles discoveredResourceProfiles;

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

		public ListDiscoveredResources_DiscoveredResourceProfiles DiscoveredResourceProfiles
		{
			get
			{
				return discoveredResourceProfiles;
			}
			set	
			{
				discoveredResourceProfiles = value;
			}
		}

		public class ListDiscoveredResources_DiscoveredResourceProfiles
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListDiscoveredResources_DiscoveredResourceProfile> discoveredResourceProfileList;

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

			public List<ListDiscoveredResources_DiscoveredResourceProfile> DiscoveredResourceProfileList
			{
				get
				{
					return discoveredResourceProfileList;
				}
				set	
				{
					discoveredResourceProfileList = value;
				}
			}

			public class ListDiscoveredResources_DiscoveredResourceProfile
			{

				private long? accountId;

				private string region;

				private long? resourceCreationTime;

				private int? resourceDeleted;

				private string resourceId;

				private string resourceName;

				private string resourceStatus;

				private string resourceType;

				private string tags;

				public long? AccountId
				{
					get
					{
						return accountId;
					}
					set	
					{
						accountId = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public long? ResourceCreationTime
				{
					get
					{
						return resourceCreationTime;
					}
					set	
					{
						resourceCreationTime = value;
					}
				}

				public int? ResourceDeleted
				{
					get
					{
						return resourceDeleted;
					}
					set	
					{
						resourceDeleted = value;
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

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ResourceStatus
				{
					get
					{
						return resourceStatus;
					}
					set	
					{
						resourceStatus = value;
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

				public string Tags
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
			}
		}
	}
}
