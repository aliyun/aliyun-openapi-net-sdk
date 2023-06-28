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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryInstanceByTagResponse : AcsResponse
	{

		private string code;

		private string message;

		private string nextToken;

		private string requestId;

		private bool? success;

		private List<QueryInstanceByTag_TagResourceItem> tagResource;

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

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		[JsonProperty(PropertyName = "TagResource")]
		public List<QueryInstanceByTag_TagResourceItem> TagResource
		{
			get
			{
				return tagResource;
			}
			set	
			{
				tagResource = value;
			}
		}

		public class QueryInstanceByTag_TagResourceItem
		{

			private string resourceId;

			private string resourceType;

			private List<QueryInstanceByTag_TagKeyValue> tag;

			[JsonProperty(PropertyName = "ResourceId")]
			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceType")]
			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			[JsonProperty(PropertyName = "Tag")]
			public List<QueryInstanceByTag_TagKeyValue> Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public class QueryInstanceByTag_TagKeyValue
			{

				private string key;

				private string _value;

				[JsonProperty(PropertyName = "Key")]
				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				[JsonProperty(PropertyName = "_Value")]
				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
