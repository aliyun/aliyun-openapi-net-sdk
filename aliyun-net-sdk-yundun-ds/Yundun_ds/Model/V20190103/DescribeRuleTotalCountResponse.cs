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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeRuleTotalCountResponse : AcsResponse
	{

		private string requestId;

		private DescribeRuleTotalCount_RuleCount ruleCount;

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

		public DescribeRuleTotalCount_RuleCount RuleCount
		{
			get
			{
				return ruleCount;
			}
			set	
			{
				ruleCount = value;
			}
		}

		public class DescribeRuleTotalCount_RuleCount
		{

			private long? totalCount;

			private List<DescribeRuleTotalCount_CategoryCount> categoryCountList;

			public long? TotalCount
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

			public List<DescribeRuleTotalCount_CategoryCount> CategoryCountList
			{
				get
				{
					return categoryCountList;
				}
				set	
				{
					categoryCountList = value;
				}
			}

			public class DescribeRuleTotalCount_CategoryCount
			{

				private string name;

				private string count;

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

				public string Count
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
			}
		}
	}
}
