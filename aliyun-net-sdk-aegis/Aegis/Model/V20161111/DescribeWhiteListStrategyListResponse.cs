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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeWhiteListStrategyListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeWhiteListStrategyList_Strategy> strategies;

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

		public List<DescribeWhiteListStrategyList_Strategy> Strategies
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

		public class DescribeWhiteListStrategyList_Strategy
		{

			private long? strategyId;

			private string strategyName;

			private int? studyTime;

			private int? status;

			public long? StrategyId
			{
				get
				{
					return strategyId;
				}
				set	
				{
					strategyId = value;
				}
			}

			public string StrategyName
			{
				get
				{
					return strategyName;
				}
				set	
				{
					strategyName = value;
				}
			}

			public int? StudyTime
			{
				get
				{
					return studyTime;
				}
				set	
				{
					studyTime = value;
				}
			}

			public int? Status
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
		}
	}
}
