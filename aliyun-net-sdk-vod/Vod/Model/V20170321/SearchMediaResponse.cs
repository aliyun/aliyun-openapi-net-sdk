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
	public class SearchMediaResponse : AcsResponse
	{

		private string requestId;

		private long? total;

		private string scrollToken;

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

			private string creationTime;

			private string mediaType;

			private string mediaId;

			private SearchMedia_Video video;

			private SearchMedia_Audio audio;

			private SearchMedia_Image image;

			private SearchMedia_AttachedMedia attachedMedia;

			private SearchMedia_AiData aiData;

			private SearchMedia_AiRoughData aiRoughData;

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

			public SearchMedia_AiData AiData
			{
				get
				{
					return aiData;
				}
				set	
				{
					aiData = value;
				}
			}

			public SearchMedia_AiRoughData AiRoughData
			{
				get
				{
					return aiRoughData;
				}
				set	
				{
					aiRoughData = value;
				}
			}

			public class SearchMedia_Video
			{

				private string status;

				private string creationTime;

				private string storageLocation;

				private long? cateId;

				private string auditTemplateId;

				private string tags;

				private string modificationTime;

				private string auditManualStatus;

				private string mediaType;

				private string mediaSource;

				private string description;

				private string appId;

				private string coverURL;

				private string auditStatus;

				private string auditAIStatus;

				private string videoId;

				private string auditLabel;

				private string downloadSwitch;

				private string regionId;

				private string auditAbnormalModules;

				private string customMediaInfo;

				private string cateName;

				private string transcodeMode;

				private string auditAIResult;

				private string preprocessStatus;

				private string restoreExpiration;

				private string restoreStatus;

				private string storageClass;

				private long? size;

				private float? duration;

				private string title;

				private string referenceId;

				private List<SearchMedia_PlayInfo> playInfoList;

				private List<string> spriteSnapshots;

				private List<string> snapshots;

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

				public string RestoreExpiration
				{
					get
					{
						return restoreExpiration;
					}
					set	
					{
						restoreExpiration = value;
					}
				}

				public string RestoreStatus
				{
					get
					{
						return restoreStatus;
					}
					set	
					{
						restoreStatus = value;
					}
				}

				public string StorageClass
				{
					get
					{
						return storageClass;
					}
					set	
					{
						storageClass = value;
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

				public string ReferenceId
				{
					get
					{
						return referenceId;
					}
					set	
					{
						referenceId = value;
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

				public class SearchMedia_PlayInfo
				{

					private string complexity;

					private string height;

					private string bitrate;

					private long? encrypt;

					private string definition;

					private string rand;

					private string streamType;

					private string jobId;

					private string width;

					private string size;

					private string plaintext;

					private string playURL;

					private string duration;

					private string fps;

					private string format;

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
				}
			}

			public class SearchMedia_Audio
			{

				private string status;

				private string creationTime;

				private string storageLocation;

				private long? cateId;

				private string auditTemplateId;

				private string tags;

				private string modificationTime;

				private string auditManualStatus;

				private string mediaSource;

				private string description;

				private string appId;

				private string coverURL;

				private string audioId;

				private string auditStatus;

				private string auditAIStatus;

				private string downloadSwitch;

				private string regionId;

				private string cateName;

				private string transcodeMode;

				private string customMediaInfo;

				private string auditAIResult;

				private string preprocessStatus;

				private string restoreExpiration;

				private string restoreStatus;

				private string storageClass;

				private long? size;

				private float? duration;

				private string title;

				private string referenceId;

				private List<SearchMedia_PlayInfo4> playInfoList3;

				private List<string> spriteSnapshots1;

				private List<string> snapshots2;

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

				public string RestoreExpiration
				{
					get
					{
						return restoreExpiration;
					}
					set	
					{
						restoreExpiration = value;
					}
				}

				public string RestoreStatus
				{
					get
					{
						return restoreStatus;
					}
					set	
					{
						restoreStatus = value;
					}
				}

				public string StorageClass
				{
					get
					{
						return storageClass;
					}
					set	
					{
						storageClass = value;
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

				public string ReferenceId
				{
					get
					{
						return referenceId;
					}
					set	
					{
						referenceId = value;
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

				public List<string> SpriteSnapshots1
				{
					get
					{
						return spriteSnapshots1;
					}
					set	
					{
						spriteSnapshots1 = value;
					}
				}

				public List<string> Snapshots2
				{
					get
					{
						return snapshots2;
					}
					set	
					{
						snapshots2 = value;
					}
				}

				public class SearchMedia_PlayInfo4
				{

					private string complexity;

					private string height;

					private string bitrate;

					private long? encrypt;

					private string definition;

					private string rand;

					private string streamType;

					private string jobId;

					private string width;

					private string size;

					private string plaintext;

					private string playURL;

					private string duration;

					private string fps;

					private string format;

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
				}
			}

			public class SearchMedia_Image
			{

				private string storageLocation;

				private string creationTime;

				private string type;

				private string status;

				private long? cateId;

				private string tags;

				private string modificationTime;

				private string regionId;

				private string cateName;

				private string description;

				private string appId;

				private string uRL;

				private string title;

				private string ext;

				private string imageId;

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
			}

			public class SearchMedia_AttachedMedia
			{

				private string creationTime;

				private string status;

				private string storageLocation;

				private string icon;

				private string tags;

				private string modificationTime;

				private string mediaId;

				private string businessType;

				private string regionId;

				private string description;

				private string appId;

				private string uRL;

				private string title;

				private string ext;

				private string onlineStatus;

				private List<SearchMedia_Category> categories;

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

			public class SearchMedia_AiData
			{

				private List<SearchMedia_AiLabelInfoItem> aiLabelInfo;

				private List<SearchMedia_OcrInfoItem> ocrInfo;

				public List<SearchMedia_AiLabelInfoItem> AiLabelInfo
				{
					get
					{
						return aiLabelInfo;
					}
					set	
					{
						aiLabelInfo = value;
					}
				}

				public List<SearchMedia_OcrInfoItem> OcrInfo
				{
					get
					{
						return ocrInfo;
					}
					set	
					{
						ocrInfo = value;
					}
				}

				public class SearchMedia_AiLabelInfoItem
				{

					private string category;

					private string labelName;

					private string labelId;

					private List<SearchMedia_OccurrencesItem> occurrences;

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

					public string LabelName
					{
						get
						{
							return labelName;
						}
						set	
						{
							labelName = value;
						}
					}

					public string LabelId
					{
						get
						{
							return labelId;
						}
						set	
						{
							labelId = value;
						}
					}

					public List<SearchMedia_OccurrencesItem> Occurrences
					{
						get
						{
							return occurrences;
						}
						set	
						{
							occurrences = value;
						}
					}

					public class SearchMedia_OccurrencesItem
					{

						private double? score;

						private double? from;

						private double? to;

						public double? Score
						{
							get
							{
								return score;
							}
							set	
							{
								score = value;
							}
						}

						public double? From
						{
							get
							{
								return from;
							}
							set	
							{
								from = value;
							}
						}

						public double? To
						{
							get
							{
								return to;
							}
							set	
							{
								to = value;
							}
						}
					}
				}

				public class SearchMedia_OcrInfoItem
				{

					private double? from;

					private double? to;

					private string content;

					public double? From
					{
						get
						{
							return from;
						}
						set	
						{
							from = value;
						}
					}

					public double? To
					{
						get
						{
							return to;
						}
						set	
						{
							to = value;
						}
					}

					public string Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}
			}

			public class SearchMedia_AiRoughData
			{

				private string saveType;

				private string status;

				private string aiJobId;

				private string aiCategory;

				public string SaveType
				{
					get
					{
						return saveType;
					}
					set	
					{
						saveType = value;
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

				public string AiJobId
				{
					get
					{
						return aiJobId;
					}
					set	
					{
						aiJobId = value;
					}
				}

				public string AiCategory
				{
					get
					{
						return aiCategory;
					}
					set	
					{
						aiCategory = value;
					}
				}
			}
		}
	}
}
