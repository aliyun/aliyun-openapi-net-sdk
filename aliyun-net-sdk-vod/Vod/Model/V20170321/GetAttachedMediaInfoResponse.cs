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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetAttachedMediaInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetAttachedMediaInfo_AttachedMedia> attachedMediaList;

		private List<string> nonExistMediaIds;

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

		public List<GetAttachedMediaInfo_AttachedMedia> AttachedMediaList
		{
			get
			{
				return attachedMediaList;
			}
			set	
			{
				attachedMediaList = value;
			}
		}

		public List<string> NonExistMediaIds
		{
			get
			{
				return nonExistMediaIds;
			}
			set	
			{
				nonExistMediaIds = value;
			}
		}

		public class GetAttachedMediaInfo_AttachedMedia
		{

			private string type;

			private string storageLocation;

			private string creationTime;

			private string status;

			private string icon;

			private string tags;

			private string modificationTime;

			private string mediaId;

			private string regionId;

			private string description;

			private string appId;

			private string uRL;

			private string title;

			private string onlineStatus;

			private long? fileSize;

			private List<GetAttachedMediaInfo_Category> categories;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string StorageLocation
			{
				get
				{
					return storageLocation;
				}
				set	
				{
					storageLocation = value;
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

			public string Icon
			{
				get
				{
					return icon;
				}
				set	
				{
					icon = value;
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

			public string ModificationTime
			{
				get
				{
					return modificationTime;
				}
				set	
				{
					modificationTime = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
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

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string URL
			{
				get
				{
					return uRL;
				}
				set	
				{
					uRL = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string OnlineStatus
			{
				get
				{
					return onlineStatus;
				}
				set	
				{
					onlineStatus = value;
				}
			}

			public long? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public List<GetAttachedMediaInfo_Category> Categories
			{
				get
				{
					return categories;
				}
				set	
				{
					categories = value;
				}
			}

			public class GetAttachedMediaInfo_Category
			{

				private long? parentId;

				private string cateName;

				private long? cateId;

				private long? level;

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public string CateName
				{
					get
					{
						return cateName;
					}
					set	
					{
						cateName = value;
					}
				}

				public long? CateId
				{
					get
					{
						return cateId;
					}
					set	
					{
						cateId = value;
					}
				}

				public long? Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
					}
				}
			}
		}
	}
}
