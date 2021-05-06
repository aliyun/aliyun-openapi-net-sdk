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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeScheduleTasksResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private DescribeScheduleTasks_Data data;

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

		public DescribeScheduleTasks_Data Data
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

		public class DescribeScheduleTasks_Data
		{

			private int? totalRecordCount;

			private int? pageSize;

			private int? pageNumber;

			private List<DescribeScheduleTasks_TimerInfosItem> timerInfos;

			public int? TotalRecordCount
			{
				get
				{
					return totalRecordCount;
				}
				set	
				{
					totalRecordCount = value;
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

			public List<DescribeScheduleTasks_TimerInfosItem> TimerInfos
			{
				get
				{
					return timerInfos;
				}
				set	
				{
					timerInfos = value;
				}
			}

			public class DescribeScheduleTasks_TimerInfosItem
			{

				private string status;

				private string action;

				private string taskId;

				private string plannedTime;

				private string dbClusterDescription;

				private string plannedStartTime;

				private string dBClusterId;

				private string region;

				private string orderId;

				private string plannedEndTime;

				private string dbClusterStatus;

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

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
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

				public string PlannedTime
				{
					get
					{
						return plannedTime;
					}
					set	
					{
						plannedTime = value;
					}
				}

				public string DbClusterDescription
				{
					get
					{
						return dbClusterDescription;
					}
					set	
					{
						dbClusterDescription = value;
					}
				}

				public string PlannedStartTime
				{
					get
					{
						return plannedStartTime;
					}
					set	
					{
						plannedStartTime = value;
					}
				}

				public string DBClusterId
				{
					get
					{
						return dBClusterId;
					}
					set	
					{
						dBClusterId = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string OrderId
				{
					get
					{
						return orderId;
					}
					set	
					{
						orderId = value;
					}
				}

				public string PlannedEndTime
				{
					get
					{
						return plannedEndTime;
					}
					set	
					{
						plannedEndTime = value;
					}
				}

				public string DbClusterStatus
				{
					get
					{
						return dbClusterStatus;
					}
					set	
					{
						dbClusterStatus = value;
					}
				}
			}
		}
	}
}
