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

namespace Aliyun.Acs.Slb.Model.V20130221
{
	public class DescribeLoadBalancerAttributeResponse : AcsResponse
	{

		private string vpcId;

		private long? createTimeStamp;

		private string loadBalancerSpec;

		private long? autoReleaseTime;

		private string isPublicAddress;

		private string createTime;

		private string loadBalancerId;

		private string payType;

		private string addressType;

		private string networkType;

		private string regionId;

		private string endTime;

		private string vSwitchId;

		private string requestId;

		private int? bandwidth;

		private string loadBalancerStatus;

		private string loadBalancerName;

		private string internetChargeType;

		private string address;

		private string slaveZoneId;

		private long? endTimeStamp;

		private string regionIdAlias;

		private string masterZoneId;

		private List<DescribeLoadBalancerAttribute_ListenerPortAndProtocal> listenerPortsAndProtocal;

		private List<DescribeLoadBalancerAttribute_ListenerPortAndProtocol> listenerPortsAndProtocol;

		private List<DescribeLoadBalancerAttribute_BackendServer> backendServers;

		private List<string> listenerPorts;

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

		public long? CreateTimeStamp
		{
			get
			{
				return createTimeStamp;
			}
			set	
			{
				createTimeStamp = value;
			}
		}

		public string LoadBalancerSpec
		{
			get
			{
				return loadBalancerSpec;
			}
			set	
			{
				loadBalancerSpec = value;
			}
		}

		public long? AutoReleaseTime
		{
			get
			{
				return autoReleaseTime;
			}
			set	
			{
				autoReleaseTime = value;
			}
		}

		public string IsPublicAddress
		{
			get
			{
				return isPublicAddress;
			}
			set	
			{
				isPublicAddress = value;
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

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
			}
		}

		public string AddressType
		{
			get
			{
				return addressType;
			}
			set	
			{
				addressType = value;
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		public string LoadBalancerStatus
		{
			get
			{
				return loadBalancerStatus;
			}
			set	
			{
				loadBalancerStatus = value;
			}
		}

		public string LoadBalancerName
		{
			get
			{
				return loadBalancerName;
			}
			set	
			{
				loadBalancerName = value;
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
			}
		}

		public string SlaveZoneId
		{
			get
			{
				return slaveZoneId;
			}
			set	
			{
				slaveZoneId = value;
			}
		}

		public long? EndTimeStamp
		{
			get
			{
				return endTimeStamp;
			}
			set	
			{
				endTimeStamp = value;
			}
		}

		public string RegionIdAlias
		{
			get
			{
				return regionIdAlias;
			}
			set	
			{
				regionIdAlias = value;
			}
		}

		public string MasterZoneId
		{
			get
			{
				return masterZoneId;
			}
			set	
			{
				masterZoneId = value;
			}
		}

		public List<DescribeLoadBalancerAttribute_ListenerPortAndProtocal> ListenerPortsAndProtocal
		{
			get
			{
				return listenerPortsAndProtocal;
			}
			set	
			{
				listenerPortsAndProtocal = value;
			}
		}

		public List<DescribeLoadBalancerAttribute_ListenerPortAndProtocol> ListenerPortsAndProtocol
		{
			get
			{
				return listenerPortsAndProtocol;
			}
			set	
			{
				listenerPortsAndProtocol = value;
			}
		}

		public List<DescribeLoadBalancerAttribute_BackendServer> BackendServers
		{
			get
			{
				return backendServers;
			}
			set	
			{
				backendServers = value;
			}
		}

		public List<string> ListenerPorts
		{
			get
			{
				return listenerPorts;
			}
			set	
			{
				listenerPorts = value;
			}
		}

		public class DescribeLoadBalancerAttribute_ListenerPortAndProtocal
		{

			private string listenerProtocal;

			private int? listenerPort;

			public string ListenerProtocal
			{
				get
				{
					return listenerProtocal;
				}
				set	
				{
					listenerProtocal = value;
				}
			}

			public int? ListenerPort
			{
				get
				{
					return listenerPort;
				}
				set	
				{
					listenerPort = value;
				}
			}
		}

		public class DescribeLoadBalancerAttribute_ListenerPortAndProtocol
		{

			private int? listenerPort;

			private string listenerProtocol;

			public int? ListenerPort
			{
				get
				{
					return listenerPort;
				}
				set	
				{
					listenerPort = value;
				}
			}

			public string ListenerProtocol
			{
				get
				{
					return listenerProtocol;
				}
				set	
				{
					listenerProtocol = value;
				}
			}
		}

		public class DescribeLoadBalancerAttribute_BackendServer
		{

			private int? weight;

			private string serverId;

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

			public string ServerId
			{
				get
				{
					return serverId;
				}
				set	
				{
					serverId = value;
				}
			}
		}
	}
}
