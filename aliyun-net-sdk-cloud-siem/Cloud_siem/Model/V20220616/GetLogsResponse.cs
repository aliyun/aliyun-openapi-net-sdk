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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class GetLogsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private GetLogs_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public GetLogs_Data Data
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

		public class GetLogs_Data
		{

			private GetLogs_PageInfo pageInfo;

			private GetLogs_ResponseData responseData;

			public GetLogs_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public GetLogs_ResponseData ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public class GetLogs_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

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
			}

			public class GetLogs_ResponseData
			{

				private bool? completeOrNot;

				private int? count;

				private long? cost;

				private bool? hasSql;

				private List<string> keys;

				private List<string> lines;

				public bool? CompleteOrNot
				{
					get
					{
						return completeOrNot;
					}
					set	
					{
						completeOrNot = value;
					}
				}

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public long? Cost
				{
					get
					{
						return cost;
					}
					set	
					{
						cost = value;
					}
				}

				public bool? HasSql
				{
					get
					{
						return hasSql;
					}
					set	
					{
						hasSql = value;
					}
				}

				public List<string> Keys
				{
					get
					{
						return keys;
					}
					set	
					{
						keys = value;
					}
				}

				public List<string> Lines
				{
					get
					{
						return lines;
					}
					set	
					{
						lines = value;
					}
				}
			}
		}
	}
}
