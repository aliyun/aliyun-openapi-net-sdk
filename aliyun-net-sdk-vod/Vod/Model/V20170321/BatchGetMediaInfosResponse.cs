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
	public class BatchGetMediaInfosResponse : AcsResponse
	{

		private string requestId;

		private List<BatchGetMediaInfos_MediaBasicInfo> mediaInfos;

		private List<string> nonExistMediaIds;

		private List<string> forbiddenMediaIds;

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

		public List<BatchGetMediaInfos_MediaBasicInfo> MediaInfos
		{
			get
			{
				return mediaInfos;
			}
			set	
			{
				mediaInfos = value;
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

		public List<string> ForbiddenMediaIds
		{
			get
			{
				return forbiddenMediaIds;
			}
			set	
			{
				forbiddenMediaIds = value;
			}
		}

		public class BatchGetMediaInfos_MediaBasicInfo
		{

			private string mediaId;

			private List<BatchGetMediaInfos_PlayInfo> playInfoList;

			private BatchGetMediaInfos_MediaInfo mediaInfo;

			private BatchGetMediaInfos_MezzanineInfo mezzanineInfo;

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

			public List<BatchGetMediaInfos_PlayInfo> PlayInfoList
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

			public BatchGetMediaInfos_MediaInfo MediaInfo
			{
				get
				{
					return mediaInfo;
				}
				set	
				{
					mediaInfo = value;
				}
			}

			public BatchGetMediaInfos_MezzanineInfo MezzanineInfo
			{
				get
				{
					return mezzanineInfo;
				}
				set	
				{
					mezzanineInfo = value;
				}
			}

			public class BatchGetMediaInfos_PlayInfo
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

				private string codecName;

				private string templateId;

				private string templateGroupId;

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

				public string CodecName
				{
					get
					{
						return codecName;
					}
					set	
					{
						codecName = value;
					}
				}

				public string TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
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
			}

			public class BatchGetMediaInfos_MediaInfo
			{

				private string storageLocation;

				private string creationTime;

				private string status;

				private long? cateId;

				private string mediaId;

				private string downloadSwitch;

				private string tags;

				private string modificationTime;

				private string regionId;

				private string cateName;

				private string description;

				private string preprocessStatus;

				private string appId;

				private string coverURL;

				private string templateGroupId;

				private string title;

				private string storageClass;

				private string restoreStatus;

				private string restoreExpiration;

				private string userData;

				private List<string> snapshots;

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

				public string UserData
				{
					get
					{
						return userData;
					}
					set	
					{
						userData = value;
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

			public class BatchGetMediaInfos_MezzanineInfo
			{

				private string creationTime;

				private string status;

				private string fileURL;

				private string mediaId;

				private long? height;

				private string bitrate;

				private string fileName;

				private long? width;

				private long? size;

				private string cRC64;

				private string duration;

				private string fps;

				private List<BatchGetMediaInfos_AudioStream> audioStreamList;

				private List<BatchGetMediaInfos_VideoStream> videoStreamList;

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

				public string FileURL
				{
					get
					{
						return fileURL;
					}
					set	
					{
						fileURL = value;
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

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
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

				public string CRC64
				{
					get
					{
						return cRC64;
					}
					set	
					{
						cRC64 = value;
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

				public List<BatchGetMediaInfos_AudioStream> AudioStreamList
				{
					get
					{
						return audioStreamList;
					}
					set	
					{
						audioStreamList = value;
					}
				}

				public List<BatchGetMediaInfos_VideoStream> VideoStreamList
				{
					get
					{
						return videoStreamList;
					}
					set	
					{
						videoStreamList = value;
					}
				}

				public class BatchGetMediaInfos_AudioStream
				{

					private string index;

					private string timebase;

					private string sampleFmt;

					private string sampleRate;

					private string channelLayout;

					private string lang;

					private string codecLongName;

					private string channels;

					private string numFrames;

					private string bitrate;

					private string codecTagString;

					private string startTime;

					private string codecName;

					private string duration;

					private string codecTag;

					private string codecTimeBase;

					public string Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

					public string Timebase
					{
						get
						{
							return timebase;
						}
						set	
						{
							timebase = value;
						}
					}

					public string SampleFmt
					{
						get
						{
							return sampleFmt;
						}
						set	
						{
							sampleFmt = value;
						}
					}

					public string SampleRate
					{
						get
						{
							return sampleRate;
						}
						set	
						{
							sampleRate = value;
						}
					}

					public string ChannelLayout
					{
						get
						{
							return channelLayout;
						}
						set	
						{
							channelLayout = value;
						}
					}

					public string Lang
					{
						get
						{
							return lang;
						}
						set	
						{
							lang = value;
						}
					}

					public string CodecLongName
					{
						get
						{
							return codecLongName;
						}
						set	
						{
							codecLongName = value;
						}
					}

					public string Channels
					{
						get
						{
							return channels;
						}
						set	
						{
							channels = value;
						}
					}

					public string NumFrames
					{
						get
						{
							return numFrames;
						}
						set	
						{
							numFrames = value;
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

					public string CodecTagString
					{
						get
						{
							return codecTagString;
						}
						set	
						{
							codecTagString = value;
						}
					}

					public string StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public string CodecName
					{
						get
						{
							return codecName;
						}
						set	
						{
							codecName = value;
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

					public string CodecTag
					{
						get
						{
							return codecTag;
						}
						set	
						{
							codecTag = value;
						}
					}

					public string CodecTimeBase
					{
						get
						{
							return codecTimeBase;
						}
						set	
						{
							codecTimeBase = value;
						}
					}
				}

				public class BatchGetMediaInfos_VideoStream
				{

					private string timebase;

					private string index;

					private string avgFPS;

					private string pixFmt;

					private string lang;

					private string sar;

					private string height;

					private string codecLongName;

					private string numFrames;

					private string bitrate;

					private string rotate;

					private string codecTagString;

					private string hasBFrames;

					private string profile;

					private string startTime;

					private string dar;

					private string codecName;

					private string width;

					private string duration;

					private string fps;

					private string codecTag;

					private string codecTimeBase;

					private string level;

					private string hDRType;

					public string Timebase
					{
						get
						{
							return timebase;
						}
						set	
						{
							timebase = value;
						}
					}

					public string Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

					public string AvgFPS
					{
						get
						{
							return avgFPS;
						}
						set	
						{
							avgFPS = value;
						}
					}

					public string PixFmt
					{
						get
						{
							return pixFmt;
						}
						set	
						{
							pixFmt = value;
						}
					}

					public string Lang
					{
						get
						{
							return lang;
						}
						set	
						{
							lang = value;
						}
					}

					public string Sar
					{
						get
						{
							return sar;
						}
						set	
						{
							sar = value;
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

					public string CodecLongName
					{
						get
						{
							return codecLongName;
						}
						set	
						{
							codecLongName = value;
						}
					}

					public string NumFrames
					{
						get
						{
							return numFrames;
						}
						set	
						{
							numFrames = value;
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

					public string Rotate
					{
						get
						{
							return rotate;
						}
						set	
						{
							rotate = value;
						}
					}

					public string CodecTagString
					{
						get
						{
							return codecTagString;
						}
						set	
						{
							codecTagString = value;
						}
					}

					public string HasBFrames
					{
						get
						{
							return hasBFrames;
						}
						set	
						{
							hasBFrames = value;
						}
					}

					public string Profile
					{
						get
						{
							return profile;
						}
						set	
						{
							profile = value;
						}
					}

					public string StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public string Dar
					{
						get
						{
							return dar;
						}
						set	
						{
							dar = value;
						}
					}

					public string CodecName
					{
						get
						{
							return codecName;
						}
						set	
						{
							codecName = value;
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

					public string CodecTag
					{
						get
						{
							return codecTag;
						}
						set	
						{
							codecTag = value;
						}
					}

					public string CodecTimeBase
					{
						get
						{
							return codecTimeBase;
						}
						set	
						{
							codecTimeBase = value;
						}
					}

					public string Level
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
				}
			}
		}
	}
}
