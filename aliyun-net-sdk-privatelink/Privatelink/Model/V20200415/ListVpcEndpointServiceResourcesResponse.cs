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

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
	public class ListVpcEndpointServiceResourcesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string maxResults;

		private List<ListVpcEndpointServiceResources_Resource> resources;

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

		public string MaxResults
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

		public List<ListVpcEndpointServiceResources_Resource> Resources
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

		public class ListVpcEndpointServiceResources_Resource
		{

			private string vpcId;

			private string vSwitchId;

			private string resourceType;

			private string zoneId;

			private string ip;

			private string resourceId;

			private string regionId;

			private long? relatedEndpointCount;

			private bool? autoAllocatedEnabled;

			private string statusInfo;

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
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

			public long? RelatedEndpointCount
			{
				get
				{
					return relatedEndpointCount;
				}
				set	
				{
					relatedEndpointCount = value;
				}
			}

			public bool? AutoAllocatedEnabled
			{
				get
				{
					return autoAllocatedEnabled;
				}
				set	
				{
					autoAllocatedEnabled = value;
				}
			}

			public string StatusInfo
			{
				get
				{
					return statusInfo;
				}
				set	
				{
					statusInfo = value;
				}
			}
		}
	}
}
