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
	public class ListRtcMPUTaskDetailResponse : AcsResponse
	{

		private string requestId;

		private List<ListRtcMPUTaskDetail_MpuTask> mPUTasks;

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

		[JsonProperty(PropertyName = "MPUTasks")]
		public List<ListRtcMPUTaskDetail_MpuTask> MPUTasks
		{
			get
			{
				return mPUTasks;
			}
			set	
			{
				mPUTasks = value;
			}
		}

		public class ListRtcMPUTaskDetail_MpuTask
		{

			private string appId;

			private string channelId;

			private string taskId;

			private string mixMode;

			private string streamURL;

			private string region;

			private ListRtcMPUTaskDetail_SingleSubParams singleSubParams;

			private ListRtcMPUTaskDetail_TranscodeParams transcodeParams;

			private ListRtcMPUTaskDetail_SeiParams seiParams;

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
				}
			}

			[JsonProperty(PropertyName = "SingleSubParams")]
			public ListRtcMPUTaskDetail_SingleSubParams SingleSubParams
			{
				get
				{
					return singleSubParams;
				}
				set	
				{
					singleSubParams = value;
				}
			}

			[JsonProperty(PropertyName = "TranscodeParams")]
			public ListRtcMPUTaskDetail_TranscodeParams TranscodeParams
			{
				get
				{
					return transcodeParams;
				}
				set	
				{
					transcodeParams = value;
				}
			}

			[JsonProperty(PropertyName = "SeiParams")]
			public ListRtcMPUTaskDetail_SeiParams SeiParams
			{
				get
				{
					return seiParams;
				}
				set	
				{
					seiParams = value;
				}
			}

			public class ListRtcMPUTaskDetail_SingleSubParams
			{

				private string sourceType;

				private string streamType;

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

			public class ListRtcMPUTaskDetail_TranscodeParams
			{

				private List<ListRtcMPUTaskDetail_UserInfo> userInfos;

				private ListRtcMPUTaskDetail_Background background;

				private ListRtcMPUTaskDetail_EncodeParams encodeParams;

				private ListRtcMPUTaskDetail_Layout layout;

				[JsonProperty(PropertyName = "UserInfos")]
				public List<ListRtcMPUTaskDetail_UserInfo> UserInfos
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

				[JsonProperty(PropertyName = "Background")]
				public ListRtcMPUTaskDetail_Background Background
				{
					get
					{
						return background;
					}
					set	
					{
						background = value;
					}
				}

				[JsonProperty(PropertyName = "EncodeParams")]
				public ListRtcMPUTaskDetail_EncodeParams EncodeParams
				{
					get
					{
						return encodeParams;
					}
					set	
					{
						encodeParams = value;
					}
				}

				[JsonProperty(PropertyName = "Layout")]
				public ListRtcMPUTaskDetail_Layout Layout
				{
					get
					{
						return layout;
					}
					set	
					{
						layout = value;
					}
				}

				public class ListRtcMPUTaskDetail_UserInfo
				{

					private string userId;

					private string sourceType;

					private string streamType;

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
				}

				public class ListRtcMPUTaskDetail_Background
				{

					private string renderMode;

					private string uRL;

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
				}

				public class ListRtcMPUTaskDetail_EncodeParams
				{

					private string audioOnly;

					private string audioBitrate;

					private string audioChannels;

					private string audioSampleRate;

					private string videoCodec;

					private string videoBitrate;

					private string videoFramerate;

					private string videoGop;

					private string videoHeight;

					private string videoWidth;

					private string enhancedParam;

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

					[JsonProperty(PropertyName = "VideoCodec")]
					public string VideoCodec
					{
						get
						{
							return videoCodec;
						}
						set	
						{
							videoCodec = value;
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

					[JsonProperty(PropertyName = "VideoHeight")]
					public string VideoHeight
					{
						get
						{
							return videoHeight;
						}
						set	
						{
							videoHeight = value;
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

					[JsonProperty(PropertyName = "EnhancedParam")]
					public string EnhancedParam
					{
						get
						{
							return enhancedParam;
						}
						set	
						{
							enhancedParam = value;
						}
					}
				}

				public class ListRtcMPUTaskDetail_Layout
				{

					private string layoutMode;

					private List<ListRtcMPUTaskDetail_UserPane> userPanes;

					private ListRtcMPUTaskDetail_MaxVideoUser maxVideoUser;

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

					[JsonProperty(PropertyName = "UserPanes")]
					public List<ListRtcMPUTaskDetail_UserPane> UserPanes
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

					[JsonProperty(PropertyName = "MaxVideoUser")]
					public ListRtcMPUTaskDetail_MaxVideoUser MaxVideoUser
					{
						get
						{
							return maxVideoUser;
						}
						set	
						{
							maxVideoUser = value;
						}
					}

					public class ListRtcMPUTaskDetail_UserPane
					{

						private string height;

						private string width;

						private string x;

						private string y;

						private string zOrder;

						private string backgroundImageUrl;

						private string renderMode;

						private ListRtcMPUTaskDetail_UserInfo1 userInfo1;

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

						[JsonProperty(PropertyName = "UserInfo1")]
						public ListRtcMPUTaskDetail_UserInfo1 UserInfo1
						{
							get
							{
								return userInfo1;
							}
							set	
							{
								userInfo1 = value;
							}
						}

						public class ListRtcMPUTaskDetail_UserInfo1
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

					public class ListRtcMPUTaskDetail_MaxVideoUser
					{

						private string sourceType;

						private string streamType;

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
			}

			public class ListRtcMPUTaskDetail_SeiParams
			{

				private string payloadType;

				private ListRtcMPUTaskDetail_LayoutVolume layoutVolume;

				private ListRtcMPUTaskDetail_PassThrough passThrough;

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

				[JsonProperty(PropertyName = "LayoutVolume")]
				public ListRtcMPUTaskDetail_LayoutVolume LayoutVolume
				{
					get
					{
						return layoutVolume;
					}
					set	
					{
						layoutVolume = value;
					}
				}

				[JsonProperty(PropertyName = "PassThrough")]
				public ListRtcMPUTaskDetail_PassThrough PassThrough
				{
					get
					{
						return passThrough;
					}
					set	
					{
						passThrough = value;
					}
				}

				public class ListRtcMPUTaskDetail_LayoutVolume
				{

					private string followIdr;

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

				public class ListRtcMPUTaskDetail_PassThrough
				{

					private string followIdr;

					private string interval;

					private string payloadContent;

					private string payloadContentKey;

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

					[JsonProperty(PropertyName = "PayloadContentKey")]
					public string PayloadContentKey
					{
						get
						{
							return payloadContentKey;
						}
						set	
						{
							payloadContentKey = value;
						}
					}
				}
			}
		}
	}
}
