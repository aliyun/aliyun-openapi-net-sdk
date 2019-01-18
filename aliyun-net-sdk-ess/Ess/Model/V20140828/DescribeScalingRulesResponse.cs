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
	public class DescribeScalingRulesResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<DescribeScalingRules_ScalingRule> scalingRules;

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

		public List<DescribeScalingRules_ScalingRule> ScalingRules
		{
			get
			{
				return scalingRules;
			}
			set	
			{
				scalingRules = value;
			}
		}

		public class DescribeScalingRules_ScalingRule
		{

			private string scalingRuleId;

			private string scalingGroupId;

			private string scalingRuleName;

			private int? cooldown;

			private string adjustmentType;

			private int? adjustmentValue;

			private int? minSize;

			private int? maxSize;

			private string scalingRuleAri;

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

			public int? Cooldown
			{
				get
				{
					return cooldown;
				}
				set	
				{
					cooldown = value;
				}
			}

			public string AdjustmentType
			{
				get
				{
					return adjustmentType;
				}
				set	
				{
					adjustmentType = value;
				}
			}

			public int? AdjustmentValue
			{
				get
				{
					return adjustmentValue;
				}
				set	
				{
					adjustmentValue = value;
				}
			}

			public int? MinSize
			{
				get
				{
					return minSize;
				}
				set	
				{
					minSize = value;
				}
			}

			public int? MaxSize
			{
				get
				{
					return maxSize;
				}
				set	
				{
					maxSize = value;
				}
			}

			public string ScalingRuleAri
			{
				get
				{
					return scalingRuleAri;
				}
				set	
				{
					scalingRuleAri = value;
				}
			}
		}
	}
}