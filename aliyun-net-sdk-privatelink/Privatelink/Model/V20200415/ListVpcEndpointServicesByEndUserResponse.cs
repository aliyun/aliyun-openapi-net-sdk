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

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
	public class ListVpcEndpointServicesByEndUserResponse : AcsResponse
	{

		private string maxResults;

		private string nextToken;

		private string requestId;

		private List<ListVpcEndpointServicesByEndUser_Service> services;

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

		public List<ListVpcEndpointServicesByEndUser_Service> Services
		{
			get
			{
				return services;
			}
			set	
			{
				services = value;
			}
		}

		public class ListVpcEndpointServicesByEndUser_Service
		{

			private string serviceDomain;

			private string serviceId;

			private string serviceName;

			private string payer;

			private List<string> zones;

			public string ServiceDomain
			{
				get
				{
					return serviceDomain;
				}
				set	
				{
					serviceDomain = value;
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

			public string Payer
			{
				get
				{
					return payer;
				}
				set	
				{
					payer = value;
				}
			}

			public List<string> Zones
			{
				get
				{
					return zones;
				}
				set	
				{
					zones = value;
				}
			}
		}
	}
}
