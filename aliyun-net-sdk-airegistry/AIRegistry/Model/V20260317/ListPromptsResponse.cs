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
	public class ListPromptsResponse : AcsResponse
	{

		private string requestId;

		private ListPrompts_Data data;

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

		public ListPrompts_Data Data
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

		public class ListPrompts_Data
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pagesAvailable;

			private List<ListPrompts_Item> pageItems;

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

			public int? PagesAvailable
			{
				get
				{
					return pagesAvailable;
				}
				set	
				{
					pagesAvailable = value;
				}
			}

			public List<ListPrompts_Item> PageItems
			{
				get
				{
					return pageItems;
				}
				set	
				{
					pageItems = value;
				}
			}

			public class ListPrompts_Item
			{

				private string editingVersion;

				private string description;

				private int? schemaVersion;

				private string latestVersion;

				private string promptKey;

				private long? gmtModified;

				private string labels;

				private string reviewingVersion;

				private int? onlineCnt;

				private List<string> bizTags;

				public string EditingVersion
				{
					get
					{
						return editingVersion;
					}
					set	
					{
						editingVersion = value;
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

				public int? SchemaVersion
				{
					get
					{
						return schemaVersion;
					}
					set	
					{
						schemaVersion = value;
					}
				}

				public string LatestVersion
				{
					get
					{
						return latestVersion;
					}
					set	
					{
						latestVersion = value;
					}
				}

				public string PromptKey
				{
					get
					{
						return promptKey;
					}
					set	
					{
						promptKey = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
					}
				}

				public string ReviewingVersion
				{
					get
					{
						return reviewingVersion;
					}
					set	
					{
						reviewingVersion = value;
					}
				}

				public int? OnlineCnt
				{
					get
					{
						return onlineCnt;
					}
					set	
					{
						onlineCnt = value;
					}
				}

				public List<string> BizTags
				{
					get
					{
						return bizTags;
					}
					set	
					{
						bizTags = value;
					}
				}
			}
		}
	}
}
