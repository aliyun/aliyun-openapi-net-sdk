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
	public class ListVpcEndpointServicesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string maxResults;

		private List<ListVpcEndpointServices_Service> services;

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

		public List<ListVpcEndpointServices_Service> Services
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

		public class ListVpcEndpointServices_Service
		{

			private bool? autoAcceptEnabled;

			private string serviceId;

			private string createTime;

			private int? minBandwidth;

			private int? maxBandwidth;

			private string serviceStatus;

			private bool? zoneAffinityEnabled;

			private string regionId;

			private string serviceDomain;

			private string payer;

			private string serviceBusinessStatus;

			private int? connectBandwidth;

			private string serviceName;

			private string serviceDescription;

			private string serviceResourceType;

			private string serviceType;

			public bool? AutoAcceptEnabled
			{
				get
				{
					return autoAcceptEnabled;
				}
				set	
				{
					autoAcceptEnabled = value;
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

			public int? MinBandwidth
			{
				get
				{
					return minBandwidth;
				}
				set	
				{
					minBandwidth = value;
				}
			}

			public int? MaxBandwidth
			{
				get
				{
					return maxBandwidth;
				}
				set	
				{
					maxBandwidth = value;
				}
			}

			public string ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
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

			public string ServiceBusinessStatus
			{
				get
				{
					return serviceBusinessStatus;
				}
				set	
				{
					serviceBusinessStatus = value;
				}
			}

			public int? ConnectBandwidth
			{
				get
				{
					return connectBandwidth;
				}
				set	
				{
					connectBandwidth = value;
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

			public string ServiceDescription
			{
				get
				{
					return serviceDescription;
				}
				set	
				{
					serviceDescription = value;
				}
			}

			public string ServiceResourceType
			{
				get
				{
					return serviceResourceType;
				}
				set	
				{
					serviceResourceType = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}
		}
	}
}
