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
	public class DescribeLoadBalancerListenersResponse : AcsResponse
	{

		private int? maxResults;

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private List<DescribeLoadBalancerListeners_Listener> listeners;

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeLoadBalancerListeners_Listener> Listeners
		{
			get
			{
				return listeners;
			}
			set	
			{
				listeners = value;
			}
		}

		public class DescribeLoadBalancerListeners_Listener
		{

			private string aclId;

			private string aclStatus;

			private string aclType;

			private int? backendServerPort;

			private int? bandwidth;

			private string description;

			private int? listenerPort;

			private string listenerProtocol;

			private string loadBalancerId;

			private string scheduler;

			private string status;

			private string vServerGroupId;

			private List<string> aclIds;

			private DescribeLoadBalancerListeners_HTTPListenerConfig hTTPListenerConfig;

			private DescribeLoadBalancerListeners_HTTPSListenerConfig hTTPSListenerConfig;

			private DescribeLoadBalancerListeners_TCPListenerConfig tCPListenerConfig;

			private DescribeLoadBalancerListeners_TCPSListenerConfig tCPSListenerConfig;

			private DescribeLoadBalancerListeners_UDPListenerConfig uDPListenerConfig;

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

			public DescribeLoadBalancerListeners_HTTPListenerConfig HTTPListenerConfig
			{
				get
				{
					return hTTPListenerConfig;
				}
				set	
				{
					hTTPListenerConfig = value;
				}
			}

			public DescribeLoadBalancerListeners_HTTPSListenerConfig HTTPSListenerConfig
			{
				get
				{
					return hTTPSListenerConfig;
				}
				set	
				{
					hTTPSListenerConfig = value;
				}
			}

			public DescribeLoadBalancerListeners_TCPListenerConfig TCPListenerConfig
			{
				get
				{
					return tCPListenerConfig;
				}
				set	
				{
					tCPListenerConfig = value;
				}
			}

			public DescribeLoadBalancerListeners_TCPSListenerConfig TCPSListenerConfig
			{
				get
				{
					return tCPSListenerConfig;
				}
				set	
				{
					tCPSListenerConfig = value;
				}
			}

			public DescribeLoadBalancerListeners_UDPListenerConfig UDPListenerConfig
			{
				get
				{
					return uDPListenerConfig;
				}
				set	
				{
					uDPListenerConfig = value;
				}
			}

			public class DescribeLoadBalancerListeners_HTTPListenerConfig
			{

				private string cookie;

				private int? cookieTimeout;

				private int? forwardCode;

				private int? forwardPort;

				private string gzip;

				private string healthCheck;

				private int? healthCheckConnectPort;

				private string healthCheckDomain;

				private string healthCheckHttpCode;

				private string healthCheckHttpVersion;

				private int? healthCheckInterval;

				private string healthCheckMethod;

				private int? healthCheckTimeout;

				private string healthCheckType;

				private string healthCheckURI;

				private int? healthyThreshold;

				private int? idleTimeout;

				private string listenerForward;

				private int? requestTimeout;

				private string stickySession;

				private string stickySessionType;

				private int? unhealthyThreshold;

				private string xForwardedFor;

				private string xForwardedFor_ClientSrcPort;

				private string xForwardedFor_SLBID;

				private string xForwardedFor_SLBIP;

				private string xForwardedFor_SLBPORT;

				private string xForwardedFor_proto;

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
			}

			public class DescribeLoadBalancerListeners_HTTPSListenerConfig
			{

				private string cACertificateId;

				private string cookie;

				private int? cookieTimeout;

				private string enableHttp2;

				private string gzip;

				private string healthCheck;

				private int? healthCheckConnectPort;

				private string healthCheckDomain;

				private string healthCheckHttpCode;

				private string healthCheckHttpVersion;

				private int? healthCheckInterval;

				private string healthCheckMethod;

				private int? healthCheckTimeout;

				private string healthCheckType;

				private string healthCheckURI;

				private int? healthyThreshold;

				private int? idleTimeout;

				private int? requestTimeout;

				private string serverCertificateId;

				private string stickySession;

				private string stickySessionType;

				private string tLSCipherPolicy;

				private int? unhealthyThreshold;

				private string xForwardedFor;

				private string xForwardedFor_ClientCertClientVerify;

				private string xForwardedFor_ClientCertClientVerifyAlias;

				private string xForwardedFor_ClientCertFingerprint;

				private string xForwardedFor_ClientCertFingerprintAlias;

				private string xForwardedFor_ClientCertIssuerDN;

				private string xForwardedFor_ClientCertIssuerDNAlias;

				private string xForwardedFor_ClientCertSubjectDN;

				private string xForwardedFor_ClientCertSubjectDNAlias;

				private string xForwardedFor_ClientSrcPort;

				private string xForwardedFor_SLBID;

				private string xForwardedFor_SLBIP;

				private string xForwardedFor_SLBPORT;

				private string xForwardedFor_proto;

				public string CACertificateId
				{
					get
					{
						return cACertificateId;
					}
					set	
					{
						cACertificateId = value;
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

				public string EnableHttp2
				{
					get
					{
						return enableHttp2;
					}
					set	
					{
						enableHttp2 = value;
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

				public string ServerCertificateId
				{
					get
					{
						return serverCertificateId;
					}
					set	
					{
						serverCertificateId = value;
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

				public string TLSCipherPolicy
				{
					get
					{
						return tLSCipherPolicy;
					}
					set	
					{
						tLSCipherPolicy = value;
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

				public string XForwardedFor_ClientCertClientVerify
				{
					get
					{
						return xForwardedFor_ClientCertClientVerify;
					}
					set	
					{
						xForwardedFor_ClientCertClientVerify = value;
					}
				}

				public string XForwardedFor_ClientCertClientVerifyAlias
				{
					get
					{
						return xForwardedFor_ClientCertClientVerifyAlias;
					}
					set	
					{
						xForwardedFor_ClientCertClientVerifyAlias = value;
					}
				}

				public string XForwardedFor_ClientCertFingerprint
				{
					get
					{
						return xForwardedFor_ClientCertFingerprint;
					}
					set	
					{
						xForwardedFor_ClientCertFingerprint = value;
					}
				}

				public string XForwardedFor_ClientCertFingerprintAlias
				{
					get
					{
						return xForwardedFor_ClientCertFingerprintAlias;
					}
					set	
					{
						xForwardedFor_ClientCertFingerprintAlias = value;
					}
				}

				public string XForwardedFor_ClientCertIssuerDN
				{
					get
					{
						return xForwardedFor_ClientCertIssuerDN;
					}
					set	
					{
						xForwardedFor_ClientCertIssuerDN = value;
					}
				}

				public string XForwardedFor_ClientCertIssuerDNAlias
				{
					get
					{
						return xForwardedFor_ClientCertIssuerDNAlias;
					}
					set	
					{
						xForwardedFor_ClientCertIssuerDNAlias = value;
					}
				}

				public string XForwardedFor_ClientCertSubjectDN
				{
					get
					{
						return xForwardedFor_ClientCertSubjectDN;
					}
					set	
					{
						xForwardedFor_ClientCertSubjectDN = value;
					}
				}

				public string XForwardedFor_ClientCertSubjectDNAlias
				{
					get
					{
						return xForwardedFor_ClientCertSubjectDNAlias;
					}
					set	
					{
						xForwardedFor_ClientCertSubjectDNAlias = value;
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
			}

			public class DescribeLoadBalancerListeners_TCPListenerConfig
			{

				private string connectionDrain;

				private int? connectionDrainTimeout;

				private int? establishedTimeout;

				private string healthCheck;

				private int? healthCheckConnectPort;

				private int? healthCheckConnectTimeout;

				private string healthCheckDomain;

				private string healthCheckHttpCode;

				private int? healthCheckInterval;

				private string healthCheckMethod;

				private string healthCheckType;

				private string healthCheckURI;

				private int? healthyThreshold;

				private string masterSlaveServerGroupId;

				private int? persistenceTimeout;

				private int? unhealthyThreshold;

				private string healthCheckSwitch;

				private List<DescribeLoadBalancerListeners_PortRange> portRanges;

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

				public string HealthCheckSwitch
				{
					get
					{
						return healthCheckSwitch;
					}
					set	
					{
						healthCheckSwitch = value;
					}
				}

				public List<DescribeLoadBalancerListeners_PortRange> PortRanges
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

				public class DescribeLoadBalancerListeners_PortRange
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

			public class DescribeLoadBalancerListeners_TCPSListenerConfig
			{

				private string cACertificateId;

				private string cookie;

				private int? cookieTimeout;

				private string healthCheck;

				private int? healthCheckConnectPort;

				private string healthCheckDomain;

				private string healthCheckHttpCode;

				private int? healthCheckInterval;

				private string healthCheckMethod;

				private int? healthCheckTimeout;

				private string healthCheckType;

				private string healthCheckURI;

				private int? healthyThreshold;

				private int? idleTimeout;

				private string serverCertificateId;

				private string stickySession;

				private string stickySessionType;

				private string tLSCipherPolicy;

				private int? unhealthyThreshold;

				public string CACertificateId
				{
					get
					{
						return cACertificateId;
					}
					set	
					{
						cACertificateId = value;
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

				public string ServerCertificateId
				{
					get
					{
						return serverCertificateId;
					}
					set	
					{
						serverCertificateId = value;
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

				public string TLSCipherPolicy
				{
					get
					{
						return tLSCipherPolicy;
					}
					set	
					{
						tLSCipherPolicy = value;
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
			}

			public class DescribeLoadBalancerListeners_UDPListenerConfig
			{

				private string connectionDrain;

				private int? connectionDrainTimeout;

				private string healthCheck;

				private int? healthCheckConnectPort;

				private int? healthCheckConnectTimeout;

				private string healthCheckDomain;

				private string healthCheckExp;

				private string healthCheckHttpCode;

				private int? healthCheckInterval;

				private string healthCheckMethod;

				private string healthCheckReq;

				private string healthCheckType;

				private string healthCheckURI;

				private int? healthyThreshold;

				private string masterSlaveServerGroupId;

				private int? unhealthyThreshold;

				private string healthCheckSwitch;

				private List<DescribeLoadBalancerListeners_PortRange2> portRanges1;

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

				public string HealthCheckExp
				{
					get
					{
						return healthCheckExp;
					}
					set	
					{
						healthCheckExp = value;
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

				public string HealthCheckReq
				{
					get
					{
						return healthCheckReq;
					}
					set	
					{
						healthCheckReq = value;
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

				public string HealthCheckSwitch
				{
					get
					{
						return healthCheckSwitch;
					}
					set	
					{
						healthCheckSwitch = value;
					}
				}

				public List<DescribeLoadBalancerListeners_PortRange2> PortRanges1
				{
					get
					{
						return portRanges1;
					}
					set	
					{
						portRanges1 = value;
					}
				}

				public class DescribeLoadBalancerListeners_PortRange2
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
	}
}
