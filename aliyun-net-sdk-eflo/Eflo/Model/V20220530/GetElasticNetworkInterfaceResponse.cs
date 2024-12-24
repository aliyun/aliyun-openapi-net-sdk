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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetElasticNetworkInterfaceResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetElasticNetworkInterface_Content content;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public GetElasticNetworkInterface_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class GetElasticNetworkInterface_Content
		{

			private string regionId;

			private string zoneId;

			private string elasticNetworkInterfaceId;

			private string nodeId;

			private string status;

			private string ip;

			private string vpcId;

			private string vSwitchId;

			private string message;

			private string mac;

			private string type;

			private string gateway;

			private string mask;

			private string createTime;

			private string gmtModified;

			private string description;

			private string securityGroupId;

			private bool? enableJumboFrame;

			private List<GetElasticNetworkInterface_PrivateIpAddress> privateIpAddresses;

			private List<GetElasticNetworkInterface_Ipv6Addresse> ipv6Addresses;

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

			public string ElasticNetworkInterfaceId
			{
				get
				{
					return elasticNetworkInterfaceId;
				}
				set	
				{
					elasticNetworkInterfaceId = value;
				}
			}

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

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public string Mac
			{
				get
				{
					return mac;
				}
				set	
				{
					mac = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Gateway
			{
				get
				{
					return gateway;
				}
				set	
				{
					gateway = value;
				}
			}

			public string Mask
			{
				get
				{
					return mask;
				}
				set	
				{
					mask = value;
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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public bool? EnableJumboFrame
			{
				get
				{
					return enableJumboFrame;
				}
				set	
				{
					enableJumboFrame = value;
				}
			}

			public List<GetElasticNetworkInterface_PrivateIpAddress> PrivateIpAddresses
			{
				get
				{
					return privateIpAddresses;
				}
				set	
				{
					privateIpAddresses = value;
				}
			}

			public List<GetElasticNetworkInterface_Ipv6Addresse> Ipv6Addresses
			{
				get
				{
					return ipv6Addresses;
				}
				set	
				{
					ipv6Addresses = value;
				}
			}

			public class GetElasticNetworkInterface_PrivateIpAddress
			{

				private string elasticNetworkInterfaceId;

				private string regionId;

				private string gmtCreate;

				private string gmtModified;

				private string ipName;

				private string privateIpAddress;

				private string status;

				private string description;

				private string message;

				public string ElasticNetworkInterfaceId
				{
					get
					{
						return elasticNetworkInterfaceId;
					}
					set	
					{
						elasticNetworkInterfaceId = value;
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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string IpName
				{
					get
					{
						return ipName;
					}
					set	
					{
						ipName = value;
					}
				}

				public string PrivateIpAddress
				{
					get
					{
						return privateIpAddress;
					}
					set	
					{
						privateIpAddress = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}
			}

			public class GetElasticNetworkInterface_Ipv6Addresse
			{

				private string elasticNetworkInterfaceId;

				private string ipName;

				private string ipv6Address;

				private string status;

				private string description;

				private string message;

				private string regionId;

				private string gmtCreate;

				private string gmtModified;

				public string ElasticNetworkInterfaceId
				{
					get
					{
						return elasticNetworkInterfaceId;
					}
					set	
					{
						elasticNetworkInterfaceId = value;
					}
				}

				public string IpName
				{
					get
					{
						return ipName;
					}
					set	
					{
						ipName = value;
					}
				}

				public string Ipv6Address
				{
					get
					{
						return ipv6Address;
					}
					set	
					{
						ipv6Address = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}
			}
		}
	}
}
