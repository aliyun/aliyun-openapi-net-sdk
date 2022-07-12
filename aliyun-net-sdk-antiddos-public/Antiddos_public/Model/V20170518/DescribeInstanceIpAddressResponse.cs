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

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
	public class DescribeInstanceIpAddressResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeInstanceIpAddress_Instance> instanceList;

		public int? Total
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

		public List<DescribeInstanceIpAddress_Instance> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class DescribeInstanceIpAddress_Instance
		{

			private string instanceId;

			private string instanceType;

			private string instanceName;

			private string instanceStatus;

			private List<DescribeInstanceIpAddress_IpAddressConfigItem> ipAddressConfig;

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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public List<DescribeInstanceIpAddress_IpAddressConfigItem> IpAddressConfig
			{
				get
				{
					return ipAddressConfig;
				}
				set	
				{
					ipAddressConfig = value;
				}
			}

			public class DescribeInstanceIpAddress_IpAddressConfigItem
			{

				private string instanceIp;

				private bool? isBgppack;

				private string ipVersion;

				private string ipStatus;

				private string regionId;

				private int? elasticThreshold;

				private int? blackholeThreshold;

				private int? defenseBpsThreshold;

				private int? defensePpsThreshold;

				public string InstanceIp
				{
					get
					{
						return instanceIp;
					}
					set	
					{
						instanceIp = value;
					}
				}

				public bool? IsBgppack
				{
					get
					{
						return isBgppack;
					}
					set	
					{
						isBgppack = value;
					}
				}

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

				public string IpStatus
				{
					get
					{
						return ipStatus;
					}
					set	
					{
						ipStatus = value;
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

				public int? ElasticThreshold
				{
					get
					{
						return elasticThreshold;
					}
					set	
					{
						elasticThreshold = value;
					}
				}

				public int? BlackholeThreshold
				{
					get
					{
						return blackholeThreshold;
					}
					set	
					{
						blackholeThreshold = value;
					}
				}

				public int? DefenseBpsThreshold
				{
					get
					{
						return defenseBpsThreshold;
					}
					set	
					{
						defenseBpsThreshold = value;
					}
				}

				public int? DefensePpsThreshold
				{
					get
					{
						return defensePpsThreshold;
					}
					set	
					{
						defensePpsThreshold = value;
					}
				}
			}
		}
	}
}
