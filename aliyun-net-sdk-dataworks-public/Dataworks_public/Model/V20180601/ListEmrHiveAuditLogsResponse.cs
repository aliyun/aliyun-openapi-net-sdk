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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
	public class ListEmrHiveAuditLogsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListEmrHiveAuditLogs_Data data;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public ListEmrHiveAuditLogs_Data Data
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

		public class ListEmrHiveAuditLogs_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListEmrHiveAuditLogs_AuditLog> pagedData;

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

			public List<ListEmrHiveAuditLogs_AuditLog> PagedData
			{
				get
				{
					return pagedData;
				}
				set	
				{
					pagedData = value;
				}
			}

			public class ListEmrHiveAuditLogs_AuditLog
			{

				private string table;

				private string database;

				private string user;

				private string operation;

				private long? eventTime;

				private List<string> groups;

				public string Table
				{
					get
					{
						return table;
					}
					set	
					{
						table = value;
					}
				}

				public string Database
				{
					get
					{
						return database;
					}
					set	
					{
						database = value;
					}
				}

				public string User
				{
					get
					{
						return user;
					}
					set	
					{
						user = value;
					}
				}

				public string Operation
				{
					get
					{
						return operation;
					}
					set	
					{
						operation = value;
					}
				}

				public long? EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public List<string> Groups
				{
					get
					{
						return groups;
					}
					set	
					{
						groups = value;
					}
				}
			}
		}
	}
}
