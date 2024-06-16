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
	public class ListNetworkInterfacesResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListNetworkInterfaces_Content content;

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

		public ListNetworkInterfaces_Content Content
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

		public class ListNetworkInterfaces_Content
		{

			private long? total;

			private List<ListNetworkInterfaces_DataItem> data;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<ListNetworkInterfaces_DataItem> Data
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

			public class ListNetworkInterfaces_DataItem
			{

				private string tenantId;

				private string regionId;

				private string networkInterfaceId;

				private string nodeId;

				private string zoneId;

				private string ip;

				private string serviceMac;

				private string status;

				private string gateway;

				private string createTime;

				private int? quota;

				private string ncType;

				private string networkInterfaceName;

				private List<ListNetworkInterfaces_PrivateIpAddressMacGroupItem> privateIpAddressMacGroup;

				private List<string> ethernet;

				private ListNetworkInterfaces_VpdBaseInfo vpdBaseInfo;

				private ListNetworkInterfaces_SubnetBaseInfo subnetBaseInfo;

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
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

				public string NetworkInterfaceId
				{
					get
					{
						return networkInterfaceId;
					}
					set	
					{
						networkInterfaceId = value;
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

				public string ServiceMac
				{
					get
					{
						return serviceMac;
					}
					set	
					{
						serviceMac = value;
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

				public int? Quota
				{
					get
					{
						return quota;
					}
					set	
					{
						quota = value;
					}
				}

				public string NcType
				{
					get
					{
						return ncType;
					}
					set	
					{
						ncType = value;
					}
				}

				public string NetworkInterfaceName
				{
					get
					{
						return networkInterfaceName;
					}
					set	
					{
						networkInterfaceName = value;
					}
				}

				public List<ListNetworkInterfaces_PrivateIpAddressMacGroupItem> PrivateIpAddressMacGroup
				{
					get
					{
						return privateIpAddressMacGroup;
					}
					set	
					{
						privateIpAddressMacGroup = value;
					}
				}

				public List<string> Ethernet
				{
					get
					{
						return ethernet;
					}
					set	
					{
						ethernet = value;
					}
				}

				public ListNetworkInterfaces_VpdBaseInfo VpdBaseInfo
				{
					get
					{
						return vpdBaseInfo;
					}
					set	
					{
						vpdBaseInfo = value;
					}
				}

				public ListNetworkInterfaces_SubnetBaseInfo SubnetBaseInfo
				{
					get
					{
						return subnetBaseInfo;
					}
					set	
					{
						subnetBaseInfo = value;
					}
				}

				public class ListNetworkInterfaces_PrivateIpAddressMacGroupItem
				{

					private string ipName;

					private string privateIpAddress;

					private string ipAddressMac;

					private string status;

					private string description;

					private string message;

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

					public string IpAddressMac
					{
						get
						{
							return ipAddressMac;
						}
						set	
						{
							ipAddressMac = value;
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

				public class ListNetworkInterfaces_VpdBaseInfo
				{

					private string vpdId;

					private string vpdName;

					private string cidr;

					private string createTime;

					public string VpdId
					{
						get
						{
							return vpdId;
						}
						set	
						{
							vpdId = value;
						}
					}

					public string VpdName
					{
						get
						{
							return vpdName;
						}
						set	
						{
							vpdName = value;
						}
					}

					public string Cidr
					{
						get
						{
							return cidr;
						}
						set	
						{
							cidr = value;
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
				}

				public class ListNetworkInterfaces_SubnetBaseInfo
				{

					private string subnetId;

					private string subnetName;

					private string cidr;

					private string createTime;

					public string SubnetId
					{
						get
						{
							return subnetId;
						}
						set	
						{
							subnetId = value;
						}
					}

					public string SubnetName
					{
						get
						{
							return subnetName;
						}
						set	
						{
							subnetName = value;
						}
					}

					public string Cidr
					{
						get
						{
							return cidr;
						}
						set	
						{
							cidr = value;
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
				}
			}
		}
	}
}
