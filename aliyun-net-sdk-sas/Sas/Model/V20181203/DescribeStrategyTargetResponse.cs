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
	public class DescribeStrategyTargetResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeStrategyTarget_StrategyTarget> strategyTargets;

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

		public List<DescribeStrategyTarget_StrategyTarget> StrategyTargets
		{
			get
			{
				return strategyTargets;
			}
			set	
			{
				strategyTargets = value;
			}
		}

		public class DescribeStrategyTarget_StrategyTarget
		{

			private string flag;

			private string target;

			private string targetType;

			private int? bindUuidCount;

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

			public int? BindUuidCount
			{
				get
				{
					return bindUuidCount;
				}
				set	
				{
					bindUuidCount = value;
				}
			}
		}
	}
}
