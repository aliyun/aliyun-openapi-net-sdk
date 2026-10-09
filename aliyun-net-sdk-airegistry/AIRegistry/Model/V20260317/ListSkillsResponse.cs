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
	public class ListSkillsResponse : AcsResponse
	{

		private string requestId;

		private ListSkills_Data data;

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

		public ListSkills_Data Data
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

		public class ListSkills_Data
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pagesAvailable;

			private List<ListSkills_PageItem> pageItems;

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

			public List<ListSkills_PageItem> PageItems
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

			public class ListSkills_PageItem
			{

				private string draftMode;

				private string editingVersion;

				private string owner;

				private string description;

				private string bizTags;

				private string labels;

				private string from;

				private string name;

				private string scope;

				private long? updateTime;

				private bool? enable;

				private string namespaceId;

				private string reviewingVersion;

				private int? onlineCnt;

				private bool? writeable;

				private long? downloadCount;

				public string DraftMode
				{
					get
					{
						return draftMode;
					}
					set	
					{
						draftMode = value;
					}
				}

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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
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

				public string BizTags
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

				public string From
				{
					get
					{
						return from;
					}
					set	
					{
						from = value;
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

				public string Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
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

				public bool? Writeable
				{
					get
					{
						return writeable;
					}
					set	
					{
						writeable = value;
					}
				}

				public long? DownloadCount
				{
					get
					{
						return downloadCount;
					}
					set	
					{
						downloadCount = value;
					}
				}
			}
		}
	}
}
