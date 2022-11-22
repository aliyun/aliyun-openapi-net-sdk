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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceEndpointsResponse : AcsResponse
	{

		private string requestId;

		private DescribeDBInstanceEndpoints_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribeDBInstanceEndpoints_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeDBInstanceEndpoints_Data
		{

			private string dBInstanceName;

			private string ipVersion;

			private List<DescribeDBInstanceEndpoints_DBInstanceEndpoint> dBInstanceEndpoints;

			[JsonProperty(PropertyName = "DBInstanceName")]
			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			[JsonProperty(PropertyName = "IpVersion")]
			public string IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceEndpoints")]
			public List<DescribeDBInstanceEndpoints_DBInstanceEndpoint> DBInstanceEndpoints
			{
				get
				{
					return dBInstanceEndpoints;
				}
				set	
				{
					dBInstanceEndpoints = value;
				}
			}

			public class DescribeDBInstanceEndpoints_DBInstanceEndpoint
			{

				private string endpointId;

				private string endpointType;

				private string endpointDescription;

				private List<DescribeDBInstanceEndpoints_NodeItem> nodeItems;

				private List<DescribeDBInstanceEndpoints_AddressItem> addressItems;

				[JsonProperty(PropertyName = "EndpointId")]
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

				[JsonProperty(PropertyName = "EndpointType")]
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

				[JsonProperty(PropertyName = "EndpointDescription")]
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

				[JsonProperty(PropertyName = "NodeItems")]
				public List<DescribeDBInstanceEndpoints_NodeItem> NodeItems
				{
					get
					{
						return nodeItems;
					}
					set	
					{
						nodeItems = value;
					}
				}

				[JsonProperty(PropertyName = "AddressItems")]
				public List<DescribeDBInstanceEndpoints_AddressItem> AddressItems
				{
					get
					{
						return addressItems;
					}
					set	
					{
						addressItems = value;
					}
				}

				public class DescribeDBInstanceEndpoints_NodeItem
				{

					private string nodeId;

					private string dBInstanceId;

					private int? weight;

					[JsonProperty(PropertyName = "NodeId")]
					public string NodeId
					{
						get
						{
							return nodeId;
						}
						set	
						{
							nodeId = value;
						}
					}

					[JsonProperty(PropertyName = "DBInstanceId")]
					public string DBInstanceId
					{
						get
						{
							return dBInstanceId;
						}
						set	
						{
							dBInstanceId = value;
						}
					}

					[JsonProperty(PropertyName = "Weight")]
					public int? Weight
					{
						get
						{
							return weight;
						}
						set	
						{
							weight = value;
						}
					}
				}

				public class DescribeDBInstanceEndpoints_AddressItem
				{

					private string vpcId;

					private string vSwitchId;

					private string ipType;

					private string port;

					private string connectionString;

					private string ipAddress;

					[JsonProperty(PropertyName = "VpcId")]
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

					[JsonProperty(PropertyName = "VSwitchId")]
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

					[JsonProperty(PropertyName = "IpType")]
					public string IpType
					{
						get
						{
							return ipType;
						}
						set	
						{
							ipType = value;
						}
					}

					[JsonProperty(PropertyName = "Port")]
					public string Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}

					[JsonProperty(PropertyName = "ConnectionString")]
					public string ConnectionString
					{
						get
						{
							return connectionString;
						}
						set	
						{
							connectionString = value;
						}
					}

					[JsonProperty(PropertyName = "IpAddress")]
					public string IpAddress
					{
						get
						{
							return ipAddress;
						}
						set	
						{
							ipAddress = value;
						}
					}
				}
			}
		}
	}
}
