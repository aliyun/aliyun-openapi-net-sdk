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
	public class ListVpcEndpointsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string maxResults;

		private List<ListVpcEndpoints_Endpoint> endpoints;

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

		public List<ListVpcEndpoints_Endpoint> Endpoints
		{
			get
			{
				return endpoints;
			}
			set	
			{
				endpoints = value;
			}
		}

		public class ListVpcEndpoints_Endpoint
		{

			private string vpcId;

			private string endpointName;

			private string endpointType;

			private string createTime;

			private string serviceId;

			private bool? zoneAffinityEnabled;

			private string endpointDomain;

			private string endpointStatus;

			private string regionId;

			private bool? resourceOwner;

			private long? bandwidth;

			private string connectionStatus;

			private string endpointDescription;

			private string endpointId;

			private string endpointBusinessStatus;

			private string serviceName;

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

			public string EndpointName
			{
				get
				{
					return endpointName;
				}
				set	
				{
					endpointName = value;
				}
			}

			public string EndpointType
			{
				get
				{
					return endpointType;
				}
				set	
				{
					endpointType = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public bool? ZoneAffinityEnabled
			{
				get
				{
					return zoneAffinityEnabled;
				}
				set	
				{
					zoneAffinityEnabled = value;
				}
			}

			public string EndpointDomain
			{
				get
				{
					return endpointDomain;
				}
				set	
				{
					endpointDomain = value;
				}
			}

			public string EndpointStatus
			{
				get
				{
					return endpointStatus;
				}
				set	
				{
					endpointStatus = value;
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

			public bool? ResourceOwner
			{
				get
				{
					return resourceOwner;
				}
				set	
				{
					resourceOwner = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string ConnectionStatus
			{
				get
				{
					return connectionStatus;
				}
				set	
				{
					connectionStatus = value;
				}
			}

			public string EndpointDescription
			{
				get
				{
					return endpointDescription;
				}
				set	
				{
					endpointDescription = value;
				}
			}

			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

			public string EndpointBusinessStatus
			{
				get
				{
					return endpointBusinessStatus;
				}
				set	
				{
					endpointBusinessStatus = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}
		}
	}
}
