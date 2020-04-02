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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryUnfinishedSessionsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<QueryUnfinishedSessions_LmActivitySessionModel> lmActivitySessionModelList;

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

		public List<QueryUnfinishedSessions_LmActivitySessionModel> LmActivitySessionModelList
		{
			get
			{
				return lmActivitySessionModelList;
			}
			set	
			{
				lmActivitySessionModelList = value;
			}
		}

		public class QueryUnfinishedSessions_LmActivitySessionModel
		{

			private string startDate;

			private string subBizCode;

			private string name;

			private long? lmActivityId;

			private long? lmSessionId;

			private string endDate;

			private string displayDate;

			private string description;

			private string bizId;

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string SubBizCode
			{
				get
				{
					return subBizCode;
				}
				set	
				{
					subBizCode = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? LmActivityId
			{
				get
				{
					return lmActivityId;
				}
				set	
				{
					lmActivityId = value;
				}
			}

			public long? LmSessionId
			{
				get
				{
					return lmSessionId;
				}
				set	
				{
					lmSessionId = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public string DisplayDate
			{
				get
				{
					return displayDate;
				}
				set	
				{
					displayDate = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}
		}
	}
}
