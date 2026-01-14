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
	public class GetMailTaskListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetMailTaskList_Result result;

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

		public GetMailTaskList_Result Result
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

		public class GetMailTaskList_Result
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalNum;

			private int? totalPages;

			private int? pre;

			private int? next;

			private List<GetMailTaskList_DataItem> data;

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

			public List<GetMailTaskList_DataItem> Data
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

			public class GetMailTaskList_DataItem
			{

				private string mailId;

				private bool? paused;

				private string bizOwnerUserId;

				private string bizOwnerName;

				private string subscribeName;

				public string MailId
				{
					get
					{
						return mailId;
					}
					set	
					{
						mailId = value;
					}
				}

				public bool? Paused
				{
					get
					{
						return paused;
					}
					set	
					{
						paused = value;
					}
				}

				public string BizOwnerUserId
				{
					get
					{
						return bizOwnerUserId;
					}
					set	
					{
						bizOwnerUserId = value;
					}
				}

				public string BizOwnerName
				{
					get
					{
						return bizOwnerName;
					}
					set	
					{
						bizOwnerName = value;
					}
				}

				public string SubscribeName
				{
					get
					{
						return subscribeName;
					}
					set	
					{
						subscribeName = value;
					}
				}
			}
		}
	}
}
