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
	public class ListAccelerationOfWorkspaceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListAccelerationOfWorkspace_Result result;

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

		public ListAccelerationOfWorkspace_Result Result
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

		public class ListAccelerationOfWorkspace_Result
		{

			private int? totalPages;

			private int? totalNum;

			private int? pageNum;

			private int? pageSize;

			private int? pre;

			private int? next;

			private List<ListAccelerationOfWorkspace_DataItem> data;

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

			public int? Pre
			{
				get
				{
					return pre;
				}
				set	
				{
					pre = value;
				}
			}

			public int? Next
			{
				get
				{
					return next;
				}
				set	
				{
					next = value;
				}
			}

			public List<ListAccelerationOfWorkspace_DataItem> Data
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

			public class ListAccelerationOfWorkspace_DataItem
			{

				private string cubeId;

				private string cubeName;

				private string creatorName;

				private string size;

				private string lastModifyTime;

				private string enableQuickindexTime;

				private string jobId;

				private int? jobStatus;

				private string jobHistoryId;

				public string CubeId
				{
					get
					{
						return cubeId;
					}
					set	
					{
						cubeId = value;
					}
				}

				public string CubeName
				{
					get
					{
						return cubeName;
					}
					set	
					{
						cubeName = value;
					}
				}

				public string CreatorName
				{
					get
					{
						return creatorName;
					}
					set	
					{
						creatorName = value;
					}
				}

				public string Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string LastModifyTime
				{
					get
					{
						return lastModifyTime;
					}
					set	
					{
						lastModifyTime = value;
					}
				}

				public string EnableQuickindexTime
				{
					get
					{
						return enableQuickindexTime;
					}
					set	
					{
						enableQuickindexTime = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public int? JobStatus
				{
					get
					{
						return jobStatus;
					}
					set	
					{
						jobStatus = value;
					}
				}

				public string JobHistoryId
				{
					get
					{
						return jobHistoryId;
					}
					set	
					{
						jobHistoryId = value;
					}
				}
			}
		}
	}
}
