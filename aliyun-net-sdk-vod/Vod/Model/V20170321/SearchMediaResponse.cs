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
	public class SearchMediaResponse : AcsResponse
	{

		private string requestId;

		private string scrollToken;

		private long? total;

		private List<SearchMedia_Media> mediaList;

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

		public string ScrollToken
		{
			get
			{
				return scrollToken;
			}
			set	
			{
				scrollToken = value;
			}
		}

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<SearchMedia_Media> MediaList
		{
			get
			{
				return mediaList;
			}
			set	
			{
				mediaList = value;
			}
		}

		public class SearchMedia_Media
		{

			private string mediaType;

			private string creationTime;

			private string mediaId;

			private SearchMedia_Video video;

			private SearchMedia_Audio audio;

			private SearchMedia_Image image;

			private SearchMedia_AttachedMedia attachedMedia;

			public string MediaType
			{
				get
				{
					return mediaType;
				}
				set	
				{
					mediaType = value;
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

			public SearchMedia_Video Video
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

			public SearchMedia_Audio Audio
			{
				get
				{
					return audio;
				}
				set	
				{
					audio = value;
				}
			}

			public SearchMedia_Image Image
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

			public SearchMedia_AttachedMedia AttachedMedia
			{
				get
				{
					return attachedMedia;
				}
				set	
				{
					attachedMedia = value;
				}
			}

			public class SearchMedia_Video
			{

				private string videoId;

				private string mediaSource;

				private string mediaType;

				private string title;

				private string tags;

				private string status;

				private long? size;

				private float? duration;

				private string description;

				private string modificationTime;

				private string creationTime;

				private string coverURL;

				private long? cateId;

				private string cateName;

				private string downloadSwitch;

				private string preprocessStatus;

				private string storageLocation;

				private string regionId;

				private string transcodeMode;

				private string auditStatus;

				private string auditAIStatus;

				private string auditManualStatus;

				private string auditAIResult;

				private string auditTemplateId;

				private string customMediaInfo;

				private string appId;

				private string auditAbnormalModules;

				private string auditLabel;

				private List<SearchMedia_PlayInfo> playInfoList;

				private List<string> snapshots;

				private List<string> spriteSnapshots;

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

				public string MediaSource
				{
					get
					{
						return mediaSource;
					}
					set	
					{
						mediaSource = value;
					}
				}

				public string MediaType
				{
					get
					{
						return mediaType;
					}
					set	
					{
						mediaType = value;
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

				public string TranscodeMode
				{
					get
					{
						return transcodeMode;
					}
					set	
					{
						transcodeMode = value;
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

				public string AuditAIStatus
				{
					get
					{
						return auditAIStatus;
					}
					set	
					{
						auditAIStatus = value;
					}
				}

				public string AuditManualStatus
				{
					get
					{
						return auditManualStatus;
					}
					set	
					{
						auditManualStatus = value;
					}
				}

				public string AuditAIResult
				{
					get
					{
						return auditAIResult;
					}
					set	
					{
						auditAIResult = value;
					}
				}

				public string AuditTemplateId
				{
					get
					{
						return auditTemplateId;
					}
					set	
					{
						auditTemplateId = value;
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

				public string AuditAbnormalModules
				{
					get
					{
						return auditAbnormalModules;
					}
					set	
					{
						auditAbnormalModules = value;
					}
				}

				public string AuditLabel
				{
					get
					{
						return auditLabel;
					}
					set	
					{
						auditLabel = value;
					}
				}

				public List<SearchMedia_PlayInfo> PlayInfoList
				{
					get
					{
						return playInfoList;
					}
					set	
					{
						playInfoList = value;
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

				public List<string> SpriteSnapshots
				{
					get
					{
						return spriteSnapshots;
					}
					set	
					{
						spriteSnapshots = value;
					}
				}

				public class SearchMedia_PlayInfo
				{

					private string width;

					private string height;

					private string size;

					private string playURL;

					private string bitrate;

					private string definition;

					private string duration;

					private string format;

					private string fps;

					private long? encrypt;

					private string plaintext;

					private string complexity;

					private string streamType;

					private string rand;

					private string jobId;

					public string Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public string Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}

					public string Size
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

					public string PlayURL
					{
						get
						{
							return playURL;
						}
						set	
						{
							playURL = value;
						}
					}

					public string Bitrate
					{
						get
						{
							return bitrate;
						}
						set	
						{
							bitrate = value;
						}
					}

					public string Definition
					{
						get
						{
							return definition;
						}
						set	
						{
							definition = value;
						}
					}

					public string Duration
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

					public string Format
					{
						get
						{
							return format;
						}
						set	
						{
							format = value;
						}
					}

					public string Fps
					{
						get
						{
							return fps;
						}
						set	
						{
							fps = value;
						}
					}

					public long? Encrypt
					{
						get
						{
							return encrypt;
						}
						set	
						{
							encrypt = value;
						}
					}

					public string Plaintext
					{
						get
						{
							return plaintext;
						}
						set	
						{
							plaintext = value;
						}
					}

					public string Complexity
					{
						get
						{
							return complexity;
						}
						set	
						{
							complexity = value;
						}
					}

					public string StreamType
					{
						get
						{
							return streamType;
						}
						set	
						{
							streamType = value;
						}
					}

					public string Rand
					{
						get
						{
							return rand;
						}
						set	
						{
							rand = value;
						}
					}

					public string JobId
					{
						get
						{
							return jobId;
						}
						set	
						{
							jobId = value;
						}
					}
				}
			}

			public class SearchMedia_Audio
			{

				private string audioId;

				private string mediaSource;

				private string title;

				private string tags;

				private string status;

				private long? size;

				private float? duration;

				private string description;

				private string modificationTime;

				private string creationTime;

				private string coverURL;

				private long? cateId;

				private string cateName;

				private string downloadSwitch;

				private string preprocessStatus;

				private string storageLocation;

				private string regionId;

				private string transcodeMode;

				private string auditStatus;

				private string auditAIStatus;

				private string auditManualStatus;

				private string auditAIResult;

				private string auditTemplateId;

				private string customMediaInfo;

				private string appId;

				private List<SearchMedia_PlayInfo4> playInfoList3;

				private List<string> snapshots1;

				private List<string> spriteSnapshots2;

				public string AudioId
				{
					get
					{
						return audioId;
					}
					set	
					{
						audioId = value;
					}
				}

				public string MediaSource
				{
					get
					{
						return mediaSource;
					}
					set	
					{
						mediaSource = value;
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

				public string TranscodeMode
				{
					get
					{
						return transcodeMode;
					}
					set	
					{
						transcodeMode = value;
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

				public string AuditAIStatus
				{
					get
					{
						return auditAIStatus;
					}
					set	
					{
						auditAIStatus = value;
					}
				}

				public string AuditManualStatus
				{
					get
					{
						return auditManualStatus;
					}
					set	
					{
						auditManualStatus = value;
					}
				}

				public string AuditAIResult
				{
					get
					{
						return auditAIResult;
					}
					set	
					{
						auditAIResult = value;
					}
				}

				public string AuditTemplateId
				{
					get
					{
						return auditTemplateId;
					}
					set	
					{
						auditTemplateId = value;
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

				public List<SearchMedia_PlayInfo4> PlayInfoList3
				{
					get
					{
						return playInfoList3;
					}
					set	
					{
						playInfoList3 = value;
					}
				}

				public List<string> Snapshots1
				{
					get
					{
						return snapshots1;
					}
					set	
					{
						snapshots1 = value;
					}
				}

				public List<string> SpriteSnapshots2
				{
					get
					{
						return spriteSnapshots2;
					}
					set	
					{
						spriteSnapshots2 = value;
					}
				}

				public class SearchMedia_PlayInfo4
				{

					private string width;

					private string height;

					private string size;

					private string playURL;

					private string bitrate;

					private string definition;

					private string duration;

					private string format;

					private string fps;

					private long? encrypt;

					private string plaintext;

					private string complexity;

					private string streamType;

					private string rand;

					private string jobId;

					public string Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public string Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}

					public string Size
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

					public string PlayURL
					{
						get
						{
							return playURL;
						}
						set	
						{
							playURL = value;
						}
					}

					public string Bitrate
					{
						get
						{
							return bitrate;
						}
						set	
						{
							bitrate = value;
						}
					}

					public string Definition
					{
						get
						{
							return definition;
						}
						set	
						{
							definition = value;
						}
					}

					public string Duration
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

					public string Format
					{
						get
						{
							return format;
						}
						set	
						{
							format = value;
						}
					}

					public string Fps
					{
						get
						{
							return fps;
						}
						set	
						{
							fps = value;
						}
					}

					public long? Encrypt
					{
						get
						{
							return encrypt;
						}
						set	
						{
							encrypt = value;
						}
					}

					public string Plaintext
					{
						get
						{
							return plaintext;
						}
						set	
						{
							plaintext = value;
						}
					}

					public string Complexity
					{
						get
						{
							return complexity;
						}
						set	
						{
							complexity = value;
						}
					}

					public string StreamType
					{
						get
						{
							return streamType;
						}
						set	
						{
							streamType = value;
						}
					}

					public string Rand
					{
						get
						{
							return rand;
						}
						set	
						{
							rand = value;
						}
					}

					public string JobId
					{
						get
						{
							return jobId;
						}
						set	
						{
							jobId = value;
						}
					}
				}
			}

			public class SearchMedia_Image
			{

				private string title;

				private string imageId;

				private long? cateId;

				private string cateName;

				private string ext;

				private string creationTime;

				private string modificationTime;

				private string tags;

				private string type;

				private string uRL;

				private string status;

				private string description;

				private string storageLocation;

				private string regionId;

				private string appId;

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

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
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

				public string Ext
				{
					get
					{
						return ext;
					}
					set	
					{
						ext = value;
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
			}

			public class SearchMedia_AttachedMedia
			{

				private string title;

				private string mediaId;

				private string ext;

				private string creationTime;

				private string modificationTime;

				private string tags;

				private string businessType;

				private string uRL;

				private string status;

				private string description;

				private string storageLocation;

				private string regionId;

				private string appId;

				private string icon;

				private string onlineStatus;

				private List<SearchMedia_Category> categories;

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

				public string Ext
				{
					get
					{
						return ext;
					}
					set	
					{
						ext = value;
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

				public string BusinessType
				{
					get
					{
						return businessType;
					}
					set	
					{
						businessType = value;
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

				public List<SearchMedia_Category> Categories
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

				public class SearchMedia_Category
				{

					private long? cateId;

					private string cateName;

					private long? level;

					private long? parentId;

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
				}
			}
		}
	}
}
