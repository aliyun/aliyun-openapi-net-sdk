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
	public class ListScalingGroupV2Response : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string nextToken;

		private List<ListScalingGroupV2_Item> items;

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

		public List<ListScalingGroupV2_Item> Items
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

		public class ListScalingGroupV2_Item
		{

			private string scalingGroupId;

			private string name;

			private string description;

			private string activeStatus;

			private string hostGroupBizId;

			private string scalingInMode;

			private int? scalingMinSize;

			private int? scalingMaxSize;

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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
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

			public string ActiveStatus
			{
				get
				{
					return activeStatus;
				}
				set	
				{
					activeStatus = value;
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

			public string ScalingInMode
			{
				get
				{
					return scalingInMode;
				}
				set	
				{
					scalingInMode = value;
				}
			}

			public int? ScalingMinSize
			{
				get
				{
					return scalingMinSize;
				}
				set	
				{
					scalingMinSize = value;
				}
			}

			public int? ScalingMaxSize
			{
				get
				{
					return scalingMaxSize;
				}
				set	
				{
					scalingMaxSize = value;
				}
			}
		}
	}
}
