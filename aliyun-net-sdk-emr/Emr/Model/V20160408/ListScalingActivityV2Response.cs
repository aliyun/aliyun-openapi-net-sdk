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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListScalingActivityV2Response : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string nextToken;

		private List<ListScalingActivityV2_Item> items;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListScalingActivityV2_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class ListScalingActivityV2_Item
		{

			private string bizId;

			private long? startTime;

			private long? endTime;

			private int? expectNum;

			private string instanceIds;

			private int? totalCapacity;

			private string cause;

			private string description;

			private string transition;

			private string status;

			private string scalingRuleId;

			private string scalingRuleName;

			private string hostGroupBizId;

			private string hostGroupName;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public long? StartTime
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

			public long? EndTime
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

			public int? ExpectNum
			{
				get
				{
					return expectNum;
				}
				set	
				{
					expectNum = value;
				}
			}

			public string InstanceIds
			{
				get
				{
					return instanceIds;
				}
				set	
				{
					instanceIds = value;
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

			public string Transition
			{
				get
				{
					return transition;
				}
				set	
				{
					transition = value;
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

			public string ScalingRuleId
			{
				get
				{
					return scalingRuleId;
				}
				set	
				{
					scalingRuleId = value;
				}
			}

			public string ScalingRuleName
			{
				get
				{
					return scalingRuleName;
				}
				set	
				{
					scalingRuleName = value;
				}
			}

			public string HostGroupBizId
			{
				get
				{
					return hostGroupBizId;
				}
				set	
				{
					hostGroupBizId = value;
				}
			}

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
				}
			}
		}
	}
}
