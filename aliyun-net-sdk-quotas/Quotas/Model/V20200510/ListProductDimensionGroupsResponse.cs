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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListProductDimensionGroupsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListProductDimensionGroups_DimensionGroupsItem> dimensionGroups;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListProductDimensionGroups_DimensionGroupsItem> DimensionGroups
		{
			get
			{
				return dimensionGroups;
			}
			set	
			{
				dimensionGroups = value;
			}
		}

		public class ListProductDimensionGroups_DimensionGroupsItem
		{

			private string groupName;

			private string productCode;

			private string groupCode;

			private List<string> dimensionKeys;

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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string GroupCode
			{
				get
				{
					return groupCode;
				}
				set	
				{
					groupCode = value;
				}
			}

			public List<string> DimensionKeys
			{
				get
				{
					return dimensionKeys;
				}
				set	
				{
					dimensionKeys = value;
				}
			}
		}
	}
}
