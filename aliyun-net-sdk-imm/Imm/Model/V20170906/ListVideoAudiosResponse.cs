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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class ListVideoAudiosResponse : AcsResponse
	{

		private string setId;

		private string videoUri;

		private string nextMarker;

		private string requestId;

		private List<ListVideoAudios_AudiosItem> audios;

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
			}
		}

		public string VideoUri
		{
			get
			{
				return videoUri;
			}
			set	
			{
				videoUri = value;
			}
		}

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
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

		public List<ListVideoAudios_AudiosItem> Audios
		{
			get
			{
				return audios;
			}
			set	
			{
				audios = value;
			}
		}

		public class ListVideoAudios_AudiosItem
		{

			private float? audioDuration;

			private string audioUri;

			private int? audioRate;

			private string sourceType;

			private string modifyTime;

			private int? fileSize;

			private string sourceUri;

			private string createTime;

			private string remarksA;

			private string remarksB;

			private string audioTextsStatus;

			private string audioTextsModifyTime;

			private string processModifyTime;

			private string processStatus;

			private string sourcePosition;

			private string audioFormat;

			private string audioTextsFailReason;

			private string processFailReason;

			private string remarksC;

			private string remarksD;

			private string externalId;

			private List<ListVideoAudios_AudioTextsItem> audioTexts;

			public float? AudioDuration
			{
				get
				{
					return audioDuration;
				}
				set	
				{
					audioDuration = value;
				}
			}

			public string AudioUri
			{
				get
				{
					return audioUri;
				}
				set	
				{
					audioUri = value;
				}
			}

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

			public int? FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public string SourceUri
			{
				get
				{
					return sourceUri;
				}
				set	
				{
					sourceUri = value;
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

			public string RemarksA
			{
				get
				{
					return remarksA;
				}
				set	
				{
					remarksA = value;
				}
			}

			public string RemarksB
			{
				get
				{
					return remarksB;
				}
				set	
				{
					remarksB = value;
				}
			}

			public string AudioTextsStatus
			{
				get
				{
					return audioTextsStatus;
				}
				set	
				{
					audioTextsStatus = value;
				}
			}

			public string AudioTextsModifyTime
			{
				get
				{
					return audioTextsModifyTime;
				}
				set	
				{
					audioTextsModifyTime = value;
				}
			}

			public string ProcessModifyTime
			{
				get
				{
					return processModifyTime;
				}
				set	
				{
					processModifyTime = value;
				}
			}

			public string ProcessStatus
			{
				get
				{
					return processStatus;
				}
				set	
				{
					processStatus = value;
				}
			}

			public string SourcePosition
			{
				get
				{
					return sourcePosition;
				}
				set	
				{
					sourcePosition = value;
				}
			}

			public string AudioFormat
			{
				get
				{
					return audioFormat;
				}
				set	
				{
					audioFormat = value;
				}
			}

			public string AudioTextsFailReason
			{
				get
				{
					return audioTextsFailReason;
				}
				set	
				{
					audioTextsFailReason = value;
				}
			}

			public string ProcessFailReason
			{
				get
				{
					return processFailReason;
				}
				set	
				{
					processFailReason = value;
				}
			}

			public string RemarksC
			{
				get
				{
					return remarksC;
				}
				set	
				{
					remarksC = value;
				}
			}

			public string RemarksD
			{
				get
				{
					return remarksD;
				}
				set	
				{
					remarksD = value;
				}
			}

			public string ExternalId
			{
				get
				{
					return externalId;
				}
				set	
				{
					externalId = value;
				}
			}

			public List<ListVideoAudios_AudioTextsItem> AudioTexts
			{
				get
				{
					return audioTexts;
				}
				set	
				{
					audioTexts = value;
				}
			}

			public class ListVideoAudios_AudioTextsItem
			{

				private string text;

				private float? beginTime;

				private float? endTime;

				private float? silenceDuration;

				private float? emotionValue;

				private int? channelId;

				private int? speechRate;

				private float? confidence;

				private string person;

				private string library;

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public float? BeginTime
				{
					get
					{
						return beginTime;
					}
					set	
					{
						beginTime = value;
					}
				}

				public float? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public float? SilenceDuration
				{
					get
					{
						return silenceDuration;
					}
					set	
					{
						silenceDuration = value;
					}
				}

				public float? EmotionValue
				{
					get
					{
						return emotionValue;
					}
					set	
					{
						emotionValue = value;
					}
				}

				public int? ChannelId
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

				public int? SpeechRate
				{
					get
					{
						return speechRate;
					}
					set	
					{
						speechRate = value;
					}
				}

				public float? Confidence
				{
					get
					{
						return confidence;
					}
					set	
					{
						confidence = value;
					}
				}

				public string Person
				{
					get
					{
						return person;
					}
					set	
					{
						person = value;
					}
				}

				public string Library
				{
					get
					{
						return library;
					}
					set	
					{
						library = value;
					}
				}
			}
		}
	}
}
