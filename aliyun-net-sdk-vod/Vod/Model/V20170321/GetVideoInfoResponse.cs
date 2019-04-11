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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetVideoInfoResponse : AcsResponse
	{

		private string requestId;

		private string aI;

		private GetVideoInfo_Video video;

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

		public string AI
		{
			get
			{
				return aI;
			}
			set	
			{
				aI = value;
			}
		}

		public GetVideoInfo_Video Video
		{
			get
			{
				return video;
			}
			set	
			{
				video = value;
			}
		}

		public class GetVideoInfo_Video
		{

			private string videoId;

			private string title;

			private string tags;

			private string status;

			private long? size;

			private float? duration;

			private string description;

			private string createTime;

			private string modifyTime;

			private string modificationTime;

			private string creationTime;

			private string coverURL;

			private long? cateId;

			private string cateName;

			private string downloadSwitch;

			private string templateGroupId;

			private string preprocessStatus;

			private string storageLocation;

			private string regionId;

			private string customMediaInfo;

			private string auditStatus;

			private string appId;

			private List<GetVideoInfo_Thumbnail> thumbnailList;

			private List<string> snapshots;

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
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

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public float? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public string CoverURL
			{
				get
				{
					return coverURL;
				}
				set	
				{
					coverURL = value;
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

			public string DownloadSwitch
			{
				get
				{
					return downloadSwitch;
				}
				set	
				{
					downloadSwitch = value;
				}
			}

			public string TemplateGroupId
			{
				get
				{
					return templateGroupId;
				}
				set	
				{
					templateGroupId = value;
				}
			}

			public string PreprocessStatus
			{
				get
				{
					return preprocessStatus;
				}
				set	
				{
					preprocessStatus = value;
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

			public string CustomMediaInfo
			{
				get
				{
					return customMediaInfo;
				}
				set	
				{
					customMediaInfo = value;
				}
			}

			public string AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
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

			public List<GetVideoInfo_Thumbnail> ThumbnailList
			{
				get
				{
					return thumbnailList;
				}
				set	
				{
					thumbnailList = value;
				}
			}

			public List<string> Snapshots
			{
				get
				{
					return snapshots;
				}
				set	
				{
					snapshots = value;
				}
			}

			public class GetVideoInfo_Thumbnail
			{

				private string uRL;

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
			}
		}
	}
}
