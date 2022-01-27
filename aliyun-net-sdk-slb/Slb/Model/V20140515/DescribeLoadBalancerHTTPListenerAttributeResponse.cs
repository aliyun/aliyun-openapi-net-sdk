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
	public class DescribeLoadBalancerHTTPListenerAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? listenerPort;

		private int? backendServerPort;

		private int? bandwidth;

		private string status;

		private string securityStatus;

		private string xForwardedFor;

		private string scheduler;

		private string stickySession;

		private string stickySessionType;

		private int? cookieTimeout;

		private string cookie;

		private string healthCheck;

		private string healthCheckType;

		private string healthCheckDomain;

		private string healthCheckURI;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckTimeout;

		private int? healthCheckInterval;

		private int? healthCheckConnectPort;

		private string healthCheckHttpCode;

		private string healthCheckMethod;

		private string healthCheckHttpVersion;

		private int? maxConnection;

		private string vServerGroupId;

		private string gzip;

		private string xForwardedFor_SLBIP;

		private string xForwardedFor_SLBID;

		private string xForwardedFor_proto;

		private string aclId;

		private string aclType;

		private string aclStatus;

		private string vpcIds;

		private string listenerForward;

		private int? forwardPort;

		private int? requestTimeout;

		private int? idleTimeout;

		private string description;

		private string xForwardedFor_SLBPORT;

		private string xForwardedFor_ClientSrcPort;

		private int? forwardCode;

		private List<DescribeLoadBalancerHTTPListenerAttribute_Rule> rules;

		private List<string> aclIds;

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

		public string SecurityStatus
		{
			get
			{
				return securityStatus;
			}
			set	
			{
				securityStatus = value;
			}
		}

		public string XForwardedFor
		{
			get
			{
				return xForwardedFor;
			}
			set	
			{
				xForwardedFor = value;
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

		public string HealthCheckHttpVersion
		{
			get
			{
				return healthCheckHttpVersion;
			}
			set	
			{
				healthCheckHttpVersion = value;
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

		public string Gzip
		{
			get
			{
				return gzip;
			}
			set	
			{
				gzip = value;
			}
		}

		public string XForwardedFor_SLBIP
		{
			get
			{
				return xForwardedFor_SLBIP;
			}
			set	
			{
				xForwardedFor_SLBIP = value;
			}
		}

		public string XForwardedFor_SLBID
		{
			get
			{
				return xForwardedFor_SLBID;
			}
			set	
			{
				xForwardedFor_SLBID = value;
			}
		}

		public string XForwardedFor_proto
		{
			get
			{
				return xForwardedFor_proto;
			}
			set	
			{
				xForwardedFor_proto = value;
			}
		}

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

		public string ListenerForward
		{
			get
			{
				return listenerForward;
			}
			set	
			{
				listenerForward = value;
			}
		}

		public int? ForwardPort
		{
			get
			{
				return forwardPort;
			}
			set	
			{
				forwardPort = value;
			}
		}

		public int? RequestTimeout
		{
			get
			{
				return requestTimeout;
			}
			set	
			{
				requestTimeout = value;
			}
		}

		public int? IdleTimeout
		{
			get
			{
				return idleTimeout;
			}
			set	
			{
				idleTimeout = value;
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

		public string XForwardedFor_SLBPORT
		{
			get
			{
				return xForwardedFor_SLBPORT;
			}
			set	
			{
				xForwardedFor_SLBPORT = value;
			}
		}

		public string XForwardedFor_ClientSrcPort
		{
			get
			{
				return xForwardedFor_ClientSrcPort;
			}
			set	
			{
				xForwardedFor_ClientSrcPort = value;
			}
		}

		public int? ForwardCode
		{
			get
			{
				return forwardCode;
			}
			set	
			{
				forwardCode = value;
			}
		}

		public List<DescribeLoadBalancerHTTPListenerAttribute_Rule> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
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

		public class DescribeLoadBalancerHTTPListenerAttribute_Rule
		{

			private string ruleId;

			private string ruleName;

			private string domain;

			private string url;

			private string vServerGroupId;

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
		}
	}
}
