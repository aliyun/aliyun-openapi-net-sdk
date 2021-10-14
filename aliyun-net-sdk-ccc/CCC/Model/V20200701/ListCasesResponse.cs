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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListCasesResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private long? httpStatusCode;

		private string code;

		private bool? success;

		private ListCases_Data data;

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

		public long? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListCases_Data Data
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

		public class ListCases_Data
		{

			private long? pageNumber;

			private long? pageSize;

			private long? totalCount;

			private List<ListCases_ListItem> list;

			public long? PageNumber
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

			public List<ListCases_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListCases_ListItem
			{

				private string abandonType;

				private long? attemptCount;

				private string expandInfo;

				private string failureReason;

				private string phoneNumber;

				private string state;

				private string caseId;

				private string customVariables;

				public string AbandonType
				{
					get
					{
						return abandonType;
					}
					set	
					{
						abandonType = value;
					}
				}

				public long? AttemptCount
				{
					get
					{
						return attemptCount;
					}
					set	
					{
						attemptCount = value;
					}
				}

				public string ExpandInfo
				{
					get
					{
						return expandInfo;
					}
					set	
					{
						expandInfo = value;
					}
				}

				public string FailureReason
				{
					get
					{
						return failureReason;
					}
					set	
					{
						failureReason = value;
					}
				}

				public string PhoneNumber
				{
					get
					{
						return phoneNumber;
					}
					set	
					{
						phoneNumber = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string CaseId
				{
					get
					{
						return caseId;
					}
					set	
					{
						caseId = value;
					}
				}

				public string CustomVariables
				{
					get
					{
						return customVariables;
					}
					set	
					{
						customVariables = value;
					}
				}
			}
		}
	}
}
