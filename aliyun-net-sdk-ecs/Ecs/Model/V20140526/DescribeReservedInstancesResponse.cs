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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeReservedInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeReservedInstances_ReservedInstance> reservedInstances;

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

		public List<DescribeReservedInstances_ReservedInstance> ReservedInstances
		{
			get
			{
				return reservedInstances;
			}
			set	
			{
				reservedInstances = value;
			}
		}

		public class DescribeReservedInstances_ReservedInstance
		{

			private string reservedInstanceId;

			private string regionId;

			private string zoneId;

			private string reservedInstanceName;

			private string description;

			private string instanceType;

			private string scope;

			private string offeringType;

			private string platform;

			private int? instanceAmount;

			private string status;

			private string creationTime;

			private string expiredTime;

			private string startTime;

			private string resourceGroupId;

			private string allocationStatus;

			private List<DescribeReservedInstances_OperationLock> operationLocks;

			private List<DescribeReservedInstances_Tag> tags;

			public string ReservedInstanceId
			{
				get
				{
					return reservedInstanceId;
				}
				set	
				{
					reservedInstanceId = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ReservedInstanceName
			{
				get
				{
					return reservedInstanceName;
				}
				set	
				{
					reservedInstanceName = value;
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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string Scope
			{
				get
				{
					return scope;
				}
				set	
				{
					scope = value;
				}
			}

			public string OfferingType
			{
				get
				{
					return offeringType;
				}
				set	
				{
					offeringType = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public int? InstanceAmount
			{
				get
				{
					return instanceAmount;
				}
				set	
				{
					instanceAmount = value;
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

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public string AllocationStatus
			{
				get
				{
					return allocationStatus;
				}
				set	
				{
					allocationStatus = value;
				}
			}

			public List<DescribeReservedInstances_OperationLock> OperationLocks
			{
				get
				{
					return operationLocks;
				}
				set	
				{
					operationLocks = value;
				}
			}

			public List<DescribeReservedInstances_Tag> Tags
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

			public class DescribeReservedInstances_OperationLock
			{

				private string lockReason;

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}
			}

			public class DescribeReservedInstances_Tag
			{

				private string tagKey;

				private string tagValue;

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
			}
		}
	}
}
