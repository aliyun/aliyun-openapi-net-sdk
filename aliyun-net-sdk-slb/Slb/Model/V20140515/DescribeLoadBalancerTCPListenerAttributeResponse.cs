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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeLoadBalancerTCPListenerAttributeResponse : AcsResponse
	{

		private string aclId;

		private string aclStatus;

		private string aclType;

		private int? backendServerPort;

		private int? bandwidth;

		private string connectionDrain;

		private int? connectionDrainTimeout;

		private string description;

		private int? establishedTimeout;

		private string failoverStrategy;

		private int? failoverThreshold;

		private string healthCheck;

		private int? healthCheckConnectPort;

		private int? healthCheckConnectTimeout;

		private string healthCheckDomain;

		private string healthCheckHttpCode;

		private int? healthCheckInterval;

		private string healthCheckMethod;

		private bool? healthCheckTcpFastCloseEnabled;

		private string healthCheckType;

		private string healthCheckURI;

		private int? healthyThreshold;

		private int? listenerPort;

		private string masterServerGroupId;

		private bool? masterSlaveModeEnabled;

		private string masterSlaveServerGroupId;

		private int? maxConnection;

		private int? persistenceTimeout;

		private bool? proxyProtocolV2Enabled;

		private string requestId;

		private string scheduler;

		private string slaveServerGroupId;

		private string status;

		private string synProxy;

		private int? unhealthyThreshold;

		private string vServerGroupId;

		private string vpcIds;

		private string workingServerGroupId;

		private List<DescribeLoadBalancerTCPListenerAttribute_PortRange> portRanges;

		private List<string> aclIds;

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
			}
		}

		public int? BackendServerPort
		{
			get
			{
				return backendServerPort;
			}
			set	
			{
				backendServerPort = value;
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

		public string ConnectionDrain
		{
			get
			{
				return connectionDrain;
			}
			set	
			{
				connectionDrain = value;
			}
		}

		public int? ConnectionDrainTimeout
		{
			get
			{
				return connectionDrainTimeout;
			}
			set	
			{
				connectionDrainTimeout = value;
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

		public int? EstablishedTimeout
		{
			get
			{
				return establishedTimeout;
			}
			set	
			{
				establishedTimeout = value;
			}
		}

		public string FailoverStrategy
		{
			get
			{
				return failoverStrategy;
			}
			set	
			{
				failoverStrategy = value;
			}
		}

		public int? FailoverThreshold
		{
			get
			{
				return failoverThreshold;
			}
			set	
			{
				failoverThreshold = value;
			}
		}

		public string HealthCheck
		{
			get
			{
				return healthCheck;
			}
			set	
			{
				healthCheck = value;
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
			}
		}

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return healthCheckConnectTimeout;
			}
			set	
			{
				healthCheckConnectTimeout = value;
			}
		}

		public string HealthCheckDomain
		{
			get
			{
				return healthCheckDomain;
			}
			set	
			{
				healthCheckDomain = value;
			}
		}

		public string HealthCheckHttpCode
		{
			get
			{
				return healthCheckHttpCode;
			}
			set	
			{
				healthCheckHttpCode = value;
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
			}
		}

		public string HealthCheckMethod
		{
			get
			{
				return healthCheckMethod;
			}
			set	
			{
				healthCheckMethod = value;
			}
		}

		public bool? HealthCheckTcpFastCloseEnabled
		{
			get
			{
				return healthCheckTcpFastCloseEnabled;
			}
			set	
			{
				healthCheckTcpFastCloseEnabled = value;
			}
		}

		public string HealthCheckType
		{
			get
			{
				return healthCheckType;
			}
			set	
			{
				healthCheckType = value;
			}
		}

		public string HealthCheckURI
		{
			get
			{
				return healthCheckURI;
			}
			set	
			{
				healthCheckURI = value;
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
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

		public string MasterServerGroupId
		{
			get
			{
				return masterServerGroupId;
			}
			set	
			{
				masterServerGroupId = value;
			}
		}

		public bool? MasterSlaveModeEnabled
		{
			get
			{
				return masterSlaveModeEnabled;
			}
			set	
			{
				masterSlaveModeEnabled = value;
			}
		}

		public string MasterSlaveServerGroupId
		{
			get
			{
				return masterSlaveServerGroupId;
			}
			set	
			{
				masterSlaveServerGroupId = value;
			}
		}

		public int? MaxConnection
		{
			get
			{
				return maxConnection;
			}
			set	
			{
				maxConnection = value;
			}
		}

		public int? PersistenceTimeout
		{
			get
			{
				return persistenceTimeout;
			}
			set	
			{
				persistenceTimeout = value;
			}
		}

		public bool? ProxyProtocolV2Enabled
		{
			get
			{
				return proxyProtocolV2Enabled;
			}
			set	
			{
				proxyProtocolV2Enabled = value;
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

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
			}
		}

		public string SlaveServerGroupId
		{
			get
			{
				return slaveServerGroupId;
			}
			set	
			{
				slaveServerGroupId = value;
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

		public string SynProxy
		{
			get
			{
				return synProxy;
			}
			set	
			{
				synProxy = value;
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
			}
		}

		public string VpcIds
		{
			get
			{
				return vpcIds;
			}
			set	
			{
				vpcIds = value;
			}
		}

		public string WorkingServerGroupId
		{
			get
			{
				return workingServerGroupId;
			}
			set	
			{
				workingServerGroupId = value;
			}
		}

		public List<DescribeLoadBalancerTCPListenerAttribute_PortRange> PortRanges
		{
			get
			{
				return portRanges;
			}
			set	
			{
				portRanges = value;
			}
		}

		public List<string> AclIds
		{
			get
			{
				return aclIds;
			}
			set	
			{
				aclIds = value;
			}
		}

		public class DescribeLoadBalancerTCPListenerAttribute_PortRange
		{

			private int? endPort;

			private int? startPort;

			public int? EndPort
			{
				get
				{
					return endPort;
				}
				set	
				{
					endPort = value;
				}
			}

			public int? StartPort
			{
				get
				{
					return startPort;
				}
				set	
				{
					startPort = value;
				}
			}
		}
	}
}
