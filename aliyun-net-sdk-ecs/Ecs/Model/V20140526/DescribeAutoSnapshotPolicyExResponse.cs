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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoSnapshotPolicyExResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<AutoSnapshotPolicy> autoSnapshotPolicies;

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

		public List<AutoSnapshotPolicy> AutoSnapshotPolicies
		{
			get
			{
				return autoSnapshotPolicies;
			}
			set	
			{
				autoSnapshotPolicies = value;
			}
		}

		public class AutoSnapshotPolicy{

			private int? autoSnapshotPolicyId;

			private string regionId;

			private string autoSnapshotPolicyName;

			private string timePoints;

			private string repeatWeekdays;

			private int? retentionDays;

			private int? diskNums;

			private string creationTime;

			public int? AutoSnapshotPolicyId
			{
				get
				{
					return autoSnapshotPolicyId;
				}
				set	
				{
					autoSnapshotPolicyId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string AutoSnapshotPolicyName
			{
				get
				{
					return autoSnapshotPolicyName;
				}
				set	
				{
					autoSnapshotPolicyName = value;
				}
			}

			public string TimePoints
			{
				get
				{
					return timePoints;
				}
				set	
				{
					timePoints = value;
				}
			}

			public string RepeatWeekdays
			{
				get
				{
					return repeatWeekdays;
				}
				set	
				{
					repeatWeekdays = value;
				}
			}

			public int? RetentionDays
			{
				get
				{
					return retentionDays;
				}
				set	
				{
					retentionDays = value;
				}
			}

			public int? DiskNums
			{
				get
				{
					return diskNums;
				}
				set	
				{
					diskNums = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}
		}
	}
}