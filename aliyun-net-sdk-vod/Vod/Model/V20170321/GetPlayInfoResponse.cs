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

			private string creationTime;

			private string status;

			private string specification;

			private string complexity;

			private string narrowBandType;

			private long? height;

			private string bitrate;

			private string modificationTime;

			private string watermarkId;

			private long? encrypt;

			private string definition;

			private string rand;

			private string encryptType;

			private string encryptMode;

			private string preprocessStatus;

			private string streamType;

			private string jobId;

			private string plaintext;

			private long? size;

			private long? width;

			private string fps;

			private string duration;

			private string playURL;

			private string format;

			private string hDRType;

			private int? bitDepth;

			private int? jobType;

			private string jobExt;

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

			public string EncryptMode
			{
				get
				{
					return encryptMode;
				}
				set	
				{
					encryptMode = value;
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

			public string HDRType
			{
				get
				{
					return hDRType;
				}
				set	
				{
					hDRType = value;
				}
			}

			public int? BitDepth
			{
				get
				{
					return bitDepth;
				}
				set	
				{
					bitDepth = value;
				}
			}

			public int? JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string JobExt
			{
				get
				{
					return jobExt;
				}
				set	
				{
					jobExt = value;
				}
			}
		}

		public class GetPlayInfo_VideoBase
		{

			private string creationTime;

			private string status;

			private string transcodeMode;

			private string outputType;

			private string videoId;

			private string coverURL;

			private string duration;

			private string title;

			private string mediaType;

			private string danMuURL;

			private string storageClass;

			private List<GetPlayInfo_Thumbnail> thumbnailList;

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

			public string DanMuURL
			{
				get
				{
					return danMuURL;
				}
				set	
				{
					danMuURL = value;
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
