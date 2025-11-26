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
	public class TermQueryResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private string httpStatusCode;

		private TermQuery_Data data;

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
		public TermQuery_Data Data
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

		public class TermQuery_Data
		{

			private long? failCount;

			private List<TermQuery_TermsItem> terms;

			[JsonProperty(PropertyName = "FailCount")]
			public long? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}

			[JsonProperty(PropertyName = "Terms")]
			public List<TermQuery_TermsItem> Terms
			{
				get
				{
					return terms;
				}
				set	
				{
					terms = value;
				}
			}

			public class TermQuery_TermsItem
			{

				private string termId;

				private string src;

				private string tgt;

				[JsonProperty(PropertyName = "TermId")]
				public string TermId
				{
					get
					{
						return termId;
					}
					set	
					{
						termId = value;
					}
				}

				[JsonProperty(PropertyName = "Src")]
				public string Src
				{
					get
					{
						return src;
					}
					set	
					{
						src = value;
					}
				}

				[JsonProperty(PropertyName = "Tgt")]
				public string Tgt
				{
					get
					{
						return tgt;
					}
					set	
					{
						tgt = value;
					}
				}
			}
		}
	}
}
