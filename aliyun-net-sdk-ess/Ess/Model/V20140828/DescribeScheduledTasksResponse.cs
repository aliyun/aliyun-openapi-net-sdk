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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeScheduledTasksResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScheduledTasks_ScheduledTask> scheduledTasks;

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

		public List<DescribeScheduledTasks_ScheduledTask> ScheduledTasks
		{
			get
			{
				return scheduledTasks;
			}
			set	
			{
				scheduledTasks = value;
			}
		}

		public class DescribeScheduledTasks_ScheduledTask
		{

			private string scheduledTaskId;

			private string scheduledTaskName;

			private string description;

			private string scheduledAction;

			private string recurrenceEndTime;

			private string launchTime;

			private string recurrenceType;

			private string recurrenceValue;

			private int? launchExpirationTime;

			private bool? taskEnabled;

			private int? maxValue;

			private int? minValue;

			private int? desiredCapacity;

			private string scalingGroupId;

			public string ScheduledTaskId
			{
				get
				{
					return scheduledTaskId;
				}
				set	
				{
					scheduledTaskId = value;
				}
			}

			public string ScheduledTaskName
			{
				get
				{
					return scheduledTaskName;
				}
				set	
				{
					scheduledTaskName = value;
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

			public string ScheduledAction
			{
				get
				{
					return scheduledAction;
				}
				set	
				{
					scheduledAction = value;
				}
			}

			public string RecurrenceEndTime
			{
				get
				{
					return recurrenceEndTime;
				}
				set	
				{
					recurrenceEndTime = value;
				}
			}

			public string LaunchTime
			{
				get
				{
					return launchTime;
				}
				set	
				{
					launchTime = value;
				}
			}

			public string RecurrenceType
			{
				get
				{
					return recurrenceType;
				}
				set	
				{
					recurrenceType = value;
				}
			}

			public string RecurrenceValue
			{
				get
				{
					return recurrenceValue;
				}
				set	
				{
					recurrenceValue = value;
				}
			}

			public int? LaunchExpirationTime
			{
				get
				{
					return launchExpirationTime;
				}
				set	
				{
					launchExpirationTime = value;
				}
			}

			public bool? TaskEnabled
			{
				get
				{
					return taskEnabled;
				}
				set	
				{
					taskEnabled = value;
				}
			}

			public int? MaxValue
			{
				get
				{
					return maxValue;
				}
				set	
				{
					maxValue = value;
				}
			}

			public int? MinValue
			{
				get
				{
					return minValue;
				}
				set	
				{
					minValue = value;
				}
			}

			public int? DesiredCapacity
			{
				get
				{
					return desiredCapacity;
				}
				set	
				{
					desiredCapacity = value;
				}
			}

			public string ScalingGroupId
			{
				get
				{
					return scalingGroupId;
				}
				set	
				{
					scalingGroupId = value;
				}
			}
		}
	}
}
