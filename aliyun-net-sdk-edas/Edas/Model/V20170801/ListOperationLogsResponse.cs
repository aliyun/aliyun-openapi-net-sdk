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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListOperationLogsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private int? totalSize;

		private int? currentPage;

		private int? pageSize;

		private List<ListOperationLogs_Log> logList;

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

		public int? TotalSize
		{
			get
			{
				return totalSize;
			}
			set	
			{
				totalSize = value;
			}
		}

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

		public List<ListOperationLogs_Log> LogList
		{
			get
			{
				return logList;
			}
			set	
			{
				logList = value;
			}
		}

		public class ListOperationLogs_Log
		{

			private string actionGroup;

			private string actionName;

			private long? beginTime;

			private long? endTime;

			private string operatorName;

			private string operatorId;

			private string source;

			private string status;

			private string message;

			private string extraParameters;

			private string appId;

			public string ActionGroup
			{
				get
				{
					return actionGroup;
				}
				set	
				{
					actionGroup = value;
				}
			}

			public string ActionName
			{
				get
				{
					return actionName;
				}
				set	
				{
					actionName = value;
				}
			}

			public long? BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public long? EndTime
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

			public string OperatorName
			{
				get
				{
					return operatorName;
				}
				set	
				{
					operatorName = value;
				}
			}

			public string OperatorId
			{
				get
				{
					return operatorId;
				}
				set	
				{
					operatorId = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
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

			public string ExtraParameters
			{
				get
				{
					return extraParameters;
				}
				set	
				{
					extraParameters = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}
		}
	}
}
