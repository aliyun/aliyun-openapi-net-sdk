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
	public class DescribeAutoSnapshotPolicyExResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy> autoSnapshotPolicies;

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

		public List<DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy> AutoSnapshotPolicies
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

		public class DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy
		{

			private string timePoints;

			private string creationTime;

			private string status;

			private string autoSnapshotPolicyName;

			private string targetCopyRegions;

			private int? copiedSnapshotsRetentionDays;

			private string autoSnapshotPolicyId;

			private int? retentionDays;

			private string regionId;

			private int? diskNums;

			private bool? enableCrossRegionCopy;

			private string repeatWeekdays;

			private int? volumeNums;

			private string resourceGroupId;

			private List<DescribeAutoSnapshotPolicyEx_Tag> tags;

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

			public string TargetCopyRegions
			{
				get
				{
					return targetCopyRegions;
				}
				set	
				{
					targetCopyRegions = value;
				}
			}

			public int? CopiedSnapshotsRetentionDays
			{
				get
				{
					return copiedSnapshotsRetentionDays;
				}
				set	
				{
					copiedSnapshotsRetentionDays = value;
				}
			}

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

			public bool? EnableCrossRegionCopy
			{
				get
				{
					return enableCrossRegionCopy;
				}
				set	
				{
					enableCrossRegionCopy = value;
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

			public int? VolumeNums
			{
				get
				{
					return volumeNums;
				}
				set	
				{
					volumeNums = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public List<DescribeAutoSnapshotPolicyEx_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class DescribeAutoSnapshotPolicyEx_Tag
			{

				private string tagValue;

				private string tagKey;

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}
			}
		}
	}
}
