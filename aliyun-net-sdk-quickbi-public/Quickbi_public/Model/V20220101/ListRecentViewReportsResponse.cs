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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class ListRecentViewReportsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListRecentViewReports_Result result;

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

		public ListRecentViewReports_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListRecentViewReports_Result
		{

			private string attention;

			private int? pageNum;

			private int? pageSize;

			private int? totalNum;

			private int? totalPages;

			private List<ListRecentViewReports_DataItem> data;

			public string Attention
			{
				get
				{
					return attention;
				}
				set	
				{
					attention = value;
				}
			}

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<ListRecentViewReports_DataItem> Data
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

			public class ListRecentViewReports_DataItem
			{

				private bool? favorite;

				private string gmtCreate;

				private string gmtModified;

				private bool? hasEditAuth;

				private bool? hasViewAuth;

				private string latestViewTime;

				private string name;

				private string ownerName;

				private string ownerNum;

				private int? publishStatus;

				private string treeId;

				private string type;

				private long? viewCount;

				private string workspaceId;

				private string workspaceName;

				public bool? Favorite
				{
					get
					{
						return favorite;
					}
					set	
					{
						favorite = value;
					}
				}

				public string GmtCreate
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

				public string GmtModified
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

				public bool? HasEditAuth
				{
					get
					{
						return hasEditAuth;
					}
					set	
					{
						hasEditAuth = value;
					}
				}

				public bool? HasViewAuth
				{
					get
					{
						return hasViewAuth;
					}
					set	
					{
						hasViewAuth = value;
					}
				}

				public string LatestViewTime
				{
					get
					{
						return latestViewTime;
					}
					set	
					{
						latestViewTime = value;
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

				public string OwnerName
				{
					get
					{
						return ownerName;
					}
					set	
					{
						ownerName = value;
					}
				}

				public string OwnerNum
				{
					get
					{
						return ownerNum;
					}
					set	
					{
						ownerNum = value;
					}
				}

				public int? PublishStatus
				{
					get
					{
						return publishStatus;
					}
					set	
					{
						publishStatus = value;
					}
				}

				public string TreeId
				{
					get
					{
						return treeId;
					}
					set	
					{
						treeId = value;
					}
				}

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

				public long? ViewCount
				{
					get
					{
						return viewCount;
					}
					set	
					{
						viewCount = value;
					}
				}

				public string WorkspaceId
				{
					get
					{
						return workspaceId;
					}
					set	
					{
						workspaceId = value;
					}
				}

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}
			}
		}
	}
}
