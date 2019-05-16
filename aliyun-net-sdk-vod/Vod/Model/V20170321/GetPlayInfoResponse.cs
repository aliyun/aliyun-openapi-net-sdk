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
	public class GetPlayInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetPlayInfo_PlayInfo> playInfoList;

		private GetPlayInfo_VideoBase videoBase;

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

		public List<GetPlayInfo_PlayInfo> PlayInfoList
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

		public GetPlayInfo_VideoBase VideoBase
		{
			get
			{
				return videoBase;
			}
			set	
			{
				videoBase = value;
			}
		}

		public class GetPlayInfo_PlayInfo
		{

			private long? width;

			private long? height;

			private long? size;

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

			private string preprocessStatus;

			private string watermarkId;

			private string status;

			private string creationTime;

			private string modificationTime;

			private string encryptType;

			private string narrowBandType;

			private string specification;

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

			public string WatermarkId
			{
				get
				{
					return watermarkId;
				}
				set	
				{
					watermarkId = value;
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

			public string EncryptType
			{
				get
				{
					return encryptType;
				}
				set	
				{
					encryptType = value;
				}
			}

			public string NarrowBandType
			{
				get
				{
					return narrowBandType;
				}
				set	
				{
					narrowBandType = value;
				}
			}

			public string Specification
			{
				get
				{
					return specification;
				}
				set	
				{
					specification = value;
				}
			}
		}

		public class GetPlayInfo_VideoBase
		{

			private string outputType;

			private string coverURL;

			private string duration;

			private string status;

			private string title;

			private string videoId;

			private string mediaType;

			private string creationTime;

			private string transcodeMode;

			private List<GetPlayInfo_Thumbnail> thumbnailList;

			public string OutputType
			{
				get
				{
					return outputType;
				}
				set	
				{
					outputType = value;
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

			public List<GetPlayInfo_Thumbnail> ThumbnailList
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

			public class GetPlayInfo_Thumbnail
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
