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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class CreateInstanceResponse : AcsResponse
	{

		private string vpcId;

		private long? qPS;

		private long? capacity;

		private string connectionDomain;

		private string chargeType;

		private string networkType;

		private string instanceId;

		private int? port;

		private string config;

		private string regionId;

		private string endTime;

		private string vSwitchId;

		private string requestId;

		private string nodeType;

		private long? connections;

		private long? bandwidth;

		private string instanceName;

		private string zoneId;

		private string instanceStatus;

		private string privateIpAddr;

		private string userName;

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

		public long? QPS
		{
			get
			{
				return qPS;
			}
			set	
			{
				qPS = value;
			}
		}

		public long? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
			}
		}

		public string ConnectionDomain
		{
			get
			{
				return connectionDomain;
			}
			set	
			{
				connectionDomain = value;
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
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

		public int? Port
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

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
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

		public string NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
			}
		}

		public long? Connections
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

		public long? Bandwidth
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

		public string PrivateIpAddr
		{
			get
			{
				return privateIpAddr;
			}
			set	
			{
				privateIpAddr = value;
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}
	}
}
