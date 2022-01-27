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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class ListDbfsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<ListDbfs_Info> dBFSInfo;

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

		public List<ListDbfs_Info> DBFSInfo
		{
			get
			{
				return dBFSInfo;
			}
			set	
			{
				dBFSInfo = value;
			}
		}

		public class ListDbfs_Info
		{

			private string status;

			private bool? encryption;

			private string payType;

			private string fsId;

			private int? sizeG;

			private string regionId;

			private string dBFSClusterId;

			private string zoneId;

			private string fsName;

			private string category;

			private string createdTime;

			private int? attachNodeNumber;

			private string kMSKeyId;

			private string performanceLevel;

			private string usedScene;

			private string lastMountTime;

			private string lastUmountTime;

			private bool? enableRaid;

			private int? raidStrip;

			private List<ListDbfs_TagList> tags;

			private List<ListDbfs_EcsListItem> ecsList;

			private List<ListDbfs_EbsListItem> ebsList;

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

			public bool? Encryption
			{
				get
				{
					return encryption;
				}
				set	
				{
					encryption = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string FsId
			{
				get
				{
					return fsId;
				}
				set	
				{
					fsId = value;
				}
			}

			public int? SizeG
			{
				get
				{
					return sizeG;
				}
				set	
				{
					sizeG = value;
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

			public string DBFSClusterId
			{
				get
				{
					return dBFSClusterId;
				}
				set	
				{
					dBFSClusterId = value;
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

			public string FsName
			{
				get
				{
					return fsName;
				}
				set	
				{
					fsName = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public int? AttachNodeNumber
			{
				get
				{
					return attachNodeNumber;
				}
				set	
				{
					attachNodeNumber = value;
				}
			}

			public string KMSKeyId
			{
				get
				{
					return kMSKeyId;
				}
				set	
				{
					kMSKeyId = value;
				}
			}

			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
				}
			}

			public string UsedScene
			{
				get
				{
					return usedScene;
				}
				set	
				{
					usedScene = value;
				}
			}

			public string LastMountTime
			{
				get
				{
					return lastMountTime;
				}
				set	
				{
					lastMountTime = value;
				}
			}

			public string LastUmountTime
			{
				get
				{
					return lastUmountTime;
				}
				set	
				{
					lastUmountTime = value;
				}
			}

			public bool? EnableRaid
			{
				get
				{
					return enableRaid;
				}
				set	
				{
					enableRaid = value;
				}
			}

			public int? RaidStrip
			{
				get
				{
					return raidStrip;
				}
				set	
				{
					raidStrip = value;
				}
			}

			public List<ListDbfs_TagList> Tags
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

			public List<ListDbfs_EcsListItem> EcsList
			{
				get
				{
					return ecsList;
				}
				set	
				{
					ecsList = value;
				}
			}

			public List<ListDbfs_EbsListItem> EbsList
			{
				get
				{
					return ebsList;
				}
				set	
				{
					ebsList = value;
				}
			}

			public class ListDbfs_TagList
			{

				private string tagValue;

				private long? id;

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

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

			public class ListDbfs_EcsListItem
			{

				private string ecsId;

				public string EcsId
				{
					get
					{
						return ecsId;
					}
					set	
					{
						ecsId = value;
					}
				}
			}

			public class ListDbfs_EbsListItem
			{

				private string ebsId;

				private int? sizeG;

				public string EbsId
				{
					get
					{
						return ebsId;
					}
					set	
					{
						ebsId = value;
					}
				}

				public int? SizeG
				{
					get
					{
						return sizeG;
					}
					set	
					{
						sizeG = value;
					}
				}
			}
		}
	}
}
