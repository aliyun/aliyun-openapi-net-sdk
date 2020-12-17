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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ValidateRoleSetResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<ValidateRoleSet_SentenceResult> data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<ValidateRoleSet_SentenceResult> Data
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

		public class ValidateRoleSet_SentenceResult
		{

			private long? beginTime;

			private int? channelId;

			private long? endTime;

			private string text;

			private int? emotionValue;

			private int? silenceDuration;

			private int? speechRate;

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

			public int? EmotionValue
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

			public int? SilenceDuration
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
		}
	}
}
