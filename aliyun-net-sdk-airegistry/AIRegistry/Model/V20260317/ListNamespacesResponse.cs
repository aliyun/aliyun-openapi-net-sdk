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

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
	public class ListNamespacesResponse : AcsResponse
	{

		private string requestId;

		private ListNamespaces_Data data;

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

		public ListNamespaces_Data Data
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

		public class ListNamespaces_Data
		{

			private int? totalCount;

			private int? pageSize;

			private int? pageNumber;

			private List<ListNamespaces_Item> items;

			public int? TotalCount
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

			public int? PageSize
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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public List<ListNamespaces_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class ListNamespaces_Item
			{

				private int? sourceIndex;

				private string description;

				private int? promptCount;

				private string createdTime;

				private string ipWhitelist;

				private int? skillCount;

				private bool? publicAccessEnabled;

				private string namespaceId;

				private string tags;

				private string source;

				private string name;

				private string publicDomain;

				public int? SourceIndex
				{
					get
					{
						return sourceIndex;
					}
					set	
					{
						sourceIndex = value;
					}
				}

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

				public int? PromptCount
				{
					get
					{
						return promptCount;
					}
					set	
					{
						promptCount = value;
					}
				}

				public string CreatedTime
				{
					get
					{
						return createdTime;
					}
					set	
					{
						createdTime = value;
					}
				}

				public string IpWhitelist
				{
					get
					{
						return ipWhitelist;
					}
					set	
					{
						ipWhitelist = value;
					}
				}

				public int? SkillCount
				{
					get
					{
						return skillCount;
					}
					set	
					{
						skillCount = value;
					}
				}

				public bool? PublicAccessEnabled
				{
					get
					{
						return publicAccessEnabled;
					}
					set	
					{
						publicAccessEnabled = value;
					}
				}

				public string NamespaceId
				{
					get
					{
						return namespaceId;
					}
					set	
					{
						namespaceId = value;
					}
				}

				public string Tags
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

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

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

				public string PublicDomain
				{
					get
					{
						return publicDomain;
					}
					set	
					{
						publicDomain = value;
					}
				}
			}
		}
	}
}
