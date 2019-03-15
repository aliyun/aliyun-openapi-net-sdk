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

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
	public class ListRegisteredTagsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string action;

		private List<ListRegisteredTags_RegisteredTag> registeredTags;

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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
			}
		}

		public List<ListRegisteredTags_RegisteredTag> RegisteredTags
		{
			get
			{
				return registeredTags;
			}
			set	
			{
				registeredTags = value;
			}
		}

		public class ListRegisteredTags_RegisteredTag
		{

			private string tagKey;

			private List<ListRegisteredTags_TagValue> tagValues;

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}

			public List<ListRegisteredTags_TagValue> TagValues
			{
				get
				{
					return tagValues;
				}
				set	
				{
					tagValues = value;
				}
			}

			public class ListRegisteredTags_TagValue
			{

				private string lang;

				private string text;

				public string Lang
				{
					get
					{
						return lang;
					}
					set	
					{
						lang = value;
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
			}
		}
	}
}
