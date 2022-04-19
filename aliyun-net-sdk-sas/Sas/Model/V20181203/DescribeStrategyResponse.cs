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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeStrategyResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeStrategy_Strategy> strategies;

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

		public List<DescribeStrategy_Strategy> Strategies
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

		public class DescribeStrategy_Strategy
		{

			private int? type;

			private int? execStatus;

			private int? passRate;

			private string authVersionList;

			private int? cycleStartTime;

			private string customType;

			private int? ecsCount;

			private int? processRate;

			private int? cycleDays;

			private int? riskCount;

			private string name;

			private int? id;

			private List<DescribeStrategy_ConfigTarget> configTargets;

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

			public int? ExecStatus
			{
				get
				{
					return execStatus;
				}
				set	
				{
					execStatus = value;
				}
			}

			public int? PassRate
			{
				get
				{
					return passRate;
				}
				set	
				{
					passRate = value;
				}
			}

			public string AuthVersionList
			{
				get
				{
					return authVersionList;
				}
				set	
				{
					authVersionList = value;
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

			public string CustomType
			{
				get
				{
					return customType;
				}
				set	
				{
					customType = value;
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

			public int? ProcessRate
			{
				get
				{
					return processRate;
				}
				set	
				{
					processRate = value;
				}
			}

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

			public List<DescribeStrategy_ConfigTarget> ConfigTargets
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

			public class DescribeStrategy_ConfigTarget
			{

				private string flag;

				private string target;

				private string targetType;

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
			}
		}
	}
}
