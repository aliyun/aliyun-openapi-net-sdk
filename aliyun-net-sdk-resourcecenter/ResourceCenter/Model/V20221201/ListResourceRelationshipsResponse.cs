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
	public class ListResourceRelationshipsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private List<ListResourceRelationships_ResourceRelationship> resourceRelationships;

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

		public List<ListResourceRelationships_ResourceRelationship> ResourceRelationships
		{
			get
			{
				return resourceRelationships;
			}
			set	
			{
				resourceRelationships = value;
			}
		}

		public class ListResourceRelationships_ResourceRelationship
		{

			private string regionId;

			private string resourceType;

			private string resourceId;

			private string relatedResourceRegionId;

			private string relatedResourceType;

			private string relatedResourceId;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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

			public string RelatedResourceRegionId
			{
				get
				{
					return relatedResourceRegionId;
				}
				set	
				{
					relatedResourceRegionId = value;
				}
			}

			public string RelatedResourceType
			{
				get
				{
					return relatedResourceType;
				}
				set	
				{
					relatedResourceType = value;
				}
			}

			public string RelatedResourceId
			{
				get
				{
					return relatedResourceId;
				}
				set	
				{
					relatedResourceId = value;
				}
			}
		}
	}
}
