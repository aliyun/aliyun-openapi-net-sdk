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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListTagsResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private List<ListTags_TagGroup> tagGroups;

		private List<ListTags_Tag> tags;

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

		public int? HttpStatusCode
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

		public List<ListTags_TagGroup> TagGroups
		{
			get
			{
				return tagGroups;
			}
			set	
			{
				tagGroups = value;
			}
		}

		public List<ListTags_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public class ListTags_TagGroup
		{

			private string scriptId;

			private string tagGroup;

			private string tagGroupId;

			private int? tagGroupIndex;

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string TagGroup
			{
				get
				{
					return tagGroup;
				}
				set	
				{
					tagGroup = value;
				}
			}

			public string TagGroupId
			{
				get
				{
					return tagGroupId;
				}
				set	
				{
					tagGroupId = value;
				}
			}

			public int? TagGroupIndex
			{
				get
				{
					return tagGroupIndex;
				}
				set	
				{
					tagGroupIndex = value;
				}
			}
		}

		public class ListTags_Tag
		{

			private string scriptId;

			private string tagGroup;

			private string tagId;

			private int? tagIndex;

			private string tagName;

			public string ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string TagGroup
			{
				get
				{
					return tagGroup;
				}
				set	
				{
					tagGroup = value;
				}
			}

			public string TagId
			{
				get
				{
					return tagId;
				}
				set	
				{
					tagId = value;
				}
			}

			public int? TagIndex
			{
				get
				{
					return tagIndex;
				}
				set	
				{
					tagIndex = value;
				}
			}

			public string TagName
			{
				get
				{
					return tagName;
				}
				set	
				{
					tagName = value;
				}
			}
		}
	}
}
