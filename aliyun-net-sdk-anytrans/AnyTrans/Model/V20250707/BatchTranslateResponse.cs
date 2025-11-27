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

namespace Aliyun.Acs.AnyTrans.Model.V20250707
{
	public class BatchTranslateResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private string httpStatusCode;

		private BatchTranslate_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "HttpStatusCode")]
		public string HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public BatchTranslate_Data Data
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

		public class BatchTranslate_Data
		{

			private List<BatchTranslate_TranslationListItem> translationList;

			[JsonProperty(PropertyName = "TranslationList")]
			public List<BatchTranslate_TranslationListItem> TranslationList
			{
				get
				{
					return translationList;
				}
				set	
				{
					translationList = value;
				}
			}

			public class BatchTranslate_TranslationListItem
			{

				private long? code;

				private string message;

				private string index;

				private string translation;

				private BatchTranslate_Usage usage;

				[JsonProperty(PropertyName = "Code")]
				public long? Code
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

				[JsonProperty(PropertyName = "Message")]
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

				[JsonProperty(PropertyName = "Index")]
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

				[JsonProperty(PropertyName = "Translation")]
				public string Translation
				{
					get
					{
						return translation;
					}
					set	
					{
						translation = value;
					}
				}

				[JsonProperty(PropertyName = "Usage")]
				public BatchTranslate_Usage Usage
				{
					get
					{
						return usage;
					}
					set	
					{
						usage = value;
					}
				}

				public class BatchTranslate_Usage
				{

					private long? inputTokens;

					private long? outputTokens;

					private long? totalTokens;

					[JsonProperty(PropertyName = "InputTokens")]
					public long? InputTokens
					{
						get
						{
							return inputTokens;
						}
						set	
						{
							inputTokens = value;
						}
					}

					[JsonProperty(PropertyName = "OutputTokens")]
					public long? OutputTokens
					{
						get
						{
							return outputTokens;
						}
						set	
						{
							outputTokens = value;
						}
					}

					[JsonProperty(PropertyName = "TotalTokens")]
					public long? TotalTokens
					{
						get
						{
							return totalTokens;
						}
						set	
						{
							totalTokens = value;
						}
					}
				}
			}
		}
	}
}
