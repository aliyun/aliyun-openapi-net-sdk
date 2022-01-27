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
	public class DescribeBruteForceSummaryResponse : AcsResponse
	{

		private string requestId;

		private DescribeBruteForceSummary_BruteForceSummary bruteForceSummary;

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

		public DescribeBruteForceSummary_BruteForceSummary BruteForceSummary
		{
			get
			{
				return bruteForceSummary;
			}
			set	
			{
				bruteForceSummary = value;
			}
		}

		public class DescribeBruteForceSummary_BruteForceSummary
		{

			private int? allStrategyCount;

			private int? effectiveCount;

			public int? AllStrategyCount
			{
				get
				{
					return allStrategyCount;
				}
				set	
				{
					allStrategyCount = value;
				}
			}

			public int? EffectiveCount
			{
				get
				{
					return effectiveCount;
				}
				set	
				{
					effectiveCount = value;
				}
			}
		}
	}
}
