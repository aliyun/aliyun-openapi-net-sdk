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
	public class GetDbfsResponse : AcsResponse
	{

		private string requestId;

		private GetDbfs_DBFSInfo dBFSInfo;

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

		[JsonProperty(PropertyName = "DBFSInfo")]
		public GetDbfs_DBFSInfo DBFSInfo
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

		public class GetDbfs_DBFSInfo
		{

			private string status;

			private string payType;

			private string fsId;

			private int? sizeG;

			private string regionId;

			private string dBFSClusterId;

			private string description;

			private string zoneId;

			private string fsName;

			private string category;

			private string createdTime;

			private int? attachNodeNumber;

			private string kMSKeyId;

			private bool? encryption;

			private string performanceLevel;

			private string usedScene;

			private string lastMountTime;

			private string lastUmountTime;

			private bool? enableRaid;

			private string instanceType;

			private int? raidStrip;

			private string lastFailed;

			private List<GetDbfs_TagList> tags;

			private List<GetDbfs_EcsListItem> ecsList;

			private List<GetDbfs_EbsListItem> ebsList;

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

			[JsonProperty(PropertyName = "Description")]
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
			public List<GetDbfs_TagList> Tags
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
			public List<GetDbfs_EcsListItem> EcsList
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
			public List<GetDbfs_EbsListItem> EbsList
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

			public class GetDbfs_TagList
			{

				private string tagValue;

				private int? id;

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
				public int? Id
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

			public class GetDbfs_EcsListItem
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

			public class GetDbfs_EbsListItem
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
		}
	}
}
