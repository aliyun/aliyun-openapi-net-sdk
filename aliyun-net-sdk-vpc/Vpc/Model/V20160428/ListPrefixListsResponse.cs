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
	public class ListPrefixListsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private long? totalCount;

		private long? maxResults;

		private List<ListPrefixLists_PrefixList> prefixLists;

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

		public long? TotalCount
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

		public long? MaxResults
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

		public List<ListPrefixLists_PrefixList> PrefixLists
		{
			get
			{
				return prefixLists;
			}
			set	
			{
				prefixLists = value;
			}
		}

		public class ListPrefixLists_PrefixList
		{

			private string prefixListId;

			private string prefixListName;

			private string prefixListDescription;

			private string ipVersion;

			private string creationTime;

			private string shareType;

			private int? maxEntries;

			private string status;

			private string ownerId;

			private string prefixListStatus;

			private string regionId;

			private string resourceGroupId;

			private List<ListPrefixLists_Tag> tags;

			private List<string> cidrBlocks;

			public string PrefixListId
			{
				get
				{
					return prefixListId;
				}
				set	
				{
					prefixListId = value;
				}
			}

			public string PrefixListName
			{
				get
				{
					return prefixListName;
				}
				set	
				{
					prefixListName = value;
				}
			}

			public string PrefixListDescription
			{
				get
				{
					return prefixListDescription;
				}
				set	
				{
					prefixListDescription = value;
				}
			}

			public string IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
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

			public int? MaxEntries
			{
				get
				{
					return maxEntries;
				}
				set	
				{
					maxEntries = value;
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

			public string PrefixListStatus
			{
				get
				{
					return prefixListStatus;
				}
				set	
				{
					prefixListStatus = value;
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

			public List<ListPrefixLists_Tag> Tags
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

			public List<string> CidrBlocks
			{
				get
				{
					return cidrBlocks;
				}
				set	
				{
					cidrBlocks = value;
				}
			}

			public class ListPrefixLists_Tag
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
