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
	public class ListLiveRecordVideoResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<ListLiveRecordVideo_LiveRecordVideo> liveRecordVideoList;

		public int? Total
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

		public List<ListLiveRecordVideo_LiveRecordVideo> LiveRecordVideoList
		{
			get
			{
				return liveRecordVideoList;
			}
			set	
			{
				liveRecordVideoList = value;
			}
		}

		public class ListLiveRecordVideo_LiveRecordVideo
		{

			private string appName;

			private string playlistId;

			private string streamName;

			private string recordEndTime;

			private string recordStartTime;

			private string domainName;

			private List<ListLiveRecordVideo_PlayInfo> playInfoList;

			private ListLiveRecordVideo_Video video;

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string PlaylistId
			{
				get
				{
					return playlistId;
				}
				set	
				{
					playlistId = value;
				}
			}

			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			public string RecordEndTime
			{
				get
				{
					return recordEndTime;
				}
				set	
				{
					recordEndTime = value;
				}
			}

			public string RecordStartTime
			{
				get
				{
					return recordStartTime;
				}
				set	
				{
					recordStartTime = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public List<ListLiveRecordVideo_PlayInfo> PlayInfoList
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

			public ListLiveRecordVideo_Video Video
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

			public class ListLiveRecordVideo_PlayInfo
			{

				private string complexity;

				private long? height;

				private string bitrate;

				private long? encrypt;

				private string definition;

				private string rand;

				private string streamType;

				private string jobId;

				private long? width;

				private long? size;

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

				public long? Height
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

				public long? Width
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

			public class ListLiveRecordVideo_Video
			{

				private string creationTime;

				private string status;

				private int? cateId;

				private int? privilege;

				private string videoId;

				private string createTime;

				private string downloadSwitch;

				private string tags;

				private string cateName;

				private string description;

				private long? size;

				private string coverURL;

				private string templateGroupId;

				private long? customerId;

				private float? duration;

				private string title;

				private string modifyTime;

				private List<string> snapshots;

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

				public int? CateId
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

				public int? Privilege
				{
					get
					{
						return privilege;
					}
					set	
					{
						privilege = value;
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

				public long? CustomerId
				{
					get
					{
						return customerId;
					}
					set	
					{
						customerId = value;
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
			}
		}
	}
}
