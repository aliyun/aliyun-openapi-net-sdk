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

namespace Aliyun.Acs.viapi.Model.V20230117
{
	public class QueryAsyncJobListResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private bool? success;

		private string httpCode;

		private QueryAsyncJobList_Data data;

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

		public string HttpCode
		{
			get
			{
				return httpCode;
			}
			set	
			{
				httpCode = value;
			}
		}

		public QueryAsyncJobList_Data Data
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

		public class QueryAsyncJobList_Data
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalPage;

			private int? totalRecord;

			private List<QueryAsyncJobList_ResultItem> result;

			public int? CurrentPage
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

			public int? TotalPage
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

			public int? TotalRecord
			{
				get
				{
					return totalRecord;
				}
				set	
				{
					totalRecord = value;
				}
			}

			public List<QueryAsyncJobList_ResultItem> Result
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

			public class QueryAsyncJobList_ResultItem
			{

				private string callerParentId;

				private string endTime;

				private string gmtCreate;

				private string jobId;

				private string popApiName;

				private string popProduct;

				private string startTime;

				private string status;

				public string CallerParentId
				{
					get
					{
						return callerParentId;
					}
					set	
					{
						callerParentId = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
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

				public string PopApiName
				{
					get
					{
						return popApiName;
					}
					set	
					{
						popApiName = value;
					}
				}

				public string PopProduct
				{
					get
					{
						return popProduct;
					}
					set	
					{
						popProduct = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
