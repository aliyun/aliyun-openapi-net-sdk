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
	public class GetWorksEmbedListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetWorksEmbedList_Result result;

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

		public GetWorksEmbedList_Result Result
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

		public class GetWorksEmbedList_Result
		{

			private long? pageNo;

			private long? pageSize;

			private long? totalNum;

			private long? totalPages;

			private List<GetWorksEmbedList_DataItem> data;

			public long? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
				}
			}

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

			public long? TotalNum
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

			public long? TotalPages
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

			public List<GetWorksEmbedList_DataItem> Data
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

			public class GetWorksEmbedList_DataItem
			{

				private string embedTime;

				private string worksId;

				private string worksName;

				private string worksType;

				private string workspaceId;

				public string EmbedTime
				{
					get
					{
						return embedTime;
					}
					set	
					{
						embedTime = value;
					}
				}

				public string WorksId
				{
					get
					{
						return worksId;
					}
					set	
					{
						worksId = value;
					}
				}

				public string WorksName
				{
					get
					{
						return worksName;
					}
					set	
					{
						worksName = value;
					}
				}

				public string WorksType
				{
					get
					{
						return worksType;
					}
					set	
					{
						worksType = value;
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
			}
		}
	}
}
