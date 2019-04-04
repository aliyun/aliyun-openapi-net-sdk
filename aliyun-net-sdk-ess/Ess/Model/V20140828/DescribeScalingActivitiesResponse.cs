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
	public class DescribeScalingActivitiesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingActivities_ScalingActivity> scalingActivities;

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

		public List<DescribeScalingActivities_ScalingActivity> ScalingActivities
		{
			get
			{
				return scalingActivities;
			}
			set	
			{
				scalingActivities = value;
			}
		}

		public class DescribeScalingActivities_ScalingActivity
		{

			private string scalingActivityId;

			private string scalingGroupId;

			private string description;

			private string cause;

			private string startTime;

			private string endTime;

			private int? progress;

			private string statusCode;

			private string statusMessage;

			private string totalCapacity;

			private string attachedCapacity;

			private string autoCreatedCapacity;

			private int? scalingInstanceNumber;

			public string ScalingActivityId
			{
				get
				{
					return scalingActivityId;
				}
				set	
				{
					scalingActivityId = value;
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

			public string Cause
			{
				get
				{
					return cause;
				}
				set	
				{
					cause = value;
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

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string StatusCode
			{
				get
				{
					return statusCode;
				}
				set	
				{
					statusCode = value;
				}
			}

			public string StatusMessage
			{
				get
				{
					return statusMessage;
				}
				set	
				{
					statusMessage = value;
				}
			}

			public string TotalCapacity
			{
				get
				{
					return totalCapacity;
				}
				set	
				{
					totalCapacity = value;
				}
			}

			public string AttachedCapacity
			{
				get
				{
					return attachedCapacity;
				}
				set	
				{
					attachedCapacity = value;
				}
			}

			public string AutoCreatedCapacity
			{
				get
				{
					return autoCreatedCapacity;
				}
				set	
				{
					autoCreatedCapacity = value;
				}
			}

			public int? ScalingInstanceNumber
			{
				get
				{
					return scalingInstanceNumber;
				}
				set	
				{
					scalingInstanceNumber = value;
				}
			}
		}
	}
}
