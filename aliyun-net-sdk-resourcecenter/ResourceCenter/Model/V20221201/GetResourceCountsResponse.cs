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

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
	public class GetResourceCountsResponse : AcsResponse
	{

		private string groupByKey;

		private string requestId;

		private List<GetResourceCounts_Filter> filters;

		private List<GetResourceCounts_ResourceCount> resourceCounts;

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

		public List<GetResourceCounts_Filter> Filters
		{
			get
			{
				return filters;
			}
			set	
			{
				filters = value;
			}
		}

		public List<GetResourceCounts_ResourceCount> ResourceCounts
		{
			get
			{
				return resourceCounts;
			}
			set	
			{
				resourceCounts = value;
			}
		}

		public class GetResourceCounts_Filter
		{

			private string key;

			private List<string> values;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public List<string> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}
		}

		public class GetResourceCounts_ResourceCount
		{

			private long? count;

			private string groupName;

			public long? Count
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
