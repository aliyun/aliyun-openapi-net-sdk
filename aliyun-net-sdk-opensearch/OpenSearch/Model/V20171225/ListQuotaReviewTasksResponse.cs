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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListQuotaReviewTasksResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<ListQuotaReviewTasks_ResultItem> result;

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

		public List<ListQuotaReviewTasks_ResultItem> Result
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

		public class ListQuotaReviewTasks_ResultItem
		{

			private int? oldDocSize;

			private bool? pending;

			private string memo;

			private bool? approved;

			private string oldSpec;

			private int? oldComputeResource;

			private string appGroupType;

			private bool? available;

			private string gmtCreate;

			private int? newSocSize;

			private int? id;

			private int? appGroupId;

			private int? newComputeResource;

			private string appGroupName;

			private string gmtModified;

			private string newSpec;

			public int? OldDocSize
			{
				get
				{
					return oldDocSize;
				}
				set	
				{
					oldDocSize = value;
				}
			}

			public bool? Pending
			{
				get
				{
					return pending;
				}
				set	
				{
					pending = value;
				}
			}

			public string Memo
			{
				get
				{
					return memo;
				}
				set	
				{
					memo = value;
				}
			}

			public bool? Approved
			{
				get
				{
					return approved;
				}
				set	
				{
					approved = value;
				}
			}

			public string OldSpec
			{
				get
				{
					return oldSpec;
				}
				set	
				{
					oldSpec = value;
				}
			}

			public int? OldComputeResource
			{
				get
				{
					return oldComputeResource;
				}
				set	
				{
					oldComputeResource = value;
				}
			}

			public string AppGroupType
			{
				get
				{
					return appGroupType;
				}
				set	
				{
					appGroupType = value;
				}
			}

			public bool? Available
			{
				get
				{
					return available;
				}
				set	
				{
					available = value;
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

			public int? NewSocSize
			{
				get
				{
					return newSocSize;
				}
				set	
				{
					newSocSize = value;
				}
			}

			public int? Id
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

			public int? AppGroupId
			{
				get
				{
					return appGroupId;
				}
				set	
				{
					appGroupId = value;
				}
			}

			public int? NewComputeResource
			{
				get
				{
					return newComputeResource;
				}
				set	
				{
					newComputeResource = value;
				}
			}

			public string AppGroupName
			{
				get
				{
					return appGroupName;
				}
				set	
				{
					appGroupName = value;
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

			public string NewSpec
			{
				get
				{
					return newSpec;
				}
				set	
				{
					newSpec = value;
				}
			}
		}
	}
}
