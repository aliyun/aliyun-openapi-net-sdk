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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListBaselineStatusesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListBaselineStatuses_Data data;

		public int? HttpStatusCode
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

		public ListBaselineStatuses_Data Data
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

		public class ListBaselineStatuses_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListBaselineStatuses_BaselineStatusesItem> baselineStatuses;

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

			public List<ListBaselineStatuses_BaselineStatusesItem> BaselineStatuses
			{
				get
				{
					return baselineStatuses;
				}
				set	
				{
					baselineStatuses = value;
				}
			}

			public class ListBaselineStatuses_BaselineStatusesItem
			{

				private string status;

				private string owner;

				private long? finishTime;

				private long? projectId;

				private int? priority;

				private long? endCast;

				private int? inGroupId;

				private string baselineName;

				private long? baselineId;

				private string finishStatus;

				private long? bizdate;

				private long? buffer;

				private long? slaTime;

				private long? expTime;

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

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public long? FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public int? Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public long? EndCast
				{
					get
					{
						return endCast;
					}
					set	
					{
						endCast = value;
					}
				}

				public int? InGroupId
				{
					get
					{
						return inGroupId;
					}
					set	
					{
						inGroupId = value;
					}
				}

				public string BaselineName
				{
					get
					{
						return baselineName;
					}
					set	
					{
						baselineName = value;
					}
				}

				public long? BaselineId
				{
					get
					{
						return baselineId;
					}
					set	
					{
						baselineId = value;
					}
				}

				public string FinishStatus
				{
					get
					{
						return finishStatus;
					}
					set	
					{
						finishStatus = value;
					}
				}

				public long? Bizdate
				{
					get
					{
						return bizdate;
					}
					set	
					{
						bizdate = value;
					}
				}

				public long? Buffer
				{
					get
					{
						return buffer;
					}
					set	
					{
						buffer = value;
					}
				}

				public long? SlaTime
				{
					get
					{
						return slaTime;
					}
					set	
					{
						slaTime = value;
					}
				}

				public long? ExpTime
				{
					get
					{
						return expTime;
					}
					set	
					{
						expTime = value;
					}
				}
			}
		}
	}
}
