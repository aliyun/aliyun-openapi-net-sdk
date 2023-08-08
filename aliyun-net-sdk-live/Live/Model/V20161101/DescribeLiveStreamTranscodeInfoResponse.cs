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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveStreamTranscodeInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> domainTranscodeList;

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

		[JsonProperty(PropertyName = "DomainTranscodeList")]
		public List<DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo> DomainTranscodeList
		{
			get
			{
				return domainTranscodeList;
			}
			set	
			{
				domainTranscodeList = value;
			}
		}

		public class DescribeLiveStreamTranscodeInfo_DomainTranscodeInfo
		{

			private string transcodeApp;

			private string transcodeTemplate;

			private bool? isLazy;

			private string transcodeName;

			private DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters customTranscodeParameters;

			private DescribeLiveStreamTranscodeInfo_EncryptParameters encryptParameters;

			[JsonProperty(PropertyName = "TranscodeApp")]
			public string TranscodeApp
			{
				get
				{
					return transcodeApp;
				}
				set	
				{
					transcodeApp = value;
				}
			}

			[JsonProperty(PropertyName = "TranscodeTemplate")]
			public string TranscodeTemplate
			{
				get
				{
					return transcodeTemplate;
				}
				set	
				{
					transcodeTemplate = value;
				}
			}

			[JsonProperty(PropertyName = "IsLazy")]
			public bool? IsLazy
			{
				get
				{
					return isLazy;
				}
				set	
				{
					isLazy = value;
				}
			}

			[JsonProperty(PropertyName = "TranscodeName")]
			public string TranscodeName
			{
				get
				{
					return transcodeName;
				}
				set	
				{
					transcodeName = value;
				}
			}

			[JsonProperty(PropertyName = "CustomTranscodeParameters")]
			public DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters CustomTranscodeParameters
			{
				get
				{
					return customTranscodeParameters;
				}
				set	
				{
					customTranscodeParameters = value;
				}
			}

			[JsonProperty(PropertyName = "EncryptParameters")]
			public DescribeLiveStreamTranscodeInfo_EncryptParameters EncryptParameters
			{
				get
				{
					return encryptParameters;
				}
				set	
				{
					encryptParameters = value;
				}
			}

			public class DescribeLiveStreamTranscodeInfo_CustomTranscodeParameters
			{

				private string bitrateWithSource;

				private string videoProfile;

				private int? audioBitrate;

				private int? height;

				private string rtsFlag;

				private string templateType;

				private string bframes;

				private string extWithSource;

				private int? audioRate;

				private string fpsWithSource;

				private string audioCodec;

				private int? fPS;

				private string gop;

				private int? width;

				private int? videoBitrate;

				private int? audioChannelNum;

				private string audioProfile;

				private string resWithSource;

				[JsonProperty(PropertyName = "BitrateWithSource")]
				public string BitrateWithSource
				{
					get
					{
						return bitrateWithSource;
					}
					set	
					{
						bitrateWithSource = value;
					}
				}

				[JsonProperty(PropertyName = "VideoProfile")]
				public string VideoProfile
				{
					get
					{
						return videoProfile;
					}
					set	
					{
						videoProfile = value;
					}
				}

				[JsonProperty(PropertyName = "AudioBitrate")]
				public int? AudioBitrate
				{
					get
					{
						return audioBitrate;
					}
					set	
					{
						audioBitrate = value;
					}
				}

				[JsonProperty(PropertyName = "Height")]
				public int? Height
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

				[JsonProperty(PropertyName = "RtsFlag")]
				public string RtsFlag
				{
					get
					{
						return rtsFlag;
					}
					set	
					{
						rtsFlag = value;
					}
				}

				[JsonProperty(PropertyName = "TemplateType")]
				public string TemplateType
				{
					get
					{
						return templateType;
					}
					set	
					{
						templateType = value;
					}
				}

				[JsonProperty(PropertyName = "Bframes")]
				public string Bframes
				{
					get
					{
						return bframes;
					}
					set	
					{
						bframes = value;
					}
				}

				[JsonProperty(PropertyName = "ExtWithSource")]
				public string ExtWithSource
				{
					get
					{
						return extWithSource;
					}
					set	
					{
						extWithSource = value;
					}
				}

				[JsonProperty(PropertyName = "AudioRate")]
				public int? AudioRate
				{
					get
					{
						return audioRate;
					}
					set	
					{
						audioRate = value;
					}
				}

				[JsonProperty(PropertyName = "FpsWithSource")]
				public string FpsWithSource
				{
					get
					{
						return fpsWithSource;
					}
					set	
					{
						fpsWithSource = value;
					}
				}

				[JsonProperty(PropertyName = "AudioCodec")]
				public string AudioCodec
				{
					get
					{
						return audioCodec;
					}
					set	
					{
						audioCodec = value;
					}
				}

				[JsonProperty(PropertyName = "FPS")]
				public int? FPS
				{
					get
					{
						return fPS;
					}
					set	
					{
						fPS = value;
					}
				}

				[JsonProperty(PropertyName = "Gop")]
				public string Gop
				{
					get
					{
						return gop;
					}
					set	
					{
						gop = value;
					}
				}

				[JsonProperty(PropertyName = "Width")]
				public int? Width
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

				[JsonProperty(PropertyName = "VideoBitrate")]
				public int? VideoBitrate
				{
					get
					{
						return videoBitrate;
					}
					set	
					{
						videoBitrate = value;
					}
				}

				[JsonProperty(PropertyName = "AudioChannelNum")]
				public int? AudioChannelNum
				{
					get
					{
						return audioChannelNum;
					}
					set	
					{
						audioChannelNum = value;
					}
				}

				[JsonProperty(PropertyName = "AudioProfile")]
				public string AudioProfile
				{
					get
					{
						return audioProfile;
					}
					set	
					{
						audioProfile = value;
					}
				}

				[JsonProperty(PropertyName = "ResWithSource")]
				public string ResWithSource
				{
					get
					{
						return resWithSource;
					}
					set	
					{
						resWithSource = value;
					}
				}
			}

			public class DescribeLiveStreamTranscodeInfo_EncryptParameters
			{

				private string encryptType;

				private string kmsKeyID;

				private string kmsKeyExpireInterval;

				[JsonProperty(PropertyName = "EncryptType")]
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

				[JsonProperty(PropertyName = "KmsKeyID")]
				public string KmsKeyID
				{
					get
					{
						return kmsKeyID;
					}
					set	
					{
						kmsKeyID = value;
					}
				}

				[JsonProperty(PropertyName = "KmsKeyExpireInterval")]
				public string KmsKeyExpireInterval
				{
					get
					{
						return kmsKeyExpireInterval;
					}
					set	
					{
						kmsKeyExpireInterval = value;
					}
				}
			}
		}
	}
}
