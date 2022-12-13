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

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
	public class ListWorkspacesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private ListWorkspaces_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public ListWorkspaces_Data Data
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

		public class ListWorkspaces_Data
		{

			private long? currentPage;

			private long? pageSize;

			private long? totalPage;

			private long? totalCount;

			private List<ListWorkspaces_Element> elements;

			[JsonProperty(PropertyName = "CurrentPage")]
			public long? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
			public long? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			[JsonProperty(PropertyName = "TotalPage")]
			public long? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			[JsonProperty(PropertyName = "TotalCount")]
			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			[JsonProperty(PropertyName = "Elements")]
			public List<ListWorkspaces_Element> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class ListWorkspaces_Element
			{

				private long? id;

				private long? gmtCreate;

				private string name;

				private string description;

				private string type;

				[JsonProperty(PropertyName = "Id")]
				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				[JsonProperty(PropertyName = "GmtCreate")]
				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "Description")]
				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
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
			}
		}
	}
}
