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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoProvisioningGroupHistoryResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory> autoProvisioningGroupHistories;

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

		public List<DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory> AutoProvisioningGroupHistories
		{
			get
			{
				return autoProvisioningGroupHistories;
			}
			set	
			{
				autoProvisioningGroupHistories = value;
			}
		}

		public class DescribeAutoProvisioningGroupHistory_AutoProvisioningGroupHistory
		{

			private string status;

			private string startTime;

			private string taskId;

			private string lastEventTime;

			private List<DescribeAutoProvisioningGroupHistory_ActivityDetail> activityDetails;

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

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string LastEventTime
			{
				get
				{
					return lastEventTime;
				}
				set	
				{
					lastEventTime = value;
				}
			}

			public List<DescribeAutoProvisioningGroupHistory_ActivityDetail> ActivityDetails
			{
				get
				{
					return activityDetails;
				}
				set	
				{
					activityDetails = value;
				}
			}

			public class DescribeAutoProvisioningGroupHistory_ActivityDetail
			{

				private string status;

				private string detail;

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

				public string Detail
				{
					get
					{
						return detail;
					}
					set	
					{
						detail = value;
					}
				}
			}
		}
	}
}
