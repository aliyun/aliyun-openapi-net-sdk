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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class GetAccessKeyLastUsedResourcesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<GetAccessKeyLastUsedResources_ResourcesItem> resources;

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

		public List<GetAccessKeyLastUsedResources_ResourcesItem> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class GetAccessKeyLastUsedResources_ResourcesItem
		{

			private long? usedTimestamp;

			private string detail;

			private string resourceName;

			private string resourceType;

			private string source;

			public long? UsedTimestamp
			{
				get
				{
					return usedTimestamp;
				}
				set	
				{
					usedTimestamp = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public string ResourceName
			{
				get
				{
					return resourceName;
				}
				set	
				{
					resourceName = value;
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

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}
		}
	}
}
