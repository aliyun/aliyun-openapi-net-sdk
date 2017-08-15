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
	public class DescribeLoadBalancerTCPListenerAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? listenerPort;

		private int? backendServerPort;

		private string status;

		private int? bandwidth;

		private string scheduler;

		private string synProxy;

		private int? persistenceTimeout;

		private int? establishedTimeout;

		private string healthCheck;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckConnectTimeout;

		private int? healthCheckConnectPort;

		private int? healthCheckInterval;

		private string healthCheckHttpCode;

		private string healthCheckDomain;

		private string healthCheckURI;

		private string healthCheckType;

		private int? maxConnection;

		private string vServerGroupId;

		private string masterSlaveServerGroupId;

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
	}
}