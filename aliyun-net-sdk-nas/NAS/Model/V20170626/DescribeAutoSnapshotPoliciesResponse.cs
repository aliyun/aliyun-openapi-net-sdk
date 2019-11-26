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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeAutoSnapshotPoliciesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeAutoSnapshotPolicies_AutoSnapshotPolicy> autoSnapshotPolicies;

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

		public List<DescribeAutoSnapshotPolicies_AutoSnapshotPolicy> AutoSnapshotPolicies
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

		public class DescribeAutoSnapshotPolicies_AutoSnapshotPolicy
		{

			private string autoSnapshotPolicyId;

			private string autoSnapshotPolicyName;

			private string createTime;

			private int? fileSystemNums;

			private string regionId;

			private string repeatWeekdays;

			private int? retentionDays;

			private string status;

			private string timePoints;

			public string AutoSnapshotPolicyId
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

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? FileSystemNums
			{
				get
				{
					return fileSystemNums;
				}
				set	
				{
					fileSystemNums = value;
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
		}
	}
}
