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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeClusterDevicesResponse : AcsResponse
	{

		private string requestId;

		private long? total;

		private List<DescribeClusterDevices_Device> devices;

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

		public List<DescribeClusterDevices_Device> Devices
		{
			get
			{
				return devices;
			}
			set	
			{
				devices = value;
			}
		}

		public class DescribeClusterDevices_Device
		{

			private string instanceId;

			private string edgeNodeName;

			private string platformType;

			private string status;

			private string macAddress;

			private string server;

			private string instanceChargeType;

			private bool? autoRenew;

			private int? autoRenewPeriod;

			private int? period;

			private string periodUnit;

			private List<DescribeClusterDevices_IpInfo> ipInfos;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string EdgeNodeName
			{
				get
				{
					return edgeNodeName;
				}
				set	
				{
					edgeNodeName = value;
				}
			}

			public string PlatformType
			{
				get
				{
					return platformType;
				}
				set	
				{
					platformType = value;
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

			public string MacAddress
			{
				get
				{
					return macAddress;
				}
				set	
				{
					macAddress = value;
				}
			}

			public string Server
			{
				get
				{
					return server;
				}
				set	
				{
					server = value;
				}
			}

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
				}
			}

			public bool? AutoRenew
			{
				get
				{
					return autoRenew;
				}
				set	
				{
					autoRenew = value;
				}
			}

			public int? AutoRenewPeriod
			{
				get
				{
					return autoRenewPeriod;
				}
				set	
				{
					autoRenewPeriod = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string PeriodUnit
			{
				get
				{
					return periodUnit;
				}
				set	
				{
					periodUnit = value;
				}
			}

			public List<DescribeClusterDevices_IpInfo> IpInfos
			{
				get
				{
					return ipInfos;
				}
				set	
				{
					ipInfos = value;
				}
			}

			public class DescribeClusterDevices_IpInfo
			{

				private string natType;

				private string externalIp;

				private string externalPort;

				private string internalIp;

				private string internalPort;

				private string ipProtocol;

				private string iSP;

				public string NatType
				{
					get
					{
						return natType;
					}
					set	
					{
						natType = value;
					}
				}

				public string ExternalIp
				{
					get
					{
						return externalIp;
					}
					set	
					{
						externalIp = value;
					}
				}

				public string ExternalPort
				{
					get
					{
						return externalPort;
					}
					set	
					{
						externalPort = value;
					}
				}

				public string InternalIp
				{
					get
					{
						return internalIp;
					}
					set	
					{
						internalIp = value;
					}
				}

				public string InternalPort
				{
					get
					{
						return internalPort;
					}
					set	
					{
						internalPort = value;
					}
				}

				public string IpProtocol
				{
					get
					{
						return ipProtocol;
					}
					set	
					{
						ipProtocol = value;
					}
				}

				public string ISP
				{
					get
					{
						return iSP;
					}
					set	
					{
						iSP = value;
					}
				}
			}
		}
	}
}
