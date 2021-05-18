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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QuerySpeechResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QuerySpeech_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QuerySpeech_Data Data
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

		public class QuerySpeech_Data
		{

			private string speechCode;

			private string bizCode;

			private string voice;

			private int? volume;

			private int? speechRate;

			private string text;

			private string audioFormat;

			private string speechType;

			public string SpeechCode
			{
				get
				{
					return speechCode;
				}
				set	
				{
					speechCode = value;
				}
			}

			public string BizCode
			{
				get
				{
					return bizCode;
				}
				set	
				{
					bizCode = value;
				}
			}

			public string Voice
			{
				get
				{
					return voice;
				}
				set	
				{
					voice = value;
				}
			}

			public int? Volume
			{
				get
				{
					return volume;
				}
				set	
				{
					volume = value;
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

			public string SpeechType
			{
				get
				{
					return speechType;
				}
				set	
				{
					speechType = value;
				}
			}
		}
	}
}
