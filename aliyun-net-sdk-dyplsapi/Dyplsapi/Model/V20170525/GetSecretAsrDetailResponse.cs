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

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
	public class GetSecretAsrDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetSecretAsrDetail_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public GetSecretAsrDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetSecretAsrDetail_Data
		{

			private string requestId;

			private string businessId;

			private string businessKey;

			private string code;

			private string msg;

			private long? bizDuration;

			private string type;

			private List<GetSecretAsrDetail_SecretAsrSentenceDTO> sentences;

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

			public string BusinessId
			{
				get
				{
					return businessId;
				}
				set	
				{
					businessId = value;
				}
			}

			public string BusinessKey
			{
				get
				{
					return businessKey;
				}
				set	
				{
					businessKey = value;
				}
			}

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Msg
			{
				get
				{
					return msg;
				}
				set	
				{
					msg = value;
				}
			}

			public long? BizDuration
			{
				get
				{
					return bizDuration;
				}
				set	
				{
					bizDuration = value;
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

			public List<GetSecretAsrDetail_SecretAsrSentenceDTO> Sentences
			{
				get
				{
					return sentences;
				}
				set	
				{
					sentences = value;
				}
			}

			public class GetSecretAsrDetail_SecretAsrSentenceDTO
			{

				private long? endTime;

				private long? silenceDuration;

				private long? beginTime;

				private string text;

				private int? channelId;

				private int? speechRate;

				private string emotionValue;

				public long? EndTime
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

				public long? SilenceDuration
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

				public long? BeginTime
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

				public string EmotionValue
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
			}
		}
	}
}
