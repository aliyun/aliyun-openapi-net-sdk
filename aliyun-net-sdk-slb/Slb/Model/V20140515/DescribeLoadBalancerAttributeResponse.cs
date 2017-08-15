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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeLoadBalancerAttributeResponse : AcsResponse
	{

		private string requestId;

		private string loadBalancerId;

		private string resourceGroupId;

		private string loadBalancerName;

		private string loadBalancerStatus;

		private string regionId;

		private string regionIdAlias;

		private string address;

		private string addressType;

		private string vpcId;

		private string vSwitchId;

		private string networkType;

		private string internetChargeType;

		private long? autoReleaseTime;

		private int? bandwidth;

		private string loadBalancerSpec;

		private string createTime;

		private long? createTimeStamp;

		private string endTime;

		private long? endTimeStamp;

		private string payType;

		private string masterZoneId;

		private string slaveZoneId;

		private List<DescribeLoadBalancerAttribute_ListenerPortAndProtocal> listenerPortsAndProtocal;

		private List<DescribeLoadBalancerAttribute_ListenerPortAndProtocol> listenerPortsAndProtocol;

		private List<DescribeLoadBalancerAttribute_BackendServer> backendServers;

		private List<string> listenerPorts;

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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
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

			private int? listenerPort;

			private string listenerProtocal;

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

			private string serverId;

			private int? weight;

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
	}
}