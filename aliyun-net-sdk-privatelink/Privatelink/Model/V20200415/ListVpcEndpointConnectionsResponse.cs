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
	public class ListVpcEndpointConnectionsResponse : AcsResponse
	{

		private string maxResults;

		private string nextToken;

		private string requestId;

		private List<ListVpcEndpointConnections_Connection> connections;

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

		public List<ListVpcEndpointConnections_Connection> Connections
		{
			get
			{
				return connections;
			}
			set	
			{
				connections = value;
			}
		}

		public class ListVpcEndpointConnections_Connection
		{

			private string serviceId;

			private string endpointId;

			private long? endpointOwnerId;

			private string connectionStatus;

			private string endpointVpcId;

			private int? bandwidth;

			private string modifiedTime;

			private bool? resourceOwner;

			private List<ListVpcEndpointConnections_Zone> zones;

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

			public long? EndpointOwnerId
			{
				get
				{
					return endpointOwnerId;
				}
				set	
				{
					endpointOwnerId = value;
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

			public string EndpointVpcId
			{
				get
				{
					return endpointVpcId;
				}
				set	
				{
					endpointVpcId = value;
				}
			}

			public int? Bandwidth
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

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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

			public List<ListVpcEndpointConnections_Zone> Zones
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

			public class ListVpcEndpointConnections_Zone
			{

				private string zoneId;

				private string eniId;

				private string zoneDomain;

				private string vSwitchId;

				private string resourceId;

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

				public string EniId
				{
					get
					{
						return eniId;
					}
					set	
					{
						eniId = value;
					}
				}

				public string ZoneDomain
				{
					get
					{
						return zoneDomain;
					}
					set	
					{
						zoneDomain = value;
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
			}
		}
	}
}
