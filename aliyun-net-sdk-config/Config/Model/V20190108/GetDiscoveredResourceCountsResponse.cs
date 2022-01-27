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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class GetDiscoveredResourceCountsResponse : AcsResponse
	{

		private string requestId;

		private GetDiscoveredResourceCounts_GroupedResourceCounts groupedResourceCounts;

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

		public GetDiscoveredResourceCounts_GroupedResourceCounts GroupedResourceCounts
		{
			get
			{
				return groupedResourceCounts;
			}
			set	
			{
				groupedResourceCounts = value;
			}
		}

		public class GetDiscoveredResourceCounts_GroupedResourceCounts
		{

			private string groupByKey;

			private List<GetDiscoveredResourceCounts_GroupedResourceCount> groupedResourceCountList;

			public string GroupByKey
			{
				get
				{
					return groupByKey;
				}
				set	
				{
					groupByKey = value;
				}
			}

			public List<GetDiscoveredResourceCounts_GroupedResourceCount> GroupedResourceCountList
			{
				get
				{
					return groupedResourceCountList;
				}
				set	
				{
					groupedResourceCountList = value;
				}
			}

			public class GetDiscoveredResourceCounts_GroupedResourceCount
			{

				private long? resourceCount;

				private string groupName;

				public long? ResourceCount
				{
					get
					{
						return resourceCount;
					}
					set	
					{
						resourceCount = value;
					}
				}

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}
			}
		}
	}
}
