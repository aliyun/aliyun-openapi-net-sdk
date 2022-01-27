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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class ListDeliveryHistoryJobsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListDeliveryHistoryJobs_DeliveryHistoryJob> deliveryHistoryJobs;

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

		public List<ListDeliveryHistoryJobs_DeliveryHistoryJob> DeliveryHistoryJobs
		{
			get
			{
				return deliveryHistoryJobs;
			}
			set	
			{
				deliveryHistoryJobs = value;
			}
		}

		public class ListDeliveryHistoryJobs_DeliveryHistoryJob
		{

			private string trailName;

			private string createdTime;

			private string updatedTime;

			private string homeRegion;

			private string startTime;

			private string endTime;

			private long? jobId;

			private int? jobStatus;

			public string TrailName
			{
				get
				{
					return trailName;
				}
				set	
				{
					trailName = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string UpdatedTime
			{
				get
				{
					return updatedTime;
				}
				set	
				{
					updatedTime = value;
				}
			}

			public string HomeRegion
			{
				get
				{
					return homeRegion;
				}
				set	
				{
					homeRegion = value;
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

			public long? JobId
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

			public int? JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}
		}
	}
}
