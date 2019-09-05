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
	public class DescribeRuleAttributeResponse : AcsResponse
	{

		private string ruleId;

		private string requestId;

		private string ruleName;

		private string loadBalancerId;

		private string listenerPort;

		private string domain;

		private string url;

		private string vServerGroupId;

		private string listenerSync;

		private string scheduler;

		private string stickySession;

		private string stickySessionType;

		private int? cookieTimeout;

		private string cookie;

		private string healthCheck;

		private string healthCheckDomain;

		private string healthCheckURI;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckTimeout;

		private int? healthCheckInterval;

		private int? healthCheckConnectPort;

		private string healthCheckHttpCode;

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
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

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
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

		public string ListenerPort
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

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
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

		public string ListenerSync
		{
			get
			{
				return listenerSync;
			}
			set	
			{
				listenerSync = value;
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

		public string StickySession
		{
			get
			{
				return stickySession;
			}
			set	
			{
				stickySession = value;
			}
		}

		public string StickySessionType
		{
			get
			{
				return stickySessionType;
			}
			set	
			{
				stickySessionType = value;
			}
		}

		public int? CookieTimeout
		{
			get
			{
				return cookieTimeout;
			}
			set	
			{
				cookieTimeout = value;
			}
		}

		public string Cookie
		{
			get
			{
				return cookie;
			}
			set	
			{
				cookie = value;
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

		public int? HealthCheckTimeout
		{
			get
			{
				return healthCheckTimeout;
			}
			set	
			{
				healthCheckTimeout = value;
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
	}
}
