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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOpenApiRcpStatsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeOpenApiRcpStats_Stat> statList;

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

		public List<DescribeOpenApiRcpStats_Stat> StatList
		{
			get
			{
				return statList;
			}
			set	
			{
				statList = value;
			}
		}

		public class DescribeOpenApiRcpStats_Stat
		{

			private string resourceType;

			private int? passCount;

			private string date;

			private int? totalCount;

			private int? blockCount;

			private int? totalDuration;

			private int? reviewCount;

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public int? PassCount
			{
				get
				{
					return passCount;
				}
				set	
				{
					passCount = value;
				}
			}

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
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

			public int? BlockCount
			{
				get
				{
					return blockCount;
				}
				set	
				{
					blockCount = value;
				}
			}

			public int? TotalDuration
			{
				get
				{
					return totalDuration;
				}
				set	
				{
					totalDuration = value;
				}
			}

			public int? ReviewCount
			{
				get
				{
					return reviewCount;
				}
				set	
				{
					reviewCount = value;
				}
			}
		}
	}
}
