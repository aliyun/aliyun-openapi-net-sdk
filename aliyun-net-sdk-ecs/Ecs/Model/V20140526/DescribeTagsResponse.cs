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
	public class DescribeTagsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeTags_Tag> tags;

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

		public List<DescribeTags_Tag> Tags
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

		public class DescribeTags_Tag
		{

			private string tagKey;

			private string tagValue;

			private DescribeTags_ResourceTypeCount resourceTypeCount;

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

			public DescribeTags_ResourceTypeCount ResourceTypeCount
			{
				get
				{
					return resourceTypeCount;
				}
				set	
				{
					resourceTypeCount = value;
				}
			}

			public class DescribeTags_ResourceTypeCount
			{

				private int? instance;

				private int? disk;

				private int? volume;

				private int? image;

				private int? snapshot;

				private int? securitygroup;

				private int? launchTemplate;

				private int? eni;

				private int? ddh;

				private int? keyPair;

				private int? snapshotPolicy;

				private int? reservedInstance;

				public int? Instance
				{
					get
					{
						return instance;
					}
					set	
					{
						instance = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public int? Volume
				{
					get
					{
						return volume;
					}
					set	
					{
						volume = value;
					}
				}

				public int? Image
				{
					get
					{
						return image;
					}
					set	
					{
						image = value;
					}
				}

				public int? Snapshot
				{
					get
					{
						return snapshot;
					}
					set	
					{
						snapshot = value;
					}
				}

				public int? Securitygroup
				{
					get
					{
						return securitygroup;
					}
					set	
					{
						securitygroup = value;
					}
				}

				public int? LaunchTemplate
				{
					get
					{
						return launchTemplate;
					}
					set	
					{
						launchTemplate = value;
					}
				}

				public int? Eni
				{
					get
					{
						return eni;
					}
					set	
					{
						eni = value;
					}
				}

				public int? Ddh
				{
					get
					{
						return ddh;
					}
					set	
					{
						ddh = value;
					}
				}

				public int? KeyPair
				{
					get
					{
						return keyPair;
					}
					set	
					{
						keyPair = value;
					}
				}

				public int? SnapshotPolicy
				{
					get
					{
						return snapshotPolicy;
					}
					set	
					{
						snapshotPolicy = value;
					}
				}

				public int? ReservedInstance
				{
					get
					{
						return reservedInstance;
					}
					set	
					{
						reservedInstance = value;
					}
				}
			}
		}
	}
}
