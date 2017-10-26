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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeCapacityHistoryResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeCapacityHistory_CapacityHistoryModel> capacityHistoryItems;

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

		public List<DescribeCapacityHistory_CapacityHistoryModel> CapacityHistoryItems
		{
			get
			{
				return capacityHistoryItems;
			}
			set	
			{
				capacityHistoryItems = value;
			}
		}

		public class DescribeCapacityHistory_CapacityHistoryModel
		{

			private string scalingGroupId;

			private int? totalCapacity;

			private int? attachedCapacity;

			private int? autoCreatedCapacity;

			private string timestamp;

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

			public int? TotalCapacity
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

			public int? AttachedCapacity
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

			public int? AutoCreatedCapacity
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

			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}
		}
	}
}