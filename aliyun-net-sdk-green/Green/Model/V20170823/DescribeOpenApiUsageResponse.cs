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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOpenApiUsageResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeOpenApiUsage_OpenApiUsage> openApiUsageList;

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

		public List<DescribeOpenApiUsage_OpenApiUsage> OpenApiUsageList
		{
			get
			{
				return openApiUsageList;
			}
			set	
			{
				openApiUsageList = value;
			}
		}

		public class DescribeOpenApiUsage_OpenApiUsage
		{

			private string date;

			private string resourceType;

			private string scene;

			private int? totalCount;

			private int? passCount;

			private int? reviewCount;

			private int? blockCount;

			private int? innerTotalCount;

			private int? outerTotalCount;

			private int? totalDuration;

			private int? passDuration;

			private int? reviewDuration;

			private int? blockDuration;

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

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
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

			public int? InnerTotalCount
			{
				get
				{
					return innerTotalCount;
				}
				set	
				{
					innerTotalCount = value;
				}
			}

			public int? OuterTotalCount
			{
				get
				{
					return outerTotalCount;
				}
				set	
				{
					outerTotalCount = value;
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

			public int? PassDuration
			{
				get
				{
					return passDuration;
				}
				set	
				{
					passDuration = value;
				}
			}

			public int? ReviewDuration
			{
				get
				{
					return reviewDuration;
				}
				set	
				{
					reviewDuration = value;
				}
			}

			public int? BlockDuration
			{
				get
				{
					return blockDuration;
				}
				set	
				{
					blockDuration = value;
				}
			}
		}
	}
}
