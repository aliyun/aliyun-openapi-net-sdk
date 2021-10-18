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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class ListTagResourcesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private List<ListTagResources_TagResource> tagResources;

		[JsonProperty(PropertyName = "NextToken")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TagResources")]
		public List<ListTagResources_TagResource> TagResources
		{
			get
			{
				return tagResources;
			}
			set	
			{
				tagResources = value;
			}
		}

		public class ListTagResources_TagResource
		{

			private string tagValue;

			private string resourceType;

			private string resourceId;

			private string tagKey;

			[JsonProperty(PropertyName = "TagValue")]
			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceType")]
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

			[JsonProperty(PropertyName = "ResourceId")]
			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			[JsonProperty(PropertyName = "TagKey")]
			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}
		}
	}
}
