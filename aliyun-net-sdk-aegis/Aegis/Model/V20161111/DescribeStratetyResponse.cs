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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeStratetyResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private List<DescribeStratety_Data> strategies;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<DescribeStratety_Data> Strategies
		{
			get
			{
				return strategies;
			}
			set	
			{
				strategies = value;
			}
		}

		public class DescribeStratety_Data
		{

			private int? cycleDays;

			private int? id;

			private int? cycleStartTime;

			private int? type;

			private string name;

			private int? riskCount;

			private int? ecsCount;

			private List<DescribeStratety_ConfigTarget> configTargets;

			public int? CycleDays
			{
				get
				{
					return cycleDays;
				}
				set	
				{
					cycleDays = value;
				}
			}

			public int? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? CycleStartTime
			{
				get
				{
					return cycleStartTime;
				}
				set	
				{
					cycleStartTime = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public int? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public int? EcsCount
			{
				get
				{
					return ecsCount;
				}
				set	
				{
					ecsCount = value;
				}
			}

			public List<DescribeStratety_ConfigTarget> ConfigTargets
			{
				get
				{
					return configTargets;
				}
				set	
				{
					configTargets = value;
				}
			}

			public class DescribeStratety_ConfigTarget
			{

				private string flag;

				private string targetType;

				private string target;

				public string Flag
				{
					get
					{
						return flag;
					}
					set	
					{
						flag = value;
					}
				}

				public string TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}
			}
		}
	}
}