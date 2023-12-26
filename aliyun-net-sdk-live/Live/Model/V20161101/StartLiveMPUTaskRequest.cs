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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class StartLiveMPUTaskRequest : RpcAcsRequest<StartLiveMPUTaskResponse>
    {
        public StartLiveMPUTaskRequest()
            : base("live", "2016-11-01", "StartLiveMPUTask", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private SingleSubParams singleSubParams_;

		private SeiParams seiParams_;

		private TranscodeParams transcodeParams_;

		private string appId;

		private string region;

		private string mixMode;

		private string channelId;

		private string taskId;

		private string streamURL;

		[JsonProperty(PropertyName = "SingleSubParams")]
		public SingleSubParams SingleSubParams_
		{
			get
			{
				return singleSubParams_;
			}

			set
			{
				singleSubParams_ = value;
				DictionaryUtil.Add(QueryParameters, "SingleSubParams", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "SeiParams")]
		public SeiParams SeiParams_
		{
			get
			{
				return seiParams_;
			}

			set
			{
				seiParams_ = value;
				DictionaryUtil.Add(QueryParameters, "SeiParams", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "TranscodeParams")]
		public TranscodeParams TranscodeParams_
		{
			get
			{
				return transcodeParams_;
			}

			set
			{
				transcodeParams_ = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeParams", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		[JsonProperty(PropertyName = "MixMode")]
		public string MixMode
		{
			get
			{
				return mixMode;
			}
			set	
			{
				mixMode = value;
				DictionaryUtil.Add(QueryParameters, "MixMode", value);
			}
		}

		[JsonProperty(PropertyName = "ChannelId")]
		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		[JsonProperty(PropertyName = "StreamURL")]
		public string StreamURL
		{
			get
			{
				return streamURL;
			}
			set	
			{
				streamURL = value;
				DictionaryUtil.Add(QueryParameters, "StreamURL", value);
			}
		}

		public class SingleSubParams
		{

			private string streamType;

			private string sourceType;

			private string userId;

			[JsonProperty(PropertyName = "StreamType")]
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

			[JsonProperty(PropertyName = "SourceType")]
			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			[JsonProperty(PropertyName = "UserId")]
			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}
		}

		public class SeiParams
		{

			private LayoutVolume layoutVolume_;

			private PassThrough passThrough_;

			[JsonProperty(PropertyName = "LayoutVolume")]
			public LayoutVolume LayoutVolume_
			{
				get
				{
					return layoutVolume_;
				}
				set	
				{
					layoutVolume_ = value;
				}
			}

			[JsonProperty(PropertyName = "PassThrough")]
			public PassThrough PassThrough_
			{
				get
				{
					return passThrough_;
				}
				set	
				{
					passThrough_ = value;
				}
			}

			public class LayoutVolume
			{

				private string followIdr;

				private string payloadType;

				private string interval;

				[JsonProperty(PropertyName = "FollowIdr")]
				public string FollowIdr
				{
					get
					{
						return followIdr;
					}
					set	
					{
						followIdr = value;
					}
				}

				[JsonProperty(PropertyName = "PayloadType")]
				public string PayloadType
				{
					get
					{
						return payloadType;
					}
					set	
					{
						payloadType = value;
					}
				}

				[JsonProperty(PropertyName = "Interval")]
				public string Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
					}
				}
			}

			public class PassThrough
			{

				private string followIdr;

				private string payloadType;

				private string payloadContent;

				private string interval;

				[JsonProperty(PropertyName = "FollowIdr")]
				public string FollowIdr
				{
					get
					{
						return followIdr;
					}
					set	
					{
						followIdr = value;
					}
				}

				[JsonProperty(PropertyName = "PayloadType")]
				public string PayloadType
				{
					get
					{
						return payloadType;
					}
					set	
					{
						payloadType = value;
					}
				}

				[JsonProperty(PropertyName = "PayloadContent")]
				public string PayloadContent
				{
					get
					{
						return payloadContent;
					}
					set	
					{
						payloadContent = value;
					}
				}

				[JsonProperty(PropertyName = "Interval")]
				public string Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
					}
				}
			}
		}

		public class TranscodeParams
		{

			private Layout layout_;

			private Background background_;

			private List<UserInfosItem> userInfos = new List<UserInfosItem>(){ };

			private EncodeParams encodeParams_;

			[JsonProperty(PropertyName = "Layout")]
			public Layout Layout_
			{
				get
				{
					return layout_;
				}
				set	
				{
					layout_ = value;
				}
			}

			[JsonProperty(PropertyName = "Background")]
			public Background Background_
			{
				get
				{
					return background_;
				}
				set	
				{
					background_ = value;
				}
			}

			[JsonProperty(PropertyName = "UserInfos")]
			public List<UserInfosItem> UserInfos
			{
				get
				{
					return userInfos;
				}
				set	
				{
					userInfos = value;
				}
			}

			[JsonProperty(PropertyName = "EncodeParams")]
			public EncodeParams EncodeParams_
			{
				get
				{
					return encodeParams_;
				}
				set	
				{
					encodeParams_ = value;
				}
			}

			public class Layout
			{

				private List<UserPanesItem> userPanes = new List<UserPanesItem>(){ };

				private string layoutMode;

				private MaxVideoUser maxVideoUser_;

				[JsonProperty(PropertyName = "UserPanes")]
				public List<UserPanesItem> UserPanes
				{
					get
					{
						return userPanes;
					}
					set	
					{
						userPanes = value;
					}
				}

				[JsonProperty(PropertyName = "LayoutMode")]
				public string LayoutMode
				{
					get
					{
						return layoutMode;
					}
					set	
					{
						layoutMode = value;
					}
				}

				[JsonProperty(PropertyName = "MaxVideoUser")]
				public MaxVideoUser MaxVideoUser_
				{
					get
					{
						return maxVideoUser_;
					}
					set	
					{
						maxVideoUser_ = value;
					}
				}

				public class UserPanesItem
				{

					private string backgroundImageUrl;

					private string zOrder;

					private string x;

					private string width;

					private string y;

					private UserInfo userInfo_;

					private string renderMode;

					private string height;

					[JsonProperty(PropertyName = "BackgroundImageUrl")]
					public string BackgroundImageUrl
					{
						get
						{
							return backgroundImageUrl;
						}
						set	
						{
							backgroundImageUrl = value;
						}
					}

					[JsonProperty(PropertyName = "ZOrder")]
					public string ZOrder
					{
						get
						{
							return zOrder;
						}
						set	
						{
							zOrder = value;
						}
					}

					[JsonProperty(PropertyName = "X")]
					public string X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					[JsonProperty(PropertyName = "Width")]
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

					[JsonProperty(PropertyName = "Y")]
					public string Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}

					[JsonProperty(PropertyName = "UserInfo")]
					public UserInfo UserInfo_
					{
						get
						{
							return userInfo_;
						}
						set	
						{
							userInfo_ = value;
						}
					}

					[JsonProperty(PropertyName = "RenderMode")]
					public string RenderMode
					{
						get
						{
							return renderMode;
						}
						set	
						{
							renderMode = value;
						}
					}

					[JsonProperty(PropertyName = "Height")]
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

					public class UserInfo
					{

						private string sourceType;

						private string userId;

						[JsonProperty(PropertyName = "SourceType")]
						public string SourceType
						{
							get
							{
								return sourceType;
							}
							set	
							{
								sourceType = value;
							}
						}

						[JsonProperty(PropertyName = "UserId")]
						public string UserId
						{
							get
							{
								return userId;
							}
							set	
							{
								userId = value;
							}
						}
					}
				}

				public class MaxVideoUser
				{

					private string streamType;

					private string sourceType;

					private string userId;

					[JsonProperty(PropertyName = "StreamType")]
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

					[JsonProperty(PropertyName = "SourceType")]
					public string SourceType
					{
						get
						{
							return sourceType;
						}
						set	
						{
							sourceType = value;
						}
					}

					[JsonProperty(PropertyName = "UserId")]
					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}
				}
			}

			public class Background
			{

				private string uRL;

				private string renderMode;

				[JsonProperty(PropertyName = "URL")]
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

				[JsonProperty(PropertyName = "RenderMode")]
				public string RenderMode
				{
					get
					{
						return renderMode;
					}
					set	
					{
						renderMode = value;
					}
				}
			}

			public class UserInfosItem
			{

				private string streamType;

				private string sourceType;

				private string userId;

				[JsonProperty(PropertyName = "StreamType")]
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

				[JsonProperty(PropertyName = "SourceType")]
				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

				[JsonProperty(PropertyName = "UserId")]
				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}
			}

			public class EncodeParams
			{

				private string audioOnly;

				private string videoWidth;

				private string audioBitrate;

				private string videoFramerate;

				private string vIdeoHeight;

				private string videoBitrate;

				private string audioSampleRate;

				private string videoGop;

				private string audioChannels;

				[JsonProperty(PropertyName = "AudioOnly")]
				public string AudioOnly
				{
					get
					{
						return audioOnly;
					}
					set	
					{
						audioOnly = value;
					}
				}

				[JsonProperty(PropertyName = "VideoWidth")]
				public string VideoWidth
				{
					get
					{
						return videoWidth;
					}
					set	
					{
						videoWidth = value;
					}
				}

				[JsonProperty(PropertyName = "AudioBitrate")]
				public string AudioBitrate
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

				[JsonProperty(PropertyName = "VideoFramerate")]
				public string VideoFramerate
				{
					get
					{
						return videoFramerate;
					}
					set	
					{
						videoFramerate = value;
					}
				}

				[JsonProperty(PropertyName = "VIdeoHeight")]
				public string VIdeoHeight
				{
					get
					{
						return vIdeoHeight;
					}
					set	
					{
						vIdeoHeight = value;
					}
				}

				[JsonProperty(PropertyName = "VideoBitrate")]
				public string VideoBitrate
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

				[JsonProperty(PropertyName = "AudioSampleRate")]
				public string AudioSampleRate
				{
					get
					{
						return audioSampleRate;
					}
					set	
					{
						audioSampleRate = value;
					}
				}

				[JsonProperty(PropertyName = "VideoGop")]
				public string VideoGop
				{
					get
					{
						return videoGop;
					}
					set	
					{
						videoGop = value;
					}
				}

				[JsonProperty(PropertyName = "AudioChannels")]
				public string AudioChannels
				{
					get
					{
						return audioChannels;
					}
					set	
					{
						audioChannels = value;
					}
				}
			}
		}

        public override StartLiveMPUTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartLiveMPUTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
