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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class GetAuditItemListResponse : AcsResponse
	{

		private string requestId;

		private long? currentPage;

		private long? pageSize;

		private long? totalCount;

		private List<GetAuditItemList_ItemsItem> items;

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

		public List<GetAuditItemList_ItemsItem> Items
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

		public class GetAuditItemList_ItemsItem
		{

			private long? id;

			private string create;

			private string uid;

			private string subUid;

			private string bizType;

			private string rcpTs;

			private string rcpResult;

			private string rcpRiskType;

			private string customTs;

			private string customResult;

			private string customRiskType;

			private string _operator;

			private string taskId;

			private string dataId;

			private string type;

			private string content;

			private string url;

			private string thumbnail;

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

			public string Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
				}
			}

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			public string SubUid
			{
				get
				{
					return subUid;
				}
				set	
				{
					subUid = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string RcpTs
			{
				get
				{
					return rcpTs;
				}
				set	
				{
					rcpTs = value;
				}
			}

			public string RcpResult
			{
				get
				{
					return rcpResult;
				}
				set	
				{
					rcpResult = value;
				}
			}

			public string RcpRiskType
			{
				get
				{
					return rcpRiskType;
				}
				set	
				{
					rcpRiskType = value;
				}
			}

			public string CustomTs
			{
				get
				{
					return customTs;
				}
				set	
				{
					customTs = value;
				}
			}

			public string CustomResult
			{
				get
				{
					return customResult;
				}
				set	
				{
					customResult = value;
				}
			}

			public string CustomRiskType
			{
				get
				{
					return customRiskType;
				}
				set	
				{
					customRiskType = value;
				}
			}

			public string _Operator
			{
				get
				{
					return _operator;
				}
				set	
				{
					_operator = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string Thumbnail
			{
				get
				{
					return thumbnail;
				}
				set	
				{
					thumbnail = value;
				}
			}
		}
	}
}
