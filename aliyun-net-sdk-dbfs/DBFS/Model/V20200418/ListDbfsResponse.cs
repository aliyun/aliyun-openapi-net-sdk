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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class ListDbfsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<ListDbfs_Info> dBFSInfo;

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "DBFSInfo")]
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

			private string instanceType;

			private string lastFailed;

			private List<ListDbfs_TagList> tags;

			private List<ListDbfs_EcsListItem> ecsList;

			private List<ListDbfs_EbsListItem> ebsList;

			private ListDbfs_SnapshotInfo snapshotInfo;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "Encryption")]
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

			[JsonProperty(PropertyName = "PayType")]
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

			[JsonProperty(PropertyName = "FsId")]
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

			[JsonProperty(PropertyName = "SizeG")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "DBFSClusterId")]
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

			[JsonProperty(PropertyName = "ZoneId")]
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

			[JsonProperty(PropertyName = "FsName")]
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

			[JsonProperty(PropertyName = "Category")]
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

			[JsonProperty(PropertyName = "CreatedTime")]
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

			[JsonProperty(PropertyName = "AttachNodeNumber")]
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

			[JsonProperty(PropertyName = "KMSKeyId")]
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

			[JsonProperty(PropertyName = "PerformanceLevel")]
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

			[JsonProperty(PropertyName = "UsedScene")]
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

			[JsonProperty(PropertyName = "LastMountTime")]
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

			[JsonProperty(PropertyName = "LastUmountTime")]
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

			[JsonProperty(PropertyName = "EnableRaid")]
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

			[JsonProperty(PropertyName = "RaidStrip")]
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

			[JsonProperty(PropertyName = "InstanceType")]
			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			[JsonProperty(PropertyName = "LastFailed")]
			public string LastFailed
			{
				get
				{
					return lastFailed;
				}
				set	
				{
					lastFailed = value;
				}
			}

			[JsonProperty(PropertyName = "Tags")]
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

			[JsonProperty(PropertyName = "EcsList")]
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

			[JsonProperty(PropertyName = "EbsList")]
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

			[JsonProperty(PropertyName = "SnapshotInfo")]
			public ListDbfs_SnapshotInfo SnapshotInfo
			{
				get
				{
					return snapshotInfo;
				}
				set	
				{
					snapshotInfo = value;
				}
			}

			public class ListDbfs_TagList
			{

				private string tagValue;

				private long? id;

				private string tagKey;

				[JsonProperty(PropertyName = "TagValue")]
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

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "TagKey")]
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

				[JsonProperty(PropertyName = "EcsId")]
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

				[JsonProperty(PropertyName = "EbsId")]
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

				[JsonProperty(PropertyName = "SizeG")]
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

			public class ListDbfs_SnapshotInfo
			{

				private int? snapshotCount;

				private long? totalSize;

				private string linkId;

				private string policyId;

				[JsonProperty(PropertyName = "SnapshotCount")]
				public int? SnapshotCount
				{
					get
					{
						return snapshotCount;
					}
					set	
					{
						snapshotCount = value;
					}
				}

				[JsonProperty(PropertyName = "TotalSize")]
				public long? TotalSize
				{
					get
					{
						return totalSize;
					}
					set	
					{
						totalSize = value;
					}
				}

				[JsonProperty(PropertyName = "LinkId")]
				public string LinkId
				{
					get
					{
						return linkId;
					}
					set	
					{
						linkId = value;
					}
				}

				[JsonProperty(PropertyName = "PolicyId")]
				public string PolicyId
				{
					get
					{
						return policyId;
					}
					set	
					{
						policyId = value;
					}
				}
			}
		}
	}
}
