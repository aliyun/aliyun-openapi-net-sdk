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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListVpcGatewayEndpointsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private long? totalCount;

		private long? maxResults;

		private List<ListVpcGatewayEndpoints_Endpoint> endpoints;

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

		public long? TotalCount
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

		public long? MaxResults
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

		public List<ListVpcGatewayEndpoints_Endpoint> Endpoints
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

		public class ListVpcGatewayEndpoints_Endpoint
		{

			private string endpointId;

			private string endpointName;

			private string endpointDescription;

			private string serviceName;

			private string vpcId;

			private string policyDocument;

			private string creationTime;

			private string endpointStatus;

			private List<string> associatedRouteTables;

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

			public string PolicyDocument
			{
				get
				{
					return policyDocument;
				}
				set	
				{
					policyDocument = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public List<string> AssociatedRouteTables
			{
				get
				{
					return associatedRouteTables;
				}
				set	
				{
					associatedRouteTables = value;
				}
			}
		}
	}
}
