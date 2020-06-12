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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QuerySummarySceneRuleLogResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string code;

		private QuerySummarySceneRuleLog_Data data;

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

		public string Code
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

		public QuerySummarySceneRuleLog_Data Data
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

		public class QuerySummarySceneRuleLog_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<QuerySummarySceneRuleLog_LogInfo> logList;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
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

			public List<QuerySummarySceneRuleLog_LogInfo> LogList
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

			public class QuerySummarySceneRuleLog_LogInfo
			{

				private int? logTime;

				private string result;

				private string traceId;

				public int? LogTime
				{
					get
					{
						return logTime;
					}
					set	
					{
						logTime = value;
					}
				}

				public string Result
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

				public string TraceId
				{
					get
					{
						return traceId;
					}
					set	
					{
						traceId = value;
					}
				}
			}
		}
	}
}
