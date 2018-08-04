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
using Aliyun.Acs.Core;
using System.Collections.Generic;

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

				private List<string> snapshots2;

				private List<string> spriteSnapshots3;

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

				public List<string> SpriteSnapshots3
				{
					get
					{
						return spriteSnapshots3;
					}
					set	
					{
						spriteSnapshots3 = value;
					}
				}
			}
		}
	}
}