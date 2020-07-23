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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ListJobHistoriesResponse : AcsResponse
	{

		private int? code;

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private long? totalCount;

		private string errorMsg;

		private List<ListJobHistories_JobDetail> data;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public List<ListJobHistories_JobDetail> Data
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

		public class ListJobHistories_JobDetail
		{

			private string name;

			private string completionTime;

			private string startTime;

			private int? succeeded;

			private int? failed;

			private string message;

			private int? activeDeadlineSeconds;

			private int? backoffLimit;

			private int? completions;

			private int? parallelism;

			private List<string> podList;

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

			public string CompletionTime
			{
				get
				{
					return completionTime;
				}
				set	
				{
					completionTime = value;
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

			public int? Succeeded
			{
				get
				{
					return succeeded;
				}
				set	
				{
					succeeded = value;
				}
			}

			public int? Failed
			{
				get
				{
					return failed;
				}
				set	
				{
					failed = value;
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

			public int? ActiveDeadlineSeconds
			{
				get
				{
					return activeDeadlineSeconds;
				}
				set	
				{
					activeDeadlineSeconds = value;
				}
			}

			public int? BackoffLimit
			{
				get
				{
					return backoffLimit;
				}
				set	
				{
					backoffLimit = value;
				}
			}

			public int? Completions
			{
				get
				{
					return completions;
				}
				set	
				{
					completions = value;
				}
			}

			public int? Parallelism
			{
				get
				{
					return parallelism;
				}
				set	
				{
					parallelism = value;
				}
			}

			public List<string> PodList
			{
				get
				{
					return podList;
				}
				set	
				{
					podList = value;
				}
			}
		}
	}
}
